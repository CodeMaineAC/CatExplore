using System;
using System.Collections.Generic;
using System.Text;

namespace CatExplore
{
    class Initializer
    {
        internal List<Room> house;

        public Initializer()
        {
            house = new List<Room>();

            Room kitchen = new Room("Kitchen", "People cook food here");
            Room diningRoom = new Room("Dining Room", "People eat here. Sometimes there is fod on floor");
            Room livingRoom = new Room("Living Room", "There are some comfortable couches and chairs in here");
            Room mudRoom = new Room("Mud Room", "There is a lot of shoes and coats piled up in the corner");
            Room bedroom = new Room("Guest Bedroom", "There is a bed and nightstand that are both a little dusty and covered in cat hair");

            kitchen.Ajoin(diningRoom, 'e');
            diningRoom.Ajoin(livingRoom, 'e');
            kitchen.Ajoin(mudRoom, 's');
            livingRoom.Ajoin(bedroom, 'n');

            house.Add(kitchen);
            house.Add(diningRoom);
            house.Add(livingRoom);
            house.Add(mudRoom);
            house.Add(bedroom);

        }

        public Room StartingRoom()
        {
            Random rand = new Random();
            int roomPos = rand.Next(0, house.Count);
            return house[roomPos];
        }

        public void  PrintHouseRooms()
        {
            foreach (Room room in house) room.RoomStats();
        }
    }
}
