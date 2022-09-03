using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Wolfman_Game
{
    public class User1
    {
        public string userName { get; set; }
        public int damage { get; set; }
        public string branch { get; set; }
        public string race { get; set; }
        public string weapon { get; set; }


        Random rndmDamage = new Random();
        public void Attack()
    {
        damage = 0;

        if (branch == "Assasins")
        {
            damage += rndmDamage.Next(55, 66);
        }
        else if (branch == "Wolf Man")
        {
           damage += 55;
        }
        else if (branch == "Wizzard")
        {
            damage += rndmDamage.Next(45,61);
        }
        else if (branch == "Archar")
        {
            damage += rndmDamage.Next(35,56);
        }
        else
            {
                damage += 60;
            }
    }
    }
}
