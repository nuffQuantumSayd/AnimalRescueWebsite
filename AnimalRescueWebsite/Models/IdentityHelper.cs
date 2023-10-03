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
    }
}
