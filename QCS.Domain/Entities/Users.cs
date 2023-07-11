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
    [Required, MaxLength(150)]
     public string ElieTest { get; set; }
    [MaxLength(150)]
    public string FullName { get; set; }
    [MaxLength(150)]
    public string Email { get; set; }
    [MaxLength(150)]
    public string UserId { get; set; }
    [MaxLength(150)]
    public string Role { get; set; }
    [MaxLength(150)]
    public string Status { get; set; }
    [MaxLength(150)]
    public string JobType { get; set; }
    [MaxLength(150)]
    public bool TeamId { get; set; }
    public string PasswordToken { get; set; }
  
  }
}