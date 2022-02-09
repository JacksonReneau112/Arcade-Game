namespace Arcade_Game
{
    partial class ArcadeGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArcadeGame));
            this.PlayGameButton = new System.Windows.Forms.Button();
            this.NewGameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayGameButton
            // 
            this.PlayGameButton.BackColor = System.Drawing.Color.Turquoise;
            this.PlayGameButton.FlatAppearance.BorderSize = 0;
            this.PlayGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayGameButton.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayGameButton.ForeColor = System.Drawing.Color.Black;
            this.PlayGameButton.Location = new System.Drawing.Point(12, 183);
            this.PlayGameButton.Name = "PlayGameButton";
            this.PlayGameButton.Size = new System.Drawing.Size(776, 66);
            this.PlayGameButton.TabIndex = 0;
            this.PlayGameButton.Text = "Play Game";
            this.PlayGameButton.UseVisualStyleBackColor = false;
            this.PlayGameButton.Click += new System.EventHandler(this.PlayGameButton_Click);
            // 
            // NewGameLabel
            // 
            this.NewGameLabel.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameLabel.Location = new System.Drawing.Point(12, 36);
            this.NewGameLabel.Name = "NewGameLabel";
            this.NewGameLabel.Size = new System.Drawing.Size(776, 77);
            this.NewGameLabel.TabIndex = 1;
            this.NewGameLabel.Text = "New Game";
            this.NewGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewGameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ArcadeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewGameLabel);
            this.Controls.Add(this.PlayGameButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArcadeGame";
            this.Text = "Arcade Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayGameButton;
        private System.Windows.Forms.Label NewGameLabel;
    }
}

