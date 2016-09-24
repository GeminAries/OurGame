using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{

    public class Character : Entity
    {

        //Overall status attributes
        private int stat_hitPoints;
        private int stat_abilityPoints;
        private BuffList buffList;

        //Combat stats
        private int stat_attackPower;
        private int stat_defenseRating;
        private int stat_abilityPower;
        private int stat_magicDefense;
        private int stat_constitution;
        private int stat_luck;
        private int stat_intelligence;
        private int stat_perception;

        //Inventory attributes
        private ItemList inventory;
        private Item equipSlot_helmet;
        private Item equipSlot_armor;
        private Item equipSlot_gadget;
        private Item equipSlot_weapon;

        //Location attributes
        private int xCoord = 0;
        private int yCoord = 0;

        /******************** default constructor ***************************/
        public Character()
        {

            stat_hitPoints = stat_abilityPoints = stat_attackPower = stat_defenseRating = stat_abilityPower
                 = stat_magicDefense = stat_constitution = stat_luck = xCoord = yCoord = 0;

            buffList = null;
            inventory = null;
            equipSlot_helmet = equipSlot_armor = equipSlot_gadget = equipSlot_weapon = null;
        }
        /******************** Setters *************************************/
        public void setIntelligence(int intelligence)
        {
            this.stat_intelligence = intelligence;
        }

        public void setPerception(int perception)
        {
            this.stat_perception = perception;
        }

        public void setHitPoints(int hitPoints)
        {
            this.stat_hitPoints = hitPoints;
        }

        public void setAbilityPoints(int abilityPoints)
        {
            this.stat_abilityPoints = abilityPoints;
        }

        public void setAttackPower(int attackPower)
        {
            this.stat_attackPower = attackPower;
        }

        public void setDefenseRating(int defenseRating)
        {
            this.stat_defenseRating = defenseRating;
        }

        public void setAbilityPower(int abilityPower)
        {
            this.stat_abilityPower = abilityPower;
        }

        public void setMagicDefense(int magicDefense)
        {
            this.stat_magicDefense = magicDefense;
        }

        public void setConstitution(int constitution)
        {
            this.stat_constitution = constitution;
        }

        public void setLuck(int luck)
        {
            this.stat_luck = luck;
        }

        public void setX(int x)
        {
            this.xCoord = x;
        }

        public void setY(int y)
        {
            this.yCoord = y;
        }


        /************************* Getters **********************************/

        public int getIntelligence()
        {
            return this.stat_intelligence;
        }

        public int getPerception()
        {
            return this.stat_perception;
        }

        public int getHitPoints()
        {
            return this.stat_hitPoints;
        }

        public int getAttackPower()
        {
            return this.stat_attackPower;
        }

        public int getDefenseRating()
        {
            return this.stat_defenseRating;
        }

        public int getAbilityPower()
        {
            return this.stat_abilityPower;
        }

        public int getMagicDefense()
        {
            return this.stat_magicDefense;
        }

        public int getConstitution()
        {
            return this.stat_constitution;
        }

        public int getLuck()
        {
            return this.stat_luck;
        }

        public int getX()
        {
            return this.xCoord;
        }

        public int getY()
        {
            return this.yCoord;
        }

        public int getAbilityPoints()
        {
            return this.stat_abilityPoints;
        }
    } //Still need to do work on itemList, buffList, individual item slots.

    //endCharacter


    //beginNPC
    public class NPC : Character
    {
        //Disposition towards the player
        private bool NPC_isFriendly;

        //Is this a shopkeeper?
        private bool NPC_isShopKeeper;

        //Is this a quest-giver?
        private bool NPC_isQuestGiver;
        /************************ Default Constructor *************/

        //needs default constuctor

        /************************ Setters **********/
        public void setFriendly(bool isFriendly)
        {
            this.NPC_isFriendly = isFriendly;
        }

        public void setShopkeeper(bool isShopkeeper)
        {
            this.NPC_isShopKeeper = isShopkeeper;
        }

        public void setQuestGiver(bool questGiver)
        {
            this.NPC_isQuestGiver = questGiver;
        }
    }

    public class Player : Character
    {
        //additional stats
        private int player_level;
        private int player_experiencePoints;
        private int player_experienceToNextLevel;
        /**************** Default Constructor **************/

        //needs default constructor.


        /**************** Getters and setters *************/

        public void setLevel(int level)
        {
            this.player_level = level;
        }

        public void setExperience(int exp)
        {
            this.player_experiencePoints = exp;
        }

        public void setExperienceToNext(int exp)
        {
            this.player_experienceToNextLevel = exp;
        }

        public int getLevel()
        {
            return this.player_level;
        }

        public int getExperience()
        {
            return this.player_experiencePoints;
        }

        public int getExperienceToNext()
        {
            return this.player_experienceToNextLevel;
        }

    }//endPlayer


    //beginMonster
    public class Monster : Character
    {
        //this class will define what exactly a "monster" is.
    }//endMonster
}

