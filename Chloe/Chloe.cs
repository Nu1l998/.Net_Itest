using Chloe;
using Chloe.MySql;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chloe_test.Chloe
{
    class Chloe : ITest
    {
        public void PreRun()
        {
            
        }

        public void RunTest()
        {
            Console.WriteLine("start");

            string connString = "Data Source=192.168.1.237;port=6606;user id=root;password=mario_pwd; Initial Catalog=mario;Charset=utf8;";
            MySqlContext context = new MySqlContext(new MySqlConnectionFactory(connString));


            IQuery<User> Iuser = context.Query<User>();
            User user = Iuser.Where(l => l.uid == 1).FirstOrDefault();
            Console.WriteLine(JsonConvert.SerializeObject(user));

            User nu1lUser = new User();
            nu1lUser.userName = "nu1l";
            nu1lUser.roleId = 1;
            nu1lUser.userNickName = "zzt_test";
            nu1lUser.wxId = "";

            //nu1lUser = context.Insert(nu1lUser);

            Console.WriteLine(JsonConvert.SerializeObject(nu1lUser));
        }
    }
}
