using System.ComponentModel.DataAnnotations;


namespace Formapp.Data
{
    public class ContactSendto
    { 
        [Required,MinLength(2),MaxLength(150)]
        public string FullName { get; set; }
        [Required, MinLength(10), MaxLength(10)]
        public string Email { get; set; }
        [Required, MinLength(10), MaxLength(10)]
        public string Message { get; set; }
    
    }
}
