using System;
using System.Collections.Generic;
using System.Text;

namespace CatExplore
{
    class Room
    {
        string name;
        string description;

        Room northNei;
        Room southNei;
        Room eastNei;
        Room westNei;

        public Room(string name, string descrip)
        {
            this.name = name;
            description = descrip;
        }
        public string Name
        {
            get { return name; }
        }

        public string Description
        {
            get { return description; }
        }

        public Room NorthNei
        {
            get { return northNei; }
        }

        public Room SouthNei
        {
            get { return southNei; }
        }

        public Room EastNei
        {
            get { return eastNei; }
        }

        public Room WestNei
        {
            get { return westNei; }
        }

        public void Ajoin(Room room, char dir)
        {
            if(dir == 'n')
            {
                northNei = room;
                //Checks if ajoining room is connected and connects if it is not
                if(room.SouthNei != this)
                {
                    room.Ajoin(this, 's');
                }
            }
            else if( dir == 's')
            {
                southNei = room;
                //Checks if ajoining room is connected and connects if it is not
                if (room.NorthNei != this)
                {
                    room.Ajoin(this, 'n');
                }
            }
            else if(dir == 'e')
            {
                eastNei = room;
                //Checks if ajoining room is connected and connects if it is not
                if (room.WestNei != this)
                {
                    room.Ajoin(this, 'w');
                }
            }
            else
            {
                westNei = room;
                //Checks if ajoining room is connected and connects if it is not
                if (room.EastNei != this)
                {
                    room.Ajoin(this, 'e');
                }
            }
        }

        public static string FindNeighbors(Room room)
        {
            string returnString = "";

            if(room.NorthNei != null)
            {
                returnString += "\n" + room.NorthNei.Name + " to the north";
            }
            if(room.EastNei != null)
            {
                returnString += "\n" + room.EastNei.Name + " to the east";
            }
            if (room.WestNei != null)
            {
                returnString += "\n" + room.WestNei.Name + " to the west";
            }
            if (room.SouthNei != null)
            {
                returnString += "\n" + room.SouthNei.Name + " to the south";
            }

            return returnString;

        }

        public bool IsAjoined(Room room)
        {
            bool ajoined = room == NorthNei || room == EastNei || room == SouthNei || room == WestNei;
            return room != null && ajoined;
        }

        public void RoomStats()
        {
            string stats = name + ": " + description;

            stats += FindNeighbors(this);

            Console.WriteLine(stats);

        }
    }
}
