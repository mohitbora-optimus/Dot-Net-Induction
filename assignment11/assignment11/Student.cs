
namespace assignment11
{
    abstract class Student
    {
        protected int Age;
        public int RollNo;
        public string Name;
        public string Affilation;

        protected int age
        {
            get
            {
                return Age;
            }
            set
            {
                age = value;
            }
        }

        public int RollNumber
        {
            get
            {
                return RollNo;
            }
            set
            {
                RollNo = value;
            }
        }
        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public string affilation
        {
            get
            {
                return Affilation;
            }
            set
            {
                Affilation = value;
            }
        }
    }
}
