namespace TounamentAppUI {
    partial class ChoosingCardsForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoosingCardsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cardsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.cardViewer1 = new TounamentAppUI.CardViewer();
            this.cardsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose 4 Cards for the next battle";
            // 
            // cardsPanel
            // 
            this.cardsPanel.Controls.Add(this.cardViewer1);
            this.cardsPanel.Location = new System.Drawing.Point(31, 103);
            this.cardsPanel.Name = "cardsPanel";
            this.cardsPanel.Size = new System.Drawing.Size(670, 276);
            this.cardsPanel.TabIndex = 1;
            // 
            // vScrollBar
            // 
            this.vScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar.Location = new System.Drawing.Point(685, 103);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(16, 276);
            this.vScrollBar.TabIndex = 0;
            // 
            // cardViewer1
            // 
            this.cardViewer1.Card = null;
            this.cardViewer1.Img = null;
            this.cardViewer1.Location = new System.Drawing.Point(3, 3);
            this.cardViewer1.Name = "cardViewer1";
            this.cardViewer1.Rect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cardViewer1.Size = new System.Drawing.Size(75, 23);
            this.cardViewer1.TabIndex = 0;
            this.cardViewer1.Text2 = "oi Hp";
            // 
            // ChoosingCardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(736, 417);
            this.Controls.Add(this.vScrollBar);
            this.Controls.Add(this.cardsPanel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChoosingCardsForm";
            this.Text = "The Ultimate Tournament";
            this.Load += new System.EventHandler(this.ChoosingCardsForm_Load);
            this.cardsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel cardsPanel;
        private System.Windows.Forms.VScrollBar vScrollBar;
        private CardViewer cardViewer1;
    }
}