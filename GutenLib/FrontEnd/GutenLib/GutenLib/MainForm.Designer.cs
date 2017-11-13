namespace GutenLib
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMaster = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblRecentBook1 = new System.Windows.Forms.Label();
            this.lblRecentBook2 = new System.Windows.Forms.Label();
            this.lblRecentBook3 = new System.Windows.Forms.Label();
            this.lblRecentBook4 = new System.Windows.Forms.Label();
            this.lblRecentBook5 = new System.Windows.Forms.Label();
            this.lblRecentBook6 = new System.Windows.Forms.Label();
            this.lblLibraryBook1 = new System.Windows.Forms.Label();
            this.lblLibraryBook2 = new System.Windows.Forms.Label();
            this.lblLibraryBook3 = new System.Windows.Forms.Label();
            this.lblLibraryBook4 = new System.Windows.Forms.Label();
            this.lblLibraryBook5 = new System.Windows.Forms.Label();
            this.lblLibraryBook6 = new System.Windows.Forms.Label();
            this.lblShowOptions = new System.Windows.Forms.Label();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.radSubject = new System.Windows.Forms.RadioButton();
            this.radAuthor = new System.Windows.Forms.RadioButton();
            this.radTitle = new System.Windows.Forms.RadioButton();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.lblSort = new System.Windows.Forms.Label();
            this.lblBottomRight = new System.Windows.Forms.Label();
            this.lblBottomLeft = new System.Windows.Forms.Label();
            this.lblLibrary = new System.Windows.Forms.Label();
            this.lblTopRight = new System.Windows.Forms.Label();
            this.lblTopLeft = new System.Windows.Forms.Label();
            this.lblRecent = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlReader = new System.Windows.Forms.Panel();
            this.htmlReader = new System.Windows.Forms.WebBrowser();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.lblPrevious = new System.Windows.Forms.Label();
            this.pnlLoginCenter = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblGutenLib = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pnlMaster.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.pnlReader.SuspendLayout();
            this.pnlLoginCenter.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMaster
            // 
            this.pnlMaster.Controls.Add(this.pnlContent);
            this.pnlMaster.Controls.Add(this.pnlHeader);
            this.pnlMaster.Controls.Add(this.statusStrip);
            this.pnlMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMaster.Location = new System.Drawing.Point(0, 686);
            this.pnlMaster.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMaster.Name = "pnlMaster";
            this.pnlMaster.Size = new System.Drawing.Size(1167, 22);
            this.pnlMaster.TabIndex = 5;
            this.pnlMaster.Visible = false;
            // 
            // pnlContent
            // 
            this.pnlContent.AutoSize = true;
            this.pnlContent.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlContent.BackgroundImage")));
            this.pnlContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContent.Controls.Add(this.lblRecentBook1);
            this.pnlContent.Controls.Add(this.lblRecentBook2);
            this.pnlContent.Controls.Add(this.lblRecentBook3);
            this.pnlContent.Controls.Add(this.lblRecentBook4);
            this.pnlContent.Controls.Add(this.lblRecentBook5);
            this.pnlContent.Controls.Add(this.lblRecentBook6);
            this.pnlContent.Controls.Add(this.lblLibraryBook1);
            this.pnlContent.Controls.Add(this.lblLibraryBook2);
            this.pnlContent.Controls.Add(this.lblLibraryBook3);
            this.pnlContent.Controls.Add(this.lblLibraryBook4);
            this.pnlContent.Controls.Add(this.lblLibraryBook5);
            this.pnlContent.Controls.Add(this.lblLibraryBook6);
            this.pnlContent.Controls.Add(this.lblShowOptions);
            this.pnlContent.Controls.Add(this.pnlOptions);
            this.pnlContent.Controls.Add(this.lblBottomRight);
            this.pnlContent.Controls.Add(this.lblBottomLeft);
            this.pnlContent.Controls.Add(this.lblLibrary);
            this.pnlContent.Controls.Add(this.lblTopRight);
            this.pnlContent.Controls.Add(this.lblTopLeft);
            this.pnlContent.Controls.Add(this.lblRecent);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 46);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1167, 0);
            this.pnlContent.TabIndex = 8;
            // 
            // lblRecentBook1
            // 
            this.lblRecentBook1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblRecentBook1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRecentBook1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentBook1.Location = new System.Drawing.Point(71, 51);
            this.lblRecentBook1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecentBook1.Name = "lblRecentBook1";
            this.lblRecentBook1.Size = new System.Drawing.Size(153, 210);
            this.lblRecentBook1.TabIndex = 43;
            this.lblRecentBook1.Tag = "1";
            this.lblRecentBook1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRecentBook1.Click += new System.EventHandler(this.ReadBook);
            this.lblRecentBook1.MouseHover += new System.EventHandler(this.OpenOrCloseBook);
            // 
            // lblRecentBook2
            // 
            this.lblRecentBook2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblRecentBook2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRecentBook2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentBook2.Location = new System.Drawing.Point(245, 51);
            this.lblRecentBook2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecentBook2.Name = "lblRecentBook2";
            this.lblRecentBook2.Size = new System.Drawing.Size(153, 210);
            this.lblRecentBook2.TabIndex = 42;
            this.lblRecentBook2.Tag = "2";
            this.lblRecentBook2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRecentBook2.Click += new System.EventHandler(this.ReadBook);
            this.lblRecentBook2.MouseHover += new System.EventHandler(this.OpenOrCloseBook);
            // 
            // lblRecentBook3
            // 
            this.lblRecentBook3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblRecentBook3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRecentBook3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentBook3.Location = new System.Drawing.Point(419, 51);
            this.lblRecentBook3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecentBook3.Name = "lblRecentBook3";
            this.lblRecentBook3.Size = new System.Drawing.Size(153, 210);
            this.lblRecentBook3.TabIndex = 41;
            this.lblRecentBook3.Tag = "3";
            this.lblRecentBook3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRecentBook3.Click += new System.EventHandler(this.ReadBook);
            this.lblRecentBook3.MouseHover += new System.EventHandler(this.OpenOrCloseBook);
            // 
            // lblRecentBook4
            // 
            this.lblRecentBook4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblRecentBook4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRecentBook4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentBook4.Location = new System.Drawing.Point(593, 51);
            this.lblRecentBook4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecentBook4.Name = "lblRecentBook4";
            this.lblRecentBook4.Size = new System.Drawing.Size(153, 210);
            this.lblRecentBook4.TabIndex = 40;
            this.lblRecentBook4.Tag = "4";
            this.lblRecentBook4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRecentBook4.Click += new System.EventHandler(this.ReadBook);
            this.lblRecentBook4.MouseHover += new System.EventHandler(this.OpenOrCloseBook);
            // 
            // lblRecentBook5
            // 
            this.lblRecentBook5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblRecentBook5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRecentBook5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentBook5.Location = new System.Drawing.Point(767, 51);
            this.lblRecentBook5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecentBook5.Name = "lblRecentBook5";
            this.lblRecentBook5.Size = new System.Drawing.Size(153, 210);
            this.lblRecentBook5.TabIndex = 39;
            this.lblRecentBook5.Tag = "5";
            this.lblRecentBook5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRecentBook5.Click += new System.EventHandler(this.ReadBook);
            this.lblRecentBook5.MouseHover += new System.EventHandler(this.OpenOrCloseBook);
            // 
            // lblRecentBook6
            // 
            this.lblRecentBook6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblRecentBook6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRecentBook6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentBook6.Location = new System.Drawing.Point(941, 51);
            this.lblRecentBook6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecentBook6.Name = "lblRecentBook6";
            this.lblRecentBook6.Size = new System.Drawing.Size(153, 210);
            this.lblRecentBook6.TabIndex = 38;
            this.lblRecentBook6.Tag = "6";
            this.lblRecentBook6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRecentBook6.Click += new System.EventHandler(this.ReadBook);
            this.lblRecentBook6.MouseHover += new System.EventHandler(this.OpenOrCloseBook);
            // 
            // lblLibraryBook1
            // 
            this.lblLibraryBook1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblLibraryBook1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLibraryBook1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibraryBook1.Location = new System.Drawing.Point(71, 330);
            this.lblLibraryBook1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLibraryBook1.Name = "lblLibraryBook1";
            this.lblLibraryBook1.Size = new System.Drawing.Size(153, 210);
            this.lblLibraryBook1.TabIndex = 37;
            this.lblLibraryBook1.Tag = "7";
            this.lblLibraryBook1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLibraryBook1.Click += new System.EventHandler(this.ReadBook);
            this.lblLibraryBook1.MouseHover += new System.EventHandler(this.OpenOrCloseBook);
            // 
            // lblLibraryBook2
            // 
            this.lblLibraryBook2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblLibraryBook2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLibraryBook2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibraryBook2.Location = new System.Drawing.Point(245, 330);
            this.lblLibraryBook2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLibraryBook2.Name = "lblLibraryBook2";
            this.lblLibraryBook2.Size = new System.Drawing.Size(153, 210);
            this.lblLibraryBook2.TabIndex = 36;
            this.lblLibraryBook2.Tag = "8";
            this.lblLibraryBook2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLibraryBook2.Click += new System.EventHandler(this.ReadBook);
            this.lblLibraryBook2.MouseHover += new System.EventHandler(this.OpenOrCloseBook);
            // 
            // lblLibraryBook3
            // 
            this.lblLibraryBook3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblLibraryBook3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLibraryBook3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibraryBook3.Location = new System.Drawing.Point(419, 330);
            this.lblLibraryBook3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLibraryBook3.Name = "lblLibraryBook3";
            this.lblLibraryBook3.Size = new System.Drawing.Size(153, 210);
            this.lblLibraryBook3.TabIndex = 35;
            this.lblLibraryBook3.Tag = "9";
            this.lblLibraryBook3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLibraryBook3.Click += new System.EventHandler(this.ReadBook);
            this.lblLibraryBook3.MouseHover += new System.EventHandler(this.OpenOrCloseBook);
            // 
            // lblLibraryBook4
            // 
            this.lblLibraryBook4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblLibraryBook4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLibraryBook4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibraryBook4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLibraryBook4.Location = new System.Drawing.Point(593, 330);
            this.lblLibraryBook4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLibraryBook4.Name = "lblLibraryBook4";
            this.lblLibraryBook4.Size = new System.Drawing.Size(153, 210);
            this.lblLibraryBook4.TabIndex = 34;
            this.lblLibraryBook4.Tag = "10";
            this.lblLibraryBook4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLibraryBook4.Click += new System.EventHandler(this.ReadBook);
            this.lblLibraryBook4.MouseHover += new System.EventHandler(this.OpenOrCloseBook);
            // 
            // lblLibraryBook5
            // 
            this.lblLibraryBook5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblLibraryBook5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLibraryBook5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibraryBook5.Location = new System.Drawing.Point(767, 330);
            this.lblLibraryBook5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLibraryBook5.Name = "lblLibraryBook5";
            this.lblLibraryBook5.Size = new System.Drawing.Size(153, 210);
            this.lblLibraryBook5.TabIndex = 33;
            this.lblLibraryBook5.Tag = "11";
            this.lblLibraryBook5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLibraryBook5.Click += new System.EventHandler(this.ReadBook);
            this.lblLibraryBook5.MouseHover += new System.EventHandler(this.OpenOrCloseBook);
            // 
            // lblLibraryBook6
            // 
            this.lblLibraryBook6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblLibraryBook6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLibraryBook6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibraryBook6.Location = new System.Drawing.Point(941, 330);
            this.lblLibraryBook6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLibraryBook6.Name = "lblLibraryBook6";
            this.lblLibraryBook6.Size = new System.Drawing.Size(153, 210);
            this.lblLibraryBook6.TabIndex = 32;
            this.lblLibraryBook6.Tag = "12";
            this.lblLibraryBook6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLibraryBook6.Click += new System.EventHandler(this.ReadBook);
            this.lblLibraryBook6.MouseHover += new System.EventHandler(this.OpenOrCloseBook);
            // 
            // lblShowOptions
            // 
            this.lblShowOptions.BackColor = System.Drawing.Color.Transparent;
            this.lblShowOptions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowOptions.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblShowOptions.Location = new System.Drawing.Point(71, 566);
            this.lblShowOptions.Margin = new System.Windows.Forms.Padding(0);
            this.lblShowOptions.Name = "lblShowOptions";
            this.lblShowOptions.Size = new System.Drawing.Size(154, 36);
            this.lblShowOptions.TabIndex = 20;
            this.lblShowOptions.Text = "Show Options";
            this.lblShowOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblShowOptions.Click += new System.EventHandler(this.ShowOrHideOptions);
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.Transparent;
            this.pnlOptions.Controls.Add(this.radSubject);
            this.pnlOptions.Controls.Add(this.radAuthor);
            this.pnlOptions.Controls.Add(this.radTitle);
            this.pnlOptions.Controls.Add(this.radAll);
            this.pnlOptions.Controls.Add(this.lblSort);
            this.pnlOptions.Location = new System.Drawing.Point(245, 551);
            this.pnlOptions.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(847, 73);
            this.pnlOptions.TabIndex = 18;
            this.pnlOptions.Visible = false;
            // 
            // radSubject
            // 
            this.radSubject.AutoSize = true;
            this.radSubject.BackColor = System.Drawing.Color.Transparent;
            this.radSubject.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSubject.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radSubject.Location = new System.Drawing.Point(171, 37);
            this.radSubject.Margin = new System.Windows.Forms.Padding(2);
            this.radSubject.Name = "radSubject";
            this.radSubject.Size = new System.Drawing.Size(61, 18);
            this.radSubject.TabIndex = 4;
            this.radSubject.TabStop = true;
            this.radSubject.Tag = "";
            this.radSubject.Text = "Subject";
            this.radSubject.UseVisualStyleBackColor = false;
            this.radSubject.CheckedChanged += new System.EventHandler(this.SortLibrary);
            // 
            // radAuthor
            // 
            this.radAuthor.AutoSize = true;
            this.radAuthor.BackColor = System.Drawing.Color.Transparent;
            this.radAuthor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAuthor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radAuthor.Location = new System.Drawing.Point(107, 37);
            this.radAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.radAuthor.Name = "radAuthor";
            this.radAuthor.Size = new System.Drawing.Size(58, 18);
            this.radAuthor.TabIndex = 3;
            this.radAuthor.TabStop = true;
            this.radAuthor.Tag = "";
            this.radAuthor.Text = "Author";
            this.radAuthor.UseVisualStyleBackColor = false;
            this.radAuthor.CheckedChanged += new System.EventHandler(this.SortLibrary);
            // 
            // radTitle
            // 
            this.radTitle.AutoSize = true;
            this.radTitle.BackColor = System.Drawing.Color.Transparent;
            this.radTitle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radTitle.Location = new System.Drawing.Point(57, 37);
            this.radTitle.Margin = new System.Windows.Forms.Padding(2);
            this.radTitle.Name = "radTitle";
            this.radTitle.Size = new System.Drawing.Size(44, 18);
            this.radTitle.TabIndex = 2;
            this.radTitle.Tag = "";
            this.radTitle.Text = "Title";
            this.radTitle.UseVisualStyleBackColor = false;
            this.radTitle.CheckedChanged += new System.EventHandler(this.SortLibrary);
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.BackColor = System.Drawing.Color.Transparent;
            this.radAll.Checked = true;
            this.radAll.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAll.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radAll.Location = new System.Drawing.Point(14, 37);
            this.radAll.Margin = new System.Windows.Forms.Padding(2);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(37, 18);
            this.radAll.TabIndex = 1;
            this.radAll.TabStop = true;
            this.radAll.Tag = "";
            this.radAll.Text = "All";
            this.radAll.UseVisualStyleBackColor = false;
            this.radAll.CheckedChanged += new System.EventHandler(this.SortLibrary);
            // 
            // lblSort
            // 
            this.lblSort.BackColor = System.Drawing.Color.Transparent;
            this.lblSort.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSort.Location = new System.Drawing.Point(8, 8);
            this.lblSort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(142, 20);
            this.lblSort.TabIndex = 0;
            this.lblSort.Text = "Display books by...";
            // 
            // lblBottomRight
            // 
            this.lblBottomRight.BackColor = System.Drawing.Color.Transparent;
            this.lblBottomRight.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBottomRight.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBottomRight.Location = new System.Drawing.Point(1115, 330);
            this.lblBottomRight.Margin = new System.Windows.Forms.Padding(0);
            this.lblBottomRight.Name = "lblBottomRight";
            this.lblBottomRight.Size = new System.Drawing.Size(27, 210);
            this.lblBottomRight.TabIndex = 11;
            this.lblBottomRight.Tag = "library";
            this.lblBottomRight.Text = ">";
            this.lblBottomRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBottomRight.Click += new System.EventHandler(this.CycleShelf);
            // 
            // lblBottomLeft
            // 
            this.lblBottomLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblBottomLeft.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBottomLeft.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBottomLeft.Location = new System.Drawing.Point(24, 330);
            this.lblBottomLeft.Margin = new System.Windows.Forms.Padding(0);
            this.lblBottomLeft.Name = "lblBottomLeft";
            this.lblBottomLeft.Size = new System.Drawing.Size(27, 210);
            this.lblBottomLeft.TabIndex = 10;
            this.lblBottomLeft.Tag = "library";
            this.lblBottomLeft.Text = "<";
            this.lblBottomLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBottomLeft.Click += new System.EventHandler(this.CycleShelf);
            // 
            // lblLibrary
            // 
            this.lblLibrary.BackColor = System.Drawing.Color.Transparent;
            this.lblLibrary.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrary.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLibrary.Location = new System.Drawing.Point(27, 284);
            this.lblLibrary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLibrary.Name = "lblLibrary";
            this.lblLibrary.Size = new System.Drawing.Size(190, 31);
            this.lblLibrary.TabIndex = 9;
            this.lblLibrary.Text = "Library | All";
            this.lblLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTopRight
            // 
            this.lblTopRight.BackColor = System.Drawing.Color.Transparent;
            this.lblTopRight.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopRight.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTopRight.Location = new System.Drawing.Point(1115, 51);
            this.lblTopRight.Margin = new System.Windows.Forms.Padding(0);
            this.lblTopRight.Name = "lblTopRight";
            this.lblTopRight.Size = new System.Drawing.Size(27, 210);
            this.lblTopRight.TabIndex = 2;
            this.lblTopRight.Tag = "recent";
            this.lblTopRight.Text = ">";
            this.lblTopRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTopRight.Click += new System.EventHandler(this.CycleShelf);
            // 
            // lblTopLeft
            // 
            this.lblTopLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblTopLeft.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopLeft.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTopLeft.Location = new System.Drawing.Point(24, 51);
            this.lblTopLeft.Margin = new System.Windows.Forms.Padding(0);
            this.lblTopLeft.Name = "lblTopLeft";
            this.lblTopLeft.Size = new System.Drawing.Size(27, 210);
            this.lblTopLeft.TabIndex = 1;
            this.lblTopLeft.Tag = "recent";
            this.lblTopLeft.Text = "<";
            this.lblTopLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTopLeft.Click += new System.EventHandler(this.CycleShelf);
            // 
            // lblRecent
            // 
            this.lblRecent.BackColor = System.Drawing.Color.Transparent;
            this.lblRecent.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRecent.Location = new System.Drawing.Point(27, 9);
            this.lblRecent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecent.Name = "lblRecent";
            this.lblRecent.Size = new System.Drawing.Size(190, 31);
            this.lblRecent.TabIndex = 0;
            this.lblRecent.Text = "Recent Activity";
            this.lblRecent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1167, 46);
            this.pnlHeader.TabIndex = 7;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip.Size = new System.Drawing.Size(1167, 22);
            this.statusStrip.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // pnlReader
            // 
            this.pnlReader.BackColor = System.Drawing.Color.White;
            this.pnlReader.Controls.Add(this.htmlReader);
            this.pnlReader.Controls.Add(this.lblTitle);
            this.pnlReader.Controls.Add(this.lblClose);
            this.pnlReader.Controls.Add(this.lblNext);
            this.pnlReader.Controls.Add(this.lblPrevious);
            this.pnlReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReader.Location = new System.Drawing.Point(0, 686);
            this.pnlReader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlReader.Name = "pnlReader";
            this.pnlReader.Size = new System.Drawing.Size(1167, 22);
            this.pnlReader.TabIndex = 6;
            this.pnlReader.Visible = false;
            // 
            // htmlReader
            // 
            this.htmlReader.Location = new System.Drawing.Point(0, 46);
            this.htmlReader.Margin = new System.Windows.Forms.Padding(2);
            this.htmlReader.MinimumSize = new System.Drawing.Size(13, 14);
            this.htmlReader.Name = "htmlReader";
            this.htmlReader.Size = new System.Drawing.Size(1165, 622);
            this.htmlReader.TabIndex = 0;
            this.htmlReader.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.KeyPressEvents);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1167, 40);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title by Author";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClose
            // 
            this.lblClose.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(450, 671);
            this.lblClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(267, 37);
            this.lblClose.TabIndex = 3;
            this.lblClose.Tag = "close";
            this.lblClose.Text = "close";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.NavigateBook);
            // 
            // lblNext
            // 
            this.lblNext.BackColor = System.Drawing.Color.Transparent;
            this.lblNext.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNext.Location = new System.Drawing.Point(899, 671);
            this.lblNext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(267, 37);
            this.lblNext.TabIndex = 2;
            this.lblNext.Tag = "next";
            this.lblNext.Text = "next >>";
            this.lblNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNext.Click += new System.EventHandler(this.NavigateBook);
            // 
            // lblPrevious
            // 
            this.lblPrevious.BackColor = System.Drawing.Color.Transparent;
            this.lblPrevious.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevious.Location = new System.Drawing.Point(2, 671);
            this.lblPrevious.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrevious.Name = "lblPrevious";
            this.lblPrevious.Size = new System.Drawing.Size(267, 37);
            this.lblPrevious.TabIndex = 1;
            this.lblPrevious.Tag = "previous";
            this.lblPrevious.Text = "<< previous";
            this.lblPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrevious.Click += new System.EventHandler(this.NavigateBook);
            // 
            // pnlLoginCenter
            // 
            this.pnlLoginCenter.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlLoginCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLoginCenter.Controls.Add(this.lblGutenLib);
            this.pnlLoginCenter.Controls.Add(this.btnLogin);
            this.pnlLoginCenter.Controls.Add(this.lblPassword);
            this.pnlLoginCenter.Controls.Add(this.lblUsername);
            this.pnlLoginCenter.Controls.Add(this.txtPassword);
            this.pnlLoginCenter.Controls.Add(this.txtUsername);
            this.pnlLoginCenter.Location = new System.Drawing.Point(317, 199);
            this.pnlLoginCenter.Name = "pnlLoginCenter";
            this.pnlLoginCenter.Size = new System.Drawing.Size(533, 289);
            this.pnlLoginCenter.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(247, 108);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(160, 32);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(247, 147);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(160, 32);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(124, 111);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(117, 25);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(127, 150);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(114, 25);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(210, 204);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(111, 33);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.Login);
            // 
            // lblGutenLib
            // 
            this.lblGutenLib.Font = new System.Drawing.Font("Baskerville Old Face", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGutenLib.Location = new System.Drawing.Point(0, 0);
            this.lblGutenLib.Name = "lblGutenLib";
            this.lblGutenLib.Size = new System.Drawing.Size(532, 79);
            this.lblGutenLib.TabIndex = 5;
            this.lblGutenLib.Text = "GutenLib";
            this.lblGutenLib.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogin.BackgroundImage")));
            this.pnlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogin.Controls.Add(this.pnlLoginCenter);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(1167, 686);
            this.pnlLogin.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1167, 708);
            this.Controls.Add(this.pnlMaster);
            this.Controls.Add(this.pnlReader);
            this.Controls.Add(this.pnlLogin);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GutenLib";
            this.pnlMaster.ResumeLayout(false);
            this.pnlMaster.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pnlReader.ResumeLayout(false);
            this.pnlLoginCenter.ResumeLayout(false);
            this.pnlLoginCenter.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMaster;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblShowOptions;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.RadioButton radSubject;
        private System.Windows.Forms.RadioButton radAuthor;
        private System.Windows.Forms.RadioButton radTitle;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Label lblBottomRight;
        private System.Windows.Forms.Label lblBottomLeft;
        private System.Windows.Forms.Label lblLibrary;
        private System.Windows.Forms.Label lblTopRight;
        private System.Windows.Forms.Label lblTopLeft;
        private System.Windows.Forms.Label lblRecent;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Panel pnlReader;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lblPrevious;
        private System.Windows.Forms.WebBrowser htmlReader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLibraryBook1;
        private System.Windows.Forms.Label lblLibraryBook2;
        private System.Windows.Forms.Label lblLibraryBook3;
        private System.Windows.Forms.Label lblLibraryBook4;
        private System.Windows.Forms.Label lblLibraryBook5;
        private System.Windows.Forms.Label lblLibraryBook6;
        private System.Windows.Forms.Label lblRecentBook6;
        private System.Windows.Forms.Label lblRecentBook5;
        private System.Windows.Forms.Label lblRecentBook4;
        private System.Windows.Forms.Label lblRecentBook3;
        private System.Windows.Forms.Label lblRecentBook1;
        private System.Windows.Forms.Label lblRecentBook2;
        private System.Windows.Forms.Panel pnlLoginCenter;
        private System.Windows.Forms.Label lblGutenLib;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel pnlLogin;
    }
}

