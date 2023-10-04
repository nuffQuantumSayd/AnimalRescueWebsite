using Microsoft.AspNetCore.Identity;
#nullable disable

namespace AnimalRescueWebsite.Models
{
    public static class IdentityHelper
    {
        public const string Administrator = "Administrator";
        public const string WebUser = "WebUser";

        public static async Task CreateRoles(IServiceProvider provider, params string[] roles)
        {
            RoleManager<IdentityRole> roleManager = provider.GetService<RoleManager<IdentityRole>>();

            foreach (string role in roles)
            {
                bool doesRolesExist = await roleManager.RoleExistsAsync(role);
                if (!doesRolesExist)
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

        }

        public static async Task CreateDefaultUser(IServiceProvider provider, string role)
        {
            var userManager = provider.GetService<UserManager<IdentityUser>>();

            // If no users are present make the default user
            if (userManager.Users.Any() == false)
            {
                var defaultUser = new IdentityUser()
                {
                    Email = "administrator@gmail.com",
                    UserName = "Admin"
                };

                await userManager.CreateAsync(defaultUser, "Administrator1!");

                await userManager.AddToRoleAsync(defaultUser, role);
            }
        }

    }
}
