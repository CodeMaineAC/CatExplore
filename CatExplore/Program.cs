using System;

namespace CatExplore
{
    class Program
    {
        static void Main(string[] args)
        {
            Room kitchen = new Room("Kitchen", "People cook food here");
            Room diningRoom = new Room("Dining Room", "People eat here. Sometimes there is fod on floor");
            Room livingRoom = new Room("Living Room", "There are some comfortable couches and chairs in here");
            Cat tom = new Cat("Tom", kitchen);
            UserInterface ui = new UserInterface(tom);

            Console.WriteLine("{0} is in the {1}", tom.Name, tom.Location.Name);

            kitchen.Ajoin(diningRoom, 'e');
            //tom.Move(diningRoom);
            Console.WriteLine(ui.MoveCat("east"));

            Console.WriteLine("{0} is in the {1}", tom.Name, tom.Location.Name);
            Console.WriteLine(ui.MoveCat("Water"));
            //Console.WriteLine("{0} can move to {1}? {2}", tom.Name, livingRoom.Name,
            //tom.Move(livingRoom));
            Console.WriteLine("{0} is in the {1}", tom.Name, tom.Location.Name);
            Console.WriteLine(ui.MoveCat("North"));
            kitchen.RoomStats();
            diningRoom.RoomStats();
        }
    }
}
