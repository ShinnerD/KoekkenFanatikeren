namespace KF_UserInterface
{
    partial class SalgsStatistikForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalgsStatistikForm));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.LukModulButton = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.HeaderImageLabel = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.RightMainPanel = new System.Windows.Forms.Panel();
            this.BottomRightPanel = new System.Windows.Forms.Panel();
            this.WriteToTextButton = new System.Windows.Forms.Button();
            this.OrdreGrpBox = new System.Windows.Forms.GroupBox();
            this.KundeOrdreGridView = new System.Windows.Forms.DataGridView();
            this.DatoGrpBox = new System.Windows.Forms.GroupBox();
            this.FromDateTxtLbl = new System.Windows.Forms.Label();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDateTxtLbl = new System.Windows.Forms.Label();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TotalPriceTxtLbl = new System.Windows.Forms.Label();
            this.TotalPriceContentLabel = new System.Windows.Forms.Label();
            this.SearchDatesButton = new System.Windows.Forms.Button();
            this.OrdreNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kunde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Afsendt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AntalVare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.RightMainPanel.SuspendLayout();
            this.BottomRightPanel.SuspendLayout();
            this.OrdreGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KundeOrdreGridView)).BeginInit();
            this.DatoGrpBox.SuspendLayout();
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
            // HeaderLabel
            // 
            this.HeaderLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderLabel.Location = new System.Drawing.Point(146, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(142, 80);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Salgsstatistik";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeaderImageLabel
            // 
            this.HeaderImageLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.HeaderImageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeaderImageLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderImageLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderImageLabel.Image = global::KF_UserInterface.Properties.Resources.OrdreImage;
            this.HeaderImageLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.MainPanel.Controls.Add(this.RightMainPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 80);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1284, 601);
            this.MainPanel.TabIndex = 2;
            // 
            // RightMainPanel
            // 
            this.RightMainPanel.Controls.Add(this.BottomRightPanel);
            this.RightMainPanel.Controls.Add(this.OrdreGrpBox);
            this.RightMainPanel.Controls.Add(this.DatoGrpBox);
            this.RightMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightMainPanel.Location = new System.Drawing.Point(0, 0);
            this.RightMainPanel.Name = "RightMainPanel";
            this.RightMainPanel.Size = new System.Drawing.Size(1284, 601);
            this.RightMainPanel.TabIndex = 6;
            // 
            // BottomRightPanel
            // 
            this.BottomRightPanel.Controls.Add(this.WriteToTextButton);
            this.BottomRightPanel.Controls.Add(this.TotalPriceContentLabel);
            this.BottomRightPanel.Controls.Add(this.TotalPriceTxtLbl);
            this.BottomRightPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomRightPanel.Location = new System.Drawing.Point(0, 538);
            this.BottomRightPanel.Name = "BottomRightPanel";
            this.BottomRightPanel.Size = new System.Drawing.Size(1284, 63);
            this.BottomRightPanel.TabIndex = 2;
            // 
            // WriteToTextButton
            // 
            this.WriteToTextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WriteToTextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.WriteToTextButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.WriteToTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WriteToTextButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteToTextButton.ForeColor = System.Drawing.Color.White;
            this.WriteToTextButton.Location = new System.Drawing.Point(1044, 15);
            this.WriteToTextButton.Name = "WriteToTextButton";
            this.WriteToTextButton.Size = new System.Drawing.Size(194, 37);
            this.WriteToTextButton.TabIndex = 1;
            this.WriteToTextButton.Text = "Udskriv Til Tekst";
            this.WriteToTextButton.UseVisualStyleBackColor = false;
            this.WriteToTextButton.Click += new System.EventHandler(this.WriteToTextButton_Click);
            // 
            // OrdreGrpBox
            // 
            this.OrdreGrpBox.Controls.Add(this.KundeOrdreGridView);
            this.OrdreGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdreGrpBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdreGrpBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.OrdreGrpBox.Location = new System.Drawing.Point(0, 122);
            this.OrdreGrpBox.Name = "OrdreGrpBox";
            this.OrdreGrpBox.Size = new System.Drawing.Size(1284, 479);
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
            this.Kunde,
            this.Afsendt,
            this.AntalVare,
            this.Pris});
            this.KundeOrdreGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KundeOrdreGridView.GridColor = System.Drawing.Color.Black;
            this.KundeOrdreGridView.Location = new System.Drawing.Point(3, 25);
            this.KundeOrdreGridView.Name = "KundeOrdreGridView";
            this.KundeOrdreGridView.ReadOnly = true;
            this.KundeOrdreGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.KundeOrdreGridView.RowHeadersVisible = false;
            this.KundeOrdreGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KundeOrdreGridView.Size = new System.Drawing.Size(1278, 451);
            this.KundeOrdreGridView.TabIndex = 3;
            // 
            // DatoGrpBox
            // 
            this.DatoGrpBox.Controls.Add(this.SearchDatesButton);
            this.DatoGrpBox.Controls.Add(this.ToDateTimePicker);
            this.DatoGrpBox.Controls.Add(this.FromDateTimePicker);
            this.DatoGrpBox.Controls.Add(this.ToDateTxtLbl);
            this.DatoGrpBox.Controls.Add(this.FromDateTxtLbl);
            this.DatoGrpBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatoGrpBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatoGrpBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.DatoGrpBox.Location = new System.Drawing.Point(0, 0);
            this.DatoGrpBox.Name = "DatoGrpBox";
            this.DatoGrpBox.Size = new System.Drawing.Size(1284, 122);
            this.DatoGrpBox.TabIndex = 0;
            this.DatoGrpBox.TabStop = false;
            this.DatoGrpBox.Text = "Dato";
            // 
            // FromDateTxtLbl
            // 
            this.FromDateTxtLbl.AutoSize = true;
            this.FromDateTxtLbl.Location = new System.Drawing.Point(96, 55);
            this.FromDateTxtLbl.Name = "FromDateTxtLbl";
            this.FromDateTxtLbl.Size = new System.Drawing.Size(108, 21);
            this.FromDateTxtLbl.TabIndex = 1;
            this.FromDateTxtLbl.Text = "Vis Ordrer fra:";
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.Location = new System.Drawing.Point(210, 49);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.FromDateTimePicker.TabIndex = 2;
            // 
            // ToDateTxtLbl
            // 
            this.ToDateTxtLbl.AutoSize = true;
            this.ToDateTxtLbl.Location = new System.Drawing.Point(451, 55);
            this.ToDateTxtLbl.Name = "ToDateTxtLbl";
            this.ToDateTxtLbl.Size = new System.Drawing.Size(29, 21);
            this.ToDateTxtLbl.TabIndex = 1;
            this.ToDateTxtLbl.Text = "Til:";
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.Location = new System.Drawing.Point(486, 49);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.ToDateTimePicker.TabIndex = 2;
            // 
            // TotalPriceTxtLbl
            // 
            this.TotalPriceTxtLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalPriceTxtLbl.AutoSize = true;
            this.TotalPriceTxtLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceTxtLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.TotalPriceTxtLbl.Location = new System.Drawing.Point(12, 15);
            this.TotalPriceTxtLbl.Name = "TotalPriceTxtLbl";
            this.TotalPriceTxtLbl.Size = new System.Drawing.Size(56, 21);
            this.TotalPriceTxtLbl.TabIndex = 1;
            this.TotalPriceTxtLbl.Text = "I alt kr.";
            // 
            // TotalPriceContentLabel
            // 
            this.TotalPriceContentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalPriceContentLabel.AutoSize = true;
            this.TotalPriceContentLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceContentLabel.ForeColor = System.Drawing.Color.Black;
            this.TotalPriceContentLabel.Location = new System.Drawing.Point(74, 15);
            this.TotalPriceContentLabel.Name = "TotalPriceContentLabel";
            this.TotalPriceContentLabel.Size = new System.Drawing.Size(19, 21);
            this.TotalPriceContentLabel.TabIndex = 1;
            this.TotalPriceContentLabel.Text = "0";
            // 
            // SearchDatesButton
            // 
            this.SearchDatesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.SearchDatesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SearchDatesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchDatesButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchDatesButton.ForeColor = System.Drawing.Color.White;
            this.SearchDatesButton.Location = new System.Drawing.Point(767, 46);
            this.SearchDatesButton.Name = "SearchDatesButton";
            this.SearchDatesButton.Size = new System.Drawing.Size(139, 37);
            this.SearchDatesButton.TabIndex = 1;
            this.SearchDatesButton.Text = "Søg";
            this.SearchDatesButton.UseVisualStyleBackColor = false;
            this.SearchDatesButton.Click += new System.EventHandler(this.SearchDatesButton_Click);
            // 
            // OrdreNr
            // 
            this.OrdreNr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrdreNr.DataPropertyName = "Id";
            this.OrdreNr.HeaderText = "Ordre Nr.";
            this.OrdreNr.Name = "OrdreNr";
            this.OrdreNr.ReadOnly = true;
            this.OrdreNr.Width = 101;
            // 
            // Kunde
            // 
            this.Kunde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kunde.DataPropertyName = "KundeName";
            this.Kunde.HeaderText = "Kunde";
            this.Kunde.Name = "Kunde";
            this.Kunde.ReadOnly = true;
            // 
            // Afsendt
            // 
            this.Afsendt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Afsendt.DataPropertyName = "DateOfSending";
            this.Afsendt.HeaderText = "Afsendt";
            this.Afsendt.Name = "Afsendt";
            this.Afsendt.ReadOnly = true;
            // 
            // AntalVare
            // 
            this.AntalVare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AntalVare.DataPropertyName = "ProductCount";
            this.AntalVare.HeaderText = "Antal Vare";
            this.AntalVare.Name = "AntalVare";
            this.AntalVare.ReadOnly = true;
            this.AntalVare.Width = 106;
            // 
            // Pris
            // 
            this.Pris.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pris.DataPropertyName = "TotalPrice";
            this.Pris.HeaderText = "Total Pris";
            this.Pris.Name = "Pris";
            this.Pris.ReadOnly = true;
            this.Pris.Width = 97;
            // 
            // SalgsStatistikForm
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
            this.Name = "SalgsStatistikForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Køkken Fanatikeren Kunde Modul";
            this.HeaderPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.RightMainPanel.ResumeLayout(false);
            this.BottomRightPanel.ResumeLayout(false);
            this.BottomRightPanel.PerformLayout();
            this.OrdreGrpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KundeOrdreGridView)).EndInit();
            this.DatoGrpBox.ResumeLayout(false);
            this.DatoGrpBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox DatoGrpBox;
        private System.Windows.Forms.Panel BottomRightPanel;
        private System.Windows.Forms.Button WriteToTextButton;
        private System.Windows.Forms.GroupBox OrdreGrpBox;
        private System.Windows.Forms.DataGridView KundeOrdreGridView;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.Label FromDateTxtLbl;
        private System.Windows.Forms.Label TotalPriceContentLabel;
        private System.Windows.Forms.Label TotalPriceTxtLbl;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.Label ToDateTxtLbl;
        private System.Windows.Forms.Button SearchDatesButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdreNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kunde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Afsendt;
        private System.Windows.Forms.DataGridViewTextBoxColumn AntalVare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pris;
    }
}

