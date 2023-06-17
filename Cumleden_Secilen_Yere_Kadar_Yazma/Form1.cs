using System;
using System.Windows.Forms;

namespace Cumleden_Secilen_Yere_Kadar_Yazma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle, kelime, harf, kesilen_kelime;
            int kontrol = 0;
            textBox3.Clear();

            cumle = textBox1.Text;
            kelime = textBox2.Text;

            foreach (char item in cumle) if (item == Convert.ToChar(" ")) kontrol += 1;

            if (kontrol > 0)
            {
                if (kelime == "") textBox3.Text = textBox1.Text;
                else
                {
                    for (int i = 0; i < cumle.Length; i++)
                    {
                        harf = cumle.Substring(i, 1);

                        if (harf == " ")
                        {
                            kesilen_kelime = cumle.Substring(++i, kelime.Length);

                            if (kesilen_kelime == kelime) break;
                            else --i;
                        }
                        textBox3.Text += harf;
                    }
                }
            }
            else MessageBox.Show("En az 2 kelime yazmalısınız");
        }
    }
}
