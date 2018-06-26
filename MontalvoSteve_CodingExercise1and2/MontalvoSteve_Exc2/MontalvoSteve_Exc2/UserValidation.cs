using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontalvoSteve_Exc2
{
    class UserValidation
    {
        public static string IsNullOrWhiteSpace(string usersName)
        {
            while (string.IsNullOrWhiteSpace(usersName))
            {
                Console.WriteLine("Please select one of the menu options: ");
                usersName = Console.ReadLine();
            }
            return usersName;
        }
    }
}
