using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void openEquipmentManager(object sender, EventArgs e)
        {
            
            hubWriteLine("User has clicked on 'Manage Equipment'");
            //This function will open a new UI which will allow the player to customize their equipment for individual body parts (helmet, armor, weapon, gadget)
        }

        private void clicked_moveNorth(object sender, EventArgs e)
        {
            hubWriteLine("User has clicked on 'Move North'");
           
            //This function will decide whether or not it is legal for the player to move North, and if so - will allow the player to move North.
        }

        private void clicked_moveWest(object sender, EventArgs e)
        {
            hubWriteLine("User has clicked on 'Move West'");
            //This function will decide whether or not it is legal for the player to move West, and if so - will allow the player to move West.
        }

        private void clicked_moveEast(object sender, EventArgs e)
        {
            hubWriteLine("User has clicked on 'Move East'");
            //This function will decide whether or not it is legal for the player to move East, and if so - will allow the player to move East.
        }

        private void clicked_moveSouth(object sender, EventArgs e)
        {
            hubWriteLine("User has clicked on 'Move South'");
            //This function will decide whether or not it is legal for the player to move South, and if so - will allow the player to move South.
        }

        private void clicked_useItem(object sender, EventArgs e)
        {
            hubWriteLine("User has clicked on 'Use Item'");
            //This function will decide which list item the player clicked, and decide which action to take based on the item (if any).
        }

        private void clicked_examineItem(object sender, EventArgs e)
        {
            hubWriteLine("User has clicked on 'Examine Item'");
            //This function will decide which list item the player clicked, and output a brief description of the item to the inventoryDescription textbox
        }

        private void clicked_map(object sender, EventArgs e)
        {
            hubWriteLine("User has clicked on 'Map'");
            //This function will pull up a larger view of the map, listing the player's current location and also a few nearby rooms.
        }

        private void clicked_userEntryPanel(object sender, EventArgs e)
        {
            userEntryPanel.Text = "";
        }

        private void clicked_userEntrySubmit(object sender, EventArgs e)
        {
            hubWriteLine("The user has typed \"" + userEntryPanel.Text + "\" into the user entry panel.");
            userEntryPanel.Text = "";
        }

        private void clicked_startGameButton(object sender, EventArgs e)
        {
            if (textbox_CharName.Text != null && textbox_CharName.Text != "")
            {
                //Hide and disable interface components
                CharacterNameLabel.Enabled = false;
                CharacterNameLabel.Visible = false;
                textbox_CharName.Enabled = false;
                textbox_CharName.Visible = false;
                startGameButton.Enabled = false;
                startGameButton.Visible = false;

                //Create a new player object using Name inputted and dice-rolled base stats.  100 health, 50 ability points.
                Player player = new Player();
                player.setName(textbox_CharName.Text);
                player.setHitPoints(100);
                player.setAbilityPoints(50);

                //Dice role core stats.
                Random rand = new Random();
                player.setAttackPower(rand.Next(4, 100));
                player.setDefenseRating(rand.Next(4, 100));
                player.setAbilityPower(rand.Next(4, 100));
                player.setMagicDefense(rand.Next(4, 100));
                player.setConstitution(rand.Next(4, 100));
                player.setIntelligence(rand.Next(4, 100));
                player.setPerception(rand.Next(4, 100));
                player.setLuck(rand.Next(4, 100));

                //Set experience
                player.setExperience(0);
                player.setExperienceToNext(100);
                player.setLevel(1);

                //location
                player.setX(20);
                player.setY(33);

                //welcome the character using its name.
                hubClear();
                hubWriteLine("Character created!  Are you ready to start your journey, " + player.getName() + "?\n");

                //Report the new character's statistics.
                hubWriteLine("Character Level: " + player.getLevel() + "\nHitPoints: " + player.getHitPoints() + "\nAbility Points: " + player.getAbilityPoints() + "\n----------------\nAttack Power: " + player.getAttackPower() +
                    "\nDefense Rating: " + player.getDefenseRating() + "\nAbility Power: " + player.getAbilityPower() + "\nMagic Defense: " + player.getMagicDefense() + "\nConstitution: " + player.getConstitution() + "\nLuck: " +
                    player.getLuck() + "\nIntelligence: " + player.getPerception() + "\n"); 
                    
                
            }

                 
            //This function will start the entire game.  This is the entry point for the game.  When the user clicks start, the character will be built, the map will be built, the game will be built, etc.
            //This could possibly be one of the most important functions in the entire game.
            //A welcome message will be printed along with a very brief text tutorial
            //The player will be prompted to enter their character's name, age, gender, and will be asked a few questions that will determine beginning stats.
            //A very brief story will be printed, informing the player of the overall objective of the game.
            //Maybe some  tool-tips or popup arrows will appear, telling the player how to use the interface for the first time.
            //This function will immediately hand-off to Main, which will run all of the above functionality.
        }

        /* --------------These functions create shortcut functionality to use when trying to print to the central info hub, for ease of use. ----------------------------*/
       public void hubWrite(string text)
        {
            centralInfoHub.AppendText(text);
        }

       public void hubWriteLine(string text)
        { 
            centralInfoHub.AppendText(text + "\n");
        }

        public void hubClear()
        {
            centralInfoHub.Text = "";
        }

        public void hubOnlyShow(string text)
        {
            centralInfoHub.Text = "";
            centralInfoHub.Text = text;
        }

        public void hubOnlyShowLine(string text)
        {
            centralInfoHub.Text = "";
            centralInfoHub.Text = text + "\n";
        }
        /* ------------------ End infoHub QOL functions -------------------------------*/
    }
}
