namespace zktco_access.Dtos.Controlador
{
    public class createControladorDto
    {
        [Required(ErrorMessage = "Nombre es Requerido")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "debe contener como maximo 100 caracteres y minimo 3")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Descripcion es Requerido")]
        [StringLength(maximumLength: 100, MinimumLength = 3)]
        public string decripcion { get; set; }

        [Required(ErrorMessage = "Protocolo es Requerido")]
        [StringLength(maximumLength: 100, MinimumLength = 5)]
        public string protocolo { get; set; }

        [Required(ErrorMessage = "Dirrecion ip es Requerido")]
        [StringLength(maximumLength: 15, MinimumLength = 6)]
        public string ip_address { get; set; }

        [Required(ErrorMessage = "Puerto es Requerido")]
        [RegularExpression("([0-9]+)")]
        public int port { get; set; }

        [Required(ErrorMessage = "Usuario es Requerido")]
        [RegularExpression("([0-9]+)")]
        public int timeout { get; set; }

        [Required(ErrorMessage = "Contraseña es Requerido")]
        [StringLength(maximumLength: 512, MinimumLength = 3, ErrorMessage = "Contraseña muy corta")]
        public string password { get; set; }
    }
}
