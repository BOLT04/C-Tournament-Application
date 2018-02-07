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
    public partial class DeckViewer : Control {

        /// <summary>
        /// Displays the name of the card.
        /// </summary>
        public new string Text { get; set; }

        public static readonly int INIT_X = 3;
        public static readonly int INIT_Y = 3;
        public static readonly int WIDTH = 80;
        public static readonly int HEIGHT = 55;

        //Backgroung and rectangle colors.
        public static readonly Color HOVER_COLOR = Color.SteelBlue;
        public static readonly Color NORMAL_COLOR = Color.White;
        public static readonly Color SELECTED_COLOR = Color.LightGreen;

        //Text colors
        public static readonly Color TEXT_COLOR1 = Color.Black;

        protected bool selected;

        public Deck Deck { get; set; } = new Deck();
        public PictureBox Img { get; set; } = new PictureBox();
        public Rectangle Rect { get; set; }

        public Color MouseInColor { get; set; }
        public Color NormalColor { get; set; }
        
        public DeckViewer() {
            InitializeComponent();

            //Define the location and size of this control to make it visible.
            Location = new Point(INIT_X, INIT_Y);
            Size = new Size(WIDTH, HEIGHT);

            NormalColor = NORMAL_COLOR;
            MouseInColor = Color.Transparent;
        }

        public DeckViewer(Deck d) : this() {
            Deck = d;

            Text = d.Name;
            Img.ChangeImageTo(d.Path);
        }

        public static readonly string FONT_FAMILY = "Verdana";

        protected override void OnPaint(PaintEventArgs pe) {
            Graphics g = pe.Graphics;
            Rectangle rc = new Rectangle(ClientRectangle.X, ClientRectangle.Y, WIDTH, HEIGHT);

            Brush normalBrush = new SolidBrush(NormalColor);
            Brush txtBrush = new SolidBrush(TEXT_COLOR1);

            g.FillRectangle(normalBrush, rc);

            byte penW = 5;
            g.DrawRectangle(new Pen(MouseInColor, penW), rc);// Draw outline for the card.

            g.DrawString(Text, new Font(FONT_FAMILY, 8F), txtBrush, new RectangleF(rc.Left, rc.Bottom -40, rc.Width, rc.Height));
        }

        protected override void OnPaintBackground(PaintEventArgs pevent) {
            
        }

        protected override void OnMouseEnter(EventArgs e) {
            MouseInColor = HOVER_COLOR;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e) {
            MouseInColor = Color.Transparent;
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
