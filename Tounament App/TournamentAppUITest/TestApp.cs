using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TounamentAppUI;
using System.Windows.Forms;


namespace TournamentAppUITest {

    static class TestApp {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TournamentViewerTests());
        }
    }
}
