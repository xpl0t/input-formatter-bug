using System.ComponentModel.DataAnnotations;

namespace CustomValidation.Models
{
  public class User
  {
    [Required]
    public string Name { get; set; }
    [EmailAddress]
    public string Email { get; set; }
  }
}
