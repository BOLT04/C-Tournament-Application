using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentAppDB.Model;

namespace TounamentAppUI {
    public partial class AppForm : Form {

        //Backgroung and rectangle colors.
        public static readonly Color HOVER_COLOR = Color.DarkViolet;
        public static readonly Color NORMAL_COLOR = Color.White;
        public static readonly Color SELECTED_COLOR = Color.Green;

        public Game game;//TODO: should this field exist in this class? Or in App.cs?

        public AppForm() {
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e) {

        }

        private void PlayBtn_Click(object sender, EventArgs e) {
            if (game == null)// In case it was already instanciated.
                game = new Game();
            //game.start();

            new PlayForm().ShowAndHide(this);
        }

        private void EditCharacter_Click(object sender, EventArgs e) {
            
        }

        private Color MouseInColor;

        private bool isSelected;

        //TODO: MAKE A CUSTOM BUTTON THAT HAS THESE METHODS INSTEAD OF HAVING TWO NORMAL BUTTONS with the same code in different methods!!!

        private void PlayBtn_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;

            Rectangle rc = playBtn.ClientRectangle;

            // Various options of gradients to use:
            //   OPTION 1 - Simple Blue and a whiteish silver.
            LinearGradientBrush brush1 = new LinearGradientBrush(rc, Color.SteelBlue, Color.Silver, 90F);

            //   OPTION 2 - Multiple color gradient.
            LinearGradientBrush brush2 = new LinearGradientBrush(rc, Color.SteelBlue, Color.Silver, LinearGradientMode.Horizontal);

            ColorBlend cB = new ColorBlend {
                Colors = new Color[] { Color.DarkViolet, Color.SteelBlue, Color.SteelBlue, Color.DarkViolet },
                Positions = new float[] { 0, .25F, .75F, 1 }
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
            int x = rc.Width / 2 - playBtn.Text.Length;
            int y = rc.Height / 2;

            Console.WriteLine(rc.Width);
            Console.WriteLine(rc.Height);

            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Draw "Play".
            g.DrawString(
                playBtn.Text,
                new Font("Sitka Heading", 12F, FontStyle.Bold),
                drawBrush, 
                new PointF(x, y));
        }

        private void PlayBtn_MouseEnter(object sender, EventArgs e) {
            MouseInColor = HOVER_COLOR;
            Invalidate();
        }

        private void PlayBtn_MouseLeave(object sender, EventArgs e) {
            MouseInColor = Color.Transparent;
            Invalidate();
        }

        private void PlayBtn_MouseUp(object sender, MouseEventArgs e) {
            isSelected = false;
            Invalidate();
        }

        private void PlayBtn_MouseDown(object sender, MouseEventArgs e) {
            isSelected = true;
            Invalidate();
        }
    }
}
