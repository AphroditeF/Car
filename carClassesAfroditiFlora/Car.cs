using System;
namespace carClassesAfroditiFlora
{
    public class Car
    {
        private Color _color;  //property 1a
        private string _brand;  //property 1b
        public string _model;    //property 1c
        public Engine engine;    //property 1d  
        private int _currentSpeed = 0 ;

        public void Accelerate(int speed)    //1a
        {
            if (speed <= 120 && speed>=-120)
            {
                if (speed >= 0)
                {
                    for (int i = _currentSpeed; i <= speed; i++)
                    {
                        Console.WriteLine("Current speed: {0}",  i);
                    }
                }
                else if(speed<0)//opisthen
                {
                    for (int i = _currentSpeed; i >= speed; i--)
                    {
                        Console.WriteLine("Current speed: {0}", i);
                    }
                }
                _currentSpeed =  speed;
            }
            else
            {
                Console.WriteLine("Error! The limit of accaration is 120 km/h");
            }
        }

        public void Stop(){ //on mac os when () are missing, it doesn't run //1b
            _currentSpeed =  0;
            Console.Write("Current speed: ");
            Console.WriteLine(_currentSpeed);
        }

        public  Car(Color color, string brand, string thisModel,string thisEngine)      //2
                    //Engine thisEngine.EngineNumber)
        {
            _color = color;
            _brand = brand;
            _model = thisModel;
            engine = new Engine();
            engine.EngineNumber = thisEngine;
        }
    }
}
