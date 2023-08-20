
namespace HomeBank
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSummaExp = new System.Windows.Forms.TextBox();
            this.cBoxEspenseType2 = new System.Windows.Forms.ComboBox();
            this.cBChoiceAccount2 = new System.Windows.Forms.ComboBox();
            this.textBoxCommentExp = new System.Windows.Forms.TextBox();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.dateTimePickerExpense = new System.Windows.Forms.DateTimePicker();
            this.btnAddExpenseType = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сумма*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Тип затрат*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Счет*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Дата*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Комментарий";
            // 
            // textBoxSummaExp
            // 
            this.textBoxSummaExp.Location = new System.Drawing.Point(309, 256);
            this.textBoxSummaExp.Name = "textBoxSummaExp";
            this.textBoxSummaExp.Size = new System.Drawing.Size(164, 20);
            this.textBoxSummaExp.TabIndex = 1;
            // 
            // cBoxEspenseType2
            // 
            this.cBoxEspenseType2.FormattingEnabled = true;
            this.cBoxEspenseType2.Location = new System.Drawing.Point(309, 295);
            this.cBoxEspenseType2.Name = "cBoxEspenseType2";
            this.cBoxEspenseType2.Size = new System.Drawing.Size(164, 21);
            this.cBoxEspenseType2.TabIndex = 2;
            // 
            // cBChoiceAccount2
            // 
            this.cBChoiceAccount2.FormattingEnabled = true;
            this.cBChoiceAccount2.Location = new System.Drawing.Point(310, 334);
            this.cBChoiceAccount2.Name = "cBChoiceAccount2";
            this.cBChoiceAccount2.Size = new System.Drawing.Size(164, 21);
            this.cBChoiceAccount2.TabIndex = 3;
            // 
            // textBoxCommentExp
            // 
            this.textBoxCommentExp.Location = new System.Drawing.Point(309, 411);
            this.textBoxCommentExp.Name = "textBoxCommentExp";
            this.textBoxCommentExp.Size = new System.Drawing.Size(225, 20);
            this.textBoxCommentExp.TabIndex = 5;
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddExpense.Location = new System.Drawing.Point(310, 463);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(123, 39);
            this.btnAddExpense.TabIndex = 6;
            this.btnAddExpense.Text = "Записать";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAddExpense_MouseClick);
            // 
            // dateTimePickerExpense
            // 
            this.dateTimePickerExpense.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePickerExpense.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerExpense.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerExpense.Location = new System.Drawing.Point(310, 373);
            this.dateTimePickerExpense.Name = "dateTimePickerExpense";
            this.dateTimePickerExpense.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePickerExpense.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerExpense.TabIndex = 7;
            this.dateTimePickerExpense.Value = new System.DateTime(2023, 6, 18, 0, 0, 0, 0);
            // 
            // btnAddExpenseType
            // 
            this.btnAddExpenseType.Location = new System.Drawing.Point(479, 293);
            this.btnAddExpenseType.Name = "btnAddExpenseType";
            this.btnAddExpenseType.Size = new System.Drawing.Size(25, 23);
            this.btnAddExpenseType.TabIndex = 8;
            this.btnAddExpenseType.Text = "+";
            this.btnAddExpenseType.UseVisualStyleBackColor = true;
            this.btnAddExpenseType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAddExpenseType_MouseClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Location = new System.Drawing.Point(510, 293);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(25, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnUpdate_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(292, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "ДОБАВИТЬ РАСХОДЫ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 645);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddExpenseType);
            this.Controls.Add(this.dateTimePickerExpense);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.textBoxCommentExp);
            this.Controls.Add(this.cBChoiceAccount2);
            this.Controls.Add(this.cBoxEspenseType2);
            this.Controls.Add(this.textBoxSummaExp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расходы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSummaExp;
        private System.Windows.Forms.ComboBox cBoxEspenseType2;
        private System.Windows.Forms.ComboBox cBChoiceAccount2;
        private System.Windows.Forms.TextBox textBoxCommentExp;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpense;
        private System.Windows.Forms.Button btnAddExpenseType;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label6;
    }
}