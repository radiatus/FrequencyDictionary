namespace FrequencyDictionary
{
    partial class Form1
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.WordCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadFile = new System.Windows.Forms.Button();
            this.FrequencyRun = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WordCol,
            this.CountCol});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(263, 663);
            this.dataGridView.TabIndex = 1;
            // 
            // WordCol
            // 
            this.WordCol.HeaderText = "Words";
            this.WordCol.Name = "WordCol";
            this.WordCol.ReadOnly = true;
            // 
            // CountCol
            // 
            this.CountCol.HeaderText = "Count";
            this.CountCol.Name = "CountCol";
            this.CountCol.ReadOnly = true;
            // 
            // LoadFile
            // 
            this.LoadFile.Location = new System.Drawing.Point(12, 681);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(117, 37);
            this.LoadFile.TabIndex = 2;
            this.LoadFile.Text = "LOAD";
            this.LoadFile.UseVisualStyleBackColor = true;
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // FrequencyRun
            // 
            this.FrequencyRun.Location = new System.Drawing.Point(135, 681);
            this.FrequencyRun.Name = "FrequencyRun";
            this.FrequencyRun.Size = new System.Drawing.Size(120, 37);
            this.FrequencyRun.TabIndex = 3;
            this.FrequencyRun.Text = "RUN";
            this.FrequencyRun.UseVisualStyleBackColor = true;
            this.FrequencyRun.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 738);
            this.Controls.Add(this.FrequencyRun);
            this.Controls.Add(this.LoadFile);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Frequency dictionary";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountCol;
        private System.Windows.Forms.Button LoadFile;
        private System.Windows.Forms.Button FrequencyRun;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

