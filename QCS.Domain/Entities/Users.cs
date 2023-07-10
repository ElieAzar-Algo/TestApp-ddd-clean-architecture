using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QCS.Domain.Entities
{
  [Table("User")]
  [Index(nameof(Email), IsUnique=true, Name="Unique_Email")]
  public class Users 
  {
    [Key]
    public int Id { get; set; }
    [Required]
    public string AgentLogin { get; set; }
    [MaxLength(150)]
    public string FullNameAR { get; set; }
    [MaxLength(150)]
    public string FullNameLT { get; set; }
    [MaxLength(150)]
    public string Email { get; set; }
    public string Password { get; set; }
    public string Image { get; set; }
    [DefaultValue(true)]
    public bool Active { get; set; }
    public string PasswordToken { get; set; }
  
  }
}