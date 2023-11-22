// main.cs
using System;
using workshop;
class Program
{
    static void Main()

    {
        Controller c= new Controller();
        

      ;
          c.UpdateUserInput();

         c.ConvertirUserOutput(c.view.userInput);
         c.view.afficher();

    }

}

