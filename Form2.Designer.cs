
namespace HomeBank
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.btnPeriodExpense = new System.Windows.Forms.Button();
            this.cBoxEspenseType = new System.Windows.Forms.ComboBox();
            this.labelExpenseType = new System.Windows.Forms.Label();
            this.labelChoiceAccount = new System.Windows.Forms.Label();
            this.cBChoiceAccount = new System.Windows.Forms.ComboBox();
            this.dataGridViewExpense = new System.Windows.Forms.DataGridView();
            this.labelUpdateExpense = new System.Windows.Forms.Label();
            this.btnAddTypeExpens = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnPeriodChoice = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.processCalc = new System.Diagnostics.Process();
            this.labelSum = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpense)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(299, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "СТАТИСТИКА ПО РАСХОДАМ";
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddExpense.Location = new System.Drawing.Point(477, 187);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(266, 38);
            this.btnAddExpense.TabIndex = 1;
            this.btnAddExpense.Text = "Внести новые расходы";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAddExpense_MouseClick);
            // 
            // btnPeriodExpense
            // 
            this.btnPeriodExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPeriodExpense.Location = new System.Drawing.Point(313, 187);
            this.btnPeriodExpense.Name = "btnPeriodExpense";
            this.btnPeriodExpense.Size = new System.Drawing.Size(117, 38);
            this.btnPeriodExpense.TabIndex = 2;
            this.btnPeriodExpense.Text = "За все время";
            this.btnPeriodExpense.UseVisualStyleBackColor = true;
            this.btnPeriodExpense.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPeriodExpense_MouseClick);
            // 
            // cBoxEspenseType
            // 
            this.cBoxEspenseType.FormattingEnabled = true;
            this.cBoxEspenseType.Location = new System.Drawing.Point(444, 263);
            this.cBoxEspenseType.Name = "cBoxEspenseType";
            this.cBoxEspenseType.Size = new System.Drawing.Size(149, 21);
            this.cBoxEspenseType.TabIndex = 3;
            // 
            // labelExpenseType
            // 
            this.labelExpenseType.AutoSize = true;
            this.labelExpenseType.Location = new System.Drawing.Point(450, 240);
            this.labelExpenseType.Name = "labelExpenseType";
            this.labelExpenseType.Size = new System.Drawing.Size(70, 13);
            this.labelExpenseType.TabIndex = 4;
            this.labelExpenseType.Text = "Тип расхода";
            // 
            // labelChoiceAccount
            // 
            this.labelChoiceAccount.AutoSize = true;
            this.labelChoiceAccount.Location = new System.Drawing.Point(606, 240);
            this.labelChoiceAccount.Name = "labelChoiceAccount";
            this.labelChoiceAccount.Size = new System.Drawing.Size(76, 13);
            this.labelChoiceAccount.TabIndex = 4;
            this.labelChoiceAccount.Text = "Выбрать счет";
            // 
            // cBChoiceAccount
            // 
            this.cBChoiceAccount.FormattingEnabled = true;
            this.cBChoiceAccount.Location = new System.Drawing.Point(599, 263);
            this.cBChoiceAccount.Name = "cBChoiceAccount";
            this.cBChoiceAccount.Size = new System.Drawing.Size(144, 21);
            this.cBChoiceAccount.TabIndex = 3;
            // 
            // dataGridViewExpense
            // 
            this.dataGridViewExpense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewExpense.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExpense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExpense.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewExpense.Location = new System.Drawing.Point(55, 300);
            this.dataGridViewExpense.Name = "dataGridViewExpense";
            this.dataGridViewExpense.Size = new System.Drawing.Size(744, 281);
            this.dataGridViewExpense.TabIndex = 5;
            // 
            // labelUpdateExpense
            // 
            this.labelUpdateExpense.AutoSize = true;
            this.labelUpdateExpense.Location = new System.Drawing.Point(13, 377);
            this.labelUpdateExpense.Name = "labelUpdateExpense";
            this.labelUpdateExpense.Size = new System.Drawing.Size(0, 13);
            this.labelUpdateExpense.TabIndex = 6;
            // 
            // btnAddTypeExpens
            // 
            this.btnAddTypeExpens.Location = new System.Drawing.Point(526, 235);
            this.btnAddTypeExpens.Name = "btnAddTypeExpens";
            this.btnAddTypeExpens.Size = new System.Drawing.Size(27, 23);
            this.btnAddTypeExpens.TabIndex = 7;
            this.btnAddTypeExpens.Text = "+";
            this.btnAddTypeExpens.UseVisualStyleBackColor = true;
            this.btnAddTypeExpens.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAddTypeExpens_MouseClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Location = new System.Drawing.Point(559, 235);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(27, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnUpdate_MouseClick);
            // 
            // btnPeriodChoice
            // 
            this.btnPeriodChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPeriodChoice.Location = new System.Drawing.Point(122, 187);
            this.btnPeriodChoice.Name = "btnPeriodChoice";
            this.btnPeriodChoice.Size = new System.Drawing.Size(117, 38);
            this.btnPeriodChoice.TabIndex = 2;
            this.btnPeriodChoice.Text = "За период";
            this.btnPeriodChoice.UseVisualStyleBackColor = true;
            this.btnPeriodChoice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPeriodChoice_MouseClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(218, 240);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(84, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2023, 6, 18, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Начало периода";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Конец периода";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(218, 266);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(84, 20);
            this.dateTimePicker2.TabIndex = 8;
            this.dateTimePicker2.Value = new System.DateTime(2023, 6, 18, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 613);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "*";
            // 
            // btnCalc
            // 
            this.btnCalc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalc.BackgroundImage")));
            this.btnCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalc.Location = new System.Drawing.Point(346, 234);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(50, 50);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCalc_MouseClick);
            // 
            // processCalc
            // 
            this.processCalc.StartInfo.Domain = "";
            this.processCalc.StartInfo.LoadUserProfile = false;
            this.processCalc.StartInfo.Password = null;
            this.processCalc.StartInfo.StandardErrorEncoding = null;
            this.processCalc.StartInfo.StandardOutputEncoding = null;
            this.processCalc.StartInfo.UserName = "";
            this.processCalc.SynchronizingObject = this;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.Location = new System.Drawing.Point(126, 588);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(72, 20);
            this.labelSum.TabIndex = 11;
            this.labelSum.Text = "ИТОГО:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(632, 587);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 38);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить строку";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDelete_MouseClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 697);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddTypeExpens);
            this.Controls.Add(this.labelUpdateExpense);
            this.Controls.Add(this.dataGridViewExpense);
            this.Controls.Add(this.labelChoiceAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelExpenseType);
            this.Controls.Add(this.cBChoiceAccount);
            this.Controls.Add(this.cBoxEspenseType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPeriodChoice);
            this.Controls.Add(this.btnPeriodExpense);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мои расходы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Button btnPeriodExpense;
        private System.Windows.Forms.ComboBox cBoxEspenseType;
        private System.Windows.Forms.Label labelExpenseType;
        private System.Windows.Forms.Label labelChoiceAccount;
        private System.Windows.Forms.ComboBox cBChoiceAccount;
        private System.Windows.Forms.DataGridView dataGridViewExpense;
        private System.Windows.Forms.Label labelUpdateExpense;
        private System.Windows.Forms.Button btnAddTypeExpens;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnPeriodChoice;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalc;
        private System.Diagnostics.Process processCalc;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Button btnDelete;
    }
}