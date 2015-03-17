namespace Checkers
{
    partial class Form2
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
            this.onePlayerButton = new System.Windows.Forms.Button();
            this.twoPlayersButton = new System.Windows.Forms.Button();
            this.levelComboBox = new System.Windows.Forms.ComboBox();
            this.levelLabel = new System.Windows.Forms.Label();
            this.startGameButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // onePlayerButton
            // 
            this.onePlayerButton.Location = new System.Drawing.Point(77, 46);
            this.onePlayerButton.Name = "onePlayerButton";
            this.onePlayerButton.Size = new System.Drawing.Size(121, 65);
            this.onePlayerButton.TabIndex = 0;
            this.onePlayerButton.Text = "One Player";
            this.onePlayerButton.UseVisualStyleBackColor = true;
            this.onePlayerButton.Click += new System.EventHandler(this.onePlayerButton_Click);
            // 
            // twoPlayersButton
            // 
            this.twoPlayersButton.Location = new System.Drawing.Point(304, 46);
            this.twoPlayersButton.Name = "twoPlayersButton";
            this.twoPlayersButton.Size = new System.Drawing.Size(121, 65);
            this.twoPlayersButton.TabIndex = 1;
            this.twoPlayersButton.Text = "Two Players";
            this.twoPlayersButton.UseVisualStyleBackColor = true;
            this.twoPlayersButton.Click += new System.EventHandler(this.twoPlayersButton_Click);
            // 
            // levelComboBox
            // 
            this.levelComboBox.FormattingEnabled = true;
            this.levelComboBox.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.levelComboBox.Location = new System.Drawing.Point(77, 208);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(121, 21);
            this.levelComboBox.TabIndex = 2;
            this.levelComboBox.Visible = false;
            this.levelComboBox.SelectedIndexChanged += new System.EventHandler(this.levelComboBox_SelectedIndexChanged);
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Segoe Marker", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.Location = new System.Drawing.Point(74, 171);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(128, 18);
            this.levelLabel.TabIndex = 3;
            this.levelLabel.Text = "Select level of difficulty";
            this.levelLabel.Visible = false;
            // 
            // startGameButton
            // 
            this.startGameButton.Enabled = false;
            this.startGameButton.Location = new System.Drawing.Point(188, 277);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(121, 65);
            this.startGameButton.TabIndex = 4;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(188, 354);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(121, 65);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(494, 431);
            this.ControlBox = false;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.levelComboBox);
            this.Controls.Add(this.twoPlayersButton);
            this.Controls.Add(this.onePlayerButton);
            this.Name = "Form2";
            this.Text = "New Game";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button onePlayerButton;
        private System.Windows.Forms.Button twoPlayersButton;
        private System.Windows.Forms.ComboBox levelComboBox;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button backButton;
    }
}