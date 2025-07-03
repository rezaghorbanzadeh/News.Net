

using NewsSite.ViewsModels.Account;

namespace NewsSite.Services.Interface
{
    public interface  IUserService : IAsyncDisposable
    {
        #region user
        Task<bool> IsUserEmailExist(string email);
        Task<RegisterResult> RegisterUser(RegisterViewModel register);
        #endregion
    }
}
