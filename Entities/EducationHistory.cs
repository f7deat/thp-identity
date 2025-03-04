using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using THPCore.Infrastructures;

namespace THPIdentity.Entities;

public class EducationHistory : BaseEntity
{
    [ForeignKey(nameof(UserDetail))]
    public Guid UserDetailId { get; set; } = default!;
    [Comment("Bậc đào tạo")]
    public string? Degree { get; set; }
    [Comment("Nơi đào tạo")]
    public string? Institution { get; set; }
    [Comment("Chuyên ngành")]
    public string? Major { get; set; }
    [Comment("Năm tốt nghiệp")]
    public int GraduationYear { get; set; }

    public UserDetail? UserDetail { get; set; }
}
