using TheBugTracker.Models;

namespace TheBugTracker.Services.Interfaces
{
    public interface IBTRolesService
    {
        public Task<bool> IsUserInRoleAsync(BTUser user, string roleName);

        public Task<IEnumerable<string>> GetUserRolesAsync(BTUser user);

        public Task<bool> AddUsertoRoleAsync(BTUser user, string roleName);

        public Task<bool> RemoveUserFromRoleAsync(BTUser user, string roleName);

        public Task<bool> RemoveUserfromRolesAsync(BTUser user, IEnumerable<string> roles);

        public Task<List<BTUser>> GetUsersInRoleAsync(string roleName, int companyId);
        
        public Task<List<BTUser>> GetUsersNotInRoleAsync(string roleName, int companyId);

        public Task<string> GetRoleNameByIdAsync(string roleId);
    }
}
