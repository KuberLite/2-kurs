namespace Task3_2_2_
{
    partial class MainForm
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
            this.NameButton = new System.Windows.Forms.Button();
            this.AgeButton = new System.Windows.Forms.Button();
            this.ResultDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // NameButton
            // 
            this.NameButton.Location = new System.Drawing.Point(12, 41);
            this.NameButton.Name = "NameButton";
            this.NameButton.Size = new System.Drawing.Size(75, 23);
            this.NameButton.TabIndex = 0;
            this.NameButton.Text = "Load Name";
            this.NameButton.UseVisualStyleBackColor = true;
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            // 
            // AgeButton
            // 
            this.AgeButton.Location = new System.Drawing.Point(12, 12);
            this.AgeButton.Name = "AgeButton";
            this.AgeButton.Size = new System.Drawing.Size(75, 23);
            this.AgeButton.TabIndex = 1;
            this.AgeButton.Text = "Load Age";
            this.AgeButton.UseVisualStyleBackColor = true;
            this.AgeButton.Click += new System.EventHandler(this.AgeButton_Click);
            // 
            // ResultDataGrid
            // 
            this.ResultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultDataGrid.Location = new System.Drawing.Point(93, 12);
            this.ResultDataGrid.Name = "ResultDataGrid";
            this.ResultDataGrid.Size = new System.Drawing.Size(477, 150);
            this.ResultDataGrid.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 174);
            this.Controls.Add(this.ResultDataGrid);
            this.Controls.Add(this.AgeButton);
            this.Controls.Add(this.NameButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NameButton;
        private System.Windows.Forms.Button AgeButton;
        private System.Windows.Forms.DataGridView ResultDataGrid;
    }
}

