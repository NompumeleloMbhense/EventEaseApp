using System.ComponentModel.DataAnnotations;

public class UserRegistrationModel
{
    [Required(ErrorMessage = "Name is required")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100")]
    [RegularExpression(@"^[a-zA-Z\s'\-]+$", ErrorMessage = "Name can only include letters, spaces, apostrophes or hyphens")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100")]
    public string Email { get; set; } = string.Empty;


}