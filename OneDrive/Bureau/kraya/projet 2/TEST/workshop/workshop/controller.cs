using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop
{
    public class Controller
    {
        public Model model;
        public View view; 
       public Controller()
        {
            model = new Model(); 
            view = new View();
        }
        public void UpdateUserInput()
        {
            do
            {
                view.GetUserInput();

            } while ((view.userInput.Length < 1) || (view.userInput.Length > 8));
        }
        public void ConvertirUserOutput(string ch) {
            string ch1;
            ch1 = ch.ToUpper();
          //  return ch1;
            view.ucUserInput = ch1;
        }
    }
}
