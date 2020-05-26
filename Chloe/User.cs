using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chloe_test
{
    [TableAttribute("role_user")]
    class User
    {
        [ColumnAttribute("uid", IsPrimaryKey = true)]

        [AutoIncrement]
        public int uid { get; set; }

        public string userName { get; set; }
        public string userNickName { get; set; }
        public string wxId { get; set; }
        public long roleId { get; set; }
    }


}
