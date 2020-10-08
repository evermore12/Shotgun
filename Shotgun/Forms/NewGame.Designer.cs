namespace Shotgun
{
    partial class frmNewGame
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
            this.cmdNewGame = new System.Windows.Forms.Button();
            this.cmdQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdNewGame
            // 
            this.cmdNewGame.Location = new System.Drawing.Point(39, 29);
            this.cmdNewGame.Name = "cmdNewGame";
            this.cmdNewGame.Size = new System.Drawing.Size(68, 23);
            this.cmdNewGame.TabIndex = 0;
            this.cmdNewGame.Text = "New Game";
            this.cmdNewGame.UseVisualStyleBackColor = true;
            this.cmdNewGame.Click += new System.EventHandler(this.cmdNewGame_Click);
            // 
            // cmdQuit
            // 
            this.cmdQuit.Location = new System.Drawing.Point(161, 29);
            this.cmdQuit.Name = "cmdQuit";
            this.cmdQuit.Size = new System.Drawing.Size(68, 23);
            this.cmdQuit.TabIndex = 1;
            this.cmdQuit.Text = "Quit";
            this.cmdQuit.UseVisualStyleBackColor = true;
            this.cmdQuit.Click += new System.EventHandler(this.cmdQuit_Click);
            // 
            // frmNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 81);
            this.Controls.Add(this.cmdQuit);
            this.Controls.Add(this.cmdNewGame);
            this.Name = "frmNewGame";
            this.Text = "New Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdNewGame;
        private System.Windows.Forms.Button cmdQuit;
    }
}

