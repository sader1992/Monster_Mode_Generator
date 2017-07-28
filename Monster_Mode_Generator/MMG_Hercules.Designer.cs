namespace Monster_Mode_Generator
{
    partial class MMG_Hercules
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MMG_Hercules));
            this.MMG_H_update = new System.Windows.Forms.Timer(this.components);
            this.MMG_R_result = new System.Windows.Forms.TextBox();
            this.Hercules_logo = new System.Windows.Forms.PictureBox();
            this.DETECTOR = new System.Windows.Forms.CheckBox();
            this.RANDOMTARGET = new System.Windows.Forms.CheckBox();
            this.TARGETWEAK = new System.Windows.Forms.CheckBox();
            this.CHANGETARGET_CHASE = new System.Windows.Forms.CheckBox();
            this.CHANGETARGET_MELEE = new System.Windows.Forms.CheckBox();
            this.ANGRY = new System.Windows.Forms.CheckBox();
            this.CHANGECHASE = new System.Windows.Forms.CheckBox();
            this.CASTSENSOR_CHASE = new System.Windows.Forms.CheckBox();
            this.CANATTACK = new System.Windows.Forms.CheckBox();
            this.CASTSENSOR_IDLE = new System.Windows.Forms.CheckBox();
            this.ASSIST = new System.Windows.Forms.CheckBox();
            this.AGGRESSIVE = new System.Windows.Forms.CheckBox();
            this.LOOTER = new System.Windows.Forms.CheckBox();
            this.CANMOVE = new System.Windows.Forms.CheckBox();
            this.NOKNOCKBACK = new System.Windows.Forms.CheckBox();
            this.PLANT = new System.Windows.Forms.CheckBox();
            this.BOSS = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Hercules_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // MMG_H_update
            // 
            this.MMG_H_update.Enabled = true;
            this.MMG_H_update.Tick += new System.EventHandler(this.MMG_H_update_Tick);
            // 
            // MMG_R_result
            // 
            this.MMG_R_result.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MMG_R_result.Location = new System.Drawing.Point(100, 407);
            this.MMG_R_result.Name = "MMG_R_result";
            this.MMG_R_result.ReadOnly = true;
            this.MMG_R_result.Size = new System.Drawing.Size(220, 47);
            this.MMG_R_result.TabIndex = 104;
            // 
            // Hercules_logo
            // 
            this.Hercules_logo.Image = ((System.Drawing.Image)(resources.GetObject("Hercules_logo.Image")));
            this.Hercules_logo.Location = new System.Drawing.Point(75, 27);
            this.Hercules_logo.Name = "Hercules_logo";
            this.Hercules_logo.Size = new System.Drawing.Size(308, 74);
            this.Hercules_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hercules_logo.TabIndex = 103;
            this.Hercules_logo.TabStop = false;
            // 
            // DETECTOR
            // 
            this.DETECTOR.AutoSize = true;
            this.DETECTOR.Location = new System.Drawing.Point(68, 355);
            this.DETECTOR.Name = "DETECTOR";
            this.DETECTOR.Size = new System.Drawing.Size(84, 21);
            this.DETECTOR.TabIndex = 100;
            this.DETECTOR.Text = "Detector";
            this.DETECTOR.UseVisualStyleBackColor = true;
            // 
            // RANDOMTARGET
            // 
            this.RANDOMTARGET.AutoSize = true;
            this.RANDOMTARGET.Location = new System.Drawing.Point(265, 328);
            this.RANDOMTARGET.Name = "RANDOMTARGET";
            this.RANDOMTARGET.Size = new System.Drawing.Size(126, 21);
            this.RANDOMTARGET.TabIndex = 91;
            this.RANDOMTARGET.Text = "Random Target";
            this.RANDOMTARGET.UseVisualStyleBackColor = true;
            // 
            // TARGETWEAK
            // 
            this.TARGETWEAK.AutoSize = true;
            this.TARGETWEAK.Location = new System.Drawing.Point(265, 274);
            this.TARGETWEAK.Name = "TARGETWEAK";
            this.TARGETWEAK.Size = new System.Drawing.Size(109, 21);
            this.TARGETWEAK.TabIndex = 90;
            this.TARGETWEAK.Text = "Target Weak";
            this.TARGETWEAK.UseVisualStyleBackColor = true;
            // 
            // CHANGETARGET_CHASE
            // 
            this.CHANGETARGET_CHASE.AutoSize = true;
            this.CHANGETARGET_CHASE.Location = new System.Drawing.Point(265, 247);
            this.CHANGETARGET_CHASE.Name = "CHANGETARGET_CHASE";
            this.CHANGETARGET_CHASE.Size = new System.Drawing.Size(162, 21);
            this.CHANGETARGET_CHASE.TabIndex = 89;
            this.CHANGETARGET_CHASE.Text = "Change Target Chase";
            this.CHANGETARGET_CHASE.UseVisualStyleBackColor = true;
            // 
            // CHANGETARGET_MELEE
            // 
            this.CHANGETARGET_MELEE.AutoSize = true;
            this.CHANGETARGET_MELEE.Location = new System.Drawing.Point(265, 220);
            this.CHANGETARGET_MELEE.Name = "CHANGETARGET_MELEE";
            this.CHANGETARGET_MELEE.Size = new System.Drawing.Size(158, 21);
            this.CHANGETARGET_MELEE.TabIndex = 88;
            this.CHANGETARGET_MELEE.Text = "Change Target Melee";
            this.CHANGETARGET_MELEE.UseVisualStyleBackColor = true;
            // 
            // ANGRY
            // 
            this.ANGRY.AutoSize = true;
            this.ANGRY.Location = new System.Drawing.Point(265, 193);
            this.ANGRY.Name = "ANGRY";
            this.ANGRY.Size = new System.Drawing.Size(67, 21);
            this.ANGRY.TabIndex = 87;
            this.ANGRY.Text = "Angry";
            this.ANGRY.UseVisualStyleBackColor = true;
            // 
            // CHANGECHASE
            // 
            this.CHANGECHASE.AutoSize = true;
            this.CHANGECHASE.Location = new System.Drawing.Point(265, 166);
            this.CHANGECHASE.Name = "CHANGECHASE";
            this.CHANGECHASE.Size = new System.Drawing.Size(118, 21);
            this.CHANGECHASE.TabIndex = 86;
            this.CHANGECHASE.Text = "Change Chase";
            this.CHANGECHASE.UseVisualStyleBackColor = true;
            // 
            // CASTSENSOR_CHASE
            // 
            this.CASTSENSOR_CHASE.AutoSize = true;
            this.CASTSENSOR_CHASE.Location = new System.Drawing.Point(265, 139);
            this.CASTSENSOR_CHASE.Name = "CASTSENSOR_CHASE";
            this.CASTSENSOR_CHASE.Size = new System.Drawing.Size(144, 21);
            this.CASTSENSOR_CHASE.TabIndex = 85;
            this.CASTSENSOR_CHASE.Text = "Cast Sensor Chase";
            this.CASTSENSOR_CHASE.UseVisualStyleBackColor = true;
            // 
            // CANATTACK
            // 
            this.CANATTACK.AutoSize = true;
            this.CANATTACK.Location = new System.Drawing.Point(68, 328);
            this.CANATTACK.Name = "CANATTACK";
            this.CANATTACK.Size = new System.Drawing.Size(97, 21);
            this.CANATTACK.TabIndex = 84;
            this.CANATTACK.Text = "Can Attack";
            this.CANATTACK.UseVisualStyleBackColor = true;
            // 
            // CASTSENSOR_IDLE
            // 
            this.CASTSENSOR_IDLE.AutoSize = true;
            this.CASTSENSOR_IDLE.Location = new System.Drawing.Point(68, 247);
            this.CASTSENSOR_IDLE.Name = "CASTSENSOR_IDLE";
            this.CASTSENSOR_IDLE.Size = new System.Drawing.Size(128, 21);
            this.CASTSENSOR_IDLE.TabIndex = 81;
            this.CASTSENSOR_IDLE.Text = "Cast Sensor Idle";
            this.CASTSENSOR_IDLE.UseVisualStyleBackColor = true;
            // 
            // ASSIST
            // 
            this.ASSIST.AutoSize = true;
            this.ASSIST.Location = new System.Drawing.Point(68, 220);
            this.ASSIST.Name = "ASSIST";
            this.ASSIST.Size = new System.Drawing.Size(63, 21);
            this.ASSIST.TabIndex = 80;
            this.ASSIST.Text = "Assist";
            this.ASSIST.UseVisualStyleBackColor = true;
            // 
            // AGGRESSIVE
            // 
            this.AGGRESSIVE.AutoSize = true;
            this.AGGRESSIVE.Location = new System.Drawing.Point(68, 193);
            this.AGGRESSIVE.Name = "AGGRESSIVE";
            this.AGGRESSIVE.Size = new System.Drawing.Size(95, 21);
            this.AGGRESSIVE.TabIndex = 79;
            this.AGGRESSIVE.Text = "Aggressive";
            this.AGGRESSIVE.UseVisualStyleBackColor = true;
            // 
            // LOOTER
            // 
            this.LOOTER.AutoSize = true;
            this.LOOTER.Location = new System.Drawing.Point(68, 166);
            this.LOOTER.Name = "LOOTER";
            this.LOOTER.Size = new System.Drawing.Size(70, 21);
            this.LOOTER.TabIndex = 78;
            this.LOOTER.Text = "Looter";
            this.LOOTER.UseVisualStyleBackColor = true;
            // 
            // CANMOVE
            // 
            this.CANMOVE.AutoSize = true;
            this.CANMOVE.Location = new System.Drawing.Point(68, 139);
            this.CANMOVE.Name = "CANMOVE";
            this.CANMOVE.Size = new System.Drawing.Size(91, 21);
            this.CANMOVE.TabIndex = 77;
            this.CANMOVE.Text = "Can Move";
            this.CANMOVE.UseVisualStyleBackColor = true;
            // 
            // NOKNOCKBACK
            // 
            this.NOKNOCKBACK.AutoSize = true;
            this.NOKNOCKBACK.Location = new System.Drawing.Point(265, 301);
            this.NOKNOCKBACK.Name = "NOKNOCKBACK";
            this.NOKNOCKBACK.Size = new System.Drawing.Size(126, 21);
            this.NOKNOCKBACK.TabIndex = 105;
            this.NOKNOCKBACK.Text = "NOKNOCKBACK";
            this.NOKNOCKBACK.UseVisualStyleBackColor = true;
            // 
            // PLANT
            // 
            this.PLANT.AutoSize = true;
            this.PLANT.Location = new System.Drawing.Point(68, 301);
            this.PLANT.Name = "PLANT";
            this.PLANT.Size = new System.Drawing.Size(70, 21);
            this.PLANT.TabIndex = 106;
            this.PLANT.Text = "PLANT";
            this.PLANT.UseVisualStyleBackColor = true;
            // 
            // BOSS
            // 
            this.BOSS.AutoSize = true;
            this.BOSS.Location = new System.Drawing.Point(68, 274);
            this.BOSS.Name = "BOSS";
            this.BOSS.Size = new System.Drawing.Size(64, 21);
            this.BOSS.TabIndex = 107;
            this.BOSS.Text = "BOSS";
            this.BOSS.UseVisualStyleBackColor = true;
            // 
            // MMG_Hercules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 496);
            this.Controls.Add(this.BOSS);
            this.Controls.Add(this.PLANT);
            this.Controls.Add(this.NOKNOCKBACK);
            this.Controls.Add(this.MMG_R_result);
            this.Controls.Add(this.Hercules_logo);
            this.Controls.Add(this.DETECTOR);
            this.Controls.Add(this.RANDOMTARGET);
            this.Controls.Add(this.TARGETWEAK);
            this.Controls.Add(this.CHANGETARGET_CHASE);
            this.Controls.Add(this.CHANGETARGET_MELEE);
            this.Controls.Add(this.ANGRY);
            this.Controls.Add(this.CHANGECHASE);
            this.Controls.Add(this.CASTSENSOR_CHASE);
            this.Controls.Add(this.CANATTACK);
            this.Controls.Add(this.CASTSENSOR_IDLE);
            this.Controls.Add(this.ASSIST);
            this.Controls.Add(this.AGGRESSIVE);
            this.Controls.Add(this.LOOTER);
            this.Controls.Add(this.CANMOVE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MMG_Hercules";
            this.Text = "MMG Hercules  By Sader Fawall (sader1992)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MMG_Hercules_FormClosing);
            this.Load += new System.EventHandler(this.MMG_Hercules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Hercules_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MMG_H_update;
        private System.Windows.Forms.TextBox MMG_R_result;
        private System.Windows.Forms.PictureBox Hercules_logo;
        private System.Windows.Forms.CheckBox DETECTOR;
        private System.Windows.Forms.CheckBox RANDOMTARGET;
        private System.Windows.Forms.CheckBox TARGETWEAK;
        private System.Windows.Forms.CheckBox CHANGETARGET_CHASE;
        private System.Windows.Forms.CheckBox CHANGETARGET_MELEE;
        private System.Windows.Forms.CheckBox ANGRY;
        private System.Windows.Forms.CheckBox CHANGECHASE;
        private System.Windows.Forms.CheckBox CASTSENSOR_CHASE;
        private System.Windows.Forms.CheckBox CANATTACK;
        private System.Windows.Forms.CheckBox CASTSENSOR_IDLE;
        private System.Windows.Forms.CheckBox ASSIST;
        private System.Windows.Forms.CheckBox AGGRESSIVE;
        private System.Windows.Forms.CheckBox LOOTER;
        private System.Windows.Forms.CheckBox CANMOVE;
        private System.Windows.Forms.CheckBox NOKNOCKBACK;
        private System.Windows.Forms.CheckBox PLANT;
        private System.Windows.Forms.CheckBox BOSS;
    }
}