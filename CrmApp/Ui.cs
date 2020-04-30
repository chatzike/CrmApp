using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp
{


    class Ui
    {



        //Factory method
        public Product CreateProduct()
        {
            Product product = new Product();
            //try-catch block to manage user's input
            try
            {

                Console.WriteLine("Give the code ");
                product.Code = Console.ReadLine();
                Console.WriteLine("Give the name ");
                product.Name = Console.ReadLine();
                Console.WriteLine("Give the price ");
                product.Price = Decimal.Parse(Console.ReadLine());
                Console.WriteLine("Give the quantity ");
                product.Quantity = Int32.Parse(Console.ReadLine());

                return product;
            }
            catch (Exception)
            {
                Console.WriteLine("You have not completed the questions properly." +
                    " Please try again.");
                return null;
            }

        }

        public int Menu()
        {
            Console.WriteLine("1.  Add a customer  2.Add a product   3. Display basket " +
                " 4. ShowCategories  5. TotalCost 0. Exit");
            Console.WriteLine("Give your choice");
            int choice = 0;
            try
            {
                choice = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

            }
            return choice;
        }


        public Customer CreateCustomer()
        {
            return null;
        }

        public Basket CreateBasket()
        {
            Basket basket = new Basket();
            int choice;

            do
            {
                choice = Menu();
                switch (choice)
                {
                    case 1:
                        Customer customer = CreateCustomer();   //simplirose diergasia add customer
                        break;
                    case 2:
                        Product product = CreateProduct();
                        basket.AddProduct(product);
                        break;
                    case 3:
                        basket.Print();
                        break;
                    case 4:
                        basket.ShowCategories();
                        break;
                    case 5:
                        Console.WriteLine("TotalCost= " + basket.TotalCost());
                        break;
                    case 0:
                        Console.WriteLine("You selected to exit");
                        break;

                }
            }
            while (choice != 0);
            return basket;
        }

    }
}
