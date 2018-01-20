namespace TounamentApp
{
    partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.playBtn = new System.Windows.Forms.Button();
            this.editCharacter = new System.Windows.Forms.Button();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.playerInfoIcon = new System.Windows.Forms.Button();
            this.gameNamePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.gameNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.Location = new System.Drawing.Point(331, 138);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(124, 66);
            this.playBtn.TabIndex = 0;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // editCharacter
            // 
            this.editCharacter.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCharacter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editCharacter.Location = new System.Drawing.Point(331, 261);
            this.editCharacter.Name = "editCharacter";
            this.editCharacter.Size = new System.Drawing.Size(124, 68);
            this.editCharacter.TabIndex = 1;
            this.editCharacter.Text = "Edit Character";
            this.editCharacter.UseVisualStyleBackColor = true;
            this.editCharacter.Click += new System.EventHandler(this.editCharacter_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.leftPanel.Controls.Add(this.playerInfoIcon);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(116, 427);
            this.leftPanel.TabIndex = 2;
            this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // playerInfoIcon
            // 
            this.playerInfoIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playerInfoIcon.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerInfoIcon.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.playerInfoIcon.Image = ((System.Drawing.Image)(resources.GetObject("playerInfoIcon.Image")));
            this.playerInfoIcon.Location = new System.Drawing.Point(0, 251);
            this.playerInfoIcon.Name = "playerInfoIcon";
            this.playerInfoIcon.Size = new System.Drawing.Size(116, 91);
            this.playerInfoIcon.TabIndex = 1;
            this.playerInfoIcon.Text = "Player Information";
            this.playerInfoIcon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.playerInfoIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.playerInfoIcon.UseVisualStyleBackColor = true;
            // 
            // gameNamePanel
            // 
            this.gameNamePanel.Controls.Add(this.label1);
            this.gameNamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gameNamePanel.Location = new System.Drawing.Point(116, 0);
            this.gameNamePanel.Name = "gameNamePanel";
            this.gameNamePanel.Size = new System.Drawing.Size(620, 85);
            this.gameNamePanel.TabIndex = 3;
            this.gameNamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Ultimate Tournament";
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(736, 427);
            this.Controls.Add(this.gameNamePanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.editCharacter);
            this.Controls.Add(this.playBtn);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AppForm";
            this.Text = "The Ultimate Tournament";
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.leftPanel.ResumeLayout(false);
            this.gameNamePanel.ResumeLayout(false);
            this.gameNamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button editCharacter;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel gameNamePanel;
        private System.Windows.Forms.Button playerInfoIcon;
        private System.Windows.Forms.Label label1;
    }
}

