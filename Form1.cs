using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Elder_Scrolls_Character_Randomizer
{
    public partial class Form1 : Form
    {
        

        List<string> Classes = new List<string>()
        {
            "Acrobat",
            "Agent",
            "Archer",
            "Assassin",
            "Barbarian",
            "Bard",
            "Battlemage",
            "Crusader",
            "Healer",
            "Knight",
            "Mage",
            "Monk",
            "Nightblade",
            "Pilgrim",
            "Rogue",
            "Scout",
            "Sorcerer",
            "Spellsword",
            "Thief",
            "Warrior",
            "Witchhunter",
         };


        List<string> Classes_Magic = new List<string>()

        {
            "Battlemage",
            "Healer",
            "Mage",
            "Nightblade",
            "Sorcerer",
            "Spellsword",
            "Witchhunter"
        };

        List<string> Classes_Combat = new List<string>()

        {
            "Archer",
            "Barbarian",
            "Crusader",
            "Knight",
            "Rogue",
            "Scout",
            "Warrior"
        };

        List<string> Classes_Stealth = new List<string>()
        { 
            "Acrobat",
            "Agent",
            "Assassin",
            "Bard",
            "Monk",
            "Pilgrim",
            "Thief"
        };


        private static Random random = new Random();
        private int rnd(int min, int max)
        {
            return random.Next(min, max);
        }


        public Form1()
        {
            

            InitializeComponent();
            Random rnd = new Random();
            int race = rnd.Next(10);
            int Class = rnd.Next(21);
            int Class_Magic = rnd.Next(7);
            int Class_Combat = rnd.Next(7);
            int Class_Stealth = rnd.Next(7);

           // string Lable2 = Convert.ToString(race);
            string Lable3 = Convert.ToString(Class);
            string Lable4 = Convert.ToString(Class_Magic);
            string Lable5 = Convert.ToString(Class_Combat);
            string Lable6 = Convert.ToString(Class_Stealth);


            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form1();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            

            if (radioButton1.Checked == true)
            {
                comboBox1.Visible = true;
            }

            else
            {
                comboBox1.Visible = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        

            

            Random rnd = new Random();
            int race = rnd.Next(10);
            int Class = rnd.Next(21);
            int Class_Magic = rnd.Next(7);
            int Class_Combat = rnd.Next(7);
            int Class_Stealth = rnd.Next(7);

            if (radioButton1.Checked == false && (comboBox3.SelectedItem == "Random" || comboBox3.SelectedItem == "Stealth" 
                || comboBox3.SelectedItem == "Magic" || comboBox3.SelectedItem == "Combat") )
            {
                comboBox1.SelectedIndex = random.Next(1,10); 
                string Selected_Race = comboBox1.SelectedItem.ToString();
                label2.Text = Selected_Race;
                label2.Visible = true;
            }

            if (comboBox3.SelectedItem == "Random")
            {
                int r = rnd.Next(Classes.Count);
                string Image_String = Classes[r];
                label3.Text = Image_String;
                label3.Visible = true;

                if (label3.Text == "Acrobat")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Acrobat;
                }

                else if (label3.Text == "Agent")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Agent;
                }

                else if (label3.Text == "Archer")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Archer;
                }

                else if (label3.Text == "Assassin")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Assassin;
                }

                else if (label3.Text == "Barbarian")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Barbarian;
                }

                else if (label3.Text == "Bard")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Bard;
                }

                else if (label3.Text == "Battlemage")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Battlemage;
                }

                else if (label3.Text == "Crusader")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Crusader;
                }

                else if (label3.Text == "Healer")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Healer;
                }

                else if (label3.Text == "Knight")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Knight;
                }

                else if (label3.Text == "Mage")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Mage;
                }

                else if (label3.Text == "Monk")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Monk;
                }

                else if (label3.Text == "Nightblade")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Nightblade;
                }

                else if (label3.Text == "Pilgrim")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Pilgrim;
                }

                else if (label3.Text == "Rogue")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Rogue;
                }

                else if (label3.Text == "Scout")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Scout;
                }

                else if (label3.Text == "Sorcerer")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Sorcerer;
                }

                else if (label3.Text == "Spellsword")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Spellsword;
                }

                else if (label3.Text == "Thief")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Thief;
                }

                else if (label3.Text == "Warrior")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Warrior;
                }

                else if (label3.Text == "Witchhunter")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Witchhunter;
                }
                button2.Text = "Re-Roll";
            }

            else if (comboBox3.SelectedItem == "Stealth")
            {
                int r = rnd.Next(Classes_Stealth.Count);
                string Image_String = Classes_Stealth[r];
                label3.Text = Image_String;
                label3.Visible = true;

                if (label3.Text == "Acrobat")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Acrobat;
                }

                else if (label3.Text == "Agent")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Agent;
                }

                else if (label3.Text == "Assassin")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Assassin;
                }

                else if (label3.Text == "Bard")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Bard;
                }

                else if (label3.Text == "Monk")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Monk;
                }

                else if (label3.Text == "Pilgrim")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Pilgrim;
                }

                else if (label3.Text == "Thief")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Thief;
                }
                button2.Text = "Re-Roll";
            }

            else if (comboBox3.SelectedItem == "Magic")
            {
                int r = rnd.Next(Classes_Magic.Count);
                string Image_String = Classes_Magic[r];
                label3.Text = Image_String;
                label3.Visible = true;

                if (label3.Text == "Battlemage")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Battlemage;
                }

                else if (label3.Text == "Healer")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Healer;
                }

                else if (label3.Text == "Mage")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Mage;
                }

                else if (label3.Text == "Nightblade")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Nightblade;
                }

                else if (label3.Text == "Sorcerer")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Sorcerer;
                }

                else if (label3.Text == "Spellsword")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Spellsword;
                }

                else if (label3.Text == "Witchhunter")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Witchhunter;
                }
                button2.Text = "Re-Roll";
            }

            else if (comboBox3.SelectedItem == "Combat")
            {
                int r = rnd.Next(Classes_Combat.Count);
                string Image_String = Classes_Combat[r];
                label3.Text = Image_String;
                label3.Visible = true;

                if (label3.Text == "Archer")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Archer;
                }

                else if (label3.Text == "Barbarian")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Barbarian;
                }

                else if (label3.Text == "Crusader")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Crusader;
                }

                else if (label3.Text == "Knight")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Knight;
                }

                else if (label3.Text == "Rogue")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Rogue;
                }

                else if (label3.Text == "Scout")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Scout;
                }

                else if (label3.Text == "Warrior")
                {
                    pictureBox1.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Warrior;
                }
                button2.Text = "Re-Roll";
            }

            if (label2.Text == "Altmer (High Elf)")
            {
                pictureBox2.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Altmer__High_Elf_;
            }

            else if (label2.Text == "Argonian")
            {
                pictureBox2.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Argonian;
            }

            else if (label2.Text == "Bosmer (Wood Elf)")
            {
                pictureBox2.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Bosmer__Wood_Elf_;
            }

            else if (label2.Text == "Breton")
            {
                pictureBox2.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Breton;
            }

            else if (label2.Text == "Dunmer (Dark Elf)")
            {
                pictureBox2.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Dunmer__Dark_Elf_;
            }

            else if (label2.Text == "Imperial")
            {
                pictureBox2.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Imperial;
            }

            else if (label2.Text == "Khajiit")
            {
                pictureBox2.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Khajiit;
            }

            else if (label2.Text == "Nord")
            {
                pictureBox2.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Nord;
            }

            else if (label2.Text == "Orsime (Orc)")
            {
                pictureBox2.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Orsimer__Orc_;
            }

            else if (label2.Text == "Redguard")
            {
                pictureBox2.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Redguard;
            }
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = comboBox1.SelectedItem.ToString();
            label2.Visible = true;

            if (label2.Text == "Altmer (High Elf)")
            {
                pictureBox2.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Altmer__High_Elf_;
            }

            else if (label2.Text == "Argonian")
            {
                pictureBox2.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Argonian;
            }

            else if (label2.Text == "Bosmer (Wood Elf)")
            {
                pictureBox2.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Bosmer__Wood_Elf_;
            }

            else if (label2.Text == "Breton")
            {
                pictureBox2.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Breton;
            }

            else if (label2.Text == "Dunmer (Dark Elf)")
            {
                pictureBox2.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Dunmer__Dark_Elf_;
            }

            else if (label2.Text == "Imperial")
            {
                pictureBox2.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Imperial;
            }

            else if (label2.Text == "Khajiit")
            {
                pictureBox2.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Khajiit;
            }

            else if (label2.Text == "Nord")
            {
                pictureBox2.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Nord;
            }

            else if (label2.Text == "Orsime (Orc)")
            {
                pictureBox2.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Orsimer__Orc_;
            }

            else if (label2.Text == "Redguard")
            {
                pictureBox2.Image = Elder_Scrolls_Character_Randomizer.Properties.Resources.Redguard;
            }
        }

        private void Oblivion_Load(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
