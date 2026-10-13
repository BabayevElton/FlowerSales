using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace FlowerSales
{
    public partial class Form1 : Form
    {
        private decimal totalIncome = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Şəkillər exe-nin yanındakı Images qovluğundan yüklənir
            string imgDir = Path.Combine(AppContext.BaseDirectory, "Images");
            LoadImage(pictureBox1, Path.Combine(imgDir, "flover.png"));
            LoadImage(pictureBox2, Path.Combine(imgDir, "dibçək.png"));
            label5.Text = totalIncome.ToString("F2");
            textBox1.Focus();
        }

        private static void LoadImage(PictureBox box, string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        box.Image = new Bitmap(fs);
                    }
                }
                else
                {
                    MessageBox.Show("Şəkil tapılmadı: " + path, "Xəta",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Şəkil yüklənmədi: " + ex.Message, "Xəta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Satış et
        private void button1_Click(object sender, EventArgs e)
        {
            // 1) Boşluq yoxlaması
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Gül növünü daxil edin!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Sayı daxil edin!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Qiyməti daxil edin!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }

            // 2) Format yoxlaması
            if (!int.TryParse(textBox2.Text.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out int count))
            {
                MessageBox.Show("Say yalnız tam ədəd olmalıdır!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                textBox2.SelectAll();
                return;
            }

            // Vergül də qəbul edilir (7,8 -> 7.8)
            string priceText = textBox3.Text.Trim().Replace(',', '.');
            if (!decimal.TryParse(priceText, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal price))
            {
                MessageBox.Show("Qiymət düzgün ədəd olmalıdır!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                textBox3.SelectAll();
                return;
            }

            // 3) Mənfi və sıfır yoxlaması
            if (count <= 0)
            {
                MessageBox.Show("Say sıfır və ya mənfi ola bilməz!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                textBox2.SelectAll();
                return;
            }
            if (price <= 0)
            {
                MessageBox.Show("Qiymət sıfır və ya mənfi ola bilməz!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                textBox3.SelectAll();
                return;
            }

            // 4) Hesablama və cədvələ əlavə
            decimal result = count * price;
            dataGridView1.Rows.Add(textBox1.Text.Trim(), count.ToString(), price.ToString(), result.ToString("F2"));

            // 5) Toplam gəlir
            totalIncome += result;
            label5.Text = totalIncome.ToString("F2");

            // 6) Xanaların sıfırlanması
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        // Çıxış
        private void button2_Click(object sender, EventArgs e)
        {
            if (AskYesNo("Çıxış edilsinmi?", "Çıxış"))
            {
                Application.Exit();
            }
        }

        // "Hə" / "Nə" düymələri olan sual pəncərəsi
        private static bool AskYesNo(string question, string title)
        {
            using (var dlg = new Form())
            {
                dlg.Text = title;
                dlg.FormBorderStyle = FormBorderStyle.FixedDialog;
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.MaximizeBox = false;
                dlg.MinimizeBox = false;
                dlg.ShowInTaskbar = false;
                dlg.ClientSize = new Size(300, 120);

                var lbl = new Label
                {
                    Text = question,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(10, 15),
                    Size = new Size(280, 40),
                    Font = new Font("Segoe UI", 10.5F)
                };
                var btnYes = new Button
                {
                    Text = "Hə",
                    DialogResult = DialogResult.Yes,
                    Location = new Point(55, 70),
                    Size = new Size(85, 32)
                };
                var btnNo = new Button
                {
                    Text = "Nə",
                    DialogResult = DialogResult.No,
                    Location = new Point(160, 70),
                    Size = new Size(85, 32)
                };

                dlg.Controls.Add(lbl);
                dlg.Controls.Add(btnYes);
                dlg.Controls.Add(btnNo);
                dlg.AcceptButton = btnYes;
                dlg.CancelButton = btnNo;

                return dlg.ShowDialog() == DialogResult.Yes;
            }
        }
    }
}
