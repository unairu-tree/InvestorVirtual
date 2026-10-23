//namespace InvestorVirtual.Data.Configuration;

//using Microsoft.AspNetCore.Identity;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//public class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
//{
//    public static readonly IdentityUser AdminUser = new IdentityUser
//    {
//        Id = "a1b2c3d4-e5f6-7890-abcd-ef0123456789",
//        UserName = "admin@investorvirtual.com",
//        NormalizedUserName = "ADMIN@INVESTORVIRTUAL.COM",
//        Email = "admin@investorvirtual.com",
//        NormalizedEmail = "ADMIN@INVESTORVIRTUAL.COM",
//        EmailConfirmed = true,
//        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(new IdentityUser() { UserName = "admin@investorvirtual.com" }, "!Admin@iNVESTORvIRTUAL#123"),
//    };

//    public void Configure(EntityTypeBuilder<IdentityUser> builder)
//    {
//        builder.HasData(AdminUser);
//    }
//}

/* I planned to add an admin profile and role and allow you, the examiner, to use it to edit the learning terms on the site as if you owned it instead of a newly created account having that right.
 * While also wanting to make a role manager UI to give your own profile roles, but time and the fact we will learn that in the next course have pushed me to postpone it from this project. */