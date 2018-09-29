using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PlaceHolder_Fixer
{
    public partial class HelpWindow : Form
    {
        // Mouse drag window move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public HelpWindow()
        {
            InitializeComponent();

            this.Padding = new Padding(-10);

            string helpText = "Ezzel a programmal az ÉTDR-be készített, helykitöltőket tartalmazó sablonok javíthatóak ki." +
                Environment.NewLine +
                Environment.NewLine +
                "Az Xml alapú dokumentumok sajátossága, hogy a bevitt karakterek közé formázó, információs elemek kerülhetnek, " +
                "így a helykitöltők nem biztos, hogy egy teljes szóként kerülnek elmentésre. Az ÉTDR jelenlegi verziója a hely" +
                "kitöltők kicserélésekor azokat nem tudja kicserélni, melyek nem egy szóként szerepelnek az xml struktúrában. " +
                "Ez a program megkeresi és egy szóvá formázza azokat." +
                Environment.NewLine +
                Environment.NewLine +
                "A helykitöltők javítása során előfordulhat, hogy megváltozik a szöveg formázása, ezért az eredmény egy új " +
                "dokumentumba kerül elmentésre - \"_jav\" végződéssel - ugyanabba a mappába, ahol az eredeti fájl(ok) is van(nak)." +
                Environment.NewLine +
                Environment.NewLine +
                Environment.NewLine +
                "Készítette:" +
                Environment.NewLine +
                "Tringer Tamás" +
                Environment.NewLine +
                "tamas.tringer@gmail.com" +
                Environment.NewLine +
                Environment.NewLine +
                "Verzió: 1.0";

            tbText.Text = helpText;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelpWindow_MouseDown(object sender, MouseEventArgs e)
        {
            WindowMove(e);
        }

        private void tbText_MouseDown(object sender, MouseEventArgs e)
        {
            WindowMove(e);
        }

        private void WindowMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
