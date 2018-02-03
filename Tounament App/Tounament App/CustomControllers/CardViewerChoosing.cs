using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;

using System.Drawing;

using System.Windows.Forms;
using TournamentAppDB.Model;

namespace TounamentAppUI.CustomControllers {
    public partial class CardViewerChoosing : CardViewer {

        private ChoosingCardsForm form;

        public CardViewerChoosing() : base() { }

        public CardViewerChoosing(Card c, ChoosingCardsForm form) : base(c) {
            this.form = form;
        } 
        
        protected override void OnMouseClick(MouseEventArgs e) {
            int count = form.SelectedCards.Count;
            int idx = count - 1;

            if (NormalColor.Equals(SELECTED_COLOR) && count == 4) {
                NormalColor = NORMAL_COLOR;
                form.SelectedCards.Remove(Card);
                selected = false;
            } else if (!selected && count < 4) {// Add the card to the array.
                NormalColor = SELECTED_COLOR;
                form.SelectedCards.Add(Card);
                selected = true;
            } else if (count != 4) {
                NormalColor = NORMAL_COLOR;
                form.SelectedCards.Remove(Card);
                selected = false;
            }

            Invalidate();
        }
    }

 

    /*

        public class ButtonZ : System.Windows.Forms.Button {
            Color clr1;
            private Color color = Color.Teal;
            private Color m_hovercolor = Color.FromArgb(0, 0, 140);
            private Color clickcolor = Color.FromArgb(160, 180, 200);
            private int textX = 6;
            private int textY = -20;
            private String text = "_";

            public String DisplayText {
                get { return text; }
                set { text = value; Invalidate(); }
            }
            public Color BZBackColor {
                get { return color; }
                set { color = value; Invalidate(); }
            }

            public Color MouseHoverColor {
                get { return m_hovercolor; }
                set { m_hovercolor = value; Invalidate(); }
            }

            public Color MouseClickColor1 {
                get { return clickcolor; }
                set { clickcolor = value; Invalidate(); }
            }


            public int TextLocation_X {
                get { return textX; }
                set { textX = value; Invalidate(); }
            }
            public int TextLocation_Y {
                get { return textY; }
                set { textY = value; Invalidate(); }
            }
            public ButtonZ() {
                this.Size = new System.Drawing.Size(31, 24);
                this.ForeColor = Color.White;
                this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Text = "_";
                text = this.Text;
            }
           

            protected override void OnMouseDown(MouseEventArgs mevent) {
                base.OnMouseDown(mevent);
                color = clickcolor;
            }

            protected override void OnMouseUp(MouseEventArgs mevent) {
                base.OnMouseUp(mevent);
                color = clr1;
            }

            protected override void OnPaint(PaintEventArgs pe) {
                base.OnPaint(pe);
                text = this.Text;
                if (textX == 100 && textY == 25) {
                    textX = ((this.Width) / 3) + 10;
                    textY = (this.Height / 2) - 1;
                }

                Point p = new Point(textX, textY);
                pe.Graphics.FillRectangle(new SolidBrush(color), ClientRectangle);
                pe.Graphics.DrawString(text, this.Font, new SolidBrush(this.ForeColor), p);
            }

        }
    }*/
}
