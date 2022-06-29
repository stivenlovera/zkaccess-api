using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zktco_access.Controllers
{
    [Route("api/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private Response response;
        private readonly DataBaseContext dbContext;
        private readonly IMapper mapper;
        public UsuarioController(DataBaseContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.response=new Response();
        }
        // GET: api/<UsuarioController>
        [HttpGet]
        public async Task<Response> Get()
        {
            var usuarios= await dbContext.Usuario.ToListAsync();
            var data= mapper.Map<List<UsuarioDto>>(usuarios);
            this.response.status = "ok";
            this.response.data = data;
            this.response.message = "lista de usuarios";
            return this.response;
            //return data;
        }
            // GET api/<UsuarioController>/5
        [HttpGet("{id}", Name ="getUsuario")]
        public async Task<ActionResult<UsuarioDto>> Get(int id)
        {
            var usuario = await dbContext.Usuario.FirstOrDefaultAsync( c=>c.id ==id);
            if(usuario==null)
            {
                return NotFound();
            }
            else
            {
                return mapper.Map<UsuarioDto>(usuario); 
            }
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public async Task<ActionResult> Post(createUsuarioDto createUsuarioDto)
        {
            var usuario = mapper.Map<Usuario>(createUsuarioDto);
            dbContext.Usuario.Add(usuario);
            await dbContext.SaveChangesAsync();
            var dto=mapper.Map<UsuarioDto>(usuario);
            return new CreatedAtRouteResult("getUsuario", new { id = usuario.id },dto);
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id,createUsuarioDto createUsuarioDto)
        {
            var usuario =await dbContext.Usuario.FirstOrDefaultAsync(c => c.id == id);
            if(usuario==null)
            {
                return NotFound();
            }
            else
            {
                mapper.Map(createUsuarioDto, usuario);
                dbContext.Entry(usuario).State = EntityState.Modified;
                await dbContext.SaveChangesAsync();
                return NoContent();
            }
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var usuario= await dbContext.Usuario.FirstOrDefaultAsync(c=>c.id == id);
            if(usuario==null)
            {
                return NotFound();
            }
            dbContext.Entry(usuario).State = EntityState.Deleted;
            await dbContext.SaveChangesAsync();
            return NoContent();

        }
    }
}
