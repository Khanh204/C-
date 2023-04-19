using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    internal class Tiendien
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello!");

            // Vietnamese Customer
            Console.WriteLine("Nhap loai khach hang: (1 - Viet Nam, 2 - Nuoc ngoai)");
            int customerType = int.Parse(Console.ReadLine());

            if (customerType == 1)
            {
                Console.WriteLine("nhap ma khach hang:");
                string customerCode = Console.ReadLine();

                Console.WriteLine("Nhap ho ten:");
                string fullName = Console.ReadLine();

                Console.WriteLine("Nhap ngay hoa don (dd/mm/yyyy):");
                string invoiceDate = Console.ReadLine();

                Console.WriteLine("nhap muc tieu khach hang (doi song, kinh doanh, san xuat):");
                string targetCustomer = Console.ReadLine();

                Console.WriteLine("Nhap so luong (So KW tieu thu):");
                int quantity = int.Parse(Console.ReadLine());

                double unitPrice = 0;
                double norm = 0;

                if (quantity <= 50)
                {
                    unitPrice = 1000;
                    norm = 50;
                }
                else if (quantity <= 100)
                {
                    unitPrice = 1200;
                    norm = 100;
                }
                else if (quantity <= 200)
                {
                    unitPrice = 1500;
                    norm = 200;
                }
                else
                {
                    unitPrice = 2000;
                    norm = 200;
                }

                double intoMoney = 0;

                if (quantity <= norm)
                {
                    intoMoney = quantity * unitPrice;
                }
                else
                {
                    intoMoney = (norm * unitPrice) + ((quantity - norm) * (unitPrice * 1.5));
                }

                Console.WriteLine("Ma khach hang: " + customerCode);
                Console.WriteLine("Ho ten: " + fullName);
                Console.WriteLine("Ngay hoa don: " + invoiceDate);
                Console.WriteLine("Muc tieu khach hang: " + targetCustomer);
                Console.WriteLine("So luong: " + quantity);
                Console.WriteLine("Don gia: " + unitPrice);
                Console.WriteLine("Thanh tien: " + intoMoney);
            }
            // Foreign Customer
            else if (customerType == 2)
            {
                Console.WriteLine("Nhap ma khach hang:");
                string customerCode = Console.ReadLine();

                Console.WriteLine("Nhap ho ten:");
                string fullName = Console.ReadLine();

                Console.WriteLine("Nhap ngay ra hoa don (dd/mm/yyyy):");
                string invoiceDate = Console.ReadLine();

                Console.WriteLine("Nhap quoc tich:");
                string nationality = Console.ReadLine();

                Console.WriteLine("Nhap so luong (So KW tieu thu):");
                int quantity = int.Parse(Console.ReadLine());

                double unitPrice = 2000;

                double intoMoney = quantity * unitPrice;

                Console.WriteLine("Ma Khach hang: " + customerCode);
                Console.WriteLine("Ho ten: " + fullName);
                Console.WriteLine("Ngay hoa don: " + invoiceDate);
                Console.WriteLine("Quoc tich: " + nationality);
                Console.WriteLine("So luong: " + quantity);
                Console.WriteLine("Don gia: " + unitPrice);
                Console.WriteLine("Thanh tien: " + intoMoney);
            }
            else
            {
                Console.WriteLine("Loai khach hang khong hop le.Vui long thu lai");
            }

            Console.ReadLine();
        }
    }
}
