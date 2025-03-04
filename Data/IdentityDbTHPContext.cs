using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using THPIdentity.Entities;

namespace THPIdentity.Data;

public class IdentityDbTHPContext(DbContextOptions<IdentityDbTHPContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<EducationHistory> EducationHistories { get; set; } = default!;
    public DbSet<Award> Awards { get; set; } = default!;
    public DbSet<ForeignLanguageProficiency> ForeignLanguageProficiencies { get; set; } = default!;
    public DbSet<UserDetail> UserDetails { get; set; } = default!;
    public DbSet<TeachingExperience> TeachingExperiences { get; set; } = default!;
}
