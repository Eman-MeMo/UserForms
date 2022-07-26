namespace FinalProject
{
    partial class SignUp
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
            this.CTelep = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.CustomerPass = new System.Windows.Forms.TextBox();
            this.CustomerAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.marketDataSet = new FinalProject.marketDataSet();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERTableAdapter = new FinalProject.marketDataSetTableAdapters.CUSTOMERTableAdapter();
            this.cUSTOMERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCOREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEPHONENUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(110, 500);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 66);
            this.button1.TabIndex = 40;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(288, 404);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(655, 150);
            this.dataGridView1.TabIndex = 39;
            // 
            // CTelep
            // 
            this.CTelep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CTelep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTelep.Location = new System.Drawing.Point(485, 289);
            this.CTelep.Margin = new System.Windows.Forms.Padding(4);
            this.CTelep.Name = "CTelep";
            this.CTelep.Size = new System.Drawing.Size(380, 36);
            this.CTelep.TabIndex = 38;
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(110, 388);
            this.Save.Margin = new System.Windows.Forms.Padding(4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 66);
            this.Save.TabIndex = 37;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(150, 292);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 29);
            this.label7.TabIndex = 36;
            this.label7.Text = "Telephone Number :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(150, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 29);
            this.label6.TabIndex = 35;
            this.label6.Text = "Customer Full Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "Password :";
            // 
            // CustomerName
            // 
            this.CustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(485, 27);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(380, 36);
            this.CustomerName.TabIndex = 33;
            // 
            // CustomerPass
            // 
            this.CustomerPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPass.Location = new System.Drawing.Point(485, 205);
            this.CustomerPass.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerPass.Name = "CustomerPass";
            this.CustomerPass.Size = new System.Drawing.Size(380, 36);
            this.CustomerPass.TabIndex = 32;
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerAddress.Location = new System.Drawing.Point(485, 115);
            this.CustomerAddress.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.Size = new System.Drawing.Size(380, 36);
            this.CustomerAddress.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Customer Name :";
            // 
            // marketDataSet
            // 
            this.marketDataSet.DataSetName = "marketDataSet";
            this.marketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.marketDataSet;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
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
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 616);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CTelep);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.CustomerPass);
            this.Controls.Add(this.CustomerAddress);
            this.Controls.Add(this.label3);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox CTelep;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.TextBox CustomerPass;
        private System.Windows.Forms.TextBox CustomerAddress;
        private System.Windows.Forms.Label label3;
        private marketDataSet marketDataSet;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private marketDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMERADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCOREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEPHONENUMDataGridViewTextBoxColumn;
    }
}