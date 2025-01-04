using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace THPIdentity.Entities;

public class ApplicationRole : IdentityRole
{
    [StringLength(512)]
    public string? DisplayName { get; set; }
}
