﻿namespace Maps.NET
{
    partial class frmStreetView
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
            this.webBrowserMap = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserMap
            // 
            this.webBrowserMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserMap.Location = new System.Drawing.Point(0, 0);
            this.webBrowserMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMap.Name = "webBrowserMap";
            this.webBrowserMap.ScriptErrorsSuppressed = true;
            this.webBrowserMap.ScrollBarsEnabled = false;
            this.webBrowserMap.Size = new System.Drawing.Size(584, 361);
            this.webBrowserMap.TabIndex = 3;
            this.webBrowserMap.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // frmStreetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.webBrowserMap);
            this.Name = "frmStreetView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Street View";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmStreetView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserMap;
    }
}