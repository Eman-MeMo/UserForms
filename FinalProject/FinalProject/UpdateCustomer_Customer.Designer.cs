namespace FinalProject
{
    partial class UpdateCustomer_Customer
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(546, 354);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(173, 47);
            this.button8.TabIndex = 53;
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
            this.dataGridView1.Location = new System.Drawing.Point(53, 425);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(724, 208);
            this.dataGridView1.TabIndex = 52;
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
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(112, 354);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(169, 53);
            this.button9.TabIndex = 51;
            this.button9.Text = "Save";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(446, 288);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(259, 30);
            this.textBox5.TabIndex = 50;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(446, 231);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(259, 30);
            this.textBox4.TabIndex = 49;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(446, 168);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(259, 30);
            this.textBox3.TabIndex = 48;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(446, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(259, 30);
            this.textBox2.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 29);
            this.label6.TabIndex = 46;
            this.label6.Text = "Telephonenum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 29);
            this.label5.TabIndex = 45;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 29);
            this.label4.TabIndex = 44;
            this.label4.Text = "Customer Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 29);
            this.label2.TabIndex = 43;
            this.label2.Text = "Customer Name";
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(252, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 50);
            this.button2.TabIndex = 55;
            this.button2.Text = "Remove Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 50);
            this.button1.TabIndex = 54;
            this.button1.Text = "Update Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateCustomer_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 660);
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
            this.Name = "UpdateCustomer_Customer";
            this.Text = "UpdateCustomer_Customer";
            this.Load += new System.EventHandler(this.UpdateCustomer_Customer_Load);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}