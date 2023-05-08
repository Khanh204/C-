using T2207A;
public class Program
{
    public static void Main(string[] args)
    {
       List<Product> products = new List<Product>();
        while (true)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1.Add product records");
            Console.WriteLine("2.Display product records");
            Console.WriteLine("3.Delete product by ID");
            Console.WriteLine("4.Exit");
            Console.WriteLine("Enter your choice: ");
            int choice = int .Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter product ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter product name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter product price: ");
                    decimal price = decimal.Parse(Console.ReadLine());
                    products.Add(new Product { ID = id, Name = name,Price = price });
                    Console.WriteLine("Product added successfully");
                    break;
                case 2: 
                    if(products.Count == 0)
                    {
                        Console.WriteLine("No product found");
                    }
                    else
                    {
                        Console.WriteLine("{0,-10} {1,-20} {2,-10}","ID","Name","Price");
                        Console.WriteLine("===========================================");
                        foreach(Product product in products)
                        {
                            Console.WriteLine("{0,-10} {1,-20} {2,-10}",product.ID,product.Name,product.Price);
                            
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter product ID to delete: ");
                    int deleteID = int.Parse (Console.ReadLine());
                    int index = products.FindIndex(p => p.ID == deleteID);
                    if(index == -1)
                    {
                        Console.WriteLine("Product not found");
                    }else {
                        products.RemoveAt(index);
                        Console.WriteLine("Product delete successfully");
                     }
                    break ;
                case 4:
                    Console.WriteLine("Exit program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.WriteLine();
        }
    }


}
