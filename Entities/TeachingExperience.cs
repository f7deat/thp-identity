using System.ComponentModel.DataAnnotations.Schema;
using THPCore.Infrastructures;

namespace THPIdentity.Entities;

/// <summary>
/// Quá trình giảng dạy
/// </summary>
public class TeachingExperience : BaseEntity
{
    [ForeignKey(nameof(UserDetail))]
    public Guid UserDetailId { get; set; } = default!;
    public string CourseCode { get; set; } = default!;
    public string CourseName { get; set; } = default!;

    public UserDetail? UserDetail { get; set; }
}
