using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Item : Entity
    {
        //This will give some definition to what exactly an item is.  Maybe a derived class (each) for consumables, equipment, quest items.

        //Consumables will have functions to increment HP/AP values, or apply buffs/debuffs.

        //Equipment will modify combat attributes, and possibly HP or AP.

        //Quest items will serve a single purpose, become unusable, but still remain in the player's inventory
    }

    public class Consumable : Item
    {

    }

    public class Equipment : Item
    {

    }

    public class QuestItem : Item
    {

    }
   
}
