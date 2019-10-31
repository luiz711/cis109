using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter
{
    public partial class currencyConverter : Form
    {
        public currencyConverter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebBrowser.Navigate("https://www.foreignexchangeresource.com/currency-converter.php?c=CAD&a=USD&amt=1&panel=1&button=2");
        }
    }
}
