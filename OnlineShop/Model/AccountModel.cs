using Model.FrameWork;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AccountModel
    {
        private OnlineShopDbContext context = null;
        public AccountModel()
        {
            context = new OnlineShopDbContext();
        }

        public bool Login(string userName, string passWord)
        {
            var sqlParams = new SqlParameter[]
             {
                new SqlParameter("@UserName", userName),
                new SqlParameter("@PassWord", passWord),
             };
            var res = context.Database.SqlQuery<bool>("Sp_Account_login @UserName, @PassWord", sqlParams).FirstOrDefault();
            return res;
        }
    }
}
