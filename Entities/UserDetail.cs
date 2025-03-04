using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using THPCore.Infrastructures;
using THPCore.Interfaces;

namespace THPIdentity.Entities;

public class UserDetail : BaseEntity, ILocale
{
    [ForeignKey(nameof(User))]
    public string UserId { get; set; } = default!;
    [Comment("Học hàm")]
    public string? AcademicTitle { get; set; }
    [Comment("Năm phong")]
    public int YearOfPromotion { get; set; }
    [Comment("Học vị")]
    public string? AcademicDegree { get; set; }
    [Comment("Chức vụ")]
    public string? Position { get; set; }
    [Comment("Nơi ở hiện nay")]
    public string? CurrentResidence { get; set; }
    [Comment("Đơn vị/ cơ quan đang công tác")]
    public string? CurrentWorkplace { get; set; }
    [Comment("Địa chỉ cơ quan")]
    public string? WorkplaceAddresss { get; set; }
    public string? IdentityNumber { get; set; }
    public DateTime? IdentityDate { get; set; }
    public string? IdentityAddress { get; set; }
    public int? CountryId { get; set; }
    [StringLength(10)]
    public string Locale { get; set; } = default!;

    public ApplicationUser? User { get; set; }
}
