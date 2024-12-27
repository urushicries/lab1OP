namespace Lab1
{
    internal class Person
    {
        // Поля класса
        private string name;
        private int age;

        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }

        public override string ToString()
        {
            return $"Name: {name}, Age: {age}";
        }
    }
}
