using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace PlaceHolder_Fixer
{
    public partial class MainWindow : Form
    {
        List<string> placeHolders = new List<string> { "<#ecs_kf_telefonszam>", "<#cimzettek_nemugyfelek>", "<#cimzettek_nemugyfelek_tordelt>", "<#cimzettek_osszes>", "<#cimzettek_osszes_tordelt>", "<#cimzettek_ugyfelek>", "<#cimzettek_ugyfelek_tordelt>", "<#cimzett_hivatalok>", "<#cimzett_hivatalok_teljes>", "<#cimzett_partnerek>", "<#cimzettek>", "<#cimzettek_tordelt>", "<#masolatotkapo_partnerek>", "<#masolatotkapo_osszes>", "<#masolatotkapo_osszes_tordelt>", "<#masolatotkapo_hivatalok>", "<#masolatotkapo_hivatalok_teljes>", "<#nyilvanos_cimzettek_kerelmezok>", "<#nyilvanos_cimzettek_kerelmezok_tordelt>", "<#nyilvanos_cimzettek_meghatalmazottak>", "<#nyilvanos_cimzettek_meghatalmazottak_tordelt>", "<#nyilvanos_cimzettek_szomszedok>", "<#nyilvanos_cimzettek_szomszedok_tordelt>", "<#nyilvanos_cimzettek_tervezok>", "<#nyilvanos_cimzettek_tervezok_tordelt>", "<#nyilvanos_cimzettek_tulajdonosok>", "<#nyilvanos_cimzettek_tulajdonosok_tordelt>", "<#rejtett_cimzettek_kerelmezok>", "<#rejtett_cimzettek_kerelmezok_tordelt>", "<#rejtett_cimzettek_szakhatosagok>", "<#rejtett_cimzettek_szakhatosagok_tordelt>", "<#rejtett_cimzettek_szomszedok>", "<#rejtett_cimzettek_szomszedok_tordelt>", "<#rejtett_cimzettek_tervezok>", "<#rejtett_cimzettek_tervezok_tordelt>", "<#pado_clerk_position>", "<#pado_clerk_email>", "<#pado_clerk_phone>", "<#iktatas_datuma>", "<#iktatast_kero_neve>", "<#pado_FilingDate>", "<#pado_FilingAskingClerk>", "<#eljarasi_cselekmeny_iktatoszama>", "<#kapcsolodo_ingatlanok>", "<#kelte>", "<#kiadmanyozo_beosztasa>", "<#kiadmanyozo_neve>", "<#table_kiserolap>", "<#eljcsel_office_cim_teljes>", "<#ecs_kf_cim_teljes>", "<#eljaras_telepules_jaras>", "<#targyi_ingatlanok>", "<#targyi_ingatlanok_varoscim>", "<#targyi_ingatlanok_varoshrsz>", "<#eljaras_epitesi_tevekenyseg>", "<#eljaras_azonosito>", "<#eljaras_hianypotlas>", "<#eljaras_hianypotlas_teljesites>", "<#pr_ProcessNumber>", "<#pado_StartDate>", "<#eljaras_telepules_kisterseg>", "<#eljaras_letrehoz_datum>", "<#eljaras_megjegyzes>", "<#eljaras_megnevezese>", "<#eljaras_megye>", "<#eljaras_telepules>", "<#eljaras_ksh>", "<#eljaras_tipusa>", "<#pado_clerk>", "<#eljaras_letrehoz_user>", "<#erintettek_hatosagok>", "<#erintettek_hatosagok_tordelt>", "<#erintettek_kerelmezok>", "<#erintettek_kerelmezok_tordelt>", "<#erintettek_osszes>", "<#erintettek_osszes_tordelt>", "<#erintettek_szakhatosagok>", "<#erintettek_szakhatosagok_tordelt>", "<#erintettek_szomszedok>", "<#erintettek_szomszedok_tordelt>", "<#erintettek_tervezok>", "<#erintettek_tervezok_tordelt>", "<#kerelem_benyujtas_idopontja>", "<#kerelem_leirasa>", "<#ecs_authorityrequestrequesttype>", "<#eljarasi_cselekmeny_feladoja>", "<#eljcsel_jogerositesdatuma>", "<#ecs_kf_DisplayName>", "<#processaction_senddate>", "<#ecs_kf_MothersName>", "<#ecs_kf_cim_egyebcim>", "<#ecs_kf_EgyebCim>", "<#ecs_kf_UniqueId>", "<#ecs_kf_email>", "<#ecs_kf_MessageEmail>", "<#ecs_kf_cim_hazszam>", "<#ecs_kf_Hazszam>", "<#ecs_kf_cim_irsz>", "<#ecs_kf_Iranyitoszam>", "<#ecs_kf_FirstName>", "<#ecs_kf_cim_kozterulet>", "<#ecs_kf_Kozterulet>", "<#ecs_kf_cim_kozteruletjelleg>", "<#ecs_kf_KozteruletJelleg>", "<#ecs_kf_KshKod>", "<#ecs_kf_Name>", "<#ecs_kf_BirthDate>", "<#ecs_kf_BirthPlace>", "<#ecs_kf_BirthName>", "<#ecs_kf_BirthCountry>", "<#ecs_kf_cim_telepules>", "<#ecs_kf_Telepules>", "<#ecs_kf_cim_ksh>", "<#ecs_kf_LastName>", "<#ecs_off_email>", "<#ecs_off_fax>", "<#ecs_off_cim_hazszam>", "<#ecs_off_cim_irsz>", "<#ecs_off_cim_kozterulet>", "<#ecs_off_cim_kozteruletjelleg>", "<#ecs_off_phone>", "<#ecs_off_cim_telepules>", "<#ecs_off_cim_ksh>", "<#ecs_off_web>", "<#eljcsel_office_egyebcim>", "<#eljcsel_office_hazszam>", "<#eljcsel_office_irsz>", "<#eljcsel_office_kozteruletjelleg>", "<#eljcsel_office_kozterulet>", "<#eljcsel_office_ksh>", "<#eljcsel_office_megjegyzes>", "<#eljcsel_office_nev1>", "<#eljcsel_office_nev2>", "<#eljcsel_office_nev3>", "<#eljcsel_office_nev>", "<#eljcsel_office_telefonszam>", "<#eljcsel_office_telepules>", "<#processaction_subject>", "<#ecs_tipus>", "<#ecs_off_helysziniszemleideje>", "<#ecs_off_helysziniszemlehelye>", "<#ecs_off_helysziniszemleidotartama>", "<#indoklas>", "<#filing_clerk_position>", "<#filing_clerk_email>", "<#filing_clerk>", "<#filing_clerk_phone>", "<#eljarasi_cselekmeny_iktato_szama>", "<#hataskorrel_feljogositott_szemely_beosztasa>", "<#hataskorrel_feljogositott_szemely_neve>", "<#pado_FilingNumber>", "<#pado_filingidentifier>", "<#irat_leiras>", "<#irat_megnevezes>", "<#irat_targy>", "<#kuldo>", "<#ecs_pontos_tipus>", "<#indoklas_ugyfeli_beadvany>", "<#table_kiserolap_ugyfeli_beadvany>", "<#erintettek_kotelezettek>", "<#erintettek_kotelezettek_tordelt>" };
        FileInfo file;
        List<FileInfo> files = new List<FileInfo>();

        // Lib for mouse drag window move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        // Lib for hiding the caret
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);


        public MainWindow()
        {
            InitializeComponent();

            // Coloring the border
            btnFilePicker.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
            btnDirectoryPicker.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
            btnStart.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);

            // Allow Drop feature
            tbInfo.AllowDrop = true;
            lbDragAndDrop.AllowDrop = true;

            // Subscribing to the Drag&Drop events
            tbInfo.DragEnter += new DragEventHandler(DragEnterEvent);
            tbInfo.DragDrop += new DragEventHandler(DragDropEvent);
            lbDragAndDrop.DragEnter += new DragEventHandler(DragEnterEvent);
            lbDragAndDrop.DragDrop += new DragEventHandler(DragDropEvent);

            // Hiding caret from textboxes
            HideCaret(tbFilePicker.Handle);
        }

        // Process for fixing the specified files
        private void FixFiles()
        {
            if (files.Count == 0)
            {
                return;
            }

            // Clearing out the info box
            tbInfo.Text = "";

            // Hiding the drop label to make place for the infos
            lbDragAndDrop.SendToBack();

            // Iterating over the files
            for (int i = 0; i < files.Count; i++)
            {
                string fileName = files[i].FullName;

                // Displaying some info
                tbInfo.Text += fileName + " javítása..." + Environment.NewLine;

                // Opening the file
                using (DocX document = DocX.Load(fileName))
                {
                    for (int j = 0; j < placeHolders.Count; j++)
                    {
                        // Replacing the placeholders so the they will be present between one xml text tag
                        document.ReplaceText(placeHolders[j], placeHolders[j]);
                    }

                    // Saving the result in new name
                    document.SaveAs(CreateNewFileName(files[i]));

                } // Releasing the file from memory
            }

            tbInfo.Text += Environment.NewLine + "--- A javítás elkészült! ---";
        }

        // Adding "_jav" at the end of the filenames
        private string CreateNewFileName(FileInfo fi)
        {
            string fileName = fi.Name.Replace(".docx", "");
            return $"{fi.DirectoryName}\\{fileName}_jav{fi.Extension}"; //  + @"\" + fileName + "_jav" + fi.Extension;
        }

        // Hiding the annoying caret in the textboxes
        private void HideCaret(object sender)
        {
            var textBox = sender as TextBox;

            BeginInvoke((Action)delegate
            {
                HideCaret(textBox.Handle);
                textBox.SelectAll();
            });

        }

        // Processing the drag drop
        private void DragDropProcess(object sender, DragEventArgs e)
        {
            // Make sure the drop contains files not other objects
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Hiding the label because information text is going to be displayed
                lbDragAndDrop.SendToBack();

                // Get the filenames
                string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);

                // The property must be cleared out because it may contain data from previous work
                files.Clear();

                // Clearing out the textboxe
                tbInfo.Text = String.Empty;
                tbFilePicker.Text = String.Empty;
                tbDirectoryPicker.Text = String.Empty;

                // Get the files and adding them to the list
                for (int i = 0; i < fileNames.Length; i++)
                {
                    file = new FileInfo(fileNames[i]);
                    files.Add(file);

                    // Displaying info
                    tbInfo.Text += file.Name + " hozzáadva" + Environment.NewLine;
                }

                // Start the fix process immediately
                FixFiles();
            }
        }

        // Processing the selected file
        private void FileProcess()
        {
            // Clearing out the file list
            files.Clear();

            // Open a file picker window
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                // Filtering out other file types
                Filter = "Docx Fájlok|*.docx",

                // Set the window title
                Title = "Válasszon egy .docx fájlt"
            };

            // When a file had been selected
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the file
                file = new FileInfo(openFileDialog1.FileName);

                // Clearing out the directory textbox
                tbDirectoryPicker.Text = "";

                // Fill the file picker textbox
                tbFilePicker.Text = file.FullName;

                // Scroll to the end of the file picker textbox. So when the full filename is longer than the textbox, the filename is visible.
                tbFilePicker.SelectionStart = tbFilePicker.Text.Length;
                tbFilePicker.ScrollToCaret();
            }

            // Adding the fileto the list
            files.Add(file);
        }

        // Processing the selected directory
        private void DirectoryProcess()
        {
            // Clearing out the file list
            files.Clear();

            // A directory picker window
            FolderBrowserDialog folderDlg = new FolderBrowserDialog
            {
                // Set the window title
                Description = "Válassza ki a mappát, ahol a feldolgozandó sablonok vannak",

                // Disable the new folder button
                ShowNewFolderButton = false
            };

            // Displaying the directory picker window
            DialogResult result = folderDlg.ShowDialog();

            // When a directory had been selected
            if (result == DialogResult.OK)
            {
                // Clearing out the other textbox
                tbFilePicker.Text = "";

                // Set the text for the actual textbox
                tbDirectoryPicker.Text = folderDlg.SelectedPath;

                // Scroll to the end of the file picker textbox. So when the full filename is longer than the textbox, the filename is visible.
                tbDirectoryPicker.SelectionStart = tbDirectoryPicker.Text.Length;
                tbDirectoryPicker.ScrollToCaret();

                // Start at the root
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
            else
            {
                // When the selection is not happened, return
                return;
            }

            // Get the selected folder
            DirectoryInfo di = new DirectoryInfo(tbDirectoryPicker.Text);

            // Adding each .docx file to the list
            foreach (FileInfo fi in di.GetFiles())
            {
                if (fi.Extension == ".docx")
                {
                    files.Add(fi);
                }
            }
        }

        #region Events
        // Click on "Fájl kiválasztása" button
        private void btnFilePicker_Click(object sender, EventArgs e)
        {
            FileProcess();
        }

        // Click event on "Mappa kiválasztása" button
        private void btnDirectoryPicker_Click(object sender, EventArgs e)
        {
            DirectoryProcess();
        }

        // Click event on "Javítás" button
        private void btnStart_Click(object sender, EventArgs e)
        {
            FixFiles();
        }

        // A nice blue border when hover
        private void btnFilePicker_MouseEnter(object sender, EventArgs e)
        {
            btnFilePicker.FlatAppearance.BorderColor = Color.MediumBlue;
        }

        // Change back to the default border
        private void btnFilePicker_MouseLeave(object sender, EventArgs e)
        {
            btnFilePicker.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
        }

        // A nice blue border when hover
        private void btnDirectoryPicker_MouseEnter(object sender, EventArgs e)
        {
            btnDirectoryPicker.FlatAppearance.BorderColor = Color.MediumBlue;
        }

        // Change back to the default border
        private void btnDirectoryPicker_MouseLeave(object sender, EventArgs e)
        {
            btnDirectoryPicker.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
        }

        // A nice blue border when hover
        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            btnStart.FlatAppearance.BorderColor = Color.MediumBlue;
        }

        // Change back to the default border
        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
        }

        // Click event on window close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Click event on window minimize button
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Event on dragging the window
        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Event on dragging the window (when grabbing the title)
        private void lbTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Event on help button
        private void btnHelp_Click(object sender, EventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.ShowDialog();
        }

        // Enter event when dragging
        private void DragEnterEvent(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        // Drag drop event
        private void DragDropEvent(object sender, DragEventArgs e)
        {
           DragDropProcess(sender, e);
        }

        // Hiding the caret when entering the textbox
        private void tbFilePicker_Enter(object sender, EventArgs e)
        {
            HideCaret(sender);
        }

        // Hiding the caret when entering the textbox
        private void tbDirectoryPicker_Enter(object sender, EventArgs e)
        {
            HideCaret(sender);
        }

        // Hiding the caret when entering the textbox
        private void tbInfo_Enter(object sender, EventArgs e)
        {
            HideCaret(sender);
        }
        #endregion
    }
}
