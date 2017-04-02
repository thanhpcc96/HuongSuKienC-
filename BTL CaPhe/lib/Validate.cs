using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_CaPhe.lib
{
    class Validate
    {
        public bool isNumber(string chuoi)
        {
            string str = chuoi.Trim();
            double num;
            bool isNum = double.TryParse(chuoi, out num);
            return isNum;
        }
    }
    
}
