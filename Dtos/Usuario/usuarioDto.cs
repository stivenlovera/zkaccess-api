namespace zktco_access.Dtos.Usuario
{
    public class UsuarioDto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string Email { get; set; }
        public string celular { get; set; }
        public string dirrecion { get; set; }
    }
    public class responseUsuarioDto
    {
        public int? status { get; set; }
        public UsuarioDto? data { get; set; }
        public string? message { get; set;}
    }
}
