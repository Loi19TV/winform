using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnUngDung_Menu
{
    public class handles
    {
        public static bool checkNumber(string text)
        {
            int num;
            if(int.TryParse(text, out num))
            {
                return true;
            }    
            return false;  
        }
    }
}
