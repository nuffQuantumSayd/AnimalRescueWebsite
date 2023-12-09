using Microsoft.AspNetCore.Identity;
#nullable disable

namespace AnimalRescueWebsite.Models
{
    /// <summary>
    /// This class represents a helper for the asp.net identity
    /// </summary>
    public static class IdentityHelper
    {
        /// <summary>
        /// The administrator role
        /// </summary>
        public const string Administrator = "Administrator";
        /// <summary>
        /// The web user role
        /// </summary>
        public const string WebUser = "WebUser";

        /// <summary>
        /// Creates the roles for the application
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="roles"></param>
        /// <returns></returns>
        public static async Task CreateRoles(IServiceProvider provider, params string[] roles)
        {
            // Get the role manager
            RoleManager<IdentityRole> roleManager = provider.GetService<RoleManager<IdentityRole>>();

            // Create the roles if they do not exist
            foreach (string role in roles)
            {
                // Check if the role exists
                bool doesRolesExist = await roleManager.RoleExistsAsync(role);
                if (!doesRolesExist)
                {
                    // Create the role
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

        }

        /// <summary>
        /// Creates the default user for the application
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        public static async Task CreateDefaultUser(IServiceProvider provider, string role)
        {
            // Get the user manager
            var userManager = provider.GetService<UserManager<IdentityUser>>();

            // If no users are present make the default user
            if (userManager.Users.Any() == false)
            {
                // Create the default user
                var defaultUser = new IdentityUser()
                {
                    Email = "administrator@gmail.com",
                    UserName = "Admin"
                };
                
                // Create the default user
                await userManager.CreateAsync(defaultUser, "Administrator1!");
                
                // Add the default user to the administrator role
                await userManager.AddToRoleAsync(defaultUser, role);
            }
        }

    }
}
