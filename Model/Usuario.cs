namespace zktco_access.Model
{
    [Index(nameof(email), IsUnique = true)]
    public class Usuario
    {
        public int id { get; set; }
        
        public string ci { get; set; }

        public string num_tarjeta { get; set; }

        public string nombre { get; set; }

        public string image { get; set; } = "/usuario-default.webp";

        public DateTime fecha_nac { get; set; }

        public string apellido { get; set; }

        public string email { get; set; }

        public string celular { get; set; }

        public string nota { get; set; }

        public string dirrecion { get; set; }

        public string usuario { get; set; }

        public string password { get; set; }

        public string estado { get; set; }

        public int proyecto_id { get; set; }

        public int rol_id { get; set; }

        public int creado_por { get; set; }
    }
}
