using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomAuthenticationMVC.Models
{
    public class LoginView
    {
        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
        [Display(Name = "Recordar")]
        public bool RememberMe { get; set; }
    }

    public class CustomSerializeModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> RoleName { get; set; }

    }

    public class RegistrationView
    {
        [Required(ErrorMessage = "Ingrese Nombre de Usuario")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Ingrese Nombre")]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Ingrese Apellido")]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Ingrese Email")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        public Guid ActivationCode { get; set; }

        [Required(ErrorMessage = "Ingrese Contraseña")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirme la Contraseña")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Contraseña")]
        [Compare("Password", ErrorMessage = "Error : Las contraseñas no concuerdan")]
        public string ConfirmPassword { get; set; }



    }
}