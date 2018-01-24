namespace TounamentAppUI {
    partial class TournamentViewer {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewer));
            this.vsImg = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerListView = new System.Windows.Forms.ListView();
            this.playBtn = new System.Windows.Forms.Button();
            this.enemiesListView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tournamentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vsImg)).BeginInit();
            this.SuspendLayout();
            // 
            // vsImg
            // 
            this.vsImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vsImg.BackgroundImage")));
            this.vsImg.Location = new System.Drawing.Point(282, 154);
            this.vsImg.Name = "vsImg";
            this.vsImg.Size = new System.Drawing.Size(182, 200);
            this.vsImg.TabIndex = 0;
            this.vsImg.TabStop = false;
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(344, 371);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(54, 34);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "You";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(551, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enemies";
            // 
            // playerListView
            // 
            this.playerListView.Location = new System.Drawing.Point(25, 78);
            this.playerListView.Name = "playerListView";
            this.playerListView.Size = new System.Drawing.Size(214, 295);
            this.playerListView.TabIndex = 5;
            this.playerListView.UseCompatibleStateImageBehavior = false;
            // 
            // playBtn
            // 
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.playBtn.Location = new System.Drawing.Point(299, 78);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(145, 55);
            this.playBtn.TabIndex = 6;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            // 
            // enemiesListView
            // 
            this.enemiesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn});
            this.enemiesListView.Location = new System.Drawing.Point(510, 78);
            this.enemiesListView.Name = "enemiesListView";
            this.enemiesListView.Size = new System.Drawing.Size(214, 295);
            this.enemiesListView.TabIndex = 7;
            this.enemiesListView.UseCompatibleStateImageBehavior = false;
            this.enemiesListView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 133;
            // 
            // tournamentLabel
            // 
            this.tournamentLabel.AutoSize = true;
            this.tournamentLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentLabel.Location = new System.Drawing.Point(275, 9);
            this.tournamentLabel.Name = "tournamentLabel";
            this.tournamentLabel.Size = new System.Drawing.Size(158, 37);
            this.tournamentLabel.TabIndex = 8;
            this.tournamentLabel.Text = "Tournament";
            // 
            // TournamentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(736, 417);
            this.Controls.Add(this.tournamentLabel);
            this.Controls.Add(this.enemiesListView);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.playerListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.vsImg);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TournamentViewer";
            this.Text = "The Ultimate Tournament";
            ((System.ComponentModel.ISupportInitialize)(this.vsImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox vsImg;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView playerListView;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.ListView enemiesListView;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.Label tournamentLabel;
    }
}