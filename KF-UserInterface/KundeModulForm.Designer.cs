﻿namespace KF_UserInterface
{
    partial class KundeModulForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KundeModulForm));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.LukModulButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.HeaderImageLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.KundeListeGridView = new System.Windows.Forms.DataGridView();
            this.KundeListeGrpBox = new System.Windows.Forms.GroupBox();
            this.Navn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TlfNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FindKundeGrpBox = new System.Windows.Forms.GroupBox();
            this.LeftMainPanel = new System.Windows.Forms.Panel();
            this.SearchFieldTextBox = new System.Windows.Forms.TextBox();
            this.RightMainPanel = new System.Windows.Forms.Panel();
            this.KundeInfoGrpBox = new System.Windows.Forms.GroupBox();
            this.NameTxtLbl = new System.Windows.Forms.Label();
            this.TlfTxtLbl = new System.Windows.Forms.Label();
            this.EmailTxtLbl = new System.Windows.Forms.Label();
            this.NameContentLabel = new System.Windows.Forms.Label();
            this.TlfContentLabel = new System.Windows.Forms.Label();
            this.EmailContentLabel = new System.Windows.Forms.Label();
            this.AdresseTxtLbl = new System.Windows.Forms.Label();
            this.AdresseContentLabel = new System.Windows.Forms.Label();
            this.OrdreGrpBox = new System.Windows.Forms.GroupBox();
            this.KundeOrdreGridView = new System.Windows.Forms.DataGridView();
            this.OrdreNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BottomRightPanel = new System.Windows.Forms.Panel();
            this.NyKundeButton = new System.Windows.Forms.Button();
            this.RedigerKundeButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.OpretOrdreButton = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KundeListeGridView)).BeginInit();
            this.KundeListeGrpBox.SuspendLayout();
            this.FindKundeGrpBox.SuspendLayout();
            this.LeftMainPanel.SuspendLayout();
            this.RightMainPanel.SuspendLayout();
            this.KundeInfoGrpBox.SuspendLayout();
            this.OrdreGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KundeOrdreGridView)).BeginInit();
            this.BottomRightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.HeaderPanel.Controls.Add(this.LukModulButton);
            this.HeaderPanel.Controls.Add(this.HeaderLabel);
            this.HeaderPanel.Controls.Add(this.HeaderImageLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1284, 80);
            this.HeaderPanel.TabIndex = 0;
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
            // LukModulButton
            // 
            this.LukModulButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LukModulButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.LukModulButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LukModulButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LukModulButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LukModulButton.ForeColor = System.Drawing.Color.White;
            this.LukModulButton.Location = new System.Drawing.Point(1118, 23);
            this.LukModulButton.Name = "LukModulButton";
            this.LukModulButton.Size = new System.Drawing.Size(154, 37);
            this.LukModulButton.TabIndex = 0;
            this.LukModulButton.Text = "Luk Modul";
            this.LukModulButton.UseVisualStyleBackColor = false;
            this.LukModulButton.Click += new System.EventHandler(this.LukModulButton_Click);
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
            // HeaderImageLabel
            // 
            this.HeaderImageLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.HeaderImageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeaderImageLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderImageLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderImageLabel.Image = global::KF_UserInterface.Properties.Resources.KundeImage;
            this.HeaderImageLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HeaderImageLabel.Location = new System.Drawing.Point(0, 0);
            this.HeaderImageLabel.Name = "HeaderImageLabel";
            this.HeaderImageLabel.Size = new System.Drawing.Size(146, 80);
            this.HeaderImageLabel.TabIndex = 0;
            this.HeaderImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.HeaderLabel.Text = "Kunde Modul";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KundeListeGridView
            // 
            this.KundeListeGridView.AllowUserToAddRows = false;
            this.KundeListeGridView.AllowUserToDeleteRows = false;
            this.KundeListeGridView.BackgroundColor = System.Drawing.Color.White;
            this.KundeListeGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KundeListeGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.KundeListeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KundeListeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Navn,
            this.TlfNr,
            this.Email});
            this.KundeListeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KundeListeGridView.GridColor = System.Drawing.Color.Black;
            this.KundeListeGridView.Location = new System.Drawing.Point(3, 25);
            this.KundeListeGridView.Name = "KundeListeGridView";
            this.KundeListeGridView.ReadOnly = true;
            this.KundeListeGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.KundeListeGridView.RowHeadersVisible = false;
            this.KundeListeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KundeListeGridView.Size = new System.Drawing.Size(630, 507);
            this.KundeListeGridView.TabIndex = 2;
            // 
            // KundeListeGrpBox
            // 
            this.KundeListeGrpBox.Controls.Add(this.KundeListeGridView);
            this.KundeListeGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KundeListeGrpBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KundeListeGrpBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KundeListeGrpBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.KundeListeGrpBox.Location = new System.Drawing.Point(0, 66);
            this.KundeListeGrpBox.Name = "KundeListeGrpBox";
            this.KundeListeGrpBox.Size = new System.Drawing.Size(636, 535);
            this.KundeListeGrpBox.TabIndex = 3;
            this.KundeListeGrpBox.TabStop = false;
            this.KundeListeGrpBox.Text = "Kunde Liste";
            // 
            // Navn
            // 
            this.Navn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Navn.HeaderText = "Navn";
            this.Navn.Name = "Navn";
            this.Navn.ReadOnly = true;
            // 
            // TlfNr
            // 
            this.TlfNr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TlfNr.FillWeight = 50F;
            this.TlfNr.HeaderText = "Tlf. Nr.";
            this.TlfNr.Name = "TlfNr";
            this.TlfNr.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Email.HeaderText = "E-Mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 79;
            // 
            // FindKundeGrpBox
            // 
            this.FindKundeGrpBox.Controls.Add(this.SearchButton);
            this.FindKundeGrpBox.Controls.Add(this.SearchFieldTextBox);
            this.FindKundeGrpBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.FindKundeGrpBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindKundeGrpBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindKundeGrpBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.FindKundeGrpBox.Location = new System.Drawing.Point(0, 0);
            this.FindKundeGrpBox.Name = "FindKundeGrpBox";
            this.FindKundeGrpBox.Size = new System.Drawing.Size(636, 66);
            this.FindKundeGrpBox.TabIndex = 4;
            this.FindKundeGrpBox.TabStop = false;
            this.FindKundeGrpBox.Text = "Find Kunde";
            // 
            // LeftMainPanel
            // 
            this.LeftMainPanel.Controls.Add(this.KundeListeGrpBox);
            this.LeftMainPanel.Controls.Add(this.FindKundeGrpBox);
            this.LeftMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftMainPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftMainPanel.Name = "LeftMainPanel";
            this.LeftMainPanel.Size = new System.Drawing.Size(636, 601);
            this.LeftMainPanel.TabIndex = 5;
            // 
            // SearchFieldTextBox
            // 
            this.SearchFieldTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchFieldTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchFieldTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFieldTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.SearchFieldTextBox.Location = new System.Drawing.Point(12, 25);
            this.SearchFieldTextBox.Name = "SearchFieldTextBox";
            this.SearchFieldTextBox.Size = new System.Drawing.Size(458, 26);
            this.SearchFieldTextBox.TabIndex = 0;
            this.SearchFieldTextBox.Text = "Indtast navn, tlf nr eller email...";
            // 
            // RightMainPanel
            // 
            this.RightMainPanel.Controls.Add(this.BottomRightPanel);
            this.RightMainPanel.Controls.Add(this.OrdreGrpBox);
            this.RightMainPanel.Controls.Add(this.KundeInfoGrpBox);
            this.RightMainPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightMainPanel.Location = new System.Drawing.Point(636, 0);
            this.RightMainPanel.Name = "RightMainPanel";
            this.RightMainPanel.Size = new System.Drawing.Size(648, 601);
            this.RightMainPanel.TabIndex = 6;
            // 
            // KundeInfoGrpBox
            // 
            this.KundeInfoGrpBox.Controls.Add(this.EmailTxtLbl);
            this.KundeInfoGrpBox.Controls.Add(this.TlfTxtLbl);
            this.KundeInfoGrpBox.Controls.Add(this.EmailContentLabel);
            this.KundeInfoGrpBox.Controls.Add(this.TlfContentLabel);
            this.KundeInfoGrpBox.Controls.Add(this.NameContentLabel);
            this.KundeInfoGrpBox.Controls.Add(this.AdresseContentLabel);
            this.KundeInfoGrpBox.Controls.Add(this.AdresseTxtLbl);
            this.KundeInfoGrpBox.Controls.Add(this.NameTxtLbl);
            this.KundeInfoGrpBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.KundeInfoGrpBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KundeInfoGrpBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.KundeInfoGrpBox.Location = new System.Drawing.Point(0, 0);
            this.KundeInfoGrpBox.Name = "KundeInfoGrpBox";
            this.KundeInfoGrpBox.Size = new System.Drawing.Size(648, 122);
            this.KundeInfoGrpBox.TabIndex = 0;
            this.KundeInfoGrpBox.TabStop = false;
            this.KundeInfoGrpBox.Text = "Kunde Information";
            // 
            // NameTxtLbl
            // 
            this.NameTxtLbl.AutoSize = true;
            this.NameTxtLbl.Location = new System.Drawing.Point(16, 30);
            this.NameTxtLbl.Name = "NameTxtLbl";
            this.NameTxtLbl.Size = new System.Drawing.Size(50, 21);
            this.NameTxtLbl.TabIndex = 0;
            this.NameTxtLbl.Text = "Navn:";
            // 
            // TlfTxtLbl
            // 
            this.TlfTxtLbl.AutoSize = true;
            this.TlfTxtLbl.Location = new System.Drawing.Point(16, 51);
            this.TlfTxtLbl.Name = "TlfTxtLbl";
            this.TlfTxtLbl.Size = new System.Drawing.Size(62, 21);
            this.TlfTxtLbl.TabIndex = 0;
            this.TlfTxtLbl.Text = "Telefon:";
            // 
            // EmailTxtLbl
            // 
            this.EmailTxtLbl.AutoSize = true;
            this.EmailTxtLbl.Location = new System.Drawing.Point(16, 72);
            this.EmailTxtLbl.Name = "EmailTxtLbl";
            this.EmailTxtLbl.Size = new System.Drawing.Size(57, 21);
            this.EmailTxtLbl.TabIndex = 0;
            this.EmailTxtLbl.Text = "E-mail:";
            // 
            // NameContentLabel
            // 
            this.NameContentLabel.AutoSize = true;
            this.NameContentLabel.ForeColor = System.Drawing.Color.Black;
            this.NameContentLabel.Location = new System.Drawing.Point(84, 30);
            this.NameContentLabel.Name = "NameContentLabel";
            this.NameContentLabel.Size = new System.Drawing.Size(86, 21);
            this.NameContentLabel.TabIndex = 0;
            this.NameContentLabel.Text = "Peter Ipsen";
            // 
            // TlfContentLabel
            // 
            this.TlfContentLabel.AutoSize = true;
            this.TlfContentLabel.ForeColor = System.Drawing.Color.Black;
            this.TlfContentLabel.Location = new System.Drawing.Point(84, 51);
            this.TlfContentLabel.Name = "TlfContentLabel";
            this.TlfContentLabel.Size = new System.Drawing.Size(94, 21);
            this.TlfContentLabel.TabIndex = 0;
            this.TlfContentLabel.Text = "75 88 19 52";
            // 
            // EmailContentLabel
            // 
            this.EmailContentLabel.AutoSize = true;
            this.EmailContentLabel.ForeColor = System.Drawing.Color.Black;
            this.EmailContentLabel.Location = new System.Drawing.Point(84, 72);
            this.EmailContentLabel.Name = "EmailContentLabel";
            this.EmailContentLabel.Size = new System.Drawing.Size(161, 21);
            this.EmailContentLabel.TabIndex = 0;
            this.EmailContentLabel.Text = "pipsen68@gmail.com";
            // 
            // AdresseTxtLbl
            // 
            this.AdresseTxtLbl.AutoSize = true;
            this.AdresseTxtLbl.Location = new System.Drawing.Point(338, 30);
            this.AdresseTxtLbl.Name = "AdresseTxtLbl";
            this.AdresseTxtLbl.Size = new System.Drawing.Size(68, 21);
            this.AdresseTxtLbl.TabIndex = 0;
            this.AdresseTxtLbl.Text = "Adresse:";
            // 
            // AdresseContentLabel
            // 
            this.AdresseContentLabel.AutoSize = true;
            this.AdresseContentLabel.ForeColor = System.Drawing.Color.Black;
            this.AdresseContentLabel.Location = new System.Drawing.Point(352, 51);
            this.AdresseContentLabel.Name = "AdresseContentLabel";
            this.AdresseContentLabel.Size = new System.Drawing.Size(221, 42);
            this.AdresseContentLabel.TabIndex = 0;
            this.AdresseContentLabel.Text = "Rudolph Wullfs Gade 10, st. tv.\r\n8000 Aarhus C";
            // 
            // OrdreGrpBox
            // 
            this.OrdreGrpBox.Controls.Add(this.KundeOrdreGridView);
            this.OrdreGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdreGrpBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdreGrpBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.OrdreGrpBox.Location = new System.Drawing.Point(0, 122);
            this.OrdreGrpBox.Name = "OrdreGrpBox";
            this.OrdreGrpBox.Size = new System.Drawing.Size(648, 479);
            this.OrdreGrpBox.TabIndex = 1;
            this.OrdreGrpBox.TabStop = false;
            this.OrdreGrpBox.Text = "Ordre";
            // 
            // KundeOrdreGridView
            // 
            this.KundeOrdreGridView.AllowUserToAddRows = false;
            this.KundeOrdreGridView.AllowUserToDeleteRows = false;
            this.KundeOrdreGridView.BackgroundColor = System.Drawing.Color.White;
            this.KundeOrdreGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KundeOrdreGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.KundeOrdreGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KundeOrdreGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrdreNr,
            this.Dato,
            this.Status});
            this.KundeOrdreGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KundeOrdreGridView.GridColor = System.Drawing.Color.Black;
            this.KundeOrdreGridView.Location = new System.Drawing.Point(3, 25);
            this.KundeOrdreGridView.Name = "KundeOrdreGridView";
            this.KundeOrdreGridView.ReadOnly = true;
            this.KundeOrdreGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.KundeOrdreGridView.RowHeadersVisible = false;
            this.KundeOrdreGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KundeOrdreGridView.Size = new System.Drawing.Size(642, 451);
            this.KundeOrdreGridView.TabIndex = 3;
            // 
            // OrdreNr
            // 
            this.OrdreNr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrdreNr.HeaderText = "Ordre Nr.";
            this.OrdreNr.Name = "OrdreNr";
            this.OrdreNr.ReadOnly = true;
            // 
            // Dato
            // 
            this.Dato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dato.FillWeight = 40F;
            this.Dato.HeaderText = "Dato";
            this.Dato.Name = "Dato";
            this.Dato.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 77;
            // 
            // BottomRightPanel
            // 
            this.BottomRightPanel.Controls.Add(this.OpretOrdreButton);
            this.BottomRightPanel.Controls.Add(this.RedigerKundeButton);
            this.BottomRightPanel.Controls.Add(this.NyKundeButton);
            this.BottomRightPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomRightPanel.Location = new System.Drawing.Point(0, 538);
            this.BottomRightPanel.Name = "BottomRightPanel";
            this.BottomRightPanel.Size = new System.Drawing.Size(648, 63);
            this.BottomRightPanel.TabIndex = 2;
            // 
            // NyKundeButton
            // 
            this.NyKundeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NyKundeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.NyKundeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.NyKundeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NyKundeButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NyKundeButton.ForeColor = System.Drawing.Color.White;
            this.NyKundeButton.Location = new System.Drawing.Point(482, 15);
            this.NyKundeButton.Name = "NyKundeButton";
            this.NyKundeButton.Size = new System.Drawing.Size(154, 37);
            this.NyKundeButton.TabIndex = 1;
            this.NyKundeButton.Text = "Ny Kunde";
            this.NyKundeButton.UseVisualStyleBackColor = false;
            // 
            // RedigerKundeButton
            // 
            this.RedigerKundeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RedigerKundeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.RedigerKundeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RedigerKundeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedigerKundeButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedigerKundeButton.ForeColor = System.Drawing.Color.White;
            this.RedigerKundeButton.Location = new System.Drawing.Point(276, 15);
            this.RedigerKundeButton.Name = "RedigerKundeButton";
            this.RedigerKundeButton.Size = new System.Drawing.Size(154, 37);
            this.RedigerKundeButton.TabIndex = 1;
            this.RedigerKundeButton.Text = "Rediger Kunde";
            this.RedigerKundeButton.UseVisualStyleBackColor = false;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(476, 19);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(154, 37);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Søg";
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // OpretOrdreButton
            // 
            this.OpretOrdreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OpretOrdreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.OpretOrdreButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OpretOrdreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpretOrdreButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpretOrdreButton.ForeColor = System.Drawing.Color.White;
            this.OpretOrdreButton.Location = new System.Drawing.Point(62, 15);
            this.OpretOrdreButton.Name = "OpretOrdreButton";
            this.OpretOrdreButton.Size = new System.Drawing.Size(154, 37);
            this.OpretOrdreButton.TabIndex = 1;
            this.OpretOrdreButton.Text = "Opret Ordre";
            this.OpretOrdreButton.UseVisualStyleBackColor = false;
            // 
            // KundeModulForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.BottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "KundeModulForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Køkken Fanatikeren Kunde Modul";
            this.HeaderPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KundeListeGridView)).EndInit();
            this.KundeListeGrpBox.ResumeLayout(false);
            this.FindKundeGrpBox.ResumeLayout(false);
            this.FindKundeGrpBox.PerformLayout();
            this.LeftMainPanel.ResumeLayout(false);
            this.RightMainPanel.ResumeLayout(false);
            this.KundeInfoGrpBox.ResumeLayout(false);
            this.KundeInfoGrpBox.PerformLayout();
            this.OrdreGrpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KundeOrdreGridView)).EndInit();
            this.BottomRightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button LukModulButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label HeaderImageLabel;
        private System.Windows.Forms.Panel RightMainPanel;
        private System.Windows.Forms.GroupBox KundeInfoGrpBox;
        private System.Windows.Forms.Label NameTxtLbl;
        private System.Windows.Forms.Panel LeftMainPanel;
        private System.Windows.Forms.GroupBox KundeListeGrpBox;
        private System.Windows.Forms.DataGridView KundeListeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Navn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TlfNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.GroupBox FindKundeGrpBox;
        private System.Windows.Forms.TextBox SearchFieldTextBox;
        private System.Windows.Forms.Panel BottomRightPanel;
        private System.Windows.Forms.Button RedigerKundeButton;
        private System.Windows.Forms.Button NyKundeButton;
        private System.Windows.Forms.GroupBox OrdreGrpBox;
        private System.Windows.Forms.DataGridView KundeOrdreGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdreNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label EmailTxtLbl;
        private System.Windows.Forms.Label TlfTxtLbl;
        private System.Windows.Forms.Label EmailContentLabel;
        private System.Windows.Forms.Label TlfContentLabel;
        private System.Windows.Forms.Label NameContentLabel;
        private System.Windows.Forms.Label AdresseContentLabel;
        private System.Windows.Forms.Label AdresseTxtLbl;
        private System.Windows.Forms.Button OpretOrdreButton;
        private System.Windows.Forms.Button SearchButton;
    }
}
