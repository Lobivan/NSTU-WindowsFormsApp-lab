namespace WindowsFormsApp1
{
    partial class AddDialogue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_boss = new System.Windows.Forms.TextBox();
            this.lbl_boss = new System.Windows.Forms.Label();
            this.lbl_worker_amount = new System.Windows.Forms.Label();
            this.tb_worker_count = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.grid_products = new System.Windows.Forms.DataGridView();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_products)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(12, 9);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(83, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Название цеха";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(12, 25);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(263, 20);
            this.tb_name.TabIndex = 1;
            // 
            // tb_boss
            // 
            this.tb_boss.Location = new System.Drawing.Point(12, 64);
            this.tb_boss.Name = "tb_boss";
            this.tb_boss.Size = new System.Drawing.Size(263, 20);
            this.tb_boss.TabIndex = 3;
            // 
            // lbl_boss
            // 
            this.lbl_boss.AutoSize = true;
            this.lbl_boss.Location = new System.Drawing.Point(12, 48);
            this.lbl_boss.Name = "lbl_boss";
            this.lbl_boss.Size = new System.Drawing.Size(88, 13);
            this.lbl_boss.TabIndex = 2;
            this.lbl_boss.Text = "Начальник цеха";
            // 
            // lbl_worker_amount
            // 
            this.lbl_worker_amount.AutoSize = true;
            this.lbl_worker_amount.Location = new System.Drawing.Point(12, 87);
            this.lbl_worker_amount.Name = "lbl_worker_amount";
            this.lbl_worker_amount.Size = new System.Drawing.Size(154, 13);
            this.lbl_worker_amount.TabIndex = 4;
            this.lbl_worker_amount.Text = "Количество работников цеха";
            // 
            // tb_worker_count
            // 
            this.tb_worker_count.Location = new System.Drawing.Point(12, 103);
            this.tb_worker_count.Name = "tb_worker_count";
            this.tb_worker_count.Size = new System.Drawing.Size(263, 20);
            this.tb_worker_count.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(28, 171);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(162, 171);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // grid_products
            // 
            this.grid_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PName,
            this.PID});
            this.grid_products.Location = new System.Drawing.Point(353, 25);
            this.grid_products.Name = "grid_products";
            this.grid_products.Size = new System.Drawing.Size(400, 377);
            this.grid_products.TabIndex = 8;
            // 
            // PName
            // 
            this.PName.HeaderText = "Наименование";
            this.PName.Name = "PName";
            // 
            // PID
            // 
            this.PID.HeaderText = "ID";
            this.PID.Name = "PID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Перечень номенклатуры выпускаемых изделий";
            // 
            // AddDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_products);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_worker_count);
            this.Controls.Add(this.lbl_worker_amount);
            this.Controls.Add(this.tb_boss);
            this.Controls.Add(this.lbl_boss);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lbl_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddDialogue";
            this.Text = "Добавление Цеха";
            ((System.ComponentModel.ISupportInitialize)(this.grid_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_boss;
        private System.Windows.Forms.Label lbl_worker_amount;
        public System.Windows.Forms.TextBox tb_name;
        public System.Windows.Forms.TextBox tb_boss;
        public System.Windows.Forms.TextBox tb_worker_count;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView grid_products;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.Button btn_cancel;
    }
}