using AK.BlogWebApp.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace AK.BlogWebApp.WebAPI.Middlewares
{
    public static class ExtensionsMiddleware
    {
        public static void CreateFirstUser(WebApplication app)
        {
            using (var scoped = app.Services.CreateScope())
            {
                var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();

                var admin = userManager.Users.FirstOrDefault(p => p.UserName == "admin");

                if (admin is null)
                {
                    AppUser user = new()
                    {
                        UserName = "admin",
                        Email = "admin@admin.com",
                        FirstName = "Ataberk",
                        LastName = "Kaya",
                        EmailConfirmed = true
                    };

                    userManager.CreateAsync(user, "1").Wait();
                }
                else if (app.Environment.IsDevelopment())
                {
                    // Keep the local development account usable after test attempts.
                    userManager.SetLockoutEndDateAsync(admin, null).Wait();
                    userManager.ResetAccessFailedCountAsync(admin).Wait();

                    var resetToken = userManager.GeneratePasswordResetTokenAsync(admin).Result;
                    userManager.ResetPasswordAsync(admin, resetToken, "1").Wait();
                }
            }
        }
    }
}
