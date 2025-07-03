using Microsoft.EntityFrameworkCore;
using NewsSite.Data;
using NewsSite.Models.Account;
using NewsSite.Security;
using NewsSite.Services.Interface;
using NewsSite.ViewsModels.Account;

namespace NewsSite.Services.Implemtations
{
    public class UserService : IUserService
    {
        #region Db 
        private readonly MyBlogContext _ctx;

        public UserService(MyBlogContext ctx)
        {
            _ctx = ctx;
        }


        #endregion
        public async Task<bool> IsUserEmailExist(string email)
        {
           return await _ctx.Users.AnyAsync(u => u.Email == email);
        }

        public async Task<RegisterResult> RegisterUser(RegisterViewModel register)
        {
            if (await IsUserEmailExist(register.Email))
                return RegisterResult.EmailExsist;
            if(register.UserName == null)
                return RegisterResult.Error;
            var user  = new User()
            {
                UserName = register.UserName,
                Email = SiteSecurity.FixEmail(register.Email),
                Password = SiteSecurity.EncodePasswordMd5(register.Password),
                CreateDate = DateTime.Now,

            };
            await _ctx.Users.AddAsync(user);
            await _ctx.SaveChangesAsync();
            return RegisterResult.Success;
        }



        public async Task<User> GetUserByEmail(string email)
        {
            return await _ctx.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<LoginResult> LoginUser(LoginVieModel login)
        {
            var user = await GetUserByEmail(login.Email);
            if(user == null) return LoginResult.NotFound;
            if (user.Password != SiteSecurity.EncodePasswordMd5(login.Password)) return LoginResult.Error;
            return LoginResult.Success;
        }

        #region user

        #endregion
        public async ValueTask DisposeAsync()
        {
            if (_ctx != null) await _ctx.DisposeAsync();
        }

    }
}
