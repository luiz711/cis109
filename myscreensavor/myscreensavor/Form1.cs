using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myscreensavor
{
    public partial class frmscsaavor : Form
    {
        List<Image> BGImages = new List<Image>();

        List<BritPic> BritPics = new List<BritPic>();
        Random rand = new Random();

        class BritPic
        {
            public int PicNum;
            public float X;
            public float Y;
            public float speed;
        }
    



        public frmscsaavor()
        {
            InitializeComponent();
        }

        private void frmscsaavor_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }

        private void frmscsaavor_Load(object sender, EventArgs e)
        {
            string[] images = System.IO.Directory.GetFiles("pics");

            foreach (string images in Image)
            {
                BGImages.Add(new Bitmap(image));

            }


            for (int i = 0; i < 50; ++i);
            {
                BritPic mp = new BritPic();
                mp.PicNum = 1 % BGImages.Count;
                mp.X = rand.Next(0, Width);
                mp.X = rand.Next(0, Height);
                BritPic.Add(mp);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void frmscsaavor_Paint(object sender, PaintEventArgs e)
        {
            foreach (BritPic bp in BritPic)
                (
                    e.Graphics.DrawImage(BGImages[bp.PicNum],bp.X, bp.Y);
                    if (bp.X < -250)
                     { Bp.X = Width + rand.Next(20, 100);
                
            )
        }
    }
}
