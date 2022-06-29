using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zktco_access.Controllers.Proyecto
{
    [Route("api/proyecto")]
    [ApiController]
    public class ProyectoController : ControllerBase
    {
        private Response response;
        private readonly DataBaseContext dbContext;
        private readonly IMapper mapper;
        public ProyectoController(DataBaseContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.response = new Response();
        }
        // GET: api/<ProyectoController>
        [HttpGet]
        public async Task<Response> Get()
        {
            var proyectos = await dbContext.Proyecto.ToListAsync();
            var data = mapper.Map<List<proyectoDto>>(proyectos);
            this.response.status = "ok";
            this.response.data = data;
            this.response.message = "lista de proyectos";
            return this.response;
        }
        // GET api/<ProyectoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProyectoController>
        [HttpPost]
        public async Task<ActionResult> Post(createProyectoDto createProyectoDto)
        {
            var proyecto = mapper.Map<Model.Proyecto>(createProyectoDto);
            dbContext.Proyecto.Add(proyecto);
            await dbContext.SaveChangesAsync();
            var dto = mapper.Map<proyectoDto>(proyecto);
            return new CreatedAtRouteResult("getUsuario", new { id = proyecto.id }, dto);
        }
        // PUT api/<ProyectoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProyectoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
