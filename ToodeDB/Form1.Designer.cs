namespace ToodeDB
{
    partial class Form1
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
            this.ToodeBox = new System.Windows.Forms.TextBox();
            this.HindBox = new System.Windows.Forms.TextBox();
            this.KogusBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toodenimetusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kogusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toodeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toodedDataSet = new ToodeDB.ToodedDataSet();
            this.toodeTableTableAdapter = new ToodeDB.ToodedDataSetTableAdapters.ToodeTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ToodeBox
            // 
            this.ToodeBox.Location = new System.Drawing.Point(36, 51);
            this.ToodeBox.Name = "ToodeBox";
            this.ToodeBox.Size = new System.Drawing.Size(100, 20);
            this.ToodeBox.TabIndex = 0;
            // 
            // HindBox
            // 
            this.HindBox.Location = new System.Drawing.Point(36, 103);
            this.HindBox.Name = "HindBox";
            this.HindBox.Size = new System.Drawing.Size(100, 20);
            this.HindBox.TabIndex = 1;
            // 
            // KogusBox
            // 
            this.KogusBox.Location = new System.Drawing.Point(36, 77);
            this.KogusBox.Name = "KogusBox";
            this.KogusBox.Size = new System.Drawing.Size(100, 20);
            this.KogusBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Toode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.18868F);
            this.label2.Location = new System.Drawing.Point(142, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kogus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.18868F);
            this.label3.Location = new System.Drawing.Point(142, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hind";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Nirmala UI", 10.18868F);
            this.btn_add.Location = new System.Drawing.Point(36, 169);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(97, 43);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Lisa uus";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Nirmala UI", 10.18868F);
            this.btn_update.Location = new System.Drawing.Point(36, 218);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(97, 43);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Uuenda";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Nirmala UI", 10.18868F);
            this.btn_delete.Location = new System.Drawing.Point(36, 267);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(97, 43);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Kustuta";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.toodenimetusDataGridViewTextBoxColumn,
            this.kogusDataGridViewTextBoxColumn,
            this.hindDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.toodeTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(302, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.Size = new System.Drawing.Size(486, 256);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 110;
            // 
            // toodenimetusDataGridViewTextBoxColumn
            // 
            this.toodenimetusDataGridViewTextBoxColumn.DataPropertyName = "Toodenimetus";
            this.toodenimetusDataGridViewTextBoxColumn.HeaderText = "Toodenimetus";
            this.toodenimetusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toodenimetusDataGridViewTextBoxColumn.Name = "toodenimetusDataGridViewTextBoxColumn";
            this.toodenimetusDataGridViewTextBoxColumn.Width = 110;
            // 
            // kogusDataGridViewTextBoxColumn
            // 
            this.kogusDataGridViewTextBoxColumn.DataPropertyName = "Kogus";
            this.kogusDataGridViewTextBoxColumn.HeaderText = "Kogus";
            this.kogusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kogusDataGridViewTextBoxColumn.Name = "kogusDataGridViewTextBoxColumn";
            this.kogusDataGridViewTextBoxColumn.Width = 110;
            // 
            // hindDataGridViewTextBoxColumn
            // 
            this.hindDataGridViewTextBoxColumn.DataPropertyName = "Hind";
            this.hindDataGridViewTextBoxColumn.HeaderText = "Hind";
            this.hindDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hindDataGridViewTextBoxColumn.Name = "hindDataGridViewTextBoxColumn";
            this.hindDataGridViewTextBoxColumn.Width = 110;
            // 
            // toodeTableBindingSource
            // 
            this.toodeTableBindingSource.DataMember = "ToodeTable";
            this.toodeTableBindingSource.DataSource = this.toodedDataSet;
            // 
            // toodedDataSet
            // 
            this.toodedDataSet.DataSetName = "ToodedDataSet";
            this.toodedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toodeTableTableAdapter
            // 
            this.toodeTableTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KogusBox);
            this.Controls.Add(this.HindBox);
            this.Controls.Add(this.ToodeBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ToodeBox;
        private System.Windows.Forms.TextBox HindBox;
        private System.Windows.Forms.TextBox KogusBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ToodedDataSet toodedDataSet;
        private System.Windows.Forms.BindingSource toodeTableBindingSource;
        private ToodedDataSetTableAdapters.ToodeTableTableAdapter toodeTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toodenimetusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kogusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hindDataGridViewTextBoxColumn;
    }
}

