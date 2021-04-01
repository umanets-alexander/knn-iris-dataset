
namespace KNN_Iris
{
    partial class KNNForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KNNForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_link_github = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridViewClas = new System.Windows.Forms.DataGridView();
            this.SepalLengthClas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SepalWidthClas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetalLengthClas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetalWidthClas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeIrisClas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_addclas = new System.Windows.Forms.Button();
            this.btn_dgvclas_rowdel = new System.Windows.Forms.Button();
            this.btn_dgvclas_clear = new System.Windows.Forms.Button();
            this.btn_save_fclas = new System.Windows.Forms.Button();
            this.btn_open_fclas = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridViewIris = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SepalLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SepalWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetalLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetalWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeIris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_open_firis = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_clas = new System.Windows.Forms.Button();
            this.lbl_numk = new System.Windows.Forms.Label();
            this.trackBarClas = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClas)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIris)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarClas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_link_github);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 663);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 36);
            this.panel1.TabIndex = 0;
            // 
            // btn_link_github
            // 
            this.btn_link_github.Image = ((System.Drawing.Image)(resources.GetObject("btn_link_github.Image")));
            this.btn_link_github.Location = new System.Drawing.Point(1111, 2);
            this.btn_link_github.Name = "btn_link_github";
            this.btn_link_github.Size = new System.Drawing.Size(32, 32);
            this.btn_link_github.TabIndex = 7;
            this.btn_link_github.UseVisualStyleBackColor = true;
            this.btn_link_github.Click += new System.EventHandler(this.btn_link_github_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 663);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridViewClas);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel7.Location = new System.Drawing.Point(0, 396);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(603, 267);
            this.panel7.TabIndex = 3;
            // 
            // dataGridViewClas
            // 
            this.dataGridViewClas.AllowUserToAddRows = false;
            this.dataGridViewClas.AllowUserToDeleteRows = false;
            this.dataGridViewClas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SepalLengthClas,
            this.SepalWidthClas,
            this.PetalLengthClas,
            this.PetalWidthClas,
            this.TypeIrisClas});
            this.dataGridViewClas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClas.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewClas.MultiSelect = false;
            this.dataGridViewClas.Name = "dataGridViewClas";
            this.dataGridViewClas.ReadOnly = true;
            this.dataGridViewClas.RowHeadersVisible = false;
            this.dataGridViewClas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClas.Size = new System.Drawing.Size(603, 267);
            this.dataGridViewClas.TabIndex = 0;
            // 
            // SepalLengthClas
            // 
            this.SepalLengthClas.HeaderText = "Длина чашелистика";
            this.SepalLengthClas.Name = "SepalLengthClas";
            this.SepalLengthClas.ReadOnly = true;
            // 
            // SepalWidthClas
            // 
            this.SepalWidthClas.HeaderText = "Ширина чашелистика";
            this.SepalWidthClas.Name = "SepalWidthClas";
            this.SepalWidthClas.ReadOnly = true;
            // 
            // PetalLengthClas
            // 
            this.PetalLengthClas.HeaderText = "Длина лепестка";
            this.PetalLengthClas.Name = "PetalLengthClas";
            this.PetalLengthClas.ReadOnly = true;
            // 
            // PetalWidthClas
            // 
            this.PetalWidthClas.HeaderText = "Ширина лепестка";
            this.PetalWidthClas.Name = "PetalWidthClas";
            this.PetalWidthClas.ReadOnly = true;
            // 
            // TypeIrisClas
            // 
            this.TypeIrisClas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeIrisClas.HeaderText = "Тип ириса";
            this.TypeIrisClas.Name = "TypeIrisClas";
            this.TypeIrisClas.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.btn_addclas);
            this.panel6.Controls.Add(this.btn_dgvclas_rowdel);
            this.panel6.Controls.Add(this.btn_dgvclas_clear);
            this.panel6.Controls.Add(this.btn_save_fclas);
            this.panel6.Controls.Add(this.btn_open_fclas);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 360);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(603, 36);
            this.panel6.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ирисы для классификации:";
            // 
            // btn_addclas
            // 
            this.btn_addclas.Image = ((System.Drawing.Image)(resources.GetObject("btn_addclas.Image")));
            this.btn_addclas.Location = new System.Drawing.Point(423, 2);
            this.btn_addclas.Name = "btn_addclas";
            this.btn_addclas.Size = new System.Drawing.Size(32, 32);
            this.btn_addclas.TabIndex = 10;
            this.btn_addclas.UseVisualStyleBackColor = true;
            this.btn_addclas.Click += new System.EventHandler(this.btn_addclas_Click);
            // 
            // btn_dgvclas_rowdel
            // 
            this.btn_dgvclas_rowdel.Image = ((System.Drawing.Image)(resources.GetObject("btn_dgvclas_rowdel.Image")));
            this.btn_dgvclas_rowdel.Location = new System.Drawing.Point(459, 2);
            this.btn_dgvclas_rowdel.Name = "btn_dgvclas_rowdel";
            this.btn_dgvclas_rowdel.Size = new System.Drawing.Size(32, 32);
            this.btn_dgvclas_rowdel.TabIndex = 9;
            this.btn_dgvclas_rowdel.UseVisualStyleBackColor = true;
            this.btn_dgvclas_rowdel.Click += new System.EventHandler(this.btn_dgvclas_rowdel_Click);
            // 
            // btn_dgvclas_clear
            // 
            this.btn_dgvclas_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_dgvclas_clear.Image")));
            this.btn_dgvclas_clear.Location = new System.Drawing.Point(495, 2);
            this.btn_dgvclas_clear.Name = "btn_dgvclas_clear";
            this.btn_dgvclas_clear.Size = new System.Drawing.Size(32, 32);
            this.btn_dgvclas_clear.TabIndex = 8;
            this.btn_dgvclas_clear.UseVisualStyleBackColor = true;
            this.btn_dgvclas_clear.Click += new System.EventHandler(this.btn_dgvclas_clear_Click);
            // 
            // btn_save_fclas
            // 
            this.btn_save_fclas.Image = ((System.Drawing.Image)(resources.GetObject("btn_save_fclas.Image")));
            this.btn_save_fclas.Location = new System.Drawing.Point(531, 2);
            this.btn_save_fclas.Name = "btn_save_fclas";
            this.btn_save_fclas.Size = new System.Drawing.Size(32, 32);
            this.btn_save_fclas.TabIndex = 7;
            this.btn_save_fclas.UseVisualStyleBackColor = true;
            this.btn_save_fclas.Click += new System.EventHandler(this.btn_save_fclas_Click);
            // 
            // btn_open_fclas
            // 
            this.btn_open_fclas.Image = ((System.Drawing.Image)(resources.GetObject("btn_open_fclas.Image")));
            this.btn_open_fclas.Location = new System.Drawing.Point(567, 2);
            this.btn_open_fclas.Name = "btn_open_fclas";
            this.btn_open_fclas.Size = new System.Drawing.Size(32, 32);
            this.btn_open_fclas.TabIndex = 6;
            this.btn_open_fclas.UseVisualStyleBackColor = true;
            this.btn_open_fclas.Click += new System.EventHandler(this.btn_open_fclas_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridViewIris);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel5.Location = new System.Drawing.Point(0, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(603, 324);
            this.panel5.TabIndex = 1;
            // 
            // dataGridViewIris
            // 
            this.dataGridViewIris.AllowUserToAddRows = false;
            this.dataGridViewIris.AllowUserToDeleteRows = false;
            this.dataGridViewIris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIris.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.SepalLength,
            this.SepalWidth,
            this.PetalLength,
            this.PetalWidth,
            this.TypeIris});
            this.dataGridViewIris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIris.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewIris.MultiSelect = false;
            this.dataGridViewIris.Name = "dataGridViewIris";
            this.dataGridViewIris.ReadOnly = true;
            this.dataGridViewIris.RowHeadersVisible = false;
            this.dataGridViewIris.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewIris.Size = new System.Drawing.Size(603, 324);
            this.dataGridViewIris.TabIndex = 0;
            // 
            // Num
            // 
            this.Num.HeaderText = "№";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            // 
            // SepalLength
            // 
            this.SepalLength.HeaderText = "Длина чашелистика";
            this.SepalLength.Name = "SepalLength";
            this.SepalLength.ReadOnly = true;
            // 
            // SepalWidth
            // 
            this.SepalWidth.HeaderText = "Ширина чашелистика";
            this.SepalWidth.Name = "SepalWidth";
            this.SepalWidth.ReadOnly = true;
            // 
            // PetalLength
            // 
            this.PetalLength.HeaderText = "Длина лепестка";
            this.PetalLength.Name = "PetalLength";
            this.PetalLength.ReadOnly = true;
            // 
            // PetalWidth
            // 
            this.PetalWidth.HeaderText = "Ширина лепестка";
            this.PetalWidth.Name = "PetalWidth";
            this.PetalWidth.ReadOnly = true;
            // 
            // TypeIris
            // 
            this.TypeIris.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeIris.HeaderText = "Тип ириса";
            this.TypeIris.Name = "TypeIris";
            this.TypeIris.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btn_open_firis);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(603, 36);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Данные ирисов Фишера:";
            // 
            // btn_open_firis
            // 
            this.btn_open_firis.Image = ((System.Drawing.Image)(resources.GetObject("btn_open_firis.Image")));
            this.btn_open_firis.Location = new System.Drawing.Point(567, 2);
            this.btn_open_firis.Name = "btn_open_firis";
            this.btn_open_firis.Size = new System.Drawing.Size(32, 32);
            this.btn_open_firis.TabIndex = 11;
            this.btn_open_firis.UseVisualStyleBackColor = true;
            this.btn_open_firis.Click += new System.EventHandler(this.btn_open_firis_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.richTextBoxResult);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btn_clas);
            this.panel3.Controls.Add(this.lbl_numk);
            this.panel3.Controls.Add(this.trackBarClas);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(603, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(544, 663);
            this.panel3.TabIndex = 2;
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(10, 153);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(522, 510);
            this.richTextBoxResult.TabIndex = 6;
            this.richTextBoxResult.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Результат классификации:";
            // 
            // btn_clas
            // 
            this.btn_clas.Location = new System.Drawing.Point(185, 95);
            this.btn_clas.Name = "btn_clas";
            this.btn_clas.Size = new System.Drawing.Size(203, 32);
            this.btn_clas.TabIndex = 4;
            this.btn_clas.Text = "Классифицировать";
            this.btn_clas.UseVisualStyleBackColor = true;
            this.btn_clas.Click += new System.EventHandler(this.btn_clas_Click);
            // 
            // lbl_numk
            // 
            this.lbl_numk.Location = new System.Drawing.Point(510, 59);
            this.lbl_numk.Name = "lbl_numk";
            this.lbl_numk.Size = new System.Drawing.Size(30, 25);
            this.lbl_numk.TabIndex = 3;
            this.lbl_numk.Text = "1";
            // 
            // trackBarClas
            // 
            this.trackBarClas.Location = new System.Drawing.Point(10, 59);
            this.trackBarClas.Maximum = 50;
            this.trackBarClas.Minimum = 1;
            this.trackBarClas.Name = "trackBarClas";
            this.trackBarClas.Size = new System.Drawing.Size(494, 45);
            this.trackBarClas.TabIndex = 2;
            this.trackBarClas.Value = 1;
            this.trackBarClas.Scroll += new System.EventHandler(this.trackBarClas_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Значение классификатора k:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Параметры для классификации:";
            // 
            // KNNForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 699);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "KNNForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KNN Iris Dataset";
            this.Load += new System.EventHandler(this.KNNForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClas)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIris)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarClas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_link_github;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridViewClas;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_addclas;
        private System.Windows.Forms.Button btn_dgvclas_rowdel;
        private System.Windows.Forms.Button btn_dgvclas_clear;
        private System.Windows.Forms.Button btn_save_fclas;
        private System.Windows.Forms.Button btn_open_fclas;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridViewIris;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_open_firis;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SepalLengthClas;
        private System.Windows.Forms.DataGridViewTextBoxColumn SepalWidthClas;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetalLengthClas;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetalWidthClas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeIrisClas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn SepalLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn SepalWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetalLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetalWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeIris;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_clas;
        private System.Windows.Forms.Label lbl_numk;
        private System.Windows.Forms.TrackBar trackBarClas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

