namespace TournamentAppUITest {
    partial class TournamentViewerTests {
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
            this.testBtn1 = new System.Windows.Forms.Button();
            this.testBtn2 = new System.Windows.Forms.Button();
            this.testBtn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testBtn1
            // 
            this.testBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testBtn1.Location = new System.Drawing.Point(301, 47);
            this.testBtn1.Name = "testBtn1";
            this.testBtn1.Size = new System.Drawing.Size(100, 59);
            this.testBtn1.TabIndex = 0;
            this.testBtn1.Text = "Test 1";
            this.testBtn1.UseVisualStyleBackColor = true;
            this.testBtn1.Click += new System.EventHandler(this.TestBtn1_Click);
            // 
            // testBtn2
            // 
            this.testBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testBtn2.Location = new System.Drawing.Point(301, 140);
            this.testBtn2.Name = "testBtn2";
            this.testBtn2.Size = new System.Drawing.Size(100, 59);
            this.testBtn2.TabIndex = 3;
            this.testBtn2.Text = "Test 2";
            this.testBtn2.UseVisualStyleBackColor = true;
            this.testBtn2.Click += new System.EventHandler(this.TestBtn2_Click);
            // 
            // testBtn3
            // 
            this.testBtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testBtn3.Location = new System.Drawing.Point(301, 246);
            this.testBtn3.Name = "testBtn3";
            this.testBtn3.Size = new System.Drawing.Size(100, 59);
            this.testBtn3.TabIndex = 4;
            this.testBtn3.Text = "Test 3";
            this.testBtn3.UseVisualStyleBackColor = true;
            this.testBtn3.Click += new System.EventHandler(this.TestBtn3_Click);
            // 
            // TournamentViewerTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 363);
            this.Controls.Add(this.testBtn3);
            this.Controls.Add(this.testBtn2);
            this.Controls.Add(this.testBtn1);
            this.Name = "TournamentViewerTests";
            this.Text = "TournamentViewerTests";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testBtn1;
        private System.Windows.Forms.Button testBtn2;
        private System.Windows.Forms.Button testBtn3;
    }
}