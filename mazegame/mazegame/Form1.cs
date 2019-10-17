using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mazegame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void finish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Congraulation!");
            Close();
        }
        private void MoveToStart();
        {
            Point startingPoint = Panel.location;
            StartingPoint.Offset(10,10);
            Cursor.Postion = PointToScreen(StartingPoint);

        private void well_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }
    }
    }
}
