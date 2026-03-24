using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace THPIdentity.Entities;

public class ApplicationUser : IdentityUser
{
    [StringLength(2048)]
    public string? Avatar { get; set; }
    public int? DepartmentId { get; set; }
    public UserType UserType { get; set; }
    public string? Address { get; set; }
    public DateTime? DateOfBirth { get; set; }
    [Column(TypeName = "money")]
    public decimal Amount { get; set; }
    public string? Name { get; set; }
    public bool? Gender { get; set; }
    public UserStatus Status { get; set; }
    public string? DeviceToken { get; set; }
    public int? DistrictId { get; set; }
    public string? CitizenId { get; set; }

    public ICollection<UserDetail>? UserDetails { get; set; }
}

public enum UserStatus
{
    /// <summary>
    /// Đang học tại trường
    /// </summary>
    Active,
    /// <summary>
    /// Chuyển từ khoá trước
    /// </summary>
    Transfer,
    /// <summary>
    ///  Kỷ luật
    /// </summary>
    Karma,
    /// <summary>
    /// Bảo lưu
    /// </summary>
    Inactive,
    /// <summary>
    /// Thôi học, xóa tên
    /// </summary>
    Dismissed,
    /// <summary>
    /// Tốt nghiệp
    /// </summary>
    Alumni
}

public enum UserType
{
    [Display(Name = "Sinh viên")]
    Student,
    [Display(Name = "Giảng viên")]
    Lecturer,
    [Display(Name = "Trưởng bộ môn")]
    Leader,
    [Display(Name = "Trưởng Khoa")]
    Dean,
    [Display(Name = "Phó trưởng đơn vị")]
    Deputy,
    [Display(Name = "Ban giám hiệu")]
    Administrator,
    [Display(Name = "Ứng viên")]
    Candidate
}