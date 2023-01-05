using System.Xml.Linq;

namespace UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The First Name Of User");
            string first_Name=Console.ReadLine();
            if (UserDetailCheck.Validate(first_Name))
            {
                Console.WriteLine("Valid Name");
            }
            else
            {
                Console.WriteLine("Invalid Name");
            }
        }
    }
}