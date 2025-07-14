using System.ComponentModel.DataAnnotations;

public class UserRegistrationModel
{
    [Required(ErrorMessage = "Name is required")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100")]
    [RegularExpression(@"^[a-zA-Z\s'\-]+$", ErrorMessage = "Name can only include letters, spaces, apostrophes or hyphens")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email format")]
    [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Email must include a valid domain (e.g., .com)")]
    public string Email { get; set; } = string.Empty;

}