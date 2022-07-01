namespace zktco_access.Dtos.Usuario
{
    public class loginDto
    {
        [Required(ErrorMessage = "Usuario es Requerido")]
        [StringLength(maximumLength: 250,MinimumLength = 3)]
        public string usuario { get; set; }

        [Required(ErrorMessage = "Contraseña es Requerido")]
        [StringLength(maximumLength: 250, MinimumLength = 3, ErrorMessage = "contraseña muy corta")]
         public string password { get; set; }
    }
}
