namespace TounamentAppUI {
    partial class BattleForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleForm));
            this.enemyLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.playerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.enemyPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.battleImg = new System.Windows.Forms.PictureBox();
            this.turnLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.battleImg)).BeginInit();
            this.SuspendLayout();
            // 
            // enemyLabel
            // 
            this.enemyLabel.AutoSize = true;
            this.enemyLabel.Location = new System.Drawing.Point(621, 110);
            this.enemyLabel.Name = "enemyLabel";
            this.enemyLabel.Size = new System.Drawing.Size(43, 17);
            this.enemyLabel.TabIndex = 2;
            this.enemyLabel.Text = "label1";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(621, 283);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(43, 17);
            this.playerLabel.TabIndex = 3;
            this.playerLabel.Text = "label2";
            // 
            // playerPanel
            // 
            this.playerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.playerPanel.Location = new System.Drawing.Point(0, 314);
            this.playerPanel.Name = "playerPanel";
            this.playerPanel.Size = new System.Drawing.Size(736, 103);
            this.playerPanel.TabIndex = 4;
            // 
            // enemyPanel
            // 
            this.enemyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.enemyPanel.Location = new System.Drawing.Point(0, 0);
            this.enemyPanel.Name = "enemyPanel";
            this.enemyPanel.Size = new System.Drawing.Size(736, 107);
            this.enemyPanel.TabIndex = 5;
            // 
            // battleImg
            // 
            this.battleImg.Location = new System.Drawing.Point(224, 148);
            this.battleImg.Name = "battleImg";
            this.battleImg.Size = new System.Drawing.Size(305, 112);
            this.battleImg.TabIndex = 6;
            this.battleImg.TabStop = false;
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.Location = new System.Drawing.Point(361, 283);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(43, 17);
            this.turnLabel.TabIndex = 7;
            this.turnLabel.Text = "label2";
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(736, 417);
            this.Controls.Add(this.turnLabel);
            this.Controls.Add(this.battleImg);
            this.Controls.Add(this.enemyPanel);
            this.Controls.Add(this.playerPanel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.enemyLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BattleForm";
            this.Text = "The Ultimate Tournament";
            ((System.ComponentModel.ISupportInitialize)(this.battleImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enemyLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.FlowLayoutPanel playerPanel;
        private System.Windows.Forms.FlowLayoutPanel enemyPanel;
        private System.Windows.Forms.PictureBox battleImg;
        private System.Windows.Forms.Label turnLabel;
    }
}