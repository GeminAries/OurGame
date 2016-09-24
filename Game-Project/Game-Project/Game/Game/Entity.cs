using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{

    public class Entity
    {
        string name;

        public Entity()
        {
            name = "";
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

    }//end entity

    public class EnvironmentalHazard : Entity
    {

    }

    public class Landmark : Entity
    {

    }

    public class ExitDoor : Entity
    {
        //exit doors will have a "direction" assigned with them.  When interacted with, they will move the player to the adjacent room in that direction, if allowed.
    }

    public class LootBox : Entity
    {

    }

    public class Impassable : Entity
    {

    }


}



