namespace FinalProject
{
    partial class UpdateCustomer_Admin
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
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cUSTOMERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCOREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEPHONENUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marketDataSet = new FinalProject.marketDataSet();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cUSTOMERTableAdapter = new FinalProject.marketDataSetTableAdapters.CUSTOMERTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(832, 353);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(173, 47);
            this.button8.TabIndex = 42;
            this.button8.Text = "show";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUSTOMERNAMEDataGridViewTextBoxColumn,
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn,
            this.pASSWORDDataGridViewTextBoxColumn,
            this.sCOREDataGridViewTextBoxColumn,
            this.tELEPHONENUMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cUSTOMERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(197, 420);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(808, 234);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cUSTOMERNAMEDataGridViewTextBoxColumn
            // 
            this.cUSTOMERNAMEDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMERNAME";
            this.cUSTOMERNAMEDataGridViewTextBoxColumn.HeaderText = "CUSTOMERNAME";
            this.cUSTOMERNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSTOMERNAMEDataGridViewTextBoxColumn.Name = "cUSTOMERNAMEDataGridViewTextBoxColumn";
            this.cUSTOMERNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSTOMERADDRESSDataGridViewTextBoxColumn
            // 
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMERADDRESS";
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn.HeaderText = "CUSTOMERADDRESS";
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn.Name = "cUSTOMERADDRESSDataGridViewTextBoxColumn";
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn.Width = 125;
            // 
            // pASSWORDDataGridViewTextBoxColumn
            // 
            this.pASSWORDDataGridViewTextBoxColumn.DataPropertyName = "PASSWORD";
            this.pASSWORDDataGridViewTextBoxColumn.HeaderText = "PASSWORD";
            this.pASSWORDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pASSWORDDataGridViewTextBoxColumn.Name = "pASSWORDDataGridViewTextBoxColumn";
            this.pASSWORDDataGridViewTextBoxColumn.Width = 125;
            // 
            // sCOREDataGridViewTextBoxColumn
            // 
            this.sCOREDataGridViewTextBoxColumn.DataPropertyName = "SCORE";
            this.sCOREDataGridViewTextBoxColumn.HeaderText = "SCORE";
            this.sCOREDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sCOREDataGridViewTextBoxColumn.Name = "sCOREDataGridViewTextBoxColumn";
            this.sCOREDataGridViewTextBoxColumn.Width = 125;
            // 
            // tELEPHONENUMDataGridViewTextBoxColumn
            // 
            this.tELEPHONENUMDataGridViewTextBoxColumn.DataPropertyName = "TELEPHONE_NUM";
            this.tELEPHONENUMDataGridViewTextBoxColumn.HeaderText = "TELEPHONE_NUM";
            this.tELEPHONENUMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tELEPHONENUMDataGridViewTextBoxColumn.Name = "tELEPHONENUMDataGridViewTextBoxColumn";
            this.tELEPHONENUMDataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.marketDataSet;
            // 
            // marketDataSet
            // 
            this.marketDataSet.DataSetName = "marketDataSet";
            this.marketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(197, 350);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(169, 53);
            this.button9.TabIndex = 40;
            this.button9.Text = "Save";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(591, 282);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(405, 38);
            this.textBox5.TabIndex = 39;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(591, 225);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(405, 38);
            this.textBox4.TabIndex = 38;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(591, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(405, 38);
            this.textBox3.TabIndex = 37;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(591, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(405, 38);
            this.textBox2.TabIndex = 36;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(191, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 32);
            this.label6.TabIndex = 35;
            this.label6.Text = "Telephonenum";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(191, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 32);
            this.label5.TabIndex = 34;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 32);
            this.label4.TabIndex = 33;
            this.label4.Text = "Customer Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 32);
            this.label2.TabIndex = 32;
            this.label2.Text = "Customer Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(953, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(241, 50);
            this.button5.TabIndex = 47;
            this.button5.Text = "Update Product";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(716, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(241, 50);
            this.button4.TabIndex = 46;
            this.button4.Text = "Remove Product";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(478, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(241, 50);
            this.button3.TabIndex = 45;
            this.button3.Text = "Add Product";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(242, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 50);
            this.button2.TabIndex = 44;
            this.button2.Text = "Remove Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 50);
            this.button1.TabIndex = 43;
            this.button1.Text = "Update Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1189, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(241, 50);
            this.button6.TabIndex = 48;
            this.button6.Text = "SQL Statement";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1425, 1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(166, 50);
            this.button7.TabIndex = 49;
            this.button7.Text = "Shows";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // UpdateCustomer_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 666);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "UpdateCustomer_Admin";
            this.Text = "UpdateCustomer_Admin";
            this.Load += new System.EventHandler(this.UpdateCustomer_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private marketDataSet marketDataSet;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private marketDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMERADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCOREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEPHONENUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}