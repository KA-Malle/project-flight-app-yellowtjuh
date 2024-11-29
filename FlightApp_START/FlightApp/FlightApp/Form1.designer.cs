﻿namespace FlightApp
{
    partial class FormFlightApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxFlights = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxInt = new System.Windows.Forms.CheckBox();
            this.checkBoxDom = new System.Windows.Forms.CheckBox();
            this.radioButtonAlle = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDeparture = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxArrival = new System.Windows.Forms.TextBox();
            this.radioButton50Meer = new System.Windows.Forms.RadioButton();
            this.radioButton75Meer = new System.Windows.Forms.RadioButton();
            this.radioButton90Meer = new System.Windows.Forms.RadioButton();
            this.labelAantalVluchten = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1722, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.afsluitenToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(119, 38);
            this.bestandToolStripMenuItem.Text = "Bestand";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(356, 6);
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.afsluitenToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auteurToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(76, 38);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // auteurToolStripMenuItem
            // 
            this.auteurToolStripMenuItem.Name = "auteurToolStripMenuItem";
            this.auteurToolStripMenuItem.Size = new System.Drawing.Size(219, 44);
            this.auteurToolStripMenuItem.Text = "Auteur";
            // 
            // listBoxFlights
            // 
            this.listBoxFlights.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFlights.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFlights.FormattingEnabled = true;
            this.listBoxFlights.ItemHeight = 28;
            this.listBoxFlights.Location = new System.Drawing.Point(520, 150);
            this.listBoxFlights.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFlights.Name = "listBoxFlights";
            this.listBoxFlights.ScrollAlwaysVisible = true;
            this.listBoxFlights.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxFlights.Size = new System.Drawing.Size(1380, 704);
            this.listBoxFlights.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxInt);
            this.groupBox1.Controls.Add(this.checkBoxDom);
            this.groupBox1.Controls.Add(this.radioButtonAlle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxDeparture);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxArrival);
            this.groupBox1.Controls.Add(this.radioButton50Meer);
            this.groupBox1.Controls.Add(this.radioButton75Meer);
            this.groupBox1.Controls.Add(this.radioButton90Meer);
            this.groupBox1.Location = new System.Drawing.Point(18, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(446, 775);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filteren";
            // 
            // checkBoxInt
            // 
            this.checkBoxInt.AutoSize = true;
            this.checkBoxInt.Checked = true;
            this.checkBoxInt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInt.Location = new System.Drawing.Point(28, 569);
            this.checkBoxInt.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxInt.Name = "checkBoxInt";
            this.checkBoxInt.Size = new System.Drawing.Size(225, 29);
            this.checkBoxInt.TabIndex = 9;
            this.checkBoxInt.Text = "International flights";
            this.checkBoxInt.UseVisualStyleBackColor = true;
            // 
            // checkBoxDom
            // 
            this.checkBoxDom.AutoSize = true;
            this.checkBoxDom.Checked = true;
            this.checkBoxDom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDom.Location = new System.Drawing.Point(28, 513);
            this.checkBoxDom.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxDom.Name = "checkBoxDom";
            this.checkBoxDom.Size = new System.Drawing.Size(196, 29);
            this.checkBoxDom.TabIndex = 8;
            this.checkBoxDom.Text = "Domestic flights";
            this.checkBoxDom.UseVisualStyleBackColor = true;
            // 
            // radioButtonAlle
            // 
            this.radioButtonAlle.AutoSize = true;
            this.radioButtonAlle.Checked = true;
            this.radioButtonAlle.Location = new System.Drawing.Point(28, 254);
            this.radioButtonAlle.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonAlle.Name = "radioButtonAlle";
            this.radioButtonAlle.Size = new System.Drawing.Size(164, 29);
            this.radioButtonAlle.TabIndex = 7;
            this.radioButtonAlle.TabStop = true;
            this.radioButtonAlle.Text = "alle vluchten";
            this.radioButtonAlle.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Departure";
            // 
            // textBoxDeparture
            // 
            this.textBoxDeparture.Location = new System.Drawing.Point(22, 88);
            this.textBoxDeparture.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDeparture.Name = "textBoxDeparture";
            this.textBoxDeparture.Size = new System.Drawing.Size(306, 31);
            this.textBoxDeparture.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Arrival";
            // 
            // textBoxArrival
            // 
            this.textBoxArrival.Location = new System.Drawing.Point(22, 173);
            this.textBoxArrival.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxArrival.Name = "textBoxArrival";
            this.textBoxArrival.Size = new System.Drawing.Size(306, 31);
            this.textBoxArrival.TabIndex = 3;
            // 
            // radioButton50Meer
            // 
            this.radioButton50Meer.AutoSize = true;
            this.radioButton50Meer.Location = new System.Drawing.Point(28, 433);
            this.radioButton50Meer.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton50Meer.Name = "radioButton50Meer";
            this.radioButton50Meer.Size = new System.Drawing.Size(182, 29);
            this.radioButton50Meer.TabIndex = 2;
            this.radioButton50Meer.Text = "meer dan 50%";
            this.radioButton50Meer.UseVisualStyleBackColor = true;
            // 
            // radioButton75Meer
            // 
            this.radioButton75Meer.AutoSize = true;
            this.radioButton75Meer.Location = new System.Drawing.Point(28, 379);
            this.radioButton75Meer.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton75Meer.Name = "radioButton75Meer";
            this.radioButton75Meer.Size = new System.Drawing.Size(182, 29);
            this.radioButton75Meer.TabIndex = 1;
            this.radioButton75Meer.Text = "meer dan 75%";
            this.radioButton75Meer.UseVisualStyleBackColor = true;
            // 
            // radioButton90Meer
            // 
            this.radioButton90Meer.AutoSize = true;
            this.radioButton90Meer.Location = new System.Drawing.Point(28, 317);
            this.radioButton90Meer.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton90Meer.Name = "radioButton90Meer";
            this.radioButton90Meer.Size = new System.Drawing.Size(182, 29);
            this.radioButton90Meer.TabIndex = 0;
            this.radioButton90Meer.Text = "meer dan 90%";
            this.radioButton90Meer.UseVisualStyleBackColor = true;
            // 
            // labelAantalVluchten
            // 
            this.labelAantalVluchten.AutoSize = true;
            this.labelAantalVluchten.Location = new System.Drawing.Point(520, 106);
            this.labelAantalVluchten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAantalVluchten.Name = "labelAantalVluchten";
            this.labelAantalVluchten.Size = new System.Drawing.Size(160, 25);
            this.labelAantalVluchten.TabIndex = 3;
            this.labelAantalVluchten.Text = "Aantal vluchten";
            // 
            // FormFlightApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1722, 919);
            this.Controls.Add(this.labelAantalVluchten);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxFlights);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFlightApp";
            this.Text = "FlightApp";
            this.Load += new System.EventHandler(this.FormFlightApp_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxFlights;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton50Meer;
        private System.Windows.Forms.RadioButton radioButton90Meer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDeparture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxArrival;
        private System.Windows.Forms.RadioButton radioButtonAlle;
        private System.Windows.Forms.Label labelAantalVluchten;
        private System.Windows.Forms.RadioButton radioButton75Meer;
        private System.Windows.Forms.CheckBox checkBoxInt;
        private System.Windows.Forms.CheckBox checkBoxDom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auteurToolStripMenuItem;
    }
}

