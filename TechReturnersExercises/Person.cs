namespace TechReturners
{
    public class Person
    {
        public Person(string firstname, string lastname, string location, int age)
        {
            firstname = firstname;
            lastname = lastname;
            Location = location;
            Age = age;
        }

        public string firstname
        { get; set; }

        public string lastname
        { get; set; }

        public string Location
        { get; set; }

        public int Age
        { get; set; }
    }
}