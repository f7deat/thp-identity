using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace THPIdentity.Entities;

public class ApplicationUser : IdentityUser
{
    public string? Avatar { get; set; }
    public int? DepartmentId { get; set; }
    public UserType UserType { get; set; }
    public string? Address { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public int? SubDepartmentId { get; set; }
    public int Amount { get; set; }
    public string? Name { get; set; }
    public int? Gender { get; set; }
    [StringLength(512)]
    public string? ClassCode { get; set; }
    public string? ClassName { get; set; }
    public UserStatus Status { get; set; }
    public string? DeviceToken { get; set; }
    public int? CityId { get; set; }

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
    Administrator
}