namespace Ilyaasprojec
{
    partial class Form8
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ordersTableAdapter3 = new Ilyaasprojec.masterDataSet18TableAdapters.OrdersTableAdapter();
            this.masterDataSet19 = new Ilyaasprojec.masterDataSet19();
            this.masterDataSet20 = new Ilyaasprojec.masterDataSet20();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Ilyaasprojec.masterDataSet20TableAdapters.OrdersTableAdapter();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterDataSet21 = new Ilyaasprojec.masterDataSet21();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new Ilyaasprojec.masterDataSet21TableAdapters.CustomersTableAdapter();
            this.masterDataSet22 = new Ilyaasprojec.masterDataSet22();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Ilyaasprojec.masterDataSet22TableAdapters.ProductsTableAdapter();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 38);
            this.label1.TabIndex = 29;
            this.label1.Text = "customer_id:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 381);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.customersBindingSource;
            this.comboBox2.DisplayMember = "customer_name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(298, 232);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(376, 28);
            this.comboBox2.TabIndex = 65;
            this.comboBox2.ValueMember = "customer_id";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Location = new System.Drawing.Point(0, 503);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1587, 77);
            this.panel3.TabIndex = 64;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(298, 153);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(364, 26);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 38);
            this.label3.TabIndex = 33;
            this.label3.Text = "order_id:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(298, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 58);
            this.textBox1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 38);
            this.label2.TabIndex = 31;
            this.label2.Text = "order_date:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderidDataGridViewTextBoxColumn,
            this.orderdateDataGridViewTextBoxColumn,
            this.customeridDataGridViewTextBoxColumn,
            this.productidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(746, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(759, 325);
            this.dataGridView1.TabIndex = 61;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Blue;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(891, 229);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(129, 72);
            this.button7.TabIndex = 60;
            this.button7.Text = "filter";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(746, 229);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 72);
            this.button8.TabIndex = 59;
            this.button8.Text = "Search";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(459, 627);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 72);
            this.button4.TabIndex = 57;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(14, 627);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 74);
            this.button2.TabIndex = 55;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(179, 627);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 72);
            this.button1.TabIndex = 54;
            this.button1.Text = "insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(325, 627);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 72);
            this.button3.TabIndex = 56;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(1026, 242);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(464, 48);
            this.textBox8.TabIndex = 58;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ilyaasprojec.Properties.Resources.checkout;
            this.pictureBox1.Location = new System.Drawing.Point(63, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 106);
            this.label4.TabIndex = 63;
            this.label4.Text = "ODERS";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(14, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 177);
            this.panel2.TabIndex = 64;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.productsBindingSource;
            this.comboBox3.DisplayMember = "product_name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(298, 315);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(376, 28);
            this.comboBox3.TabIndex = 67;
            this.comboBox3.ValueMember = "product_id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 38);
            this.label5.TabIndex = 66;
            this.label5.Text = "product_id:";
            // 
            // ordersTableAdapter3
            // 
            this.ordersTableAdapter3.ClearBeforeFill = true;
            // 
            // masterDataSet19
            // 
            this.masterDataSet19.DataSetName = "masterDataSet19";
            this.masterDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masterDataSet20
            // 
            this.masterDataSet20.DataSetName = "masterDataSet20";
            this.masterDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.masterDataSet20;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            this.orderidDataGridViewTextBoxColumn.DataPropertyName = "order_id";
            this.orderidDataGridViewTextBoxColumn.HeaderText = "order_id";
            this.orderidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
            this.orderidDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderidDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderdateDataGridViewTextBoxColumn
            // 
            this.orderdateDataGridViewTextBoxColumn.DataPropertyName = "order_date";
            this.orderdateDataGridViewTextBoxColumn.HeaderText = "order_date";
            this.orderdateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderdateDataGridViewTextBoxColumn.Name = "orderdateDataGridViewTextBoxColumn";
            this.orderdateDataGridViewTextBoxColumn.Width = 150;
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "customer_id";
            this.customeridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.Width = 150;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.Width = 150;
            // 
            // masterDataSet21
            // 
            this.masterDataSet21.DataSetName = "masterDataSet21";
            this.masterDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.masterDataSet21;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // masterDataSet22
            // 
            this.masterDataSet22.DataSetName = "masterDataSet22";
            this.masterDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.masterDataSet22;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 713);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.panel1);
            this.Name = "Form8";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ODERS";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private masterDataSet18TableAdapters.OrdersTableAdapter ordersTableAdapter3;
        private masterDataSet19 masterDataSet19;
        private masterDataSet20 masterDataSet20;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private masterDataSet20TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private masterDataSet21 masterDataSet21;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private masterDataSet21TableAdapters.CustomersTableAdapter customersTableAdapter;
        private masterDataSet22 masterDataSet22;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private masterDataSet22TableAdapters.ProductsTableAdapter productsTableAdapter;
    }
}