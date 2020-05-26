using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chloe_test
{
    public interface ITest
    {
        /// <summary>
        /// 预先动作
        /// </summary>
        void PreRun();
        /// <summary>
        /// 执行测试动作
        /// </summary>
        void RunTest();
    }
}
