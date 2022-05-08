namespace WindowsFormsApp
{
    partial class ListFindCountries_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Countries_listBox = new System.Windows.Forms.ListBox();
            this.Countries_comboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GetOutput_button = new System.Windows.Forms.Button();
            this.Name_domainUpDown = new System.Windows.Forms.DomainUpDown();
            this.Id_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Categories_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.find_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Id_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Countries_listBox);
            this.panel1.Controls.Add(this.Countries_comboBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 194);
            this.panel1.TabIndex = 0;
            // 
            // Countries_listBox
            // 
            this.Countries_listBox.FormattingEnabled = true;
            this.Countries_listBox.Location = new System.Drawing.Point(4, 30);
            this.Countries_listBox.Name = "Countries_listBox";
            this.Countries_listBox.Size = new System.Drawing.Size(214, 160);
            this.Countries_listBox.TabIndex = 1;
            // 
            // Countries_comboBox
            // 
            this.Countries_comboBox.FormattingEnabled = true;
            this.Countries_comboBox.Location = new System.Drawing.Point(3, 3);
            this.Countries_comboBox.Name = "Countries_comboBox";
            this.Countries_comboBox.Size = new System.Drawing.Size(215, 21);
            this.Countries_comboBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GetOutput_button);
            this.panel2.Controls.Add(this.Name_domainUpDown);
            this.panel2.Controls.Add(this.Id_numericUpDown);
            this.panel2.Controls.Add(this.Categories_checkedListBox);
            this.panel2.Controls.Add(this.find_label);
            this.panel2.Location = new System.Drawing.Point(277, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 194);
            this.panel2.TabIndex = 1;
            // 
            // GetOutput_button
            // 
            this.GetOutput_button.Location = new System.Drawing.Point(6, 167);
            this.GetOutput_button.Name = "GetOutput_button";
            this.GetOutput_button.Size = new System.Drawing.Size(143, 23);
            this.GetOutput_button.TabIndex = 4;
            this.GetOutput_button.Text = "Найти";
            this.GetOutput_button.UseVisualStyleBackColor = true;
            // 
            // Name_domainUpDown
            // 
            this.Name_domainUpDown.Location = new System.Drawing.Point(6, 126);
            this.Name_domainUpDown.Name = "Name_domainUpDown";
            this.Name_domainUpDown.Size = new System.Drawing.Size(143, 20);
            this.Name_domainUpDown.TabIndex = 3;
            // 
            // Id_numericUpDown
            // 
            this.Id_numericUpDown.Location = new System.Drawing.Point(6, 100);
            this.Id_numericUpDown.Name = "Id_numericUpDown";
            this.Id_numericUpDown.Size = new System.Drawing.Size(143, 20);
            this.Id_numericUpDown.TabIndex = 2;
            // 
            // Categories_checkedListBox
            // 
            this.Categories_checkedListBox.FormattingEnabled = true;
            this.Categories_checkedListBox.Location = new System.Drawing.Point(6, 30);
            this.Categories_checkedListBox.Name = "Categories_checkedListBox";
            this.Categories_checkedListBox.Size = new System.Drawing.Size(143, 49);
            this.Categories_checkedListBox.TabIndex = 1;
            // 
            // find_label
            // 
            this.find_label.AutoSize = true;
            this.find_label.Location = new System.Drawing.Point(3, 6);
            this.find_label.Name = "find_label";
            this.find_label.Size = new System.Drawing.Size(41, 13);
            this.find_label.TabIndex = 0;
            this.find_label.Text = "Найти:";
            // 
            // ListFindCountries_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 224);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ListFindCountries_Form";
            this.Text = "Форма списка и поиска стран";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Id_numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox Countries_listBox;
        private System.Windows.Forms.ComboBox Countries_comboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label find_label;
        private System.Windows.Forms.CheckedListBox Categories_checkedListBox;
        private System.Windows.Forms.NumericUpDown Id_numericUpDown;
        private System.Windows.Forms.DomainUpDown Name_domainUpDown;
        private System.Windows.Forms.Button GetOutput_button;
    }
}

