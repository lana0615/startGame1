namespace startGame1
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
            this.playGameButton = new System.Windows.Forms.Button();
            this.gameStartLabel3 = new System.Windows.Forms.Label();
            this.gameStartLabel2 = new System.Windows.Forms.Label();
            this.gameStartLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playGameButton
            // 
            this.playGameButton.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playGameButton.Location = new System.Drawing.Point(104, 179);
            this.playGameButton.Name = "playGameButton";
            this.playGameButton.Size = new System.Drawing.Size(162, 55);
            this.playGameButton.TabIndex = 0;
            this.playGameButton.Text = "Play Game";
            this.playGameButton.UseVisualStyleBackColor = true;
            this.playGameButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // gameStartLabel3
            // 
            this.gameStartLabel3.AutoSize = true;
            this.gameStartLabel3.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStartLabel3.ForeColor = System.Drawing.Color.White;
            this.gameStartLabel3.Location = new System.Drawing.Point(110, 260);
            this.gameStartLabel3.Name = "gameStartLabel3";
            this.gameStartLabel3.Size = new System.Drawing.Size(156, 35);
            this.gameStartLabel3.TabIndex = 1;
            this.gameStartLabel3.Text = "Game Starts in 3";
            this.gameStartLabel3.Click += new System.EventHandler(this.gameStartLabel3_Click);
            // 
            // gameStartLabel2
            // 
            this.gameStartLabel2.AutoSize = true;
            this.gameStartLabel2.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStartLabel2.ForeColor = System.Drawing.Color.White;
            this.gameStartLabel2.Location = new System.Drawing.Point(257, 260);
            this.gameStartLabel2.Name = "gameStartLabel2";
            this.gameStartLabel2.Size = new System.Drawing.Size(26, 35);
            this.gameStartLabel2.TabIndex = 2;
            this.gameStartLabel2.Text = "2";
            // 
            // gameStartLabel1
            // 
            this.gameStartLabel1.AutoSize = true;
            this.gameStartLabel1.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStartLabel1.ForeColor = System.Drawing.Color.White;
            this.gameStartLabel1.Location = new System.Drawing.Point(272, 263);
            this.gameStartLabel1.Name = "gameStartLabel1";
            this.gameStartLabel1.Size = new System.Drawing.Size(23, 31);
            this.gameStartLabel1.TabIndex = 3;
            this.gameStartLabel1.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(371, 353);
            this.Controls.Add(this.gameStartLabel1);
            this.Controls.Add(this.gameStartLabel2);
            this.Controls.Add(this.gameStartLabel3);
            this.Controls.Add(this.playGameButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playGameButton;
        private System.Windows.Forms.Label gameStartLabel3;
        private System.Windows.Forms.Label gameStartLabel2;
        private System.Windows.Forms.Label gameStartLabel1;
    }
}

