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

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
