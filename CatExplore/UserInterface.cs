using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

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
        public void StartUI()
        {
            string input;
            string in1stChar;
            string[] inputSentence;

            WriteLine(" Welcome to Cat Explorer!\n " +
                "You are a cat exploring the rooms of a house\n\n" +
                "What is your/cat's name?");
            kitty.Name = ReadLine();
            WriteLine("Well it's a good thing that cats name's don't really matter.");
            WriteLine("{0} currently in the {1}.\n" +
                "You can 'Move' or 'Go' in  direction (North, East, South, or West)\n" +
                "'Look' in a direction (North, East, South, or West)\n" +
                "or 'Explore' the room you are currently in\n" +
                "'QUIT' to exit the game" +
                "Try typing in one of the commands and hit the 'Enter' key on the keyboard",
                kitty.Name, kitty.Location.Name);

            while(true)
            {
                input = ReadLine();
                in1stChar = input.ToUpper().Substring(0, 1);
                inputSentence = input.Split(' ');

                if(input.ToUpper() == "QUIT")
                {
                    WriteLine("Closing the game.\n" +
                        "Have a good Day!");
                    break;
                }
                else if(in1stChar == "G" || in1stChar == "M")
                {
                    if(inputSentence.Length > 1) //checking to see if user entered a direction
                    {
                        WriteLine(MoveCat(inputSentence[1]));
                    }
                    else
                    {
                        WriteLine("Please also enter a direction too, such as:\n" +
                            "'Go North'");
                    }
                }
                else if(in1stChar == "L")
                {
                    if (inputSentence.Length > 1) //checking to see if user entered a direction
                    {
                        WriteLine(LookAhead(inputSentence[1]));
                    }
                    else
                    {
                        WriteLine("Please also enter a direction too, such as:\n" +
                            "'Look West'\n" +
                            "or you can type 'Look Allaround' to see all the nearby rooms");
                    }
                }
                else if(in1stChar == "E")
                {
                    WriteLine(Explore());
                }
                else
                {
                    WriteLine("As a cat you are unsure what that means.\n" +
                        "You lie down and relax to contemplate what you wish to do");
                }

                WriteLine("What do you wish to do now?\n" +
                    "'Move' to a new room, 'Look' at an ajoining, 'Explore', or 'QUIT' the game");
                
            }

            
        }
        public string Explore()
        {
            return kitty.Location.Description;
        }

        public string LookAhead(string dir)
        {
            string dirChar = dir.ToUpper().Substring(0, 1);
            string returnMsg;
            Room loc = kitty.Location;

            if (dirChar == "N")
            {

                if (loc.NorthNei != null)
                {
                    returnMsg = "Over there is " + loc.NorthNei.Name;
                }
                else
                {
                    returnMsg = "There is a wall there";
                }
            }
            else if (dirChar == "E")
            {
                if (loc.EastNei != null)
                {
                    returnMsg = "Over there is " + loc.EastNei.Name;
                }
                else
                {
                    returnMsg = "There is a wall there";
                }
            }
            else if (dirChar == "S")
            {
                if (loc.SouthNei != null)
                {
                    returnMsg = "Over there is " + loc.SouthNei.Name;
                }
                else
                {
                    returnMsg = "There is a wall there";
                }
            }
            else if (dirChar == "W")
            {
                if (loc.WestNei != null)
                {
                    returnMsg = "Over there is " + loc.WestNei.Name;
                }
                else
                {
                    returnMsg = "There is a wall there";
                }
            }
            else if (dirChar == "A")
            {
                returnMsg = "To";
                if (loc.NorthNei != null)
                {
                    returnMsg += " the north is the " + loc.NorthNei.Name +",";
                }
                if (loc.EastNei != null)
                {
                    returnMsg += " the east is the " + loc.EastNei.Name + ",";
                }
                if (loc.SouthNei != null)
                {
                    returnMsg += " the south is the " + loc.SouthNei.Name + ",";
                }
                if (loc.WestNei != null)
                {
                    returnMsg += " the west is the " + loc.WestNei.Name + ",";
                }
            }
            else
            {
                returnMsg = "Unsure of what direction to look you stare into space";
            }

            return returnMsg;
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
