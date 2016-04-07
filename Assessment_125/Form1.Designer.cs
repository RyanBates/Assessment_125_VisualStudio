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
            this.Skip = new System.Windows.Forms.Button();
            this.hTurn = new System.Windows.Forms.Label();
            this.vTurn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(16, 15);
            this.Display.Margin = new System.Windows.Forms.Padding(4);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(1256, 275);
            this.Display.TabIndex = 0;
            this.Display.TextChanged += new System.EventHandler(this.Display_TextChanged);
            // 
            // Attack
            // 
            this.Attack.Location = new System.Drawing.Point(494, 390);
            this.Attack.Margin = new System.Windows.Forms.Padding(4);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(111, 38);
            this.Attack.TabIndex = 1;
            this.Attack.Text = "Attack";
            this.Attack.UseVisualStyleBackColor = true;
            this.Attack.Click += new System.EventHandler(this.Attack_Click);
            // 
            // Skip
            // 
            this.Skip.Location = new System.Drawing.Point(494, 436);
            this.Skip.Margin = new System.Windows.Forms.Padding(4);
            this.Skip.Name = "Skip";
            this.Skip.Size = new System.Drawing.Size(111, 38);
            this.Skip.TabIndex = 2;
            this.Skip.Text = "Skip";
            this.Skip.UseVisualStyleBackColor = true;
            this.Skip.Click += new System.EventHandler(this.Skip_Click);
            // 
            // hTurn
            // 
            this.hTurn.AutoSize = true;
            this.hTurn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.hTurn.Location = new System.Drawing.Point(59, 411);
            this.hTurn.Name = "hTurn";
            this.hTurn.Size = new System.Drawing.Size(43, 17);
            this.hTurn.TabIndex = 3;
            this.hTurn.Text = "Hero:";
            this.hTurn.Click += new System.EventHandler(this.hTurn_Click);
            // 
            // vTurn
            // 
            this.vTurn.AutoSize = true;
            this.vTurn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.vTurn.Location = new System.Drawing.Point(942, 411);
            this.vTurn.Name = "vTurn";
            this.vTurn.Size = new System.Drawing.Size(49, 17);
            this.vTurn.TabIndex = 4;
            this.vTurn.Text = "Villain:";
            this.vTurn.Click += new System.EventHandler(this.vTurn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 575);
            this.Controls.Add(this.vTurn);
            this.Controls.Add(this.hTurn);
            this.Controls.Add(this.Skip);
            this.Controls.Add(this.Attack);
            this.Controls.Add(this.Display);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button Attack;
        private System.Windows.Forms.Button Skip;
        private System.Windows.Forms.Label hTurn;
        private System.Windows.Forms.Label vTurn;
    }
}

