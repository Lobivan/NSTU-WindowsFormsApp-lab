using Lab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddDialogue : Form
    {
        public string Res { get; set; }
        public AddDialogue()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "")
            {
                MessageBox.Show("Поле 'Название цеха' не должно быть пустым!", 
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tb_boss.Text == "")
            {
                MessageBox.Show("Поле 'Начальник цеха' не должно быть пустым!", 
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tb_worker_count.Text == "")
            {
                MessageBox.Show("Поле 'Количество работников цеха' не должно быть пустым!",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Int32.TryParse(tb_worker_count.Text, out _) == false)
            {
                MessageBox.Show("Поле 'Количество работников цеха' должно быть целым числом!",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            grid_products.AllowUserToAddRows = false;
            foreach (DataGridViewRow row in grid_products.Rows)
            {
                if (row.Cells[0].Value is null)
                {
                    MessageBox.Show("Поле 'Наименование' у каждого изделия не должно быть пустым!",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    grid_products.AllowUserToAddRows = true;
                    return;
                }
                if (row.Cells[1].Value is null)
                {
                    MessageBox.Show("Поле 'ID' у каждого изделия не должно быть пустым!",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    grid_products.AllowUserToAddRows = true;
                    return;
                }
                if (Int32.TryParse(row.Cells[1].Value as string, out _) == false)
                {
                    MessageBox.Show("Поле 'ID' у каждого изделия должно быть целым числом!",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    grid_products.AllowUserToAddRows = true;
                    return;
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
