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
    public partial class CardViewer : Control {

        /// <summary>
        /// Displays the name of the card.
        /// </summary>
        public new string Text { get; set; }

        [Category("Appearance")]
        public string Atk {
            get {
                return Card.Attack.ToString();
            }

            set {
                if (value.Equals(Card.Attack.ToString()))
                    return;

                Card.Attack = int.Parse(value);
                Invalidate();
            }
        }

        [Category("Appearance")]
        public string Hp {
            get {
                return Card.Health.ToString();
            }

            set {
                if (value.Equals(Card.Health.ToString()))
                    return;

                Card.Health = int.Parse(value);
                Invalidate();
            }
        }

        public static readonly int INIT_X = 100;
        public static readonly int INIT_Y = 100;
        public static readonly int WIDTH = 100;
        public static readonly int HEIGHT = 90;

        //Backgroung and rectangle colors.
        public static readonly Color HOVER_COLOR = Color.SteelBlue;
        public static readonly Color NORMAL_COLOR = Color.White;
        public static readonly Color SELECTED_COLOR = Color.LightGreen;

        //Text colors
        public static readonly Color TEXT_COLOR1 = Color.Black;
        public static readonly Color NUMBERS_COLOR1 = Color.Red;

        protected bool selected;

        public Card Card { get; set; } = new Card();
        public PictureBox Img { get; set; }
        public Rectangle Rect { get; set; }

        public Color MouseInColor { get; set; }
        public Color NormalColor { get; set; }
        

        public CardViewer() {
            InitializeComponent();

            //Define the location and size of this control to make it visible.
            Location = new Point(3, 3);
            Size = new Size(WIDTH, HEIGHT);

            NormalColor = NORMAL_COLOR;
            MouseInColor = Color.Transparent;
        }

        public CardViewer(Card c) : this() {
            Card = c;

            Text = c.Name;
            
            Hp = c.Health.ToString();
            Atk = c.Attack.ToString();
        }

        public static readonly string FONT_FAMILY = "Verdana";

        protected override void OnPaint(PaintEventArgs pe) {
            Graphics g = pe.Graphics;
            Rectangle rc = new Rectangle(ClientRectangle.X, ClientRectangle.Y, WIDTH, HEIGHT);

            Brush normalBrush = new SolidBrush(NormalColor);
            Brush txtBrush = new SolidBrush(TEXT_COLOR1);
            Brush ccBrush = new SolidBrush(Color.Violet);// Card class text brush.

            g.FillRectangle(normalBrush, rc);

            byte penW = 5;
            g.DrawRectangle(new Pen(MouseInColor, penW), rc);// Draw outline for the card.

            g.DrawString(Text, new Font(FONT_FAMILY, 8F), txtBrush, new RectangleF(rc.Left, rc.Top, rc.Width, rc.Height));
            g.DrawString(Card.Type, new Font(FONT_FAMILY, 10F), ccBrush, new RectangleF(rc.Left, rc.Top + 20, rc.Width, rc.Height));

            int statsY = rc.Bottom - 20,// y coordinate for Hp and Atk strings
                xOffset = 18;

            Brush numBrush = new SolidBrush(NUMBERS_COLOR1);
            Font numFont = new Font(FONT_FAMILY, 10.20F);

            if (Card.Health > 0)
                g.DrawString(Hp, numFont, numBrush, rc.Right -xOffset, statsY);
            if (Card.Attack > 0)
                g.DrawString(Atk, numFont, numBrush, rc.Left, statsY);
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
