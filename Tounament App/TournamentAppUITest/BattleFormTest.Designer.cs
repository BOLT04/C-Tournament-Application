namespace TournamentAppUITest {
    partial class BattleFormTest {
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
            this.testPlayerTurnBtn = new System.Windows.Forms.Button();
            this.testEnemyTurnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testPlayerTurnBtn
            // 
            this.testPlayerTurnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testPlayerTurnBtn.Location = new System.Drawing.Point(243, 109);
            this.testPlayerTurnBtn.Name = "testPlayerTurnBtn";
            this.testPlayerTurnBtn.Size = new System.Drawing.Size(241, 62);
            this.testPlayerTurnBtn.TabIndex = 1;
            this.testPlayerTurnBtn.Text = "Test Player Turn";
            this.testPlayerTurnBtn.UseVisualStyleBackColor = true;
            this.testPlayerTurnBtn.Click += new System.EventHandler(this.TestPlayerTurn_Click);
            // 
            // testEnemyTurnBtn
            // 
            this.testEnemyTurnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testEnemyTurnBtn.Location = new System.Drawing.Point(243, 201);
            this.testEnemyTurnBtn.Name = "testEnemyTurnBtn";
            this.testEnemyTurnBtn.Size = new System.Drawing.Size(241, 62);
            this.testEnemyTurnBtn.TabIndex = 2;
            this.testEnemyTurnBtn.Text = "Test Enemy Turn";
            this.testEnemyTurnBtn.UseVisualStyleBackColor = true;
            this.testEnemyTurnBtn.Click += new System.EventHandler(this.TestEnemyTurn_Click);
            // 
            // BattleFormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 363);
            this.Controls.Add(this.testEnemyTurnBtn);
            this.Controls.Add(this.testPlayerTurnBtn);
            this.Name = "BattleFormTest";
            this.Text = "BattleFormTest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testPlayerTurnBtn;
        private System.Windows.Forms.Button testEnemyTurnBtn;
    }
}