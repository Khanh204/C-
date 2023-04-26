using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    internal class MenuStudent
    {
        static void Themsinhvien()
        {
            Hocsinh hs = new Hocsinh();
            Console.WriteLine("Nhập tên sinh viên :");
            hs.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập tên sinh viên :");
            hs.Name = Console.ReadLine();
        }
    }
}
