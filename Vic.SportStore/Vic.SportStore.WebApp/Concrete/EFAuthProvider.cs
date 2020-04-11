using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using Vic.SportStore.WebApp.Abstract;

namespace Vic.SportStore.Domain.Concrete
{
    public class EFAuthProvider: IAuthProvider
    {
        public EFDbContext Context { get; set; }

        public bool Authenticate(string username, string password)
        {
            var result = false;

            var adminUser = Context
                .AdminUsers
                .FirstOrDefault(x => x.Username == username && x.Password == password);

            if (adminUser != null)
            {
                result = true;
            }
            if (result)
            {
                FormsAuthentication.SetAuthCookie(username, false);
            }
            return result;
        }
    }
}
