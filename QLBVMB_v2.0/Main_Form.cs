using QLBVMB_v2._0.Login_Register;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QLBVMB_v2._0
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Password frm = new Change_Password();
            frm.TopLevel = false;
            panel_Show.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.Show();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    Button btn = new Button();
                    btn.Name = (i * 1 + 1 + j * 5).ToString();
                    btn.Size = new System.Drawing.Size(50, 40);
                    btn.TabIndex = 0;
                    btn.Text = (i * 1 + 1 + j * 5).ToString();
                    btn.Location = new Point(55 * i + 542, 45 * j + 200);
                    btn.UseVisualStyleBackColor = false;
                    btn.BackColor = Color.White;
                    //btn.Click += btn_Click;

                    panel_Show.Controls.Add(btn);
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            txt_Clock.Text = dt.ToString();
        }
    }
}
