﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;

using System.Drawing;

using System.Windows.Forms;
using TournamentAppDB.Model;

namespace TounamentAppUI {
    public partial class CardViewer : Control {

        public new string Text { get; set; }

        [Category("Appearance")]
        public string Atk {
            get {
                return AtkLabel.Text;
            }

            set {
                if (value.Equals(AtkLabel.Text))
                    return;
                AtkLabel.Text = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        public string Hp {
            get {
                return HpLabel.Text;
            }

            set {
                if (value.Equals(HpLabel.Text))
                    return;
                HpLabel.Text = value;
                Invalidate();
            }
        }

        public static readonly int INIT_X = 100;
        public static readonly int INIT_Y = 100;
        public static readonly int WIDTH  = 100;
        public static readonly int HEIGHT = 90;

        public Card Card { get; set; }
        public PictureBox Img { get; set; }
        //public new Label Name { get; set; } //Temporary! An image should be displayed, not a label with the name of the card.
        public Label HpLabel { get; set; }
        public Label AtkLabel { get; set; }
        public Rectangle Rect { get; set; }
        
        public CardViewer() {
            InitializeComponent();

            //This is generated when adding a cardViewer in design.
            Location = new Point(3, 3);
            Size = new Size(WIDTH, HEIGHT);
        }
        
        public CardViewer(Card c) : this() {
            Card = c;

            Text = c.Name;
            
            HpLabel = new Label {
                Text = c.Health.ToString()
            };

            AtkLabel = new Label {
                Text = c.Attack.ToString()
            };
        } 
        
        protected override void OnPaint(PaintEventArgs pe) {
            Graphics g = pe.Graphics;

            Rectangle rc = new Rectangle(ClientRectangle.X, ClientRectangle.Y, WIDTH, HEIGHT);

            Brush wBrush = new SolidBrush(Color.White);
            Brush dGBrush = new SolidBrush(Color.DarkGreen);
            Brush ccBrush = new SolidBrush(Color.Violet);// Card class text brush.

            g.FillRectangle(wBrush, rc);

            g.DrawString(Text, new Font("Verdana", 8F), dGBrush, new RectangleF(rc.Left, rc.Top, rc.Width, rc.Height));
            g.DrawString(Card.Type, new Font("Verdana", 10F), ccBrush, new RectangleF(rc.Left, rc.Top + 20, rc.Width, rc.Height));

            int statsY = rc.Bottom - 20;// y coordinate for Hp and Atk strings

            if (Card.Health > 0)
                g.DrawString(Hp, new Font("Verdana", 10.20F), dGBrush, rc.Right -18, statsY);
            if (Card.Attack > 0)
                g.DrawString(Atk, new Font("Verdana", 10.20F), dGBrush, rc.Left, statsY);

        }

        protected override void OnPaintBackground(PaintEventArgs pevent) {
            
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
            //method mouse enter
            protected override void OnMouseEnter(EventArgs e) {
                base.OnMouseEnter(e);
                clr1 = color;
                color = m_hovercolor;
            }
            //method mouse leave
            protected override void OnMouseLeave(EventArgs e) {
                base.OnMouseLeave(e);
                color = clr1;
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
