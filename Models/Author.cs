namespace app
{
    public class Author
    {
        public string FirstName;
        public string LastName;

        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }


    }
}