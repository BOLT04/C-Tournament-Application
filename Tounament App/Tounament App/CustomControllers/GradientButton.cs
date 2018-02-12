using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;

using System.Drawing;

using System.Windows.Forms;
using TournamentAppDB.Model;
using TounamentAppUI.Properties;
using System.Drawing.Drawing2D;

namespace TounamentAppUI.CustomControllers {
    public partial class GradientButton : Button {

        public new string Text { get; set; } = Resources.defaultStr;

        public static readonly int INIT_X = WIDTH / 2;
        public static readonly int INIT_Y = 3;
        public static readonly int WIDTH = 100;
        public static readonly int HEIGHT = 90;

        //Backgroung and rectangle colors.
        public static readonly Color HOVER_COLOR = Color.DarkViolet;
        public static readonly Color NORMAL_COLOR = Color.White;
        public static readonly Color SELECTED_COLOR = Color.Green;

        //Text colors
        public static readonly Color TEXT_COLOR1 = Color.Black;

        protected bool isSelected;

        public Rectangle Rect { get; set; }

        private int textX;

        [Category("Appearance")]
        public int Text_X {
            get {
                return textX;
            }

            set {
                if (value == textX)
                    return;

                textX = value;
                Invalidate();
            }
        }

        public Color MouseInColor { get; set; }
        public Color NormalColor { get; set; }
        
        public GradientButton() {
            InitializeComponent();

            //Define the location and size of this control to make it visible.
            Location = new Point(INIT_X, INIT_Y);
            Size = new Size(WIDTH, HEIGHT);

            NormalColor = NORMAL_COLOR;
            MouseInColor = Color.Transparent;
        }

        public GradientButton(string name) : this() {
            Text = Name;
        }

        public static readonly string FONT_FAMILY = "Verdana";

        protected override void OnPaint(PaintEventArgs pe) {
            Graphics g = pe.Graphics;

            Rectangle rc = ClientRectangle;

            // Various options of gradients to use:
            //   OPTION 1 - Simple Blue and a whiteish silver.
            LinearGradientBrush brush1 = new LinearGradientBrush(rc, Color.SteelBlue, Color.Silver, 90F);

            //   OPTION 2 - Multiple color gradient.
            LinearGradientBrush brush2 = new LinearGradientBrush(rc, Color.SteelBlue, Color.Silver, LinearGradientMode.Horizontal);

            ColorBlend cB = new ColorBlend {
                Colors = new Color[] { Color.DarkViolet, Color.SteelBlue, Color.SteelBlue, Color.DarkViolet },
                Positions = new float[] { 0, .15F, .85F, 1 }
            };

            brush2.InterpolationColors = cB;
            //------ End of options ------------------------------

            Brush selectedBrush = new SolidBrush(SELECTED_COLOR);
            // Apply a gradient to the button if the user isn't holding down the click button.
            if (isSelected)
                g.FillRectangle(selectedBrush, rc);
            else
                g.FillRectangle(brush2, rc);

            byte penW = 5;
            g.DrawRectangle(new Pen(MouseInColor, penW), rc);// Draw outline for the button.

            // TODO: Fix positioning to be exact on the center like how it appears on AppForm.cs [Design]
            int y = rc.Height / 2;

            // Draw "Play".
            g.DrawString(
                Text,
                new Font("Sitka Heading", 12F, FontStyle.Bold),
                new SolidBrush(Color.Black),
                new PointF(Text_X, y));
        }

        protected override void OnMouseEnter(EventArgs e) {
            MouseInColor = HOVER_COLOR;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e) {
            MouseInColor = Color.Transparent;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e) {
            isSelected = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e) {
            isSelected = true;
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
