﻿using Microsoft.AspNetCore.Identity;
using THPCore.Enums;

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
    public string? ClassName { get; set; }
    public UserStatus Status { get; set; }
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