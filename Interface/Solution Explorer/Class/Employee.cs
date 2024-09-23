namespace PropertiesDemo
{
    public class Employee
    {
        public int Id { get; set; }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }

        public string Department { get; } = "HR";

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 18 && value <= 65)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Invalid age. Age should be between 18 and 65.");
                }
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}, Department: {Department}");
        }
    }
}
