namespace Maps.NET
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdGoogleMaps = new System.Windows.Forms.ToolStripButton();
            this.cmdBingMaps = new System.Windows.Forms.ToolStripButton();
            this.cmdStreetView = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdSalir = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblZoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLatitud = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLongitud = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webBrowserMap = new System.Windows.Forms.WebBrowser();
            this.txtEventos = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdGoogleMaps,
            this.cmdBingMaps,
            this.cmdStreetView,
            this.toolStripSeparator1,
            this.cmdSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdGoogleMaps
            // 
            this.cmdGoogleMaps.Image = ((System.Drawing.Image)(resources.GetObject("cmdGoogleMaps.Image")));
            this.cmdGoogleMaps.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdGoogleMaps.Name = "cmdGoogleMaps";
            this.cmdGoogleMaps.Size = new System.Drawing.Size(97, 22);
            this.cmdGoogleMaps.Text = "Google Maps";
            this.cmdGoogleMaps.Click += new System.EventHandler(this.cmdGoogleMaps_Click);
            // 
            // cmdBingMaps
            // 
            this.cmdBingMaps.Image = ((System.Drawing.Image)(resources.GetObject("cmdBingMaps.Image")));
            this.cmdBingMaps.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdBingMaps.Name = "cmdBingMaps";
            this.cmdBingMaps.Size = new System.Drawing.Size(83, 22);
            this.cmdBingMaps.Text = "Bing Maps";
            this.cmdBingMaps.Click += new System.EventHandler(this.cmdBingMaps_Click);
            // 
            // cmdStreetView
            // 
            this.cmdStreetView.Image = ((System.Drawing.Image)(resources.GetObject("cmdStreetView.Image")));
            this.cmdStreetView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdStreetView.Name = "cmdStreetView";
            this.cmdStreetView.Size = new System.Drawing.Size(85, 22);
            this.cmdStreetView.Text = "Street View";
            this.cmdStreetView.Click += new System.EventHandler(this.cmdStreetView_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.Image")));
            this.cmdSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(49, 22);
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.lblZoom,
            this.toolStripStatusLabel1,
            this.lblLatitud,
            this.toolStripStatusLabel3,
            this.lblLongitud});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel2.Text = "Zoom:";
            // 
            // lblZoom
            // 
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(13, 17);
            this.lblZoom.Text = "0";
            this.lblZoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(26, 17);
            this.toolStripStatusLabel1.Text = "Lat:";
            // 
            // lblLatitud
            // 
            this.lblLatitud.Name = "lblLatitud";
            this.lblLatitud.Size = new System.Drawing.Size(13, 17);
            this.lblLatitud.Text = "0";
            this.lblLatitud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(30, 17);
            this.toolStripStatusLabel3.Text = "Lon:";
            // 
            // lblLongitud
            // 
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(13, 17);
            this.lblLongitud.Text = "0";
            this.lblLongitud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.webBrowserMap);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtEventos);
            this.splitContainer1.Size = new System.Drawing.Size(784, 514);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 3;
            // 
            // webBrowserMap
            // 
            this.webBrowserMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserMap.Location = new System.Drawing.Point(0, 0);
            this.webBrowserMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMap.Name = "webBrowserMap";
            this.webBrowserMap.ScriptErrorsSuppressed = true;
            this.webBrowserMap.ScrollBarsEnabled = false;
            this.webBrowserMap.Size = new System.Drawing.Size(782, 398);
            this.webBrowserMap.TabIndex = 3;
            this.webBrowserMap.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // txtEventos
            // 
            this.txtEventos.BackColor = System.Drawing.Color.White;
            this.txtEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEventos.Location = new System.Drawing.Point(0, 0);
            this.txtEventos.Name = "txtEventos";
            this.txtEventos.ReadOnly = true;
            this.txtEventos.Size = new System.Drawing.Size(782, 108);
            this.txtEventos.TabIndex = 7;
            this.txtEventos.Text = "";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maps .NET";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cmdSalir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblLatitud;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblLongitud;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblZoom;
        private System.Windows.Forms.ToolStripButton cmdGoogleMaps;
        private System.Windows.Forms.ToolStripButton cmdBingMaps;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cmdStreetView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser webBrowserMap;
        private System.Windows.Forms.RichTextBox txtEventos;
    }
}

