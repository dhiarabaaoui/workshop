using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace workshop
{
    public class View
    {
        public string userInput;
        public string ucUserInput;
        public void setuser(string ch)
        {
            userInput = ch;

        }
       public void GetUserInput()
        {
            Console.WriteLine("donnez la phrase ");
            var a = Console.ReadLine();
            userInput = a;
        }
        public void afficher()
        {
           // Console.WriteLine("Resultat =  ", userInput);

           Console.WriteLine(ucUserInput);

        }
    }
}
