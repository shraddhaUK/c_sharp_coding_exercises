namespace TechReturners
{
    public class Person
    {
        public Person(string firstname, string lastname, string location, int age)
        {
            Firstname = firstname;
            Lastname = lastname;
            Location = location;
            Age = age;
        }

        public string Firstname
        { get; set; }

        public string Lastname
        { get; set; }

        public string Location
        { get; set; }

        public int Age
        { get; set; }
    }
}