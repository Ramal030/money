
using System;
using System.Windows.Forms;

namespace Money
{
    public partial class Form1 : Form
    {
        private readonly int[] nominallar =
            { 1, 5, 10, 20, 50, 100, 200, 500 };

        public Form1()
        {
            InitializeComponent();
        }

        private void NeticeleriTemizle()
        {
            Label[] labels =
            {
                label1, label2, label3, label4,
                label5, label6, label7, label8
            };

            foreach (Label lbl in labels)
            {
                lbl.Visible = false;
                lbl.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
                errorProvider1.SetError(textBox1, "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NeticeleriTemizle();

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(
                    textBox1, "Məbləğ daxil edin");
                textBox1.Focus();
                return;
            }

            errorProvider1.SetError(textBox1, "");

            long mebleg;

            if (!long.TryParse(textBox1.Text.Trim(), out mebleg))
            {
                MessageBox.Show(
                    "Düzgün məbləğ daxil edin.",
                    "Diqqət",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (mebleg <= 0)
            {
                MessageBox.Show(
                    "Mənfi və ya sıfır məbləğ xırdalanmaz",
                    "Diqqət",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            Label[] labels =
            {
                label1, label2, label3, label4,
                label5, label6, label7, label8
            };

            for (int i = nominallar.Length - 1; i >= 0; i--)
            {
                long say = mebleg / nominallar[i];

                if (say > 0)
                {
                    labels[i].Text =
                        nominallar[i] + " manat : " + say + " ədəd";

                    labels[i].Visible = true;
                    mebleg %= nominallar[i];
                }
            }
        }
    }
}