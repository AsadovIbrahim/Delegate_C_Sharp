using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_C_Sharp
{
    internal class Run
    {
        public void RunFunc(Func func,string str)
        {
            try
            {
                func.Invoke(str);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
