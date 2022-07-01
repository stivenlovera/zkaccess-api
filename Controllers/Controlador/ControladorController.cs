using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zktco_access.Controllers.Controlador
{
    [Route("api/controlador")]
    [ApiController]
    public class ControladorController : ControllerBase
    {
        private Response response;
        private zkControlador controlador;
        private readonly DataBaseContext dbContext;
        private readonly IMapper mapper;
        public ControladorController(DataBaseContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.response = new Response();
            this.controlador = new zkControlador();
        }
        // GET: api/<ControladorController>
        [HttpGet]
        public async Task<Response> Get()
        {
            var controlador = await dbContext.Controlador.ToListAsync();
            var data = mapper.Map<List<controladorDto>>(controlador);
            this.response.status = "ok";
            this.response.data = data;
            this.response.message = "lista de controladores";
            return this.response;
        }

        // GET api/<ControladorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ControladorController>
        [HttpPost]
        public async Task<ActionResult> Post(createControladorDto createControladorDto)
        {
            var controlador = mapper.Map<Model.Controlador>(createControladorDto);
            dbContext.Controlador.Add(controlador);
            await dbContext.SaveChangesAsync();
            var dto = mapper.Map<controladorDto>(controlador);
            return new CreatedAtRouteResult("getUsuario", new { id = controlador.id }, dto);
        }

        // GET api/<ControladorController>/5
        [HttpGet("{id}/conect")]
        public async Task<Response> GetConnect(int id)
        {
            
            var controlador = await dbContext.Controlador.FirstOrDefaultAsync(c => c.id == id);
            
            bool conect =this.controlador.conexion_controller(controlador.protocolo.ToString(), controlador.ip_address,controlador.port.ToString(),controlador.timeout.ToString(), controlador.password);
            if (conect)
            {
                this.response.status = "ok";
                this.response.data = conect;
                this.response.message = "Conexion exitosa";
            }
            else
            {
                this.response.status = "error";
                this.response.data = conect;
                this.response.message = "Error en la conexion";
            }
            return this.response;
        }

        // PUT api/<ControladorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ControladorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
