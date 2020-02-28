using System;

namespace BeerLab5_6
{
    class Program
    {
        public struct customer
        {
            public int age;
            public string first_name;
            public string last_name;
            public bool membership;

        }

        static void Main(string[] args)

        {
            customer customer1 = new customer();
            customer customer2 = new customer();
            customer customer3 = new customer();

            customer1.age = 15;
            customer1.first_name = "Herman";
            customer1.last_name = "Garcia";
            customer1.membership = false;

            customer2.age = 34;
            customer2.first_name = "Nia";
            customer2.last_name = "Long";
            customer2.membership = false;

            customer3.age = 54;
            customer3.first_name = "Rodney";
            customer3.last_name = "Lewis";
            customer3.membership = true;

            customer[] allcustomers = { customer1, customer2, customer3 };

            for (int i = 0; i < allcustomers.Length; i++)
            {

                if (allcustomers[i].age < 21)
                {
                    Console.WriteLine(allcustomers[i].first_name + "" + allcustomers[i].last_name + " Cannot place an order");
                }


                else
                {
                    Console.WriteLine(allcustomers[i].first_name + "" + allcustomers[i].last_name + "can order");
                }

                if (allcustomers[i].membership == true)
                {
                    Console.WriteLine(allcustomers[i].first_name + "" + allcustomers[i].last_name + "Premium Member");
                }

                else
                {
                    Console.WriteLine(allcustomers[i].first_name + "" + allcustomers[i].last_name + "Not a Premium Member");
                }


            }

        }

    }
}
