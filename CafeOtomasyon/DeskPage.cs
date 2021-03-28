using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyon
{
    public partial class DeskPage : Form
    {
        public DeskPage()
        {
            InitializeComponent();
        }

        private void DeskPage_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cafeOtomasyonDataSet.Urun_Tablosu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urun_TablosuTableAdapter.Fill(this.cafeOtomasyonDataSet.Urun_Tablosu);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
