namespace KF_UserInterface
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
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.SalesStatisticsButton = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.LogOffButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.VareModulButton = new System.Windows.Forms.Button();
            this.KundeModulButton = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.HeaderPanel.Controls.Add(this.SalesStatisticsButton);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(914, 80);
            this.HeaderPanel.TabIndex = 0;
            // 
            // SalesStatisticsButton
            // 
            this.SalesStatisticsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesStatisticsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.SalesStatisticsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SalesStatisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesStatisticsButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesStatisticsButton.ForeColor = System.Drawing.Color.White;
            this.SalesStatisticsButton.Location = new System.Drawing.Point(748, 12);
            this.SalesStatisticsButton.Name = "SalesStatisticsButton";
            this.SalesStatisticsButton.Size = new System.Drawing.Size(154, 37);
            this.SalesStatisticsButton.TabIndex = 0;
            this.SalesStatisticsButton.Text = "Salgsstatistik";
            this.SalesStatisticsButton.UseVisualStyleBackColor = false;
            this.SalesStatisticsButton.Click += new System.EventHandler(this.SalesStatisticsButton_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.BottomPanel.Controls.Add(this.LogOffButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 441);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(914, 80);
            this.BottomPanel.TabIndex = 1;
            // 
            // LogOffButton
            // 
            this.LogOffButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LogOffButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.LogOffButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LogOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOffButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOffButton.ForeColor = System.Drawing.Color.White;
            this.LogOffButton.Location = new System.Drawing.Point(748, 31);
            this.LogOffButton.Name = "LogOffButton";
            this.LogOffButton.Size = new System.Drawing.Size(154, 37);
            this.LogOffButton.TabIndex = 0;
            this.LogOffButton.Text = "Log Ud";
            this.LogOffButton.UseVisualStyleBackColor = false;
            this.LogOffButton.Click += new System.EventHandler(this.LogOffButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.NewOrderButton);
            this.MainPanel.Controls.Add(this.VareModulButton);
            this.MainPanel.Controls.Add(this.KundeModulButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 80);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(914, 361);
            this.MainPanel.TabIndex = 2;
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.NewOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.NewOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewOrderButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOrderButton.ForeColor = System.Drawing.Color.White;
            this.NewOrderButton.Image = global::KF_UserInterface.Properties.Resources.OrdreImage;
            this.NewOrderButton.Location = new System.Drawing.Point(655, 95);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(190, 170);
            this.NewOrderButton.TabIndex = 2;
            this.NewOrderButton.Text = "Kunde Vejledning";
            this.NewOrderButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewOrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NewOrderButton.UseVisualStyleBackColor = false;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // VareModulButton
            // 
            this.VareModulButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VareModulButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.VareModulButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.VareModulButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VareModulButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VareModulButton.ForeColor = System.Drawing.Color.White;
            this.VareModulButton.Image = global::KF_UserInterface.Properties.Resources.VareImage;
            this.VareModulButton.Location = new System.Drawing.Point(362, 95);
            this.VareModulButton.Name = "VareModulButton";
            this.VareModulButton.Size = new System.Drawing.Size(190, 170);
            this.VareModulButton.TabIndex = 2;
            this.VareModulButton.Text = "Vare Modul";
            this.VareModulButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VareModulButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.VareModulButton.UseVisualStyleBackColor = false;
            this.VareModulButton.Click += new System.EventHandler(this.VareModulButton_Click);
            // 
            // KundeModulButton
            // 
            this.KundeModulButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KundeModulButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.KundeModulButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.KundeModulButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KundeModulButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KundeModulButton.ForeColor = System.Drawing.Color.White;
            this.KundeModulButton.Image = global::KF_UserInterface.Properties.Resources.KundeImage;
            this.KundeModulButton.Location = new System.Drawing.Point(85, 94);
            this.KundeModulButton.Name = "KundeModulButton";
            this.KundeModulButton.Size = new System.Drawing.Size(190, 170);
            this.KundeModulButton.TabIndex = 1;
            this.KundeModulButton.Text = "Kunde Modul";
            this.KundeModulButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.KundeModulButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.KundeModulButton.UseVisualStyleBackColor = false;
            this.KundeModulButton.Click += new System.EventHandler(this.KundeModulButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 521);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.BottomPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Køkken Fanatikeren Home";
            this.HeaderPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button LogOffButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button KundeModulButton;
        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Button VareModulButton;
        private System.Windows.Forms.Button SalesStatisticsButton;
    }
}

