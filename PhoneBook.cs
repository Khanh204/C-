using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    internal class PhoneBook : Phone
    {
        private List<string[]> PhoneList = new List<string[]>();

        public override void InsertPhone(string name, string phone)
        {
            bool found = false;
            foreach (string[] entry in PhoneList)
            {
                if (entry[0] == name)
                {
                    found = true;
                    if (entry[1] != phone)
                    {
                        entry[1] = phone;
                        Console.WriteLine($"Số điện thoại của {name} được cập nhật {phone}");
                    }
                    else
                    {
                        Console.WriteLine($"Số điện thoại của {name} đã tồn tại");
                    }
                    break;
                }
            }

            if (!found)
            {
                string[] entry = new string[2] { name, phone };
                PhoneList.Add(entry);
                Console.WriteLine($"Đã thêm  {name} với số điện thoại {phone}");
            }
        }

        public override void RemovePhone(string name)
        {
            bool found = false;
            foreach (string[] entry in PhoneList)
            {
                if (entry[0] == name)
                {
                    PhoneList.Remove(entry);
                    Console.WriteLine($"Đã xóa {name} và số điện thoại của họ ra khỏi phone book");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"Không thể tìm thấy {name} trong phone book");
            }
        }

        public override void UpdatePhone(string name, string newphone)
        {
            bool found = false;
            foreach (string[] entry in PhoneList)
            {
                if (entry[0] == name)
                {
                    entry[1] = newphone;
                    Console.WriteLine($"Đã cập nhật số điện thoại của {name} thành {newphone}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"Không thể tìm thấy {name} trong phone book");
            }
        }

        public override void SearchPhone(string name)
        {
            bool found = false;
            foreach (string[] entry in PhoneList)
            {
                if (entry[0] == name)
                {
                    Console.WriteLine($"Số điện thoại của {name} là {entry[1]}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"Không thể tìm thấy {name} trong phone book");
            }
        }

        public override void Sort()
        {
            PhoneList.Sort((x, y) => string.Compare(x[0], y[0]));
            Console.WriteLine("Phone Book được sắp xếp theo tên");
        }
    }
}
