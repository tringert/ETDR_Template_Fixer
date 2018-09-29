namespace PlaceHolder_Fixer
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.btnFilePicker = new System.Windows.Forms.Button();
            this.btnDirectoryPicker = new System.Windows.Forms.Button();
            this.tbFilePicker = new System.Windows.Forms.TextBox();
            this.tbDirectoryPicker = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbDragAndDrop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbInfo
            // 
            this.tbInfo.AllowDrop = true;
            this.tbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInfo.ForeColor = System.Drawing.Color.White;
            this.tbInfo.Location = new System.Drawing.Point(21, 144);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.Size = new System.Drawing.Size(400, 163);
            this.tbInfo.TabIndex = 0;
            this.tbInfo.TabStop = false;
            this.tbInfo.Enter += new System.EventHandler(this.tbInfo_Enter);
            // 
            // btnFilePicker
            // 
            this.btnFilePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFilePicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilePicker.Location = new System.Drawing.Point(433, 66);
            this.btnFilePicker.Name = "btnFilePicker";
            this.btnFilePicker.Size = new System.Drawing.Size(133, 23);
            this.btnFilePicker.TabIndex = 1;
            this.btnFilePicker.Text = "Fájl kiválasztása";
            this.btnFilePicker.UseVisualStyleBackColor = false;
            this.btnFilePicker.Click += new System.EventHandler(this.btnFilePicker_Click);
            this.btnFilePicker.MouseEnter += new System.EventHandler(this.btnFilePicker_MouseEnter);
            this.btnFilePicker.MouseLeave += new System.EventHandler(this.btnFilePicker_MouseLeave);
            // 
            // btnDirectoryPicker
            // 
            this.btnDirectoryPicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDirectoryPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectoryPicker.Location = new System.Drawing.Point(433, 106);
            this.btnDirectoryPicker.Name = "btnDirectoryPicker";
            this.btnDirectoryPicker.Size = new System.Drawing.Size(133, 23);
            this.btnDirectoryPicker.TabIndex = 2;
            this.btnDirectoryPicker.Text = "Mappa kiválasztása";
            this.btnDirectoryPicker.UseVisualStyleBackColor = false;
            this.btnDirectoryPicker.Click += new System.EventHandler(this.btnDirectoryPicker_Click);
            this.btnDirectoryPicker.MouseEnter += new System.EventHandler(this.btnDirectoryPicker_MouseEnter);
            this.btnDirectoryPicker.MouseLeave += new System.EventHandler(this.btnDirectoryPicker_MouseLeave);
            // 
            // tbFilePicker
            // 
            this.tbFilePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbFilePicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFilePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilePicker.ForeColor = System.Drawing.Color.White;
            this.tbFilePicker.Location = new System.Drawing.Point(21, 66);
            this.tbFilePicker.Margin = new System.Windows.Forms.Padding(0);
            this.tbFilePicker.MaximumSize = new System.Drawing.Size(400, 23);
            this.tbFilePicker.MinimumSize = new System.Drawing.Size(400, 23);
            this.tbFilePicker.Name = "tbFilePicker";
            this.tbFilePicker.ReadOnly = true;
            this.tbFilePicker.Size = new System.Drawing.Size(400, 21);
            this.tbFilePicker.TabIndex = 3;
            this.tbFilePicker.TabStop = false;
            this.tbFilePicker.Enter += new System.EventHandler(this.tbFilePicker_Enter);
            // 
            // tbDirectoryPicker
            // 
            this.tbDirectoryPicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbDirectoryPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDirectoryPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDirectoryPicker.ForeColor = System.Drawing.Color.White;
            this.tbDirectoryPicker.Location = new System.Drawing.Point(21, 106);
            this.tbDirectoryPicker.MaximumSize = new System.Drawing.Size(400, 23);
            this.tbDirectoryPicker.MinimumSize = new System.Drawing.Size(400, 23);
            this.tbDirectoryPicker.Name = "tbDirectoryPicker";
            this.tbDirectoryPicker.ReadOnly = true;
            this.tbDirectoryPicker.Size = new System.Drawing.Size(400, 21);
            this.tbDirectoryPicker.TabIndex = 4;
            this.tbDirectoryPicker.TabStop = false;
            this.tbDirectoryPicker.Enter += new System.EventHandler(this.tbDirectoryPicker_Enter);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(433, 144);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(133, 39);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Javítás";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseEnter += new System.EventHandler(this.btnStart_MouseEnter);
            this.btnStart.MouseLeave += new System.EventHandler(this.btnStart_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Snow;
            this.btnClose.Location = new System.Drawing.Point(568, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.Snow;
            this.btnMinimize.Location = new System.Drawing.Point(533, 6);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Snow;
            this.btnHelp.Location = new System.Drawing.Point(499, 6);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(30, 30);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lbTitle.Location = new System.Drawing.Point(18, 14);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(151, 13);
            this.lbTitle.TabIndex = 10;
            this.lbTitle.Text = "ÉTDR sablon helykitöltő javító";
            this.lbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlaceHolder_Fixer.Properties.Resources.logo_blue_;
            this.pictureBox1.Location = new System.Drawing.Point(455, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lbDragAndDrop
            // 
            this.lbDragAndDrop.AllowDrop = true;
            this.lbDragAndDrop.AutoSize = true;
            this.lbDragAndDrop.Location = new System.Drawing.Point(174, 219);
            this.lbDragAndDrop.Name = "lbDragAndDrop";
            this.lbDragAndDrop.Size = new System.Drawing.Size(94, 13);
            this.lbDragAndDrop.TabIndex = 11;
            this.lbDragAndDrop.Text = "Ide húzhat fájlokat";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(604, 335);
            this.Controls.Add(this.lbDragAndDrop);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnFilePicker);
            this.Controls.Add(this.btnDirectoryPicker);
            this.Controls.Add(this.tbFilePicker);
            this.Controls.Add(this.tbDirectoryPicker);
            this.Controls.Add(this.tbInfo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(604, 335);
            this.MinimumSize = new System.Drawing.Size(604, 335);
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ÉTDR sablon helykitöltő javító";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Button btnFilePicker;
        private System.Windows.Forms.Button btnDirectoryPicker;
        private System.Windows.Forms.TextBox tbFilePicker;
        private System.Windows.Forms.TextBox tbDirectoryPicker;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lbTitle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbDragAndDrop;
    }
}

