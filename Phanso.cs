using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    
 internal class Phanso
    {

        private int ts;
        private int ms;

        public Phanso()
        {
        }
        //Nhập từ bàn phím
        public void Nhapps()
        {
            ts = Convert.ToInt32(ts);
            Console.WriteLine("Tu so = " + ts);
            ms = Convert.ToInt32(ms);
            Console.WriteLine("Mau so = " + ms);
        }
        //In phân số
        public void Inps()
        {
            Console.WriteLine($"{ts}/{ms}");
        }
        //Rút gọn 
         public void Rutgon()
        {
           
        }
        //Nghịch đảo
        public void Nghichdao()
        {
            if(ts != 0) 
            {
                int tss = ts;
                ts = ms;
                ms = tss;
            }
            else
            {
                Console.WriteLine("Khong the nghich dao");
            }
        }
        public Phanso Add(Phanso other) 
        {
            Phanso phanso = new Phanso();
            phanso.ts = ts * other.ms + other.ts * ms;
            phanso.ms = ms * other.ms;
            return other;

        }
        public Phanso Sub(Phanso other)
        {
        Phanso Phanso = new Phanso();
            Phanso.ts = ts * other.ms - other.ts * ms;
            Phanso.ms = ms * other.ms;
            return other;
        }
        public Phanso Mul(Phanso other)
        {
            Phanso phanso = new Phanso();
            phanso.ts = ts * other.ts;
            phanso.ms = ms * other.ms;
            return other;
        }
        public Phanso Div(Phanso other)
        {
            Phanso phanso =new Phanso();
            phanso.ts = ts * other.ms;
            phanso.ms = ms * other.ts;
            return other;
        }
    }

}
