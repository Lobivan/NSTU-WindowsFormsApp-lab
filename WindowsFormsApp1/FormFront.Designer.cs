namespace Lab
{
    partial class FormFront
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFront));
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_inspect = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.list_workshops = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_add = new System.Windows.Forms.ToolStripButton();
            this.tsb_inspect = new System.Windows.Forms.ToolStripButton();
            this.tsb_delete = new System.Windows.Forms.ToolStripButton();
            this.tsb_edit = new System.Windows.Forms.ToolStripButton();
            this.tsb_info = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(52, 40);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(166, 47);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_inspect
            // 
            this.btn_inspect.Location = new System.Drawing.Point(52, 93);
            this.btn_inspect.Name = "btn_inspect";
            this.btn_inspect.Size = new System.Drawing.Size(166, 47);
            this.btn_inspect.TabIndex = 1;
            this.btn_inspect.Text = "Посмотреть";
            this.btn_inspect.UseVisualStyleBackColor = true;
            this.btn_inspect.Click += new System.EventHandler(this.btn_inspect_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(52, 146);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(166, 47);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(52, 199);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(166, 47);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Редактировать";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_info
            // 
            this.btn_info.Location = new System.Drawing.Point(52, 252);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(166, 47);
            this.btn_info.TabIndex = 4;
            this.btn_info.Text = "Справка";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // list_workshops
            // 
            this.list_workshops.FormattingEnabled = true;
            this.list_workshops.HorizontalScrollbar = true;
            this.list_workshops.Location = new System.Drawing.Point(265, 40);
            this.list_workshops.Name = "list_workshops";
            this.list_workshops.Size = new System.Drawing.Size(509, 368);
            this.list_workshops.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_add,
            this.tsb_inspect,
            this.tsb_delete,
            this.tsb_edit,
            this.tsb_info});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_add
            // 
            this.tsb_add.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsb_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_add.Image = ((System.Drawing.Image)(resources.GetObject("tsb_add.Image")));
            this.tsb_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_add.Name = "tsb_add";
            this.tsb_add.Size = new System.Drawing.Size(63, 22);
            this.tsb_add.Text = "Добавить";
            this.tsb_add.Click += new System.EventHandler(this.tsb_add_Click);
            // 
            // tsb_inspect
            // 
            this.tsb_inspect.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsb_inspect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_inspect.Image = ((System.Drawing.Image)(resources.GetObject("tsb_inspect.Image")));
            this.tsb_inspect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_inspect.Name = "tsb_inspect";
            this.tsb_inspect.Size = new System.Drawing.Size(78, 22);
            this.tsb_inspect.Text = "Посмотреть";
            this.tsb_inspect.Click += new System.EventHandler(this.tsb_inspect_Click);
            // 
            // tsb_delete
            // 
            this.tsb_delete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsb_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_delete.Image = ((System.Drawing.Image)(resources.GetObject("tsb_delete.Image")));
            this.tsb_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_delete.Name = "tsb_delete";
            this.tsb_delete.Size = new System.Drawing.Size(55, 22);
            this.tsb_delete.Text = "Удалить";
            this.tsb_delete.Click += new System.EventHandler(this.tsb_delete_Click);
            // 
            // tsb_edit
            // 
            this.tsb_edit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsb_edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_edit.Image = ((System.Drawing.Image)(resources.GetObject("tsb_edit.Image")));
            this.tsb_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_edit.Name = "tsb_edit";
            this.tsb_edit.Size = new System.Drawing.Size(91, 22);
            this.tsb_edit.Text = "Редактировать";
            this.tsb_edit.Click += new System.EventHandler(this.tsb_edit_Click);
            // 
            // tsb_info
            // 
            this.tsb_info.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsb_info.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_info.Image = ((System.Drawing.Image)(resources.GetObject("tsb_info.Image")));
            this.tsb_info.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_info.Name = "tsb_info";
            this.tsb_info.Size = new System.Drawing.Size(57, 22);
            this.tsb_info.Text = "Справка";
            this.tsb_info.Click += new System.EventHandler(this.tsb_info_Click);
            // 
            // FormFront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.list_workshops);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_inspect);
            this.Controls.Add(this.btn_add);
            this.Name = "FormFront";
            this.Text = "Главная";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_inspect;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.ListBox list_workshops;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_add;
        private System.Windows.Forms.ToolStripButton tsb_inspect;
        private System.Windows.Forms.ToolStripButton tsb_delete;
        private System.Windows.Forms.ToolStripButton tsb_edit;
        private System.Windows.Forms.ToolStripButton tsb_info;
    }
}

