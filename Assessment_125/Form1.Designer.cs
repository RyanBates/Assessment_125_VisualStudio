namespace Assessment_125
{
    partial class Form1
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
            this.Display = new System.Windows.Forms.TextBox();
            this.Attack = new System.Windows.Forms.Button();
            this.hTurn = new System.Windows.Forms.Label();
            this.vTurn = new System.Windows.Forms.Label();
            this.Stats = new System.Windows.Forms.Label();
            this.VStats = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.New_Game = new System.Windows.Forms.Button();
            this.Block = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(12, 12);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(943, 224);
            this.Display.TabIndex = 0;
            this.Display.TextChanged += new System.EventHandler(this.Display_TextChanged);
            // 
            // Attack
            // 
            this.Attack.Location = new System.Drawing.Point(184, 316);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(83, 31);
            this.Attack.TabIndex = 1;
            this.Attack.Text = "Attack";
            this.Attack.UseVisualStyleBackColor = true;
            this.Attack.Click += new System.EventHandler(this.Attack_Click);
            // 
            // hTurn
            // 
            this.hTurn.AutoSize = true;
            this.hTurn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.hTurn.Location = new System.Drawing.Point(44, 334);
            this.hTurn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hTurn.Name = "hTurn";
            this.hTurn.Size = new System.Drawing.Size(33, 13);
            this.hTurn.TabIndex = 3;
            this.hTurn.Text = "Hero:";
            this.hTurn.Click += new System.EventHandler(this.hTurn_Click);
            // 
            // vTurn
            // 
            this.vTurn.AutoSize = true;
            this.vTurn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.vTurn.Location = new System.Drawing.Point(706, 334);
            this.vTurn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vTurn.Name = "vTurn";
            this.vTurn.Size = new System.Drawing.Size(37, 13);
            this.vTurn.TabIndex = 4;
            this.vTurn.Text = "Villain:";
            this.vTurn.Click += new System.EventHandler(this.vTurn_Click);
            // 
            // Stats
            // 
            this.Stats.AutoSize = true;
            this.Stats.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Stats.Location = new System.Drawing.Point(44, 363);
            this.Stats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(34, 13);
            this.Stats.TabIndex = 5;
            this.Stats.Text = "Stats:";
            this.Stats.Click += new System.EventHandler(this.Stats_Click);
            // 
            // VStats
            // 
            this.VStats.AutoSize = true;
            this.VStats.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.VStats.Location = new System.Drawing.Point(706, 363);
            this.VStats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VStats.Name = "VStats";
            this.VStats.Size = new System.Drawing.Size(34, 13);
            this.VStats.TabIndex = 6;
            this.VStats.Text = "Stats:";
            this.VStats.Click += new System.EventHandler(this.VStats_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(872, 242);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(83, 32);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(872, 334);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(83, 32);
            this.Load.TabIndex = 8;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // New_Game
            // 
            this.New_Game.Location = new System.Drawing.Point(872, 423);
            this.New_Game.Name = "New_Game";
            this.New_Game.Size = new System.Drawing.Size(83, 32);
            this.New_Game.TabIndex = 9;
            this.New_Game.Text = "New_Game";
            this.New_Game.UseVisualStyleBackColor = true;
            this.New_Game.Click += new System.EventHandler(this.New_Game_Click);
            // 
            // Block
            // 
            this.Block.Location = new System.Drawing.Point(184, 372);
            this.Block.Name = "Block";
            this.Block.Size = new System.Drawing.Size(83, 31);
            this.Block.TabIndex = 10;
            this.Block.Text = "Block";
            this.Block.UseVisualStyleBackColor = true;
            this.Block.Click += new System.EventHandler(this.Block_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 467);
            this.Controls.Add(this.Block);
            this.Controls.Add(this.New_Game);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.VStats);
            this.Controls.Add(this.Stats);
            this.Controls.Add(this.vTurn);
            this.Controls.Add(this.hTurn);
            this.Controls.Add(this.Attack);
            this.Controls.Add(this.Display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button Attack;
        private System.Windows.Forms.Label hTurn;
        private System.Windows.Forms.Label vTurn;
        private System.Windows.Forms.Label Stats;
        private System.Windows.Forms.Label VStats;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button New_Game;
        private System.Windows.Forms.Button Block;
    }
}

