namespace Ilyaasprojec
{
    partial class Form7
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.masterDataSet3 = new Ilyaasprojec.masterDataSet3();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new Ilyaasprojec.masterDataSet3TableAdapters.CategoriesTableAdapter();
            this.categoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "category_id:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(345, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 49);
            this.textBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(14, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 388);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "category_name:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(345, 126);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(356, 49);
            this.textBox2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryidDataGridViewTextBoxColumn,
            this.categorynameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.categoriesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(788, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(645, 434);
            this.dataGridView1.TabIndex = 53;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Blue;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(938, 209);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(129, 72);
            this.button7.TabIndex = 52;
            this.button7.Text = "filter";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(790, 209);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 72);
            this.button8.TabIndex = 51;
            this.button8.Text = "Search";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(464, 651);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 74);
            this.button4.TabIndex = 49;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(14, 652);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 72);
            this.button2.TabIndex = 47;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(194, 652);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 72);
            this.button1.TabIndex = 46;
            this.button1.Text = "insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(328, 652);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 72);
            this.button3.TabIndex = 48;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(1078, 222);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(352, 61);
            this.textBox8.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(513, 108);
            this.label3.TabIndex = 54;
            this.label3.Text = "CATEGORY";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ilyaasprojec.Properties.Resources.categories;
            this.pictureBox1.Location = new System.Drawing.Point(14, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // masterDataSet3
            // 
            this.masterDataSet3.DataSetName = "masterDataSet3";
            this.masterDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.masterDataSet3;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // categoryidDataGridViewTextBoxColumn
            // 
            this.categoryidDataGridViewTextBoxColumn.DataPropertyName = "category_id";
            this.categoryidDataGridViewTextBoxColumn.HeaderText = "category_id";
            this.categoryidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoryidDataGridViewTextBoxColumn.Name = "categoryidDataGridViewTextBoxColumn";
            this.categoryidDataGridViewTextBoxColumn.Width = 150;
            // 
            // categorynameDataGridViewTextBoxColumn
            // 
            this.categorynameDataGridViewTextBoxColumn.DataPropertyName = "category_name";
            this.categorynameDataGridViewTextBoxColumn.HeaderText = "category_name";
            this.categorynameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categorynameDataGridViewTextBoxColumn.Name = "categorynameDataGridViewTextBoxColumn";
            this.categorynameDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 742);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.panel1);
            this.Name = "Form7";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CATEGORY";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private masterDataSet3 masterDataSet3;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private masterDataSet3TableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorynameDataGridViewTextBoxColumn;
    }
}