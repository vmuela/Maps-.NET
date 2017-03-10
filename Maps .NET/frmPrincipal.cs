using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maps.NET
{
    [System.Runtime.InteropServices.ComVisible(true)]

    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        System.Threading.Thread MyThread;
        string BrowserURL;

        private void frmMain_Load(object sender, EventArgs e)
        {
            BrowserURL = Application.ExecutablePath;
            BrowserURL = BrowserURL.Substring(0, BrowserURL.LastIndexOf("\\"));
            BrowserURL = System.IO.Path.Combine(BrowserURL, @"html\googlemaps.html");
            MyThread = new System.Threading.Thread(new System.Threading.ThreadStart(CargarMapa));
            MyThread.Start();
        }

        public void CargarMapa()
        {
            webBrowserMap.Url = new Uri(BrowserURL);
            webBrowserMap.ObjectForScripting = this;
        }

        public void mapPositionChange(double lat, double lon, int zoom, string latcentro, string loncentro)
        {
            lblLatitud.Text = lat.ToString();
            lblLongitud.Text = lon.ToString();
            if (zoom != 0)
            {
                lblZoom.Text = zoom.ToString();
            }
        }

        public void mapZoomChange(int zoom)
        {
            lblZoom.Text = zoom.ToString();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
