using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    //Create a Map class that will be an #x# array of Room objects.
    class Map
    {
        public Map()
        {
          Room[,] mapGrid = new Room[70, 40];
    }  
}//end Map class
    
    

    //Create a room class which is a #x# array of Entity Lists.
    class Room
    {

        //a room is a 8x8 array of Entity Object Lists
        LinkedList entityList = new LinkedList();

        //a string to determine the room's name
        private String name;

        //a boolean to determine if the room is accessible to the player.
        private bool isAccessible;

        //a boolean to determine if enemies should spawn in the room.
        private bool spawnsEnemies;

        //a boolean to determine if the room is dangerously hot (gameplay mechanic)
        private bool isDangerouslyHot;

        //a boolean to determine if the room is dangerously cold (gameplay mechanic)
        private bool isDangerouslyCold;

        //a boolean to determine if the room is visible to the player on the map
        private bool isVisible;

        //a boolean to determine if an area has been previously explored
        private bool isExplored;
        

        public void setName(string name)
        {
            this.name = name;
        }

        public void setAccessible(bool b)
        {
            if (this.isAccessible != b)
                this.isAccessible = b;
        }
        
        public void setEnemySpawn(bool b)
        {
            if (this.spawnsEnemies != b)
                this.spawnsEnemies = b;
        }

        public void setDangerouslyHot(bool b)
        {
            if (isDangerouslyHot != b)
                this.isDangerouslyHot = b;
        }

        public void setDangerouslyCold(bool b)
        {
            if (isDangerouslyCold != b)
                this.isDangerouslyCold = b;
        }

        public bool getIsAccessible()
        {
            return this.isAccessible;
        }

        public bool getSpawnsEnemies()
        {
            return this.spawnsEnemies;
        }

        public string getName()
        {
            return this.name;
        }
    }//end Room class


  

}//end namespace
