using System;
using System.Drawing;
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
        frmStreetView VentanaStreetView;

        private void frmMain_Load(object sender, EventArgs e)
        {
            Text = "Maps .NET v" + Application.ProductVersion; 
            cmdGoogleMaps_Click(null, null);
        }

        public void CargarMapa()
        {
            webBrowserMap.Url = new Uri(BrowserURL);
            webBrowserMap.ObjectForScripting = this;
        }

        public void mapPositionChange(double lat, double lon, int zoom, double latcentro, double loncentro)
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

        public void executeScript(string scriptName, params object[] parameters)
        {
            try
            {
                webBrowserMap.Document.InvokeScript(scriptName, parameters);
            }
            catch
            {
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdGoogleMaps_Click(object sender, EventArgs e)
        {
            EscribeEvento("Cambiando a Google Maps...", Color.Black);
            BrowserURL = Application.StartupPath + @"\html\googlemaps.html";
            MyThread = new System.Threading.Thread(new System.Threading.ThreadStart(CargarMapa));
            MyThread.Start();
        }

        private void cmdBingMaps_Click(object sender, EventArgs e)
        {
            EscribeEvento("Cambiando a Bing Maps...", Color.Black);
            BrowserURL = Application.StartupPath + @"\html\bingmaps.html";
            MyThread = new System.Threading.Thread(new System.Threading.ThreadStart(CargarMapa));
            MyThread.Start();
        }

        private void cmdStreetView_Click(object sender, EventArgs e)
        {
            if (VentanaStreetView == null || VentanaStreetView.IsDisposed == true)
            {
                VentanaStreetView = new frmStreetView();
            }
            VentanaStreetView.Show();
        }

        private void EscribeEvento(string Evento, Color color)
        {
            txtEventos.SelectionColor = color;
            txtEventos.AppendText(DateTime.Now + ": " + Evento + "\n");
            
            txtEventos.SelectionStart = txtEventos.Text.Length;
            txtEventos.ScrollToCaret();
        }

        public void mapClicked(double lat, double lon)
        {
            //Street View
            GlobalClass.LatStreetView = lat;
            GlobalClass.LonStreetView = lon;

            if (VentanaStreetView != null && VentanaStreetView.IsDisposed == false)
            {
                VentanaStreetView.executeScript("EstablecerUbicacion", GlobalClass.LatStreetView, GlobalClass.LonStreetView);
            }

        }
    }
}
