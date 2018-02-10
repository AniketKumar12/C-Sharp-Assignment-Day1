using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    //private varible mostly in _abc
    class Program
    {
        string _ProdutName;
        double _ProdutPrice;
        int _ProdutQuantity;
        string _ProdutType;

        public int Quantity
        {
            get { return _ProdutQuantity; }
            set { _ProdutQuantity = value; }
        }

        public string Name
        {
            get { return _ProdutName; }
            set { _ProdutName = value; }
        }
        public double Price
        {
            get { return _ProdutPrice; }
            set { _ProdutPrice = value; }
        }
        public string Type
        {
            get { return _ProdutType; }
            set { _ProdutType = value; }
        }
        public override string ToString()
        {
            return "ProductName:-" + Name + " " + "ProductPrice:-" + Price +" RS" +" " + "ProdctQuantity:-" + Quantity + " " + "ProductType:-" + Type;
        }
        static List<Program> newlist = new List<Program>();

        static void Main(string[] args)
        {
            List<Program> newlist = new List<Program>() {
                 new Program(){ Name="lettuce", Price=10.5,Quantity=50,Type="Leafy green"},
                 new Program(){ Name="cabbage", Price=20,Quantity=100,Type="Cruciferous"},
                 new Program(){ Name="pumpkin", Price=30 ,Quantity=30,Type="Marrow"},
                 new Program(){ Name="cauliflower", Price=10 ,Quantity=25,Type="Cruciferous"},
                 new Program(){ Name="zucchini", Price=20.5 ,Quantity=50,Type="Marrow"},
                 new Program(){ Name="yam", Price=30 ,Quantity=50,Type="Root"},
                 new Program(){ Name="spinach", Price=10,Quantity=100,Type="Leafy green"},
                 new Program(){ Name="broccoli", Price=20.2 ,Quantity=75,Type="Cruciferous"},
                 new Program(){ Name="Garlic", Price=30,Quantity=20,Type="Leafy green"},
                 new Program(){ Name="silverbeet", Price=10,Quantity=50,Type="Marrow"}
            };
            
           
            int choice;
            Console.WriteLine("1. product list based Type of product (i.e. Leafy green, Cruciferous, Marrow etc.)");
            Console.WriteLine("2. total prize of whole Inventory including the quantities of products.)");
            Console.WriteLine("3. Print the Average prize product");
            Console.WriteLine("4.Prize of the product is greater than 50 then products should be considered as Costly products.");
            Console.WriteLine("Enter -1 to quit");
            double Total = 0;
            double avg = 0;
            do {
                
              
                Console.WriteLine("Enter Your Choice:-");
                 choice = int.Parse(Console.ReadLine());
               
                
                switch (choice)
            {
                 
                case 1:
                    Console.WriteLine("Leafy green");
                    Console.WriteLine("Cruciferous");
                    Console.WriteLine("Marrow");
                    Console.WriteLine("Root");
                    Console.WriteLine("Enter Your ChoiceType:-");
                    string ChoiceType = Console.ReadLine();

                    switch (ChoiceType)
                    {
                        case "Leafy green":
                            foreach (var item in newlist)
                            {
                                if (item.Type.Equals("Leafy green"))
                                    Console.WriteLine(item);
                            }
                            break;
                        case "Cruciferous":
                            foreach (var item in newlist)
                            {
                                if (item.Type.Equals("Cruciferous"))
                                    Console.WriteLine(item);
                            }
                            break;
                        case "Marrow":
                            foreach (var item in newlist)
                            {
                                if (item.Type.Equals("Marrow"))
                                    Console.WriteLine(item);
                            }
                            break;
                        case "Root":
                            foreach (var item in newlist)
                            {
                                if (item.Type.Equals("Root"))
                                    Console.WriteLine(item);
                            }
                            break;
                        default:
                           
                            break;
                    }
                    break;
                case 2:

                    foreach (var item in newlist)
                    {

                        Total+= item.Quantity*item.Price;
                    }
                    Console.WriteLine(Total);
                    break;

                case 3:
                    avg = Total / newlist.Count;
                    Console.WriteLine(avg);
                    break;
                case 4:
                    foreach (var item in newlist)
                    {
                        if (item.Price<50)
                        {
                            Console.WriteLine("Costly_Product:-{0}", item);
                        }       
                else
                {

                            Console.WriteLine(item);
                 }
                    }
                   
                    break;

                default :
                    Console.WriteLine("Please Enter Valid Choice");
                    break;
                }
            } while (choice != -1);

        }

        }
    }

