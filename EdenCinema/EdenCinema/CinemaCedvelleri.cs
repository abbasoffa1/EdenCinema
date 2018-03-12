using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdenCinema
{
    public partial class CinemaCedvelleri : Form
    {
        public CinemaCedvelleri()
        {
            InitializeComponent();
        }

        private void fast_btn_Click(object sender, EventArgs e)
        {
            FastFurious movie03 = new FastFurious();
            movie03.Show();
        }

        private void CinemaCedvelleri_Load(object sender, EventArgs e)
        {
            
        }

        private void overdrive_btn_Click(object sender, EventArgs e)
        {
            overdrive movie01 = new overdrive();
            movie01.Show();
        }

        private void baby_btn_Click(object sender, EventArgs e)
        {
            BabyDriver movie02 = new BabyDriver();
            movie02.Show();

        }

        private void nysm2_btn_Click(object sender, EventArgs e)
        {
            NowYouSeeMe2 movie04 = new NowYouSeeMe2();
            movie04.Show();
        }
    }
}
