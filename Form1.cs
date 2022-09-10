using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wolfman_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] race = { "Monster", "Human" };
        string[] branch = { "Warrior", "Wolf Man", "Assasins", "Wizzard", "Archar" };
        string[] weapons = { "Spell", "Sword", "Claw", "Knife", "Arrow" };

        User1 user1 = new User1();


        private void Form1_Load(object sender, EventArgs e)
        {
            cmbRace.Items.Add(race[0]);
            cmbRace.Items.Add(race[1]);
        }


        private void btnNewGame_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = true;
            cmbBranch.Enabled = true;
            cmbRace.Enabled = true;
            cmbWeapon.Enabled = true;
            btnSelect.Enabled = true;

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = false;
            cmbBranch.Enabled = false;
            cmbRace.Enabled = false;
            cmbWeapon.Enabled = false;
            btnAttack.Enabled = true;
            pictureBox1.Visible = true;
            lblEnemy.Visible = true;
            pictureBox2.Visible = true;
            lblMe.Visible = true;
        }

    
        private void cmbRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBranch.Items.Clear();

            if (cmbRace.Text == race[0])
            {
                cmbBranch.Items.Add(branch[1]);
            }
            else
            {
                cmbBranch.Items.Add(branch[0]);
                cmbBranch.Items.Add(branch[2]);
                cmbBranch.Items.Add(branch[3]);
                cmbBranch.Items.Add(branch[4]);
            }
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbWeapon.Items.Clear();

            if (cmbBranch.Text == branch[0])
            {
                cmbWeapon.Items.Add(weapons[1]);
            }
            else if (cmbBranch.Text == branch[1])
            {
                cmbWeapon.Items.Add(weapons[2]);
            }
            else if (cmbBranch.Text == branch[2])
            {
                cmbWeapon.Items.Add(weapons[3]);
            }
            else if (cmbBranch.Text == branch[3])
            {
                cmbWeapon.Items.Add(weapons[0]);
            }
            else
            {
                cmbWeapon.Items.Add(weapons[4]);
            }
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            user1.userName = txtUserName.Text;
            user1.weapon = cmbWeapon.Text;
            user1.branch = cmbBranch.Text;
            user1.race = cmbRace.Text;
            user1.Attack();

            if (lblEnemy.Width <= 200)
            {
                lblEnemy.Width -= user1.damage;
                MessageBox.Show($"Sevgili {user1.userName},\n düşmanınıza {user1.damage} kadar hasar verdiniz.");
            }
            if(lblEnemy.Width == 0)
            {
                MessageBox.Show("Tebrikler Şef düşmanı alt ettin.");
                lblEnemy.Visible = false;
                pictureBox2.Visible = false;
                btnAttack.Enabled = false;
                btnAttack2.Visible = false;
            }

            
        }
    }
}
