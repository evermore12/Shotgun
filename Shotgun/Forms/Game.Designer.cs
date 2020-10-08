namespace Shotgun.Forms
{
    partial class frmGame
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
            this.cmdShoot = new System.Windows.Forms.Button();
            this.cmdReload = new System.Windows.Forms.Button();
            this.cmdBlock = new System.Windows.Forms.Button();
            this.rtxtPlayerAmmunition = new System.Windows.Forms.RichTextBox();
            this.lblPlayerAmmunition = new System.Windows.Forms.Label();
            this.cmdShotgun = new System.Windows.Forms.Button();
            this.rtxtOppnentAmmunition = new System.Windows.Forms.RichTextBox();
            this.lblOpponent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdShoot
            // 
            this.cmdShoot.Location = new System.Drawing.Point(63, 71);
            this.cmdShoot.Name = "cmdShoot";
            this.cmdShoot.Size = new System.Drawing.Size(75, 23);
            this.cmdShoot.TabIndex = 0;
            this.cmdShoot.Text = "Shoot";
            this.cmdShoot.UseVisualStyleBackColor = true;
            this.cmdShoot.Click += new System.EventHandler(this.cmdShoot_Click);
            // 
            // cmdReload
            // 
            this.cmdReload.Location = new System.Drawing.Point(63, 131);
            this.cmdReload.Name = "cmdReload";
            this.cmdReload.Size = new System.Drawing.Size(75, 23);
            this.cmdReload.TabIndex = 1;
            this.cmdReload.Text = "Reload";
            this.cmdReload.UseVisualStyleBackColor = true;
            this.cmdReload.Click += new System.EventHandler(this.cmdReload_Click);
            // 
            // cmdBlock
            // 
            this.cmdBlock.Location = new System.Drawing.Point(63, 191);
            this.cmdBlock.Name = "cmdBlock";
            this.cmdBlock.Size = new System.Drawing.Size(75, 23);
            this.cmdBlock.TabIndex = 2;
            this.cmdBlock.Text = "Block";
            this.cmdBlock.UseVisualStyleBackColor = true;
            this.cmdBlock.Click += new System.EventHandler(this.cmdBlock_Click);
            // 
            // rtxtPlayerAmmunition
            // 
            this.rtxtPlayerAmmunition.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtPlayerAmmunition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtPlayerAmmunition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtPlayerAmmunition.Location = new System.Drawing.Point(210, 96);
            this.rtxtPlayerAmmunition.Name = "rtxtPlayerAmmunition";
            this.rtxtPlayerAmmunition.Size = new System.Drawing.Size(100, 96);
            this.rtxtPlayerAmmunition.TabIndex = 3;
            this.rtxtPlayerAmmunition.Text = "";
            this.rtxtPlayerAmmunition.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lblPlayerAmmunition
            // 
            this.lblPlayerAmmunition.AutoSize = true;
            this.lblPlayerAmmunition.Location = new System.Drawing.Point(207, 71);
            this.lblPlayerAmmunition.Name = "lblPlayerAmmunition";
            this.lblPlayerAmmunition.Size = new System.Drawing.Size(61, 13);
            this.lblPlayerAmmunition.TabIndex = 4;
            this.lblPlayerAmmunition.Text = "Ammunition";
            // 
            // cmdShotgun
            // 
            this.cmdShotgun.Enabled = false;
            this.cmdShotgun.Location = new System.Drawing.Point(63, 244);
            this.cmdShotgun.Name = "cmdShotgun";
            this.cmdShotgun.Size = new System.Drawing.Size(75, 23);
            this.cmdShotgun.TabIndex = 5;
            this.cmdShotgun.Text = "Shotgun";
            this.cmdShotgun.UseVisualStyleBackColor = true;
            this.cmdShotgun.Click += new System.EventHandler(this.cmdShotgun_Click);
            // 
            // rtxtOppnentAmmunition
            // 
            this.rtxtOppnentAmmunition.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtOppnentAmmunition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtOppnentAmmunition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtOppnentAmmunition.Location = new System.Drawing.Point(570, 96);
            this.rtxtOppnentAmmunition.Name = "rtxtOppnentAmmunition";
            this.rtxtOppnentAmmunition.Size = new System.Drawing.Size(100, 96);
            this.rtxtOppnentAmmunition.TabIndex = 6;
            this.rtxtOppnentAmmunition.Text = "";
            // 
            // lblOpponent
            // 
            this.lblOpponent.AutoSize = true;
            this.lblOpponent.Location = new System.Drawing.Point(567, 71);
            this.lblOpponent.Name = "lblOpponent";
            this.lblOpponent.Size = new System.Drawing.Size(57, 13);
            this.lblOpponent.TabIndex = 7;
            this.lblOpponent.Text = "Opponent ";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOpponent);
            this.Controls.Add(this.rtxtOppnentAmmunition);
            this.Controls.Add(this.cmdShotgun);
            this.Controls.Add(this.lblPlayerAmmunition);
            this.Controls.Add(this.rtxtPlayerAmmunition);
            this.Controls.Add(this.cmdBlock);
            this.Controls.Add(this.cmdReload);
            this.Controls.Add(this.cmdShoot);
            this.Name = "frmGame";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdShoot;
        private System.Windows.Forms.Button cmdReload;
        private System.Windows.Forms.Button cmdBlock;
        private System.Windows.Forms.RichTextBox rtxtPlayerAmmunition;
        private System.Windows.Forms.Label lblPlayerAmmunition;
        private System.Windows.Forms.Button cmdShotgun;
        private System.Windows.Forms.RichTextBox rtxtOppnentAmmunition;
        private System.Windows.Forms.Label lblOpponent;
    }
}