
namespace Money
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelSol;
        private System.Windows.Forms.Panel panelSag;
        private System.Windows.Forms.Label lblBasliq;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            panelSol = new System.Windows.Forms.Panel();
            panelSag = new System.Windows.Forms.Panel();
            lblBasliq = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);

            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();

            panelSol.SuspendLayout();
            panelSag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();

            // FORM
            Text = "Money";
            ClientSize = new System.Drawing.Size(740, 480);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            BackColor = System.Drawing.Color.Teal;

            // SOL PANEL
            panelSol.Location = new System.Drawing.Point(0, 0);
            panelSol.Size = new System.Drawing.Size(255, 480);
            panelSol.BackColor = System.Drawing.Color.DarkOrange;

            // BAŞLIQ
            lblBasliq.Text = "Xırdalanacaq məbləğ";
            lblBasliq.Location = new System.Drawing.Point(10, 145);
            lblBasliq.Size = new System.Drawing.Size(230, 30);
            lblBasliq.Font = new System.Drawing.Font(
                "Arial", 11, System.Drawing.FontStyle.Bold);

            // MƏBLƏĞ XANASI
            textBox1.Location = new System.Drawing.Point(10, 183);
            textBox1.Size = new System.Drawing.Size(225, 28);
            textBox1.Font = new System.Drawing.Font("Arial", 12);

            // XIRDALA DÜYMƏSİ
            button1.Location = new System.Drawing.Point(10, 230);
            button1.Size = new System.Drawing.Size(225, 48);
            button1.Text = "Xırdala";
            button1.Font = new System.Drawing.Font(
                "Arial", 12, System.Drawing.FontStyle.Bold);
            button1.Click += button1_Click;

            textBox1.TextChanged += textBox1_TextChanged;

            panelSol.Controls.Add(lblBasliq);
            panelSol.Controls.Add(textBox1);
            panelSol.Controls.Add(button1);

            // SAĞ PANEL
            panelSag.Location = new System.Drawing.Point(255, 0);
            panelSag.Size = new System.Drawing.Size(485, 480);
            panelSag.BackColor = System.Drawing.Color.Teal;

            System.Windows.Forms.Label[] labels =
            {
                label1, label2, label3, label4,
                label5, label6, label7, label8
            };

            string[] adlar =
            {
                "1 manat", "5 manat", "10 manat", "20 manat",
                "50 manat", "100 manat", "200 manat", "500 manat"
            };

            int[] xs = { 25, 25, 25, 25, 250, 250, 250, 250 };
            int[] ys = { 35, 145, 255, 365, 35, 145, 255, 365 };

            for (int i = 0; i < 8; i++)
            {
                labels[i].Text = adlar[i] + " : 0 ədəd";
                labels[i].Location =
                    new System.Drawing.Point(xs[i], ys[i]);
                labels[i].Size = new System.Drawing.Size(210, 35);
                labels[i].Font = new System.Drawing.Font(
                    "Arial", 12, System.Drawing.FontStyle.Bold);
                labels[i].ForeColor = System.Drawing.Color.White;
                labels[i].Visible = false;

                panelSag.Controls.Add(labels[i]);
            }

            errorProvider1.ContainerControl = this;
            errorProvider1.BlinkStyle =
                System.Windows.Forms.ErrorBlinkStyle.NeverBlink;

            Controls.Add(panelSag);
            Controls.Add(panelSol);

            panelSol.ResumeLayout(false);
            panelSol.PerformLayout();
            panelSag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }
    }
}