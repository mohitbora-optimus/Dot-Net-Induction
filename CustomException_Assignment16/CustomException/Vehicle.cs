using System;

namespace CustomException
{
    public class Vehicle : SpeedIsTooMuch
    {
        private int _yearOfManufacture;
        private string _model;
        private float _speed;
        private string _make;
        private string  _type;

         public string Type
         {
             get{
                 return _type;
             }
             set{
                 _type= value;
             }
         }       
        
        public int Year
        {
            get
            {
                return _yearOfManufacture;
            }

            set
            {
                _yearOfManufacture = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public float Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }

        public string make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }

        public Vehicle(string type, int year, string model, float speed, string make)
        {
            this.Type = type;
            this._yearOfManufacture = year;
            this._model = model;
            this._speed = speed;
            this._make = make;
        }

        public Boolean IsMoving()
        {
            return (Speed != 0.00f) ? true : false;
        }

        


        public void Acclerate()
        {
            try
            {
                Console.WriteLine("Speed of {0} has Reached {1}", this.Type, this.Speed);

                if (this.Type.Equals("Bicycle") == true && this.Speed > 100)
                    throw new SpeedIsTooMuch();

                if (this.Type.Equals("Bike") == true && this.Speed > 200)
                    throw new SpeedIsTooMuch();

                if (this.Type.Equals("Truck") == true && this.Speed > 180)
                    throw new SpeedIsTooMuch();

                if (this.Type.Equals("Car") == true && this.Speed > 300)
                    throw new IsCarDead();

                _speed += 10;
            }
            catch (CustomException.SpeedIsTooMuch e)
            {
                Console.WriteLine("speed is too much for {0}, {1}", this.Type, e);
            }
            catch (CustomException.IsCarDead e)
            {
                Console.WriteLine("Car is OverHeated {0}, {1}", this.Type, e);
                Console.WriteLine("speed of car is {0}", this.Speed);
            }
        }

        public void Deacclerate()
        {

            try
            {
                Console.WriteLine("Speed of {0} has Reached {1}", this.Type, this.Speed);
               
                if (this.Speed < 0)
                    throw new NegativeSpeed();
                
                _speed -= 10;
            }
            catch (CustomException.NegativeSpeed e)
            {
                Console.WriteLine("speed Can't be Negative {0}", e);
            }
            
         }
        public virtual void ShowDetails()
        {
        }
    }
}