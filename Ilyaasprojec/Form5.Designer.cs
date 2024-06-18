namespace Ilyaasprojec
{
    partial class Form5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet12 = new Ilyaasprojec.masterDataSet12();
            this.textBox4 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.scheduleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shceduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet11 = new Ilyaasprojec.masterDataSet11();
            this.shceduleTableAdapter = new Ilyaasprojec.masterDataSet11TableAdapters.shceduleTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.productsTableAdapter = new Ilyaasprojec.masterDataSet12TableAdapters.ProductsTableAdapter();
            this.masterDataSet13 = new Ilyaasprojec.masterDataSet13();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter1 = new Ilyaasprojec.masterDataSet13TableAdapters.ProductsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shceduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 416);
            this.panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.DataSource = this.productsBindingSource1;
            this.textBox2.DisplayMember = "product_name";
            this.textBox2.FormattingEnabled = true;
            this.textBox2.Location = new System.Drawing.Point(259, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(390, 28);
            this.textBox2.TabIndex = 26;
            this.textBox2.ValueMember = "product_id";
            this.textBox2.SelectedIndexChanged += new System.EventHandler(this.textBox2_SelectedIndexChanged);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.masterDataSet12;
            // 
            // masterDataSet12
            // 
            this.masterDataSet12.DataSetName = "masterDataSet12";
            this.masterDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(259, 345);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(390, 26);
            this.textBox4.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(259, 252);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(390, 26);
            this.textBox3.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 38);
            this.label3.TabIndex = 22;
            this.label3.Text = "end_date:";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(230, 682);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 72);
            this.button6.TabIndex = 21;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "start_date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "product_id : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(259, 47);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(390, 40);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "schedule_id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(221, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 72);
            this.button1.TabIndex = 18;
            this.button1.Text = "insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(50, 559);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 72);
            this.button2.TabIndex = 19;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(380, 559);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 72);
            this.button3.TabIndex = 20;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(554, 559);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 72);
            this.button4.TabIndex = 21;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(1007, 130);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(631, 56);
            this.textBox8.TabIndex = 24;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Blue;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(843, 114);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(141, 72);
            this.button7.TabIndex = 26;
            this.button7.Text = "filter";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(669, 114);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(168, 72);
            this.button8.TabIndex = 25;
            this.button8.Text = "Search";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ilyaasprojec.Properties.Resources.manufacture;
            this.pictureBox1.Location = new System.Drawing.Point(14, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scheduleidDataGridViewTextBoxColumn,
            this.productidDataGridViewTextBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.enddateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shceduleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(672, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(966, 337);
            this.dataGridView1.TabIndex = 22;
            // 
            // scheduleidDataGridViewTextBoxColumn
            // 
            this.scheduleidDataGridViewTextBoxColumn.DataPropertyName = "schedule_id";
            this.scheduleidDataGridViewTextBoxColumn.HeaderText = "schedule_id";
            this.scheduleidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.scheduleidDataGridViewTextBoxColumn.Name = "scheduleidDataGridViewTextBoxColumn";
            this.scheduleidDataGridViewTextBoxColumn.Width = 150;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.Width = 150;
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "start_date";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "start_date";
            this.startdateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            this.startdateDataGridViewTextBoxColumn.Width = 150;
            // 
            // enddateDataGridViewTextBoxColumn
            // 
            this.enddateDataGridViewTextBoxColumn.DataPropertyName = "end_date";
            this.enddateDataGridViewTextBoxColumn.HeaderText = "end_date";
            this.enddateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.enddateDataGridViewTextBoxColumn.Name = "enddateDataGridViewTextBoxColumn";
            this.enddateDataGridViewTextBoxColumn.Width = 150;
            // 
            // shceduleBindingSource
            // 
            this.shceduleBindingSource.DataMember = "shcedule";
            this.shceduleBindingSource.DataSource = this.masterDataSet11;
            // 
            // masterDataSet11
            // 
            this.masterDataSet11.DataSetName = "masterDataSet11";
            this.masterDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shceduleTableAdapter
            // 
            this.shceduleTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(236, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(430, 47);
            this.label5.TabIndex = 24;
            this.label5.Text = "production-schedule";
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // masterDataSet13
            // 
            this.masterDataSet13.DataSetName = "masterDataSet13";
            this.masterDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.masterDataSet13;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1672, 937);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Name = "Form5";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUPPLIERS";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shceduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private masterDataSet11 masterDataSet11;
        private System.Windows.Forms.BindingSource shceduleBindingSource;
        private masterDataSet11TableAdapters.shceduleTableAdapter shceduleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker textBox4;
        private System.Windows.Forms.DateTimePicker textBox3;
        private System.Windows.Forms.ComboBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private masterDataSet12 masterDataSet12;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private masterDataSet12TableAdapters.ProductsTableAdapter productsTableAdapter;
        private masterDataSet13 masterDataSet13;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private masterDataSet13TableAdapters.ProductsTableAdapter productsTableAdapter1;
    }
}