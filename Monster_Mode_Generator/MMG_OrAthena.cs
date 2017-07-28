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
    public partial class MMG_OrAthena : Form
    {
        public MMG_OrAthena()
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
        int MD_RANDOMTARGET = 32768;
        int MD_IGNOREMELEE = 65536;
        int MD_IGNOREMAGIC = 131072;
        int MD_IGNORERANGED = 262144;
        int MD_MVP = 524288;
        int MD_IGNOREMISC = 1048576;
        int MD_KNOCKBACK_IMMUNE = 2097152;

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
        ToolTip T_RANDOMTARGET = new ToolTip();
        ToolTip T_IGNOREMELEE = new ToolTip();
        ToolTip T_IGNOREMAGIC = new ToolTip();
        ToolTip T_IGNORERANGED = new ToolTip();
        ToolTip T_MVP = new ToolTip();
        ToolTip T_IGNOREMISC = new ToolTip();
        ToolTip T_KNOCKBACK_IMMUNE = new ToolTip();

        private void MMGOrAthena_Load(object sender, EventArgs e)
        {
            ToolTips_OrAthena();
        }

        private void ToolTips_OrAthena()
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
            T_RANDOMTARGET.SetToolTip(RANDOMTARGET, "Random Target: Picks a new random target in range on each attack / skill.");
            T_IGNOREMELEE.SetToolTip(IGNOREMELEE, "Ignore Melee: The mob will take 1 HP damage from physical attacks.");
            T_IGNOREMAGIC.SetToolTip(IGNOREMAGIC, "Ignore Magic: The mob will take 1 HP damage from magic attacks.");
            T_IGNORERANGED.SetToolTip(IGNORERANGED, "Ignore Range: The mob will take 1 HP damage from ranged attacks.");
            T_MVP.SetToolTip(MVP, "MVP: Flagged as MVP which makes mobs resistant to Coma. Also displays the" + Environment.NewLine + "MVP sign and gives players MVP EXP or MVP items.");
            T_IGNOREMISC.SetToolTip(IGNOREMISC, "Ignore Misc: The mob will take 1 HP damage from \"none\" attack type.");
            T_KNOCKBACK_IMMUNE.SetToolTip(KNOCKBACK_IMMUNE, "Knockback Immune: The mob will be unable to be knocked back.");
            T_DETECTOR.SetToolTip(DETECTOR, "Detector: Enables mob to detect and attack characters who are in hiding/cloak.");
            
            T_CANMOVE.AutoPopDelay = 30000;
            T_LOOTER.AutoPopDelay = 30000;
            T_AGGRESSIVE.AutoPopDelay = 30000;
            T_ASSIST.AutoPopDelay = 30000;
            T_BOSS.AutoPopDelay = 30000;
            T_PLANT.AutoPopDelay = 30000;
            T_CASTSENSOR_IDLE.AutoPopDelay = 30000;
            T_CANATTACK.AutoPopDelay = 30000;
            T_CASTSENSOR_CHASE.AutoPopDelay = 30000;
            T_CHANGECHASE.AutoPopDelay = 30000;
            T_ANGRY.AutoPopDelay = 30000;
            T_CHANGETARGET_MELEE.AutoPopDelay = 30000;
            T_CHANGETARGET_CHASE.AutoPopDelay = 30000;
            T_TARGETWEAK.AutoPopDelay = 30000;
            T_RANDOMTARGET.AutoPopDelay = 30000;
            T_IGNOREMELEE.AutoPopDelay = 30000;
            T_IGNOREMAGIC.AutoPopDelay = 30000;
            T_IGNORERANGED.AutoPopDelay = 30000;
            T_MVP.AutoPopDelay = 30000;
            T_IGNOREMISC.AutoPopDelay = 30000;
            T_KNOCKBACK_IMMUNE.AutoPopDelay = 30000;
            T_DETECTOR.AutoPopDelay = 30000;

            T_CANMOVE.InitialDelay = 100;
            T_LOOTER.InitialDelay = 100;
            T_AGGRESSIVE.InitialDelay = 100;
            T_ASSIST.InitialDelay = 100;
            T_BOSS.InitialDelay = 100;
            T_PLANT.InitialDelay = 100;
            T_CASTSENSOR_IDLE.InitialDelay = 100;
            T_CANATTACK.InitialDelay = 100;
            T_CASTSENSOR_CHASE.InitialDelay = 100;
            T_CHANGECHASE.InitialDelay = 100;
            T_ANGRY.InitialDelay = 100;
            T_CHANGETARGET_MELEE.InitialDelay = 100;
            T_CHANGETARGET_CHASE.InitialDelay = 100;
            T_TARGETWEAK.InitialDelay = 100;
            T_RANDOMTARGET.InitialDelay = 100;
            T_IGNOREMELEE.InitialDelay = 100;
            T_IGNOREMAGIC.InitialDelay = 100;
            T_IGNORERANGED.InitialDelay = 100;
            T_MVP.InitialDelay = 100;
            T_IGNOREMISC.InitialDelay = 100;
            T_KNOCKBACK_IMMUNE.InitialDelay = 100;
            T_DETECTOR.InitialDelay = 100;
        }

        private void MMG_O_R_update_Tick(object sender, EventArgs e)
        {
            int R_result = 0;
            if (CANMOVE.Checked) { R_result = R_result + MD_CANMOVE; }
            if (LOOTER.Checked) { R_result = R_result + MD_LOOTER; }
            if (AGGRESSIVE.Checked) { R_result = R_result + MD_AGGRESSIVE; }
            if (ASSIST.Checked) { R_result = R_result + MD_ASSIST; }
            if (BOSS.Checked) { R_result = R_result + MD_BOSS; }
            if (PLANT.Checked) { R_result = R_result + MD_PLANT; }
            if (CASTSENSOR_IDLE.Checked) { R_result = R_result + MD_CASTSENSOR_IDLE; }
            if (CANATTACK.Checked) { R_result = R_result + MD_CANATTACK; }
            if (CASTSENSOR_CHASE.Checked) { R_result = R_result + MD_CASTSENSOR_CHASE; }
            if (CHANGECHASE.Checked) { R_result = R_result + MD_CHANGECHASE; }
            if (ANGRY.Checked) { R_result = R_result + MD_ANGRY; }
            if (CHANGETARGET_MELEE.Checked) { R_result = R_result + MD_CHANGETARGET_MELEE; }
            if (CHANGETARGET_CHASE.Checked) { R_result = R_result + MD_CHANGETARGET_CHASE; }
            if (TARGETWEAK.Checked) { R_result = R_result + MD_TARGETWEAK; }
            if (RANDOMTARGET.Checked) { R_result = R_result + MD_RANDOMTARGET; }
            if (IGNOREMELEE.Checked) { R_result = R_result + MD_IGNOREMELEE; }
            if (IGNOREMAGIC.Checked) { R_result = R_result + MD_IGNOREMAGIC; }
            if (IGNORERANGED.Checked) { R_result = R_result + MD_IGNORERANGED; }
            if (MVP.Checked) { R_result = R_result + MD_MVP; }
            if (IGNOREMISC.Checked) { R_result = R_result + MD_IGNOREMISC; }
            if (KNOCKBACK_IMMUNE.Checked) { R_result = R_result + MD_KNOCKBACK_IMMUNE; }
            if (DETECTOR.Checked) { R_result = R_result + MD_DETECTOR; }



            MMG_R_result.Text = "0x" + R_result.ToString("X");
        }

        private void MMG_OrAthena_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
