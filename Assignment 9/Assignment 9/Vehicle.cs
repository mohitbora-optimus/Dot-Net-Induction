using System;

namespace Assignment9
 {
    class Vehicle
    {
        private int _yearOfManufacture;
        private string _model;
        private float _speed;
        private string _make;

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

        public Vehicle(int year, string model, float speed, string make)
        {
            this._yearOfManufacture = year;
            this._model = model;
            this._speed = speed;
            this._make = make;
        }

        public Boolean IsMoving()
        {
            return (Speed != 0.00f) ? true: false;
        }

        public void Accleration()
        {
            _speed++;
        }

        public void Deaccleration()
        {
            _speed--;
        }
    }
}