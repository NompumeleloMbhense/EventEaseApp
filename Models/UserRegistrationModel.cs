using System.ComponentModel.DataAnnotations;

public class UserRegistrationModel
{
    [Required(ErrorMessage = "Name is required")]
    public string Name {get; set;}

    [Required(ErrorMessage = "Email is required")]
    public string Email {get; set;}

    
}