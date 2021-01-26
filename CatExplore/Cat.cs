using System;
using System.Collections.Generic;
using System.Text;

namespace CatExplore
{
    class Cat
    {
        //string name;
        //Room location;

        public Cat()
        {
            Name = "cat";
        }
        public Cat(string name)
        {
            Name = name;
        }
        public Cat(string name, Room start)
        {
            Name = name;
            Location = start;
        }
        public string Name { get; set; }
        public Room Location { get; set; }

        public bool Move(Room room)
        {
            bool canMove;
            if(Location.IsAjoined(room))
            {
                Location = room;
                canMove = true;
            }
            else
            {
                canMove = false;
            }

            return canMove;
        }
        
    }
}
