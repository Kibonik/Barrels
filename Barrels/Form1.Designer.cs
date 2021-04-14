namespace Barrels
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataSet1 = new System.Data.DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.canRotate = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SortResultBox = new System.Windows.Forms.TextBox();
            this.TotalVolume = new System.Windows.Forms.Label();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barrelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barrelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(367, 469);
            this.dataGridView1.TabIndex = 4;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(304, 12);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 5;
            this.LoadBtn.Text = "Browze";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(385, 12);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(75, 23);
            this.sortBtn.TabIndex = 6;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // canRotate
            // 
            this.canRotate.AutoSize = true;
            this.canRotate.Location = new System.Drawing.Point(466, 16);
            this.canRotate.Name = "canRotate";
            this.canRotate.Size = new System.Drawing.Size(92, 17);
            this.canRotate.TabIndex = 7;
            this.canRotate.Text = "Can rotate 90\'";
            this.canRotate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Load your file with barrels:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(634, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total volume:";
            // 
            // SortResultBox
            // 
            this.SortResultBox.Location = new System.Drawing.Point(385, 41);
            this.SortResultBox.Multiline = true;
            this.SortResultBox.Name = "SortResultBox";
            this.SortResultBox.ReadOnly = true;
            this.SortResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SortResultBox.Size = new System.Drawing.Size(379, 200);
            this.SortResultBox.TabIndex = 10;
            this.SortResultBox.WordWrap = false;
            // 
            // TotalVolume
            // 
            this.TotalVolume.AutoSize = true;
            this.TotalVolume.Location = new System.Drawing.Point(705, 244);
            this.TotalVolume.Name = "TotalVolume";
            this.TotalVolume.Size = new System.Drawing.Size(0, 13);
            this.TotalVolume.TabIndex = 11;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(Barrels.Program);
            // 
            // barrelBindingSource
            // 
            this.barrelBindingSource.DataSource = typeof(Barrels.Barrel);
            // 
            // barrelBindingSource1
            // 
            this.barrelBindingSource1.DataSource = typeof(Barrels.Barrel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 522);
            this.Controls.Add(this.TotalVolume);
            this.Controls.Add(this.SortResultBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canRotate);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Barrel Sorter";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrelBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.BindingSource barrelBindingSource;
        private System.Windows.Forms.BindingSource barrelBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.CheckBox canRotate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SortResultBox;
        private System.Windows.Forms.Label TotalVolume;
    }
}

