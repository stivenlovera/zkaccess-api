namespace zktco_access.Dtos.Proyecto
{
    public class createProyectoDto
    {

        [Required(ErrorMessage = "CI es Requerido")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "debe contener como maximo 100 caracteres y minimo 3")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Descripcion es Requerido")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "debe contener como maximo 100 caracteres y minimo 3")]
        public string descripcion { get; set; }

        [Required(ErrorMessage = "Dirrecion es Requerido")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "debe contener como maximo 100 caracteres y minimo 3")]
        public string dirrecion { get; set; }

        [Required(ErrorMessage = "Fecha de nacimiento es Requerido")]
        public DateTime fecha_inicio { get; set; }

        [Required(ErrorMessage = "Fecha de nacimiento es Requerido")]
        public DateTime fecha_fin { get; set; }

        [Required(ErrorMessage = "Telefono es Requerido")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "debe contener como maximo 10 caracteres y minimo 3")]
        public string telefono { get; set; }

        [Required(ErrorMessage = "Email es Requerido")]
        [StringLength(maximumLength: 100, MinimumLength = 5)]
        public string email { get; set; }
    }
}
