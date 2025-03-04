using System.ComponentModel.DataAnnotations.Schema;
using THPCore.Infrastructures;

namespace THPIdentity.Entities;

public class Award : BaseEntity
{
    [ForeignKey(nameof(UserDetail))]
    public Guid UserDetailId { get; set; }
    public string Name { get; set; } = default!;
    public int Year { get; set; }

    public UserDetail? UserDetail { get; set; }
}
