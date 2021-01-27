using System;

namespace CatExplore
{
    class Program
    {
        static void Main(string[] args)
        {

            Initializer init = new Initializer();
            Cat cat = new Cat("Cat", init.StartingRoom());
            UserInterface ui = new UserInterface(cat);
            ui.StartUI();

        }


    }
}
