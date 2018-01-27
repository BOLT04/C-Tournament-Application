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
            this.deckImg1 = new System.Windows.Forms.PictureBox();
            this.deckImg2 = new System.Windows.Forms.PictureBox();
            this.deckImg4 = new System.Windows.Forms.PictureBox();
            this.deckImg3 = new System.Windows.Forms.PictureBox();
            this.deckImg5 = new System.Windows.Forms.PictureBox();
            this.deckImg6 = new System.Windows.Forms.PictureBox();
            this.deckImg8 = new System.Windows.Forms.PictureBox();
            this.deck1Name = new System.Windows.Forms.Label();
            this.deck2Name = new System.Windows.Forms.Label();
            this.deck4Name = new System.Windows.Forms.Label();
            this.deck3Name = new System.Windows.Forms.Label();
            this.deck6Name = new System.Windows.Forms.Label();
            this.deck5Name = new System.Windows.Forms.Label();
            this.deck8Name = new System.Windows.Forms.Label();
            this.deckImg7 = new System.Windows.Forms.PictureBox();
            this.deck7Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vsImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckImg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckImg4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckImg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckImg5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckImg6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckImg8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckImg7)).BeginInit();
            this.SuspendLayout();
            // 
            // vsImg
            // 
            this.vsImg.Image = ((System.Drawing.Image)(resources.GetObject("vsImg.Image")));
            this.vsImg.Location = new System.Drawing.Point(282, 154);
            this.vsImg.Name = "vsImg";
            this.vsImg.Size = new System.Drawing.Size(182, 200);
            this.vsImg.TabIndex = 0;
            this.vsImg.TabStop = false;
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(345, 371);
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
            this.playerListView.Size = new System.Drawing.Size(214, 306);
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
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // enemiesListView
            // 
            this.enemiesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn});
            this.enemiesListView.Location = new System.Drawing.Point(510, 78);
            this.enemiesListView.Name = "enemiesListView";
            this.enemiesListView.Size = new System.Drawing.Size(214, 306);
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
            // deckImg1
            // 
            this.deckImg1.Location = new System.Drawing.Point(37, 80);
            this.deckImg1.Name = "deckImg1";
            this.deckImg1.Size = new System.Drawing.Size(73, 53);
            this.deckImg1.TabIndex = 9;
            this.deckImg1.TabStop = false;
            this.deckImg1.Click += new System.EventHandler(this.DeckImg1_Click);
            // 
            // deckImg2
            // 
            this.deckImg2.Location = new System.Drawing.Point(153, 80);
            this.deckImg2.Name = "deckImg2";
            this.deckImg2.Size = new System.Drawing.Size(74, 53);
            this.deckImg2.TabIndex = 10;
            this.deckImg2.TabStop = false;
            this.deckImg2.Click += new System.EventHandler(this.DeckImg2_Click);
            // 
            // deckImg4
            // 
            this.deckImg4.Location = new System.Drawing.Point(153, 154);
            this.deckImg4.Name = "deckImg4";
            this.deckImg4.Size = new System.Drawing.Size(74, 53);
            this.deckImg4.TabIndex = 11;
            this.deckImg4.TabStop = false;
            this.deckImg4.Click += new System.EventHandler(this.DeckImg4_Click);
            // 
            // deckImg3
            // 
            this.deckImg3.Location = new System.Drawing.Point(37, 154);
            this.deckImg3.Name = "deckImg3";
            this.deckImg3.Size = new System.Drawing.Size(73, 53);
            this.deckImg3.TabIndex = 12;
            this.deckImg3.TabStop = false;
            this.deckImg3.Click += new System.EventHandler(this.DeckImg3_Click);
            // 
            // deckImg5
            // 
            this.deckImg5.Location = new System.Drawing.Point(37, 232);
            this.deckImg5.Name = "deckImg5";
            this.deckImg5.Size = new System.Drawing.Size(73, 53);
            this.deckImg5.TabIndex = 13;
            this.deckImg5.TabStop = false;
            this.deckImg5.Click += new System.EventHandler(this.DeckImg5_Click);
            // 
            // deckImg6
            // 
            this.deckImg6.Location = new System.Drawing.Point(153, 232);
            this.deckImg6.Name = "deckImg6";
            this.deckImg6.Size = new System.Drawing.Size(74, 53);
            this.deckImg6.TabIndex = 14;
            this.deckImg6.TabStop = false;
            this.deckImg6.Click += new System.EventHandler(this.DeckImg6_Click);
            // 
            // deckImg8
            // 
            this.deckImg8.Location = new System.Drawing.Point(153, 308);
            this.deckImg8.Name = "deckImg8";
            this.deckImg8.Size = new System.Drawing.Size(74, 53);
            this.deckImg8.TabIndex = 15;
            this.deckImg8.TabStop = false;
            this.deckImg8.Click += new System.EventHandler(this.DeckImg8_Click);
            // 
            // deck1Name
            // 
            this.deck1Name.AutoSize = true;
            this.deck1Name.Location = new System.Drawing.Point(34, 134);
            this.deck1Name.Name = "deck1Name";
            this.deck1Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deck1Name.Size = new System.Drawing.Size(0, 17);
            this.deck1Name.TabIndex = 16;
            // 
            // deck2Name
            // 
            this.deck2Name.AutoSize = true;
            this.deck2Name.Location = new System.Drawing.Point(150, 134);
            this.deck2Name.Name = "deck2Name";
            this.deck2Name.Size = new System.Drawing.Size(0, 17);
            this.deck2Name.TabIndex = 17;
            // 
            // deck4Name
            // 
            this.deck4Name.AutoSize = true;
            this.deck4Name.Location = new System.Drawing.Point(150, 210);
            this.deck4Name.Name = "deck4Name";
            this.deck4Name.Size = new System.Drawing.Size(0, 17);
            this.deck4Name.TabIndex = 18;
            // 
            // deck3Name
            // 
            this.deck3Name.AutoSize = true;
            this.deck3Name.Location = new System.Drawing.Point(34, 212);
            this.deck3Name.Name = "deck3Name";
            this.deck3Name.Size = new System.Drawing.Size(0, 17);
            this.deck3Name.TabIndex = 19;
            // 
            // deck6Name
            // 
            this.deck6Name.AutoSize = true;
            this.deck6Name.Location = new System.Drawing.Point(150, 288);
            this.deck6Name.Name = "deck6Name";
            this.deck6Name.Size = new System.Drawing.Size(0, 17);
            this.deck6Name.TabIndex = 20;
            // 
            // deck5Name
            // 
            this.deck5Name.AutoSize = true;
            this.deck5Name.Location = new System.Drawing.Point(34, 288);
            this.deck5Name.Name = "deck5Name";
            this.deck5Name.Size = new System.Drawing.Size(0, 17);
            this.deck5Name.TabIndex = 21;
            // 
            // deck8Name
            // 
            this.deck8Name.AutoSize = true;
            this.deck8Name.Location = new System.Drawing.Point(150, 364);
            this.deck8Name.Name = "deck8Name";
            this.deck8Name.Size = new System.Drawing.Size(0, 17);
            this.deck8Name.TabIndex = 22;
            // 
            // deckImg7
            // 
            this.deckImg7.Location = new System.Drawing.Point(37, 308);
            this.deckImg7.Name = "deckImg7";
            this.deckImg7.Size = new System.Drawing.Size(73, 53);
            this.deckImg7.TabIndex = 23;
            this.deckImg7.TabStop = false;
            this.deckImg7.Click += new System.EventHandler(this.DeckImg7_Click);
            // 
            // deck7Name
            // 
            this.deck7Name.AutoSize = true;
            this.deck7Name.Location = new System.Drawing.Point(34, 364);
            this.deck7Name.Name = "deck7Name";
            this.deck7Name.Size = new System.Drawing.Size(0, 17);
            this.deck7Name.TabIndex = 24;
            // 
            // TournamentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(736, 417);
            this.Controls.Add(this.deck7Name);
            this.Controls.Add(this.deckImg7);
            this.Controls.Add(this.deck8Name);
            this.Controls.Add(this.deck5Name);
            this.Controls.Add(this.deck6Name);
            this.Controls.Add(this.deck3Name);
            this.Controls.Add(this.deck4Name);
            this.Controls.Add(this.deck2Name);
            this.Controls.Add(this.deck1Name);
            this.Controls.Add(this.deckImg8);
            this.Controls.Add(this.deckImg6);
            this.Controls.Add(this.deckImg5);
            this.Controls.Add(this.deckImg3);
            this.Controls.Add(this.deckImg4);
            this.Controls.Add(this.deckImg2);
            this.Controls.Add(this.deckImg1);
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
            ((System.ComponentModel.ISupportInitialize)(this.deckImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckImg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckImg4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckImg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckImg5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckImg6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckImg8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckImg7)).EndInit();
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
        private System.Windows.Forms.PictureBox deckImg1;
        private System.Windows.Forms.PictureBox deckImg2;
        private System.Windows.Forms.PictureBox deckImg4;
        private System.Windows.Forms.PictureBox deckImg3;
        private System.Windows.Forms.PictureBox deckImg5;
        private System.Windows.Forms.PictureBox deckImg6;
        private System.Windows.Forms.PictureBox deckImg8;
        private System.Windows.Forms.Label deck1Name;
        private System.Windows.Forms.Label deck2Name;
        private System.Windows.Forms.Label deck4Name;
        private System.Windows.Forms.Label deck3Name;
        private System.Windows.Forms.Label deck6Name;
        private System.Windows.Forms.Label deck5Name;
        private System.Windows.Forms.Label deck8Name;
        private System.Windows.Forms.PictureBox deckImg7;
        private System.Windows.Forms.Label deck7Name;
    }
}