using System;
using System.Collections.Generic;
using System.Text;

namespace CatExplore
{
    class UserInterface
    {
        Cat kitty;

        public UserInterface()
        {
            kitty = new Cat();
        }
        public UserInterface(Cat cat)
        {
            kitty = cat;
        }
        public UserInterface(string catName)
        {
            kitty = new Cat(catName);             
        }
        public UserInterface(string catName, Room loc)
        {
            kitty = new Cat(catName, loc);
        }

        public Cat Kitty
        {
            get { return kitty; }
        }

        public string MoveCat(string dir)
        {
            string dirChar = dir.ToUpper().Substring(0,1);
            string returnMsg = "";
            Room des;

            if(dirChar == "N")
            {
                des = kitty.Location.NorthNei;
                if(kitty.Move(des))
                {
                    returnMsg += "You have moved to the " + kitty.Location.Name;
                }
                else
                {
                    returnMsg = "You can't go that way";
                }
            }
            else if (dirChar == "E")
            {
                des = kitty.Location.EastNei;
                if (kitty.Move(des))
                {
                    returnMsg += "You have moved to the " + kitty.Location.Name;
                }
                else
                {
                    returnMsg = "You can't go that way";
                }
            }
            else if (dirChar == "S")
            {
                des = kitty.Location.SouthNei;
                if (kitty.Move(des))
                {
                    returnMsg += "You have moved to the " + kitty.Location.Name;
                }
                else
                {
                    returnMsg = "You can't go that way";
                }
            }
            else if (dirChar == "W")
            {
                des = kitty.Location.WestNei;
                if (kitty.Move(des))
                {
                    returnMsg += "You have moved to the " + kitty.Location.Name;
                }
                else
                {
                    returnMsg = "You can't go that way";
                }
            }
            else
            {
                returnMsg = "Please pick a direction to move, North, East, West, or South";
            }

            return returnMsg;

        }

    }
}
