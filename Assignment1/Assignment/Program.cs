using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment
{
   public  class Program
    {
        string ProdutName;
        double ProdutPrice;
        int ProdutQuantity;
        string ProdutType;

        public int Quantity
        {
            get { return ProdutQuantity; }
            set { ProdutQuantity = value; }
        }

        public string Name
        {
            get { return ProdutName; }
            set { ProdutName = value; }
        }
        public double Price
        {
            get { return ProdutPrice; }
            set { ProdutPrice = value; }
        }
        public string Type
        {
            get { return ProdutType; }
            set { ProdutType = value; }
        }
        public override string ToString()
        {
            return "ProductName:-" + Name + " " +"ProductPrice:-"+ Price+" RS"+" "+"ProdctQuantity:-"+Quantity+" "+"ProductType:-"+Type;
        }
       static List<Program> newlist = new List<Program>();


        static void Main(string[] args)
        {
            /* List<Product> productList = new List<Product>() {
                 new Product(){ ProductName="lettuce", ProductPrice="10.5 RS",ProductQuantity=50,ProductType="Leafy green"},
                 new Product(){ ProductName="cabbage", ProductPrice="20 RS",ProductQuantity=100,ProductType="Cruciferous"},
                 new Product(){ ProductName="pumpkin", ProductPrice="30 RS",ProductQuantity=30,ProductType="Marrow"},
                 new Product(){ ProductName="cauliflower", ProductPrice="10 RS",ProductQuantity=25,ProductType="Cruciferous"},
                 new Product(){ ProductName="zucchini", ProductPrice="20.5 RS",ProductQuantity=50,ProductType="Marrow"},
                 new Product(){ ProductName="yam", ProductPrice="30 RS",ProductQuantity=50,ProductType="Root"},
                 new Product(){ ProductName="spinach", ProductPrice="10 RS",ProductQuantity=100,ProductType="Leafy green"},
                 new Product(){ ProductName="broccoli", ProductPrice="20.2 RS",ProductQuantity=75,ProductType="Cruciferous"},
                 new Product(){ ProductName="Garlic", ProductPrice="30 RS",ProductQuantity=20,ProductType="Leafy green"},
                 new Product(){ ProductName="silverbeet", ProductPrice="10 RS",ProductQuantity=50,ProductType="Marrow"},
             };
             Console.WriteLine("total number of Product in Proct List:-{0}",productList.Count);
             foreach (Product item in productList)
                 Console.WriteLine(item);*/

            /*Program obj = new Program();
            string ProdutName1 = "abc";
            string ProdutPrice1 = "12 Rs";
            int ProdutQuantity1 = 12;
            string ProdutType1 = "Xyz";
            obj.ProdutName = ProdutName1;
            obj.ProdutPrice = ProdutPrice1;
            obj.ProdutQuantity = ProdutQuantity1;
            obj.ProdutType = ProdutType1;
            Program.newlist.Add(obj);*/
            List<Program> newlist = new List<Program>() {
                 new Program(){ Name="lettuce", Price=10.5,Quantity=50,Type="Leafy green"},
                 new Program(){ Name="cabbage", Price=20,Quantity=100,Type="Cruciferous"},
                 new Program(){ Name="pumpkin", Price=30,Quantity=30,Type="Marrow"},
                 new Program(){ Name="cauliflower", Price=10,Quantity=25,Type="Cruciferous"},
                 new Program(){ Name="zucchini", Price=20.5,Quantity=50,Type="Marrow"},
                 new Program(){ Name="yam", Price=30,Quantity=50,Type="Root"},
                 new Program(){ Name="spinach", Price=10,Quantity=100,Type="Leafy green"},
                 new Program(){ Name="broccoli", Price=20.2 ,Quantity=75,Type="Cruciferous"},
                 new Program(){ Name="Garlic", Price=30 ,Quantity=20,Type="Leafy green"},
                 new Program(){ Name="silverbeet", Price=10,Quantity=50,Type="Marrow"}
            };
            Console.WriteLine("total number of Product in Proct List:-{0}", newlist.Count);
            Console.WriteLine("After Adding Product");
            newlist.Add(new Program() { Name = "Potato", Price = 10, Quantity = 50, Type = "Root" } );
            /*Program obj = new Program() { Name = "Potato", Price = "10 RS", Quantity = 50, Type = "Root"  };
            Program.newlist.Add(obj);*/
            Console.WriteLine("total number of Product in Proct List:-{0}", newlist.Count);
            // Console.WriteLine("total number of Product in Proct List:-{0}", newlist.Count.GetType());
            foreach (var item in newlist)
                Console.WriteLine(item);
            Console.WriteLine("------");
            foreach (var item in newlist)
            {
                if (item.Type.Equals("Leafy green"))
                    Console.WriteLine(item);
            }
            // newlist.Remove( new Program(){ Name = "Potato", Price = "10 RS", Quantity = 50, Type = "Root" });

            var itemToRemove = newlist.Single(r => r.Name == "Garlic");
            newlist.Remove(itemToRemove);
            Console.WriteLine("total number of Product in Proct List:-{0}", newlist.Count);

            foreach (var item in newlist)
            {
                if (item.Name.Equals("cabbage"))
                {
                    int a = item.Quantity + 50 ;
                    item.Quantity = a;
                    Console.WriteLine(item);
                }
                    
            }

            double total = 0;
            foreach (var item in newlist)
            {
                if (item.Name.Equals("lettuce"))
                {
                    total=total + (1)*item.Price;
                }
                if (item.Name.Equals("zucchini,"))
                {
                    total = total + (2) * item.Price;
                }
                if (item.Name.Equals("broccoli"))
                {
                    total = total + (1) * item.Price;
                }
              

            }
            Console.WriteLine("Rounded Value:-{0}",total);









        }
    }


   /* public class Product
    {
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public int  ProductQuantity { get; set; }
        public string ProductType { get; set; }

    }*/
}
