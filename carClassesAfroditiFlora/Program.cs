using System;

namespace carClassesAfroditiFlora
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Car car1 = new Car(Color.Red, "boo", "007","0000000000000000000001");


            car1.Accelerate(60);

            car1.Stop();

            while (true)
            {
                Console.WriteLine("Give new speed:");
                int a= int.Parse(Console.ReadLine());
                car1.Accelerate(a);
            }


        }
    }
}
