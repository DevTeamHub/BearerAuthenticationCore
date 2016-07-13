using Microsoft.AspNet.Identity;

namespace DevTeam.BearerAuthenticationCore
{
    public interface IExternalUserStore<TUser>: IUserStore<TUser> 
        where TUser: class, IUser
    {
        TUser GetExternalUser(string externalId, string externalName, string provider);
    }
}
