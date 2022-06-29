namespace zktco_access.Dtos.Usuario
{
    public class createUsuarioDto
    {
        [Required(ErrorMessage = "CI es Requerido")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "debe contener como maximo 100 caracteres y minimo 3")]
        public string ci { get; set; }

        [Required(ErrorMessage = "Numero de Tarjeta es Requerido")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "debe contener como maximo 100 caracteres y minimo 3")]
        public string num_tarjeta { get; set; }

        [Required(ErrorMessage = "Fecha de nacimiento es Requerido")]
        //[StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "debe contener como maximo 100 caracteres y minimo 3")]
        public DateTime fecha_nac { get; set; }

        [Required(ErrorMessage = "Nombre es Requerido")]
        [StringLength(maximumLength: 100, MinimumLength = 3,ErrorMessage ="debe contener como maximo 100 caracteres y minimo 3")]
        public string nombre { get; set; }

        //public IFormFile image { get; set; }

        [Required(ErrorMessage = "Apellido es Requerido")]
        [StringLength(maximumLength: 100, MinimumLength = 3)]
        public string apellido { get; set; }

        public string nota { get; set; }

        [Required(ErrorMessage = "Email es Requerido")]
        [StringLength(maximumLength: 100, MinimumLength = 5)]
        public string email { get; set; }

        [Required(ErrorMessage = "Celular es Requerido")]
        [StringLength(maximumLength: 15, MinimumLength = 6)]
        public string celular { get; set; }

        [Required(ErrorMessage = "Dirrecion es Requerido")]
        [StringLength(maximumLength: 250)]
        public string dirrecion { get; set; }

        [Required(ErrorMessage = "Usuario es Requerido")]
        [StringLength(maximumLength: 250)]
        public string usuario { get; set; }

        [Required(ErrorMessage = "Contraseña es Requerido")]
        [StringLength(maximumLength: 250, MinimumLength = 3, ErrorMessage ="contraseña muy corta")]
        public string password { get; set; }

        [Required(ErrorMessage = "Proyecto es Requerido")]
        [RegularExpression("([0-9]+)")]
        public int proyecto_id { get; set; }

        [Required(ErrorMessage = "Rol es Requerido")]
        [RegularExpression("([0-9]+)")]
        public int rol_id { get; set; }

        [Required(ErrorMessage = "Creado por es Requerido")]
        [RegularExpression("([0-9]+)")]
        public int creado_por { get; set; }

        [Required(ErrorMessage = "Estado es Requerido")]
        [StringLength(maximumLength: 250)]
        public string estado { get; set; }
    }
}
