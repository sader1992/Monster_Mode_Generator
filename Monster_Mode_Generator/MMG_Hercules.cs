using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monster_Mode_Generator
{
    public partial class MMG_Hercules : Form
    {
        public MMG_Hercules()
        {
            InitializeComponent();
        }
        int MD_CANMOVE = 1;
        int MD_LOOTER = 2;
        int MD_AGGRESSIVE = 4;
        int MD_ASSIST = 8;
        int MD_CASTSENSOR_IDLE = 16;
        int MD_BOSS = 32;
        int MD_PLANT = 64;
        int MD_CANATTACK = 128;
        int MD_DETECTOR = 256;
        int MD_CASTSENSOR_CHASE = 512;
        int MD_CHANGECHASE = 1024;
        int MD_ANGRY = 2048;
        int MD_CHANGETARGET_MELEE = 4096;
        int MD_CHANGETARGET_CHASE = 8192;
        int MD_TARGETWEAK = 16384;
        int MD_NOKNOCKBACK = 32768;
        int MD_RANDOMTARGET = 65536;

        ToolTip T_CANMOVE = new ToolTip();
        ToolTip T_LOOTER = new ToolTip();
        ToolTip T_AGGRESSIVE = new ToolTip();
        ToolTip T_ASSIST = new ToolTip();
        ToolTip T_CASTSENSOR_IDLE = new ToolTip();
        ToolTip T_BOSS = new ToolTip();
        ToolTip T_PLANT = new ToolTip();
        ToolTip T_CANATTACK = new ToolTip();
        ToolTip T_DETECTOR = new ToolTip();
        ToolTip T_CASTSENSOR_CHASE = new ToolTip();
        ToolTip T_CHANGECHASE = new ToolTip();
        ToolTip T_ANGRY = new ToolTip();
        ToolTip T_CHANGETARGET_MELEE = new ToolTip();
        ToolTip T_CHANGETARGET_CHASE = new ToolTip();
        ToolTip T_TARGETWEAK = new ToolTip();
        ToolTip T_NOKNOCKBACK = new ToolTip();
        ToolTip T_RANDOMTARGET = new ToolTip();

        private void MMG_Hercules_Load(object sender, EventArgs e)
        {
            ToolTips_Hercules();
            MMG_H_update.Start();
        }

        private void ToolTips_Hercules()
        {
            T_CANMOVE.SetToolTip(CANMOVE, "Can Move: Enables the mob to move/chase characters.");
            T_LOOTER.SetToolTip(LOOTER, "Looter: The mob will loot up nearby items on the ground when it's on idle state.");
            T_AGGRESSIVE.SetToolTip(AGGRESSIVE, "Aggressive: normal aggressive mob, will look for a close-by player to attack.");
            T_ASSIST.SetToolTip(ASSIST, "Assist: When a nearby mob of the same class attacks, assist types will join them.");
            T_CASTSENSOR_IDLE.SetToolTip(CASTSENSOR_IDLE, "Cast Sensor Idle: Will go after characters who start casting on them if idle or walking (without a target).");
            T_BOSS.SetToolTip(BOSS, "Boss: Special flag which makes mobs immune to certain status changes and skills.");
            T_PLANT.SetToolTip(PLANT, "Plant: Always receives 1 damage from attacks.");
            T_CANATTACK.SetToolTip(CANATTACK, "Can Attack: Enables the mob to attack/retaliate when you are within attack range." + Environment.NewLine + "Note that this only enables them to use normal attacks, skills are always allowed.");
            T_CASTSENSOR_CHASE.SetToolTip(CASTSENSOR_CHASE, "Cast Sensor Chase: Will go after characters who start casting on them if idle" + Environment.NewLine + "or chasing other players (they switch chase targets).");
            T_CHANGECHASE.SetToolTip(CHANGECHASE, "Change Chase: Allows chasing mobs to switch targets if another player happens" + Environment.NewLine + "to be within attack range (handy on ranged attackers, for example).");
            T_ANGRY.SetToolTip(ANGRY, "Angry: These mobs are \"hyper - active\". Apart from \"chase\"/\"attack\", they have" + Environment.NewLine + "the states \"follow\"/\"angry\". Once hit, they stop using these states and use" + Environment.NewLine + "the normal ones. The new states are used to determine a different skill-set" + Environment.NewLine + "for their \"before attacked\" and \"after attacked\" states. Also, when" + Environment.NewLine + "\"following\", they automatically switch to whoever character is closest.");
            T_CHANGETARGET_MELEE.SetToolTip(CHANGETARGET_MELEE, "Change Target Melee: Enables a mob to switch targets when hit by a normal attack" + Environment.NewLine + "while attacking someone else.");
            T_CHANGETARGET_CHASE.SetToolTip(CHANGETARGET_CHASE, "Change Target Chase: Enables a mob to switch targets when hit by any attack" + Environment.NewLine + "while chasing another character.");
            T_TARGETWEAK.SetToolTip(TARGETWEAK, "Target Weak: Allows aggressive monsters to only be aggressive against" + Environment.NewLine + "characters that are five levels below it's own level." + Environment.NewLine + "For example, a monster of level 104 will not pick fights with a level 99.");
            T_RANDOMTARGET.SetToolTip(RANDOMTARGET, "Random Target: Picks a new random target in range on each attack / skill.(not implemented)");
            T_NOKNOCKBACK.SetToolTip(NOKNOCKBACK, "Knockback Immune: The mob will be unable to be knocked back.");
            T_DETECTOR.SetToolTip(DETECTOR, "Detector: Enables mob to detect and attack characters who are in hiding/cloak.");

            T_CANMOVE.AutoPopDelay = 30000;
            T_LOOTER.AutoPopDelay = 30000;
            T_AGGRESSIVE.AutoPopDelay = 30000;
            T_ASSIST.AutoPopDelay = 30000;
            T_CASTSENSOR_IDLE.AutoPopDelay = 30000;
            T_BOSS.AutoPopDelay = 30000;
            T_PLANT.AutoPopDelay = 30000;
            T_CANATTACK.AutoPopDelay = 30000;
            T_CASTSENSOR_CHASE.AutoPopDelay = 30000;
            T_CHANGECHASE.AutoPopDelay = 30000;
            T_ANGRY.AutoPopDelay = 30000;
            T_CHANGETARGET_MELEE.AutoPopDelay = 30000;
            T_CHANGETARGET_CHASE.AutoPopDelay = 30000;
            T_TARGETWEAK.AutoPopDelay = 30000;
            T_RANDOMTARGET.AutoPopDelay = 30000;
            T_NOKNOCKBACK.AutoPopDelay = 30000;
            T_DETECTOR.AutoPopDelay = 30000;

            T_CANMOVE.InitialDelay = 100;
            T_LOOTER.InitialDelay = 100;
            T_AGGRESSIVE.InitialDelay = 100;
            T_ASSIST.InitialDelay = 100;
            T_CASTSENSOR_IDLE.InitialDelay = 100;
            T_BOSS.InitialDelay = 100;
            T_PLANT.InitialDelay = 100;
            T_CANATTACK.InitialDelay = 100;
            T_CASTSENSOR_CHASE.InitialDelay = 100;
            T_CHANGECHASE.InitialDelay = 100;
            T_ANGRY.InitialDelay = 100;
            T_CHANGETARGET_MELEE.InitialDelay = 100;
            T_CHANGETARGET_CHASE.InitialDelay = 100;
            T_TARGETWEAK.InitialDelay = 100;
            T_RANDOMTARGET.InitialDelay = 100;
            T_NOKNOCKBACK.InitialDelay = 100;
            T_DETECTOR.InitialDelay = 100;
        }

        private void MMG_H_update_Tick(object sender, EventArgs e)
        {
            int R_result = 0;
            if (CANMOVE.Checked) { R_result = R_result + MD_CANMOVE; }
            if (LOOTER.Checked) { R_result = R_result + MD_LOOTER; }
            if (AGGRESSIVE.Checked) { R_result = R_result + MD_AGGRESSIVE; }
            if (ASSIST.Checked) { R_result = R_result + MD_ASSIST; }
            if (CASTSENSOR_IDLE.Checked) { R_result = R_result + MD_CASTSENSOR_IDLE; }
            if (BOSS.Checked) { R_result = R_result + MD_BOSS; }
            if (PLANT.Checked) { R_result = R_result + MD_PLANT; }
            if (CANATTACK.Checked) { R_result = R_result + MD_CANATTACK; }
            if (CASTSENSOR_CHASE.Checked) { R_result = R_result + MD_CASTSENSOR_CHASE; }
            if (CHANGECHASE.Checked) { R_result = R_result + MD_CHANGECHASE; }
            if (ANGRY.Checked) { R_result = R_result + MD_ANGRY; }
            if (CHANGETARGET_MELEE.Checked) { R_result = R_result + MD_CHANGETARGET_MELEE; }
            if (CHANGETARGET_CHASE.Checked) { R_result = R_result + MD_CHANGETARGET_CHASE; }
            if (TARGETWEAK.Checked) { R_result = R_result + MD_TARGETWEAK; }
            if (RANDOMTARGET.Checked) { R_result = R_result + MD_RANDOMTARGET; }
            if (NOKNOCKBACK.Checked) { R_result = R_result + MD_NOKNOCKBACK; }
            if (DETECTOR.Checked) { R_result = R_result + MD_DETECTOR; }



            MMG_R_result.Text = "0x" + R_result.ToString("X");
        }

        private void MMG_Hercules_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
