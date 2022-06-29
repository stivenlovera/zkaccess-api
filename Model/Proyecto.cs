namespace zktco_access.Model
{
    public class Proyecto
    {
        public int id { get; set; }

        public string nombre { get; set; }

        public string? descripcion { get; set; }

        public string dirrecion { get; set; }

        public DateTime fecha_inicio { get; set; }

        public DateTime? fecha_fin { get; set; }

        public string telefono { get; set; }

        public string? email { get; set; }

        public string estado { get; set; } = "creado";
    }
}
