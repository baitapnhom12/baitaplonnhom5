using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class tinhsp
    {
        private static double soluong, giaca;
        public static double SOLUONG
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public static double GIACA
        {
            get { return giaca; }
            set { giaca = value; }
        }
        public static bool kiemtrathanhtien()
        {
            if(soluong==giaca)
            {
                return false;
            }
            return true;
        }
        public static double ThanhTien()
        {
            return soluong * giaca;
        
        }
    }
}
