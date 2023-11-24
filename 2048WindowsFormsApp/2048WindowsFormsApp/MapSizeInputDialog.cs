using _2048WindowsFormsApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class MapSizeInputDialog : Form
    {
        public MapSizeInputDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default.MapSizeSet = Convert.ToInt32(mapSizeTextBox.Text);
            Settings.Default.Save();

            Application.Restart();
        }
    }
}
