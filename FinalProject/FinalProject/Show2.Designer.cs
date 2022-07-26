namespace FinalProject
{
    partial class Show2
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pRODUCTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marketDataSet = new FinalProject.marketDataSet();
            this.pRODUCTTableAdapter = new FinalProject.marketDataSetTableAdapters.PRODUCTTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 413);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(29, 81);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(697, 311);
            this.dataGridView1.TabIndex = 2;
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
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "back ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Show2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 490);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Show2";
            this.Text = "Show2";
            this.Load += new System.EventHandler(this.Show2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private marketDataSet marketDataSet;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private marketDataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}