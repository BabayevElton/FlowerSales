using System.Drawing;
using System.Windows.Forms;

namespace FlowerSales
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();

            // dataGridView1
            this.dataGridView1.AllowUserToAddRows = true;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = Color.FromArgb(160, 160, 160);
            this.dataGridView1.BorderStyle = BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.Black,
                SelectionBackColor = Color.White,
                SelectionForeColor = Color.Black,
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                WrapMode = DataGridViewTriState.True
            };
            this.dataGridView1.ColumnHeadersHeight = 44;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colName, this.colCount, this.colPrice, this.colTotal });
            this.dataGridView1.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.Black,
                SelectionBackColor = Color.FromArgb(0, 120, 215),
                SelectionForeColor = Color.White
            };
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = Color.FromArgb(160, 160, 160);
            this.dataGridView1.Location = new Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 48;
            this.dataGridView1.RowHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                SelectionBackColor = Color.White
            };
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new Size(800, 288);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;

            // columns
            this.colName.HeaderText = "Gül növü (gül adı)";
            this.colName.Name = "colName";
            this.colName.Width = 376;
            this.colName.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.colCount.HeaderText = "Satış sayı";
            this.colCount.Name = "colCount";
            this.colCount.Width = 125;
            this.colCount.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.colPrice.HeaderText = "Qiyməti";
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 125;
            this.colPrice.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.colTotal.HeaderText = "Yekun qiyməti";
            this.colTotal.Name = "colTotal";
            this.colTotal.Width = 126;
            this.colTotal.SortMode = DataGridViewColumnSortMode.NotSortable;

            // groupBox1
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.FlatStyle = FlatStyle.Flat;
            this.groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            this.groupBox1.ForeColor = Color.White;
            this.groupBox1.Location = new Point(12, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(413, 235);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gül məlumatları";

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            this.label1.ForeColor = Color.White;
            this.label1.Location = new Point(38, 48);
            this.label1.Name = "label1";
            this.label1.Text = "Gül növü";

            // textBox1
            this.textBox1.BorderStyle = BorderStyle.FixedSingle;
            this.textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            this.textBox1.ForeColor = Color.Black;
            this.textBox1.BackColor = Color.White;
            this.textBox1.Location = new Point(36, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(195, 27);
            this.textBox1.TabIndex = 0;

            // pictureBox1 (qızılgül)
            this.pictureBox1.BackColor = Color.Transparent;
            this.pictureBox1.Location = new Point(285, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(88, 92);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabStop = false;

            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            this.label2.ForeColor = Color.White;
            this.label2.Location = new Point(38, 135);
            this.label2.Name = "label2";
            this.label2.Text = "Say";

            // label3
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            this.label3.ForeColor = Color.White;
            this.label3.Location = new Point(166, 135);
            this.label3.Name = "label3";
            this.label3.Text = "Qiymət";

            // textBox2 (say)
            this.textBox2.BorderStyle = BorderStyle.FixedSingle;
            this.textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            this.textBox2.ForeColor = Color.Black;
            this.textBox2.BackColor = Color.White;
            this.textBox2.Location = new Point(36, 161);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(68, 27);
            this.textBox2.TabIndex = 1;

            // textBox3 (qiymət)
            this.textBox3.BorderStyle = BorderStyle.FixedSingle;
            this.textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            this.textBox3.ForeColor = Color.Black;
            this.textBox3.BackColor = Color.White;
            this.textBox3.Location = new Point(163, 161);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Size(74, 27);
            this.textBox3.TabIndex = 2;

            // button1 (Satış et)
            this.button1.BackColor = Color.Maroon;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.FlatAppearance.BorderColor = Color.White;
            this.button1.FlatAppearance.BorderSize = 1;
            this.button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            this.button1.ForeColor = Color.White;
            this.button1.Location = new Point(272, 131);
            this.button1.Name = "button1";
            this.button1.Size = new Size(106, 78);
            this.button1.TabIndex = 3;
            this.button1.Text = "Satış et";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // label4 (Toplam gəlir:)
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            this.label4.ForeColor = Color.White;
            this.label4.Location = new Point(560, 308);
            this.label4.Name = "label4";
            this.label4.Text = "Toplam gəlir:";

            // label5 (məbləğ)
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            this.label5.ForeColor = Color.White;
            this.label5.Location = new Point(706, 308);
            this.label5.Name = "label5";
            this.label5.Text = "0.00";

            // pictureBox2 (dibçək)
            this.pictureBox2.BackColor = Color.Transparent;
            this.pictureBox2.Location = new Point(610, 362);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Size(160, 205);
            this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabStop = false;

            // button2 (Çıxış) - dibçəyin üzərində
            this.button2.BackColor = Color.FromArgb(255, 224, 185);
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            this.button2.ForeColor = Color.Black;
            this.button2.Location = new Point(676, 523);
            this.button2.Name = "button2";
            this.button2.Size = new Size(54, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "Çıxış";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);

            // Form1
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Purple;
            this.ClientSize = new Size(800, 573);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Gül satışı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCount;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colTotal;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
        private Button button2;
    }
}
