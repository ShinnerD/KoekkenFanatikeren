namespace KF_UserInterface
{
    partial class VisOrdreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisOrdreForm));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.HeaderImageLabel = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LeftMainPanel = new System.Windows.Forms.Panel();
            this.VareListeGrpBox = new System.Windows.Forms.GroupBox();
            this.VareListeDataGrid = new System.Windows.Forms.DataGridView();
            this.RightMainPanel = new System.Windows.Forms.Panel();
            this.OrdreInfoGrpBox = new System.Windows.Forms.GroupBox();
            this.OrdreCommentGrpBox = new System.Windows.Forms.GroupBox();
            this.OrdreCommentTextBox = new System.Windows.Forms.TextBox();
            this.AdresseTxtLbl = new System.Windows.Forms.Label();
            this.TlfTxtLbl = new System.Windows.Forms.Label();
            this.KundeTxtLbl = new System.Windows.Forms.Label();
            this.AdresseContentLabel = new System.Windows.Forms.Label();
            this.TlfContentLabel = new System.Windows.Forms.Label();
            this.KundeContentLabel = new System.Windows.Forms.Label();
            this.TotalPrisContentLabel = new System.Windows.Forms.Label();
            this.OrdreIdContentLabel = new System.Windows.Forms.Label();
            this.PrisTxtLbl = new System.Windows.Forms.Label();
            this.OrdreIdTxtLbl = new System.Windows.Forms.Label();
            this.VareInfoGrpBox = new System.Windows.Forms.GroupBox();
            this.BeskrivelseGrpBox = new System.Windows.Forms.GroupBox();
            this.VareBeskrivelseTxtBox = new System.Windows.Forms.TextBox();
            this.VareGruppeTxtLbl = new System.Windows.Forms.Label();
            this.VareIdTxtLbl = new System.Windows.Forms.Label();
            this.VareGruppeContentLabel = new System.Windows.Forms.Label();
            this.VareIdContentLabel = new System.Windows.Forms.Label();
            this.VarePrisContentLabel = new System.Windows.Forms.Label();
            this.NameContentLabel = new System.Windows.Forms.Label();
            this.VarePrisTxtLbl = new System.Windows.Forms.Label();
            this.NameTxtLbl = new System.Windows.Forms.Label();
            this.FarveTxtLbl = new System.Windows.Forms.Label();
            this.MaterialeTxtLbl = new System.Windows.Forms.Label();
            this.GrebTxtLbl = new System.Windows.Forms.Label();
            this.FarveContentLabel = new System.Windows.Forms.Label();
            this.MaterialeContentLabel = new System.Windows.Forms.Label();
            this.GrebContentLabel = new System.Windows.Forms.Label();
            this.Vare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Varegruppe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Greb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Farve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materiale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeTxtLbl = new System.Windows.Forms.Label();
            this.EmployeeContentLabel = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.LeftMainPanel.SuspendLayout();
            this.VareListeGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VareListeDataGrid)).BeginInit();
            this.RightMainPanel.SuspendLayout();
            this.OrdreInfoGrpBox.SuspendLayout();
            this.OrdreCommentGrpBox.SuspendLayout();
            this.VareInfoGrpBox.SuspendLayout();
            this.BeskrivelseGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.HeaderPanel.Controls.Add(this.HeaderLabel);
            this.HeaderPanel.Controls.Add(this.HeaderImageLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1284, 80);
            this.HeaderPanel.TabIndex = 0;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderLabel.Location = new System.Drawing.Point(146, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(142, 80);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Kunde Ordre";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeaderImageLabel
            // 
            this.HeaderImageLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.HeaderImageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeaderImageLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderImageLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderImageLabel.Image = global::KF_UserInterface.Properties.Resources.OrdreImage;
            this.HeaderImageLabel.Location = new System.Drawing.Point(0, 0);
            this.HeaderImageLabel.Name = "HeaderImageLabel";
            this.HeaderImageLabel.Size = new System.Drawing.Size(146, 80);
            this.HeaderImageLabel.TabIndex = 0;
            this.HeaderImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 681);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1284, 80);
            this.BottomPanel.TabIndex = 1;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.LeftMainPanel);
            this.MainPanel.Controls.Add(this.RightMainPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 80);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1284, 601);
            this.MainPanel.TabIndex = 2;
            // 
            // LeftMainPanel
            // 
            this.LeftMainPanel.Controls.Add(this.VareListeGrpBox);
            this.LeftMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftMainPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftMainPanel.Name = "LeftMainPanel";
            this.LeftMainPanel.Size = new System.Drawing.Size(636, 601);
            this.LeftMainPanel.TabIndex = 5;
            // 
            // VareListeGrpBox
            // 
            this.VareListeGrpBox.Controls.Add(this.VareListeDataGrid);
            this.VareListeGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VareListeGrpBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VareListeGrpBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VareListeGrpBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.VareListeGrpBox.Location = new System.Drawing.Point(0, 0);
            this.VareListeGrpBox.Name = "VareListeGrpBox";
            this.VareListeGrpBox.Size = new System.Drawing.Size(636, 601);
            this.VareListeGrpBox.TabIndex = 3;
            this.VareListeGrpBox.TabStop = false;
            this.VareListeGrpBox.Text = "Ordre Indhold";
            // 
            // VareListeDataGrid
            // 
            this.VareListeDataGrid.AllowUserToAddRows = false;
            this.VareListeDataGrid.AllowUserToDeleteRows = false;
            this.VareListeDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.VareListeDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VareListeDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.VareListeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VareListeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vare,
            this.Varegruppe,
            this.Greb,
            this.Farve,
            this.Materiale,
            this.Pris});
            this.VareListeDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VareListeDataGrid.GridColor = System.Drawing.Color.Black;
            this.VareListeDataGrid.Location = new System.Drawing.Point(3, 25);
            this.VareListeDataGrid.MultiSelect = false;
            this.VareListeDataGrid.Name = "VareListeDataGrid";
            this.VareListeDataGrid.ReadOnly = true;
            this.VareListeDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.VareListeDataGrid.RowHeadersVisible = false;
            this.VareListeDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VareListeDataGrid.Size = new System.Drawing.Size(630, 573);
            this.VareListeDataGrid.TabIndex = 2;
            this.VareListeDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VareListeDataGrid_CellClick);
            // 
            // RightMainPanel
            // 
            this.RightMainPanel.Controls.Add(this.VareInfoGrpBox);
            this.RightMainPanel.Controls.Add(this.OrdreInfoGrpBox);
            this.RightMainPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightMainPanel.Location = new System.Drawing.Point(636, 0);
            this.RightMainPanel.Name = "RightMainPanel";
            this.RightMainPanel.Size = new System.Drawing.Size(648, 601);
            this.RightMainPanel.TabIndex = 6;
            // 
            // OrdreInfoGrpBox
            // 
            this.OrdreInfoGrpBox.Controls.Add(this.OrdreCommentGrpBox);
            this.OrdreInfoGrpBox.Controls.Add(this.AdresseTxtLbl);
            this.OrdreInfoGrpBox.Controls.Add(this.TlfTxtLbl);
            this.OrdreInfoGrpBox.Controls.Add(this.KundeTxtLbl);
            this.OrdreInfoGrpBox.Controls.Add(this.AdresseContentLabel);
            this.OrdreInfoGrpBox.Controls.Add(this.TlfContentLabel);
            this.OrdreInfoGrpBox.Controls.Add(this.KundeContentLabel);
            this.OrdreInfoGrpBox.Controls.Add(this.EmployeeContentLabel);
            this.OrdreInfoGrpBox.Controls.Add(this.TotalPrisContentLabel);
            this.OrdreInfoGrpBox.Controls.Add(this.OrdreIdContentLabel);
            this.OrdreInfoGrpBox.Controls.Add(this.EmployeeTxtLbl);
            this.OrdreInfoGrpBox.Controls.Add(this.PrisTxtLbl);
            this.OrdreInfoGrpBox.Controls.Add(this.OrdreIdTxtLbl);
            this.OrdreInfoGrpBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrdreInfoGrpBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdreInfoGrpBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.OrdreInfoGrpBox.Location = new System.Drawing.Point(0, 0);
            this.OrdreInfoGrpBox.Name = "OrdreInfoGrpBox";
            this.OrdreInfoGrpBox.Size = new System.Drawing.Size(648, 290);
            this.OrdreInfoGrpBox.TabIndex = 0;
            this.OrdreInfoGrpBox.TabStop = false;
            this.OrdreInfoGrpBox.Text = "Ordre Information";
            // 
            // OrdreCommentGrpBox
            // 
            this.OrdreCommentGrpBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdreCommentGrpBox.Controls.Add(this.OrdreCommentTextBox);
            this.OrdreCommentGrpBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.OrdreCommentGrpBox.Location = new System.Drawing.Point(20, 129);
            this.OrdreCommentGrpBox.Name = "OrdreCommentGrpBox";
            this.OrdreCommentGrpBox.Size = new System.Drawing.Size(616, 135);
            this.OrdreCommentGrpBox.TabIndex = 3;
            this.OrdreCommentGrpBox.TabStop = false;
            this.OrdreCommentGrpBox.Text = "Ordre Kommentarer";
            // 
            // OrdreCommentTextBox
            // 
            this.OrdreCommentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrdreCommentTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.OrdreCommentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdreCommentTextBox.Location = new System.Drawing.Point(3, 25);
            this.OrdreCommentTextBox.Multiline = true;
            this.OrdreCommentTextBox.Name = "OrdreCommentTextBox";
            this.OrdreCommentTextBox.Size = new System.Drawing.Size(610, 107);
            this.OrdreCommentTextBox.TabIndex = 0;
            this.OrdreCommentTextBox.Text = resources.GetString("OrdreCommentTextBox.Text");
            // 
            // AdresseTxtLbl
            // 
            this.AdresseTxtLbl.AutoSize = true;
            this.AdresseTxtLbl.Location = new System.Drawing.Point(16, 93);
            this.AdresseTxtLbl.Name = "AdresseTxtLbl";
            this.AdresseTxtLbl.Size = new System.Drawing.Size(133, 21);
            this.AdresseTxtLbl.TabIndex = 0;
            this.AdresseTxtLbl.Text = "Leveringsadresse:";
            // 
            // TlfTxtLbl
            // 
            this.TlfTxtLbl.AutoSize = true;
            this.TlfTxtLbl.Location = new System.Drawing.Point(16, 72);
            this.TlfTxtLbl.Name = "TlfTxtLbl";
            this.TlfTxtLbl.Size = new System.Drawing.Size(62, 21);
            this.TlfTxtLbl.TabIndex = 0;
            this.TlfTxtLbl.Text = "Telefon:";
            // 
            // KundeTxtLbl
            // 
            this.KundeTxtLbl.AutoSize = true;
            this.KundeTxtLbl.Location = new System.Drawing.Point(16, 51);
            this.KundeTxtLbl.Name = "KundeTxtLbl";
            this.KundeTxtLbl.Size = new System.Drawing.Size(57, 21);
            this.KundeTxtLbl.TabIndex = 0;
            this.KundeTxtLbl.Text = "Kunde:";
            // 
            // AdresseContentLabel
            // 
            this.AdresseContentLabel.AutoSize = true;
            this.AdresseContentLabel.ForeColor = System.Drawing.Color.Black;
            this.AdresseContentLabel.Location = new System.Drawing.Point(155, 93);
            this.AdresseContentLabel.Name = "AdresseContentLabel";
            this.AdresseContentLabel.Size = new System.Drawing.Size(188, 21);
            this.AdresseContentLabel.TabIndex = 0;
            this.AdresseContentLabel.Text = "Gade 10, By, Postnummer";
            // 
            // TlfContentLabel
            // 
            this.TlfContentLabel.AutoSize = true;
            this.TlfContentLabel.ForeColor = System.Drawing.Color.Black;
            this.TlfContentLabel.Location = new System.Drawing.Point(116, 72);
            this.TlfContentLabel.Name = "TlfContentLabel";
            this.TlfContentLabel.Size = new System.Drawing.Size(82, 21);
            this.TlfContentLabel.TabIndex = 0;
            this.TlfContentLabel.Text = "75881952";
            // 
            // KundeContentLabel
            // 
            this.KundeContentLabel.AutoSize = true;
            this.KundeContentLabel.ForeColor = System.Drawing.Color.Black;
            this.KundeContentLabel.Location = new System.Drawing.Point(116, 51);
            this.KundeContentLabel.Name = "KundeContentLabel";
            this.KundeContentLabel.Size = new System.Drawing.Size(103, 21);
            this.KundeContentLabel.TabIndex = 0;
            this.KundeContentLabel.Text = "Jens Petersen";
            // 
            // TotalPrisContentLabel
            // 
            this.TotalPrisContentLabel.AutoSize = true;
            this.TotalPrisContentLabel.ForeColor = System.Drawing.Color.Black;
            this.TotalPrisContentLabel.Location = new System.Drawing.Point(431, 51);
            this.TotalPrisContentLabel.Name = "TotalPrisContentLabel";
            this.TotalPrisContentLabel.Size = new System.Drawing.Size(88, 21);
            this.TotalPrisContentLabel.TabIndex = 0;
            this.TotalPrisContentLabel.Text = "1299,95 kr.";
            // 
            // OrdreIdContentLabel
            // 
            this.OrdreIdContentLabel.AutoSize = true;
            this.OrdreIdContentLabel.ForeColor = System.Drawing.Color.Black;
            this.OrdreIdContentLabel.Location = new System.Drawing.Point(116, 30);
            this.OrdreIdContentLabel.Name = "OrdreIdContentLabel";
            this.OrdreIdContentLabel.Size = new System.Drawing.Size(55, 21);
            this.OrdreIdContentLabel.TabIndex = 0;
            this.OrdreIdContentLabel.Text = "12345";
            // 
            // PrisTxtLbl
            // 
            this.PrisTxtLbl.AutoSize = true;
            this.PrisTxtLbl.Location = new System.Drawing.Point(350, 51);
            this.PrisTxtLbl.Name = "PrisTxtLbl";
            this.PrisTxtLbl.Size = new System.Drawing.Size(75, 21);
            this.PrisTxtLbl.TabIndex = 0;
            this.PrisTxtLbl.Text = "Total Pris:";
            // 
            // OrdreIdTxtLbl
            // 
            this.OrdreIdTxtLbl.AutoSize = true;
            this.OrdreIdTxtLbl.Location = new System.Drawing.Point(16, 30);
            this.OrdreIdTxtLbl.Name = "OrdreIdTxtLbl";
            this.OrdreIdTxtLbl.Size = new System.Drawing.Size(71, 21);
            this.OrdreIdTxtLbl.TabIndex = 0;
            this.OrdreIdTxtLbl.Text = "Ordre Id:";
            // 
            // VareInfoGrpBox
            // 
            this.VareInfoGrpBox.Controls.Add(this.GrebTxtLbl);
            this.VareInfoGrpBox.Controls.Add(this.BeskrivelseGrpBox);
            this.VareInfoGrpBox.Controls.Add(this.MaterialeTxtLbl);
            this.VareInfoGrpBox.Controls.Add(this.FarveTxtLbl);
            this.VareInfoGrpBox.Controls.Add(this.VareGruppeTxtLbl);
            this.VareInfoGrpBox.Controls.Add(this.VareIdTxtLbl);
            this.VareInfoGrpBox.Controls.Add(this.VareGruppeContentLabel);
            this.VareInfoGrpBox.Controls.Add(this.VareIdContentLabel);
            this.VareInfoGrpBox.Controls.Add(this.VarePrisContentLabel);
            this.VareInfoGrpBox.Controls.Add(this.GrebContentLabel);
            this.VareInfoGrpBox.Controls.Add(this.MaterialeContentLabel);
            this.VareInfoGrpBox.Controls.Add(this.FarveContentLabel);
            this.VareInfoGrpBox.Controls.Add(this.NameContentLabel);
            this.VareInfoGrpBox.Controls.Add(this.VarePrisTxtLbl);
            this.VareInfoGrpBox.Controls.Add(this.NameTxtLbl);
            this.VareInfoGrpBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VareInfoGrpBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.VareInfoGrpBox.Location = new System.Drawing.Point(0, 286);
            this.VareInfoGrpBox.Name = "VareInfoGrpBox";
            this.VareInfoGrpBox.Size = new System.Drawing.Size(648, 315);
            this.VareInfoGrpBox.TabIndex = 1;
            this.VareInfoGrpBox.TabStop = false;
            this.VareInfoGrpBox.Text = "Vare Information";
            // 
            // BeskrivelseGrpBox
            // 
            this.BeskrivelseGrpBox.Controls.Add(this.VareBeskrivelseTxtBox);
            this.BeskrivelseGrpBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BeskrivelseGrpBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.BeskrivelseGrpBox.Location = new System.Drawing.Point(3, 177);
            this.BeskrivelseGrpBox.Name = "BeskrivelseGrpBox";
            this.BeskrivelseGrpBox.Size = new System.Drawing.Size(642, 135);
            this.BeskrivelseGrpBox.TabIndex = 3;
            this.BeskrivelseGrpBox.TabStop = false;
            this.BeskrivelseGrpBox.Text = "Beskrivelse";
            // 
            // VareBeskrivelseTxtBox
            // 
            this.VareBeskrivelseTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VareBeskrivelseTxtBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.VareBeskrivelseTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VareBeskrivelseTxtBox.Location = new System.Drawing.Point(3, 25);
            this.VareBeskrivelseTxtBox.Multiline = true;
            this.VareBeskrivelseTxtBox.Name = "VareBeskrivelseTxtBox";
            this.VareBeskrivelseTxtBox.Size = new System.Drawing.Size(636, 107);
            this.VareBeskrivelseTxtBox.TabIndex = 0;
            this.VareBeskrivelseTxtBox.Text = resources.GetString("VareBeskrivelseTxtBox.Text");
            // 
            // VareGruppeTxtLbl
            // 
            this.VareGruppeTxtLbl.AutoSize = true;
            this.VareGruppeTxtLbl.Location = new System.Drawing.Point(16, 72);
            this.VareGruppeTxtLbl.Name = "VareGruppeTxtLbl";
            this.VareGruppeTxtLbl.Size = new System.Drawing.Size(94, 21);
            this.VareGruppeTxtLbl.TabIndex = 0;
            this.VareGruppeTxtLbl.Text = "Varegruppe:";
            // 
            // VareIdTxtLbl
            // 
            this.VareIdTxtLbl.AutoSize = true;
            this.VareIdTxtLbl.Location = new System.Drawing.Point(16, 51);
            this.VareIdTxtLbl.Name = "VareIdTxtLbl";
            this.VareIdTxtLbl.Size = new System.Drawing.Size(63, 21);
            this.VareIdTxtLbl.TabIndex = 0;
            this.VareIdTxtLbl.Text = "Vare ID:";
            // 
            // VareGruppeContentLabel
            // 
            this.VareGruppeContentLabel.AutoSize = true;
            this.VareGruppeContentLabel.ForeColor = System.Drawing.Color.Black;
            this.VareGruppeContentLabel.Location = new System.Drawing.Point(116, 72);
            this.VareGruppeContentLabel.Name = "VareGruppeContentLabel";
            this.VareGruppeContentLabel.Size = new System.Drawing.Size(66, 21);
            this.VareGruppeContentLabel.TabIndex = 0;
            this.VareGruppeContentLabel.Text = "Højskab";
            // 
            // VareIdContentLabel
            // 
            this.VareIdContentLabel.AutoSize = true;
            this.VareIdContentLabel.ForeColor = System.Drawing.Color.Black;
            this.VareIdContentLabel.Location = new System.Drawing.Point(116, 51);
            this.VareIdContentLabel.Name = "VareIdContentLabel";
            this.VareIdContentLabel.Size = new System.Drawing.Size(73, 21);
            this.VareIdContentLabel.TabIndex = 0;
            this.VareIdContentLabel.Text = "1365884";
            // 
            // VarePrisContentLabel
            // 
            this.VarePrisContentLabel.AutoSize = true;
            this.VarePrisContentLabel.ForeColor = System.Drawing.Color.Black;
            this.VarePrisContentLabel.Location = new System.Drawing.Point(431, 30);
            this.VarePrisContentLabel.Name = "VarePrisContentLabel";
            this.VarePrisContentLabel.Size = new System.Drawing.Size(88, 21);
            this.VarePrisContentLabel.TabIndex = 0;
            this.VarePrisContentLabel.Text = "1299,95 kr.";
            // 
            // NameContentLabel
            // 
            this.NameContentLabel.AutoSize = true;
            this.NameContentLabel.ForeColor = System.Drawing.Color.Black;
            this.NameContentLabel.Location = new System.Drawing.Point(116, 30);
            this.NameContentLabel.Name = "NameContentLabel";
            this.NameContentLabel.Size = new System.Drawing.Size(175, 21);
            this.NameContentLabel.TabIndex = 0;
            this.NameContentLabel.Text = "Classic Køkkenskab, Høj";
            // 
            // VarePrisTxtLbl
            // 
            this.VarePrisTxtLbl.AutoSize = true;
            this.VarePrisTxtLbl.Location = new System.Drawing.Point(386, 30);
            this.VarePrisTxtLbl.Name = "VarePrisTxtLbl";
            this.VarePrisTxtLbl.Size = new System.Drawing.Size(39, 21);
            this.VarePrisTxtLbl.TabIndex = 0;
            this.VarePrisTxtLbl.Text = "Pris:";
            // 
            // NameTxtLbl
            // 
            this.NameTxtLbl.AutoSize = true;
            this.NameTxtLbl.Location = new System.Drawing.Point(16, 30);
            this.NameTxtLbl.Name = "NameTxtLbl";
            this.NameTxtLbl.Size = new System.Drawing.Size(44, 21);
            this.NameTxtLbl.TabIndex = 0;
            this.NameTxtLbl.Text = "Vare:";
            // 
            // FarveTxtLbl
            // 
            this.FarveTxtLbl.AutoSize = true;
            this.FarveTxtLbl.Location = new System.Drawing.Point(63, 111);
            this.FarveTxtLbl.Name = "FarveTxtLbl";
            this.FarveTxtLbl.Size = new System.Drawing.Size(47, 21);
            this.FarveTxtLbl.TabIndex = 0;
            this.FarveTxtLbl.Text = "Farve";
            // 
            // MaterialeTxtLbl
            // 
            this.MaterialeTxtLbl.AutoSize = true;
            this.MaterialeTxtLbl.Location = new System.Drawing.Point(257, 111);
            this.MaterialeTxtLbl.Name = "MaterialeTxtLbl";
            this.MaterialeTxtLbl.Size = new System.Drawing.Size(75, 21);
            this.MaterialeTxtLbl.TabIndex = 0;
            this.MaterialeTxtLbl.Text = "Materiale";
            // 
            // GrebTxtLbl
            // 
            this.GrebTxtLbl.AutoSize = true;
            this.GrebTxtLbl.Location = new System.Drawing.Point(473, 111);
            this.GrebTxtLbl.Name = "GrebTxtLbl";
            this.GrebTxtLbl.Size = new System.Drawing.Size(44, 21);
            this.GrebTxtLbl.TabIndex = 4;
            this.GrebTxtLbl.Text = "Greb";
            // 
            // FarveContentLabel
            // 
            this.FarveContentLabel.AutoSize = true;
            this.FarveContentLabel.ForeColor = System.Drawing.Color.Black;
            this.FarveContentLabel.Location = new System.Drawing.Point(63, 132);
            this.FarveContentLabel.Name = "FarveContentLabel";
            this.FarveContentLabel.Size = new System.Drawing.Size(47, 21);
            this.FarveContentLabel.TabIndex = 0;
            this.FarveContentLabel.Text = "Farve";
            // 
            // MaterialeContentLabel
            // 
            this.MaterialeContentLabel.AutoSize = true;
            this.MaterialeContentLabel.ForeColor = System.Drawing.Color.Black;
            this.MaterialeContentLabel.Location = new System.Drawing.Point(257, 132);
            this.MaterialeContentLabel.Name = "MaterialeContentLabel";
            this.MaterialeContentLabel.Size = new System.Drawing.Size(75, 21);
            this.MaterialeContentLabel.TabIndex = 0;
            this.MaterialeContentLabel.Text = "Materiale";
            // 
            // GrebContentLabel
            // 
            this.GrebContentLabel.AutoSize = true;
            this.GrebContentLabel.ForeColor = System.Drawing.Color.Black;
            this.GrebContentLabel.Location = new System.Drawing.Point(473, 132);
            this.GrebContentLabel.Name = "GrebContentLabel";
            this.GrebContentLabel.Size = new System.Drawing.Size(44, 21);
            this.GrebContentLabel.TabIndex = 0;
            this.GrebContentLabel.Text = "Greb";
            // 
            // Vare
            // 
            this.Vare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vare.DataPropertyName = "ProductName";
            this.Vare.HeaderText = "Vare";
            this.Vare.Name = "Vare";
            this.Vare.ReadOnly = true;
            // 
            // Varegruppe
            // 
            this.Varegruppe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Varegruppe.DataPropertyName = "VaregruppeNavn";
            this.Varegruppe.HeaderText = "Varegruppe";
            this.Varegruppe.Name = "Varegruppe";
            this.Varegruppe.ReadOnly = true;
            this.Varegruppe.Width = 116;
            // 
            // Greb
            // 
            this.Greb.DataPropertyName = "ChosenGripString";
            this.Greb.HeaderText = "Greb";
            this.Greb.Name = "Greb";
            this.Greb.ReadOnly = true;
            // 
            // Farve
            // 
            this.Farve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Farve.DataPropertyName = "ChosenColorString";
            this.Farve.HeaderText = "Farve";
            this.Farve.Name = "Farve";
            this.Farve.ReadOnly = true;
            this.Farve.Width = 72;
            // 
            // Materiale
            // 
            this.Materiale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Materiale.DataPropertyName = "ChosenMaterialString";
            this.Materiale.HeaderText = "Materiale";
            this.Materiale.Name = "Materiale";
            this.Materiale.ReadOnly = true;
            // 
            // Pris
            // 
            this.Pris.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pris.DataPropertyName = "Price";
            this.Pris.HeaderText = "Pris";
            this.Pris.Name = "Pris";
            this.Pris.ReadOnly = true;
            this.Pris.Width = 61;
            // 
            // EmployeeTxtLbl
            // 
            this.EmployeeTxtLbl.AutoSize = true;
            this.EmployeeTxtLbl.Location = new System.Drawing.Point(254, 30);
            this.EmployeeTxtLbl.Name = "EmployeeTxtLbl";
            this.EmployeeTxtLbl.Size = new System.Drawing.Size(171, 21);
            this.EmployeeTxtLbl.TabIndex = 0;
            this.EmployeeTxtLbl.Text = "Ansvarlig Medarbejder:";
            // 
            // EmployeeContentLabel
            // 
            this.EmployeeContentLabel.AutoSize = true;
            this.EmployeeContentLabel.ForeColor = System.Drawing.Color.Black;
            this.EmployeeContentLabel.Location = new System.Drawing.Point(431, 30);
            this.EmployeeContentLabel.Name = "EmployeeContentLabel";
            this.EmployeeContentLabel.Size = new System.Drawing.Size(136, 21);
            this.EmployeeContentLabel.TabIndex = 0;
            this.EmployeeContentLabel.Text = "MedarbejderNavn";
            // 
            // VisOrdreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.BottomPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "VisOrdreForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Køkken Fanatikeren Ordre";
            this.HeaderPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.LeftMainPanel.ResumeLayout(false);
            this.VareListeGrpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VareListeDataGrid)).EndInit();
            this.RightMainPanel.ResumeLayout(false);
            this.OrdreInfoGrpBox.ResumeLayout(false);
            this.OrdreInfoGrpBox.PerformLayout();
            this.OrdreCommentGrpBox.ResumeLayout(false);
            this.OrdreCommentGrpBox.PerformLayout();
            this.VareInfoGrpBox.ResumeLayout(false);
            this.VareInfoGrpBox.PerformLayout();
            this.BeskrivelseGrpBox.ResumeLayout(false);
            this.BeskrivelseGrpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label HeaderImageLabel;
        private System.Windows.Forms.Panel RightMainPanel;
        private System.Windows.Forms.GroupBox OrdreInfoGrpBox;
        private System.Windows.Forms.Label OrdreIdTxtLbl;
        private System.Windows.Forms.Panel LeftMainPanel;
        private System.Windows.Forms.GroupBox VareListeGrpBox;
        private System.Windows.Forms.DataGridView VareListeDataGrid;
        private System.Windows.Forms.Label AdresseTxtLbl;
        private System.Windows.Forms.Label KundeTxtLbl;
        private System.Windows.Forms.Label AdresseContentLabel;
        private System.Windows.Forms.Label KundeContentLabel;
        private System.Windows.Forms.Label OrdreIdContentLabel;
        private System.Windows.Forms.Label TotalPrisContentLabel;
        private System.Windows.Forms.Label PrisTxtLbl;
        private System.Windows.Forms.GroupBox OrdreCommentGrpBox;
        private System.Windows.Forms.TextBox OrdreCommentTextBox;
        private System.Windows.Forms.Label TlfTxtLbl;
        private System.Windows.Forms.Label TlfContentLabel;
        private System.Windows.Forms.GroupBox VareInfoGrpBox;
        private System.Windows.Forms.Label GrebTxtLbl;
        private System.Windows.Forms.GroupBox BeskrivelseGrpBox;
        private System.Windows.Forms.TextBox VareBeskrivelseTxtBox;
        private System.Windows.Forms.Label MaterialeTxtLbl;
        private System.Windows.Forms.Label FarveTxtLbl;
        private System.Windows.Forms.Label VareGruppeTxtLbl;
        private System.Windows.Forms.Label VareIdTxtLbl;
        private System.Windows.Forms.Label VareGruppeContentLabel;
        private System.Windows.Forms.Label VareIdContentLabel;
        private System.Windows.Forms.Label VarePrisContentLabel;
        private System.Windows.Forms.Label GrebContentLabel;
        private System.Windows.Forms.Label MaterialeContentLabel;
        private System.Windows.Forms.Label FarveContentLabel;
        private System.Windows.Forms.Label NameContentLabel;
        private System.Windows.Forms.Label VarePrisTxtLbl;
        private System.Windows.Forms.Label NameTxtLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Varegruppe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Greb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Farve;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materiale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pris;
        private System.Windows.Forms.Label EmployeeContentLabel;
        private System.Windows.Forms.Label EmployeeTxtLbl;
    }
}

