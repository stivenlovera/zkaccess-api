
namespace zktco_access.Data
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Usuario,UsuarioDto>().ReverseMap();
            CreateMap<createUsuarioDto, Usuario>();

            CreateMap<Controlador, controladorDto>().ReverseMap();
            CreateMap<createControladorDto, Controlador>();

            CreateMap<Proyecto, proyectoDto>().ReverseMap();
            CreateMap<createProyectoDto, Proyecto>();
        }
    }
}
