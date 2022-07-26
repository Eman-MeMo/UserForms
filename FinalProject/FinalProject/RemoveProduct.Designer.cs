namespace FinalProject
{
    partial class RemoveProduct
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
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pRODUCTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marketDataSet = new FinalProject.marketDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pRODUCTTableAdapter = new FinalProject.marketDataSetTableAdapters.PRODUCTTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(721, 226);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(208, 66);
            this.button6.TabIndex = 20;
            this.button6.Text = "show";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRODUCTIDDataGridViewTextBoxColumn,
            this.cATEGORYIDDataGridViewTextBoxColumn,
            this.pRODUCTPRICEDataGridViewTextBoxColumn,
            this.pRODUCTNAMEDataGridViewTextBoxColumn,
            this.qUANTITYDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRODUCTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(198, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(865, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // pRODUCTIDDataGridViewTextBoxColumn
            // 
            this.pRODUCTIDDataGridViewTextBoxColumn.DataPropertyName = "PRODUCTID";
            this.pRODUCTIDDataGridViewTextBoxColumn.HeaderText = "PRODUCTID";
            this.pRODUCTIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRODUCTIDDataGridViewTextBoxColumn.Name = "pRODUCTIDDataGridViewTextBoxColumn";
            this.pRODUCTIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cATEGORYIDDataGridViewTextBoxColumn
            // 
            this.cATEGORYIDDataGridViewTextBoxColumn.DataPropertyName = "CATEGORYID";
            this.cATEGORYIDDataGridViewTextBoxColumn.HeaderText = "CATEGORYID";
            this.cATEGORYIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cATEGORYIDDataGridViewTextBoxColumn.Name = "cATEGORYIDDataGridViewTextBoxColumn";
            this.cATEGORYIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRODUCTPRICEDataGridViewTextBoxColumn
            // 
            this.pRODUCTPRICEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCTPRICE";
            this.pRODUCTPRICEDataGridViewTextBoxColumn.HeaderText = "PRODUCTPRICE";
            this.pRODUCTPRICEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRODUCTPRICEDataGridViewTextBoxColumn.Name = "pRODUCTPRICEDataGridViewTextBoxColumn";
            this.pRODUCTPRICEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRODUCTNAMEDataGridViewTextBoxColumn
            // 
            this.pRODUCTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCTNAME";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.HeaderText = "PRODUCTNAME";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRODUCTNAMEDataGridViewTextBoxColumn.Name = "pRODUCTNAMEDataGridViewTextBoxColumn";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // qUANTITYDataGridViewTextBoxColumn
            // 
            this.qUANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUANTITY";
            this.qUANTITYDataGridViewTextBoxColumn.HeaderText = "QUANTITY";
            this.qUANTITYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qUANTITYDataGridViewTextBoxColumn.Name = "qUANTITYDataGridViewTextBoxColumn";
            this.qUANTITYDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.marketDataSet;
            // 
            // marketDataSet
            // 
            this.marketDataSet.DataSetName = "marketDataSet";
            this.marketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(531, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 41);
            this.textBox1.TabIndex = 18;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(255, 226);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(222, 66);
            this.button7.TabIndex = 17;
            this.button7.Text = "Remove";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 36);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(615, 36);
            this.label2.TabIndex = 15;
            this.label2.Text = "Enter the id of the product you want to delete ";
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(958, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(241, 50);
            this.button5.TabIndex = 25;
            this.button5.Text = "Update Product";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(721, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(241, 50);
            this.button4.TabIndex = 24;
            this.button4.Text = "Remove Product";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(483, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(241, 50);
            this.button3.TabIndex = 23;
            this.button3.Text = "Add Product";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(247, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 50);
            this.button2.TabIndex = 22;
            this.button2.Text = "Remove Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(7, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 50);
            this.button1.TabIndex = 21;
            this.button1.Text = "Update Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(1188, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(241, 50);
            this.button8.TabIndex = 43;
            this.button8.Text = "SQL Statement";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(1426, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(166, 50);
            this.button9.TabIndex = 44;
            this.button9.Text = "Shows";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // RemoveProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 527);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "RemoveProduct";
            this.Text = "RemoveProduct";
            this.Load += new System.EventHandler(this.RemoveProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private marketDataSet marketDataSet;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private marketDataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}