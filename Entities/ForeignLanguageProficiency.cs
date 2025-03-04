using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using THPCore.Infrastructures;

namespace THPIdentity.Entities;

public class ForeignLanguageProficiency : BaseEntity
{
    [ForeignKey(nameof(UserDetail))]
    public Guid UserDetailId { get; set; } = default!;
    [Comment("Ngoại ngữ")]
    public string? Language { get; set; }
    [Comment("Chứng chỉ")]
    public string? Certificate { get; set; }
    [Comment("Trình độ")]
    public string? Level { get; set; }

    public UserDetail? UserDetail { get; set; }
}
