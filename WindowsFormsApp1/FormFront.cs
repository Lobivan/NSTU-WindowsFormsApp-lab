using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Lab
{
    public partial class FormFront : System.Windows.Forms.Form
    {
        public FormFront()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var form = new AddDialogue())
            {
                var res = form.ShowDialog();
                if (res == DialogResult.OK)
                {
                    Workshop ws = new Workshop(form.tb_name.Text, Int32.Parse(form.tb_worker_count.Text), form.tb_boss.Text);
                    for (int i = 0; i < form.grid_products.RowCount; i++){
                        string PName = form.grid_products[0, i].Value as string;
                        Int32.TryParse(form.grid_products[1, i].Value as string, out int PID);
                        ws.Products.Add(new Product(PName, PID));
                    }
                    list_workshops.Items.Add(ws);
                }
            }
        }

        private void btn_inspect_Click(object sender, EventArgs e)
        {
            Workshop ws = list_workshops.SelectedItem as Workshop;
            if (ws is null)
            {
                MessageBox.Show("Выберите цех из списка!", "Цех не выбран", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var form = new AddDialogue())
            {
                form.tb_name.Text += ws.Name;
                form.tb_boss.Text += ws.Boss;
                form.tb_worker_count.Text += ws.WorkerCount;
                for (int i = 0; i < ws.Products.Count; i++)
                {
                    var index = form.grid_products.Rows.Add();
                    form.grid_products[0, index].Value = ws[i].Name;
                    form.grid_products[1, index].Value = ws[i].ID;
                }
                form.btn_add.Visible = false;
                form.btn_cancel.Text = "Закрыть";
                form.Text = "Просмотр информации о цехе";
                form.tb_boss.ReadOnly = true;
                form.tb_name.ReadOnly = true;
                form.tb_worker_count.ReadOnly = true;
                form.grid_products.ReadOnly = true;
                form.grid_products.AllowUserToAddRows = false;
                form.grid_products.AllowUserToDeleteRows = false;
                form.ShowDialog();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Workshop ws = list_workshops.SelectedItem as Workshop;
            if (ws is null)
            {
                MessageBox.Show("Выберите цех из списка!", "Цех не выбран", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Удалить цех " + ws.Name + "?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                list_workshops.Items.Remove(ws);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Workshop ws = list_workshops.SelectedItem as Workshop;
            if (ws is null)
            {
                MessageBox.Show("Выберите цех из списка!", "Цех не выбран", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var form = new AddDialogue())
            {
                form.tb_name.Text += ws.Name;
                form.tb_boss.Text += ws.Boss;
                form.tb_worker_count.Text += ws.WorkerCount;
                for (int i = 0; i < ws.Products.Count; i++)
                {
                    var index = form.grid_products.Rows.Add();
                    form.grid_products[0, index].Value = ws[i].Name;
                    form.grid_products[1, index].Value = ws[i].ID.ToString();
                }
                form.btn_add.Text = "Изменить";
                var res = form.ShowDialog();
                if (res == DialogResult.OK)
                {
                    Workshop ws_new = new Workshop(form.tb_name.Text, Int32.Parse(form.tb_worker_count.Text), form.tb_boss.Text);
                    for (int i = 0; i < form.grid_products.RowCount; i++)
                    {
                        string PName = form.grid_products[0, i].Value as string;
                        Int32.TryParse(form.grid_products[1, i].Value as string, out int PID);
                        ws_new.Products.Add(new Product(PName, PID));
                    }
                    list_workshops.Items.Insert(list_workshops.SelectedIndex, ws_new);
                    list_workshops.Items.Remove(ws);
                    list_workshops.Refresh();
                }
            }
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            string app_version = "Версия программы - 1.0";
            string developer = "Разработчик - Лобанов Иван Сергеевич";
            string dev_org = "Новосибирский государственный технический университет";
            using (var form = new FormInfo())
            {
                form.lbl_info.Text += app_version + "\n"
                                    + developer + '\n'
                                    + dev_org;
                form.ShowDialog();
            }
        }

        private void tsb_add_Click(object sender, EventArgs e)
        {
            btn_add_Click(sender, e);
        }
        private void tsb_inspect_Click(object sender, EventArgs e)
        {
            btn_inspect_Click(sender, e);
        }
        private void tsb_delete_Click(object sender, EventArgs e)
        {
            btn_delete_Click(sender, e);
        }
        private void tsb_edit_Click(object sender, EventArgs e)
        {
            btn_edit_Click(sender, e);
        }
        private void tsb_info_Click(object sender, EventArgs e)
        {
            btn_info_Click(sender, e);
        }
    }
}
