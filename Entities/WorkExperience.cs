using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using THPCore.Infrastructures;

namespace THPIdentity.Entities;

/// <summary>
/// Quá trình công tác
/// </summary>
public class WorkExperience : BaseEntity
{
    [ForeignKey(nameof(UserDetail))]
    public Guid UserDetailId { get; set; }
    [Comment("Thời gian")]
    public string? Period { get; set; }
    [Comment("Chức vụ")]
    public string? Position { get; set; }
    [Comment("Nơi làm việc")]
    public string? Workplace { get; set; }
    [Comment("Địa chỉ cơ quan")]
    public string? WorkplaceAddress { get; set; }

    public UserDetail? UserDetail { get; set; }
}
