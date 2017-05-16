using System;
using System.Windows.Forms;

namespace Maps.NET
{
    [System.Runtime.InteropServices.ComVisible(true)]

    public partial class frmStreetView : Form
    {
        public frmStreetView()
        {
            InitializeComponent();
        }

        System.Threading.Thread MyThread;
        string BrowserURL;

        private void frmStreetView_Load(object sender, EventArgs e)
        {
            BrowserURL = Application.StartupPath + @"\html\streetview.html";
            MyThread = new System.Threading.Thread(new System.Threading.ThreadStart(CargarMapa));
            MyThread.Start();
        }

        public void CargarMapa()
        {
            webBrowserMap.Url = new Uri(BrowserURL);
            webBrowserMap.ObjectForScripting = this;
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
    }
}
