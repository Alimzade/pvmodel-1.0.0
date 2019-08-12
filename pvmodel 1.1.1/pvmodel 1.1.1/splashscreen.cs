using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pvmodel_1._1._1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Timer2_Tick_1(object sender, EventArgs e)
        {
            progressBar1.Increment(5);
            if (progressBar1.Value == 100)
            {
                timer2.Stop();
                this.Close();
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true; //timer nesnesini başlatıyoruz.
            progressBar1.Visible = true; //progressBar nesnesinin gözükmesini istiyorsanız bu değeri true yapabilirsiniz.

            this.BackColor = Color.LimeGreen; //Bekletme ekranının saydam olması için BackColor ile TransparencyKey rengini aynı belirliyoruz.
            this.TransparencyKey = Color.LimeGreen;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ImageEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

