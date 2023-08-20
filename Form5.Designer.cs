
namespace HomeBank
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxProfitSource = new System.Windows.Forms.ComboBox();
            this.textBoxSummProfit = new System.Windows.Forms.TextBox();
            this.comboBoxAccount = new System.Windows.Forms.ComboBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.btnAddProfitSource = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnSaveProfit = new System.Windows.Forms.Button();
            this.dateTimePickerProfit = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUpdateAcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(239, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ДОБАВИТЬ ДОХОДЫ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Сумма*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Источник*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Дата*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Счет для зачисления*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Комментарий";
            // 
            // comboBoxProfitSource
            // 
            this.comboBoxProfitSource.FormattingEnabled = true;
            this.comboBoxProfitSource.Location = new System.Drawing.Point(253, 235);
            this.comboBoxProfitSource.Name = "comboBoxProfitSource";
            this.comboBoxProfitSource.Size = new System.Drawing.Size(164, 21);
            this.comboBoxProfitSource.TabIndex = 1;
            // 
            // textBoxSummProfit
            // 
            this.textBoxSummProfit.Location = new System.Drawing.Point(253, 196);
            this.textBoxSummProfit.Name = "textBoxSummProfit";
            this.textBoxSummProfit.Size = new System.Drawing.Size(164, 20);
            this.textBoxSummProfit.TabIndex = 2;
            // 
            // comboBoxAccount
            // 
            this.comboBoxAccount.FormattingEnabled = true;
            this.comboBoxAccount.Location = new System.Drawing.Point(253, 317);
            this.comboBoxAccount.Name = "comboBoxAccount";
            this.comboBoxAccount.Size = new System.Drawing.Size(164, 21);
            this.comboBoxAccount.TabIndex = 4;
            // 
            // textBoxComment
            // 
            this.textBoxComment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxComment.Location = new System.Drawing.Point(253, 358);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(228, 20);
            this.textBoxComment.TabIndex = 5;
            // 
            // btnAddProfitSource
            // 
            this.btnAddProfitSource.Location = new System.Drawing.Point(423, 233);
            this.btnAddProfitSource.Name = "btnAddProfitSource";
            this.btnAddProfitSource.Size = new System.Drawing.Size(26, 23);
            this.btnAddProfitSource.TabIndex = 6;
            this.btnAddProfitSource.Text = "+";
            this.btnAddProfitSource.UseVisualStyleBackColor = true;
            this.btnAddProfitSource.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAddProfitSource_MouseClick);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(423, 315);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(26, 23);
            this.btnAddAccount.TabIndex = 6;
            this.btnAddAccount.Text = "+";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAddAccount_MouseClick);
            // 
            // btnSaveProfit
            // 
            this.btnSaveProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveProfit.Location = new System.Drawing.Point(253, 409);
            this.btnSaveProfit.Name = "btnSaveProfit";
            this.btnSaveProfit.Size = new System.Drawing.Size(122, 35);
            this.btnSaveProfit.TabIndex = 7;
            this.btnSaveProfit.Text = "Записать";
            this.btnSaveProfit.UseVisualStyleBackColor = true;
            this.btnSaveProfit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSaveProfit_MouseClick);
            // 
            // dateTimePickerProfit
            // 
            this.dateTimePickerProfit.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerProfit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerProfit.Location = new System.Drawing.Point(253, 275);
            this.dateTimePickerProfit.Name = "dateTimePickerProfit";
            this.dateTimePickerProfit.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerProfit.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Location = new System.Drawing.Point(455, 233);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(26, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnUpdate_MouseClick);
            // 
            // btnUpdateAcc
            // 
            this.btnUpdateAcc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateAcc.BackgroundImage")));
            this.btnUpdateAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateAcc.Location = new System.Drawing.Point(455, 315);
            this.btnUpdateAcc.Name = "btnUpdateAcc";
            this.btnUpdateAcc.Size = new System.Drawing.Size(26, 23);
            this.btnUpdateAcc.TabIndex = 6;
            this.btnUpdateAcc.UseVisualStyleBackColor = true;
            this.btnUpdateAcc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAddProfitSource_MouseClick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 595);
            this.Controls.Add(this.dateTimePickerProfit);
            this.Controls.Add(this.btnSaveProfit);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.btnUpdateAcc);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddProfitSource);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.comboBoxAccount);
            this.Controls.Add(this.textBoxSummProfit);
            this.Controls.Add(this.comboBoxProfitSource);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Доходы";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form5_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxProfitSource;
        private System.Windows.Forms.TextBox textBoxSummProfit;
        private System.Windows.Forms.ComboBox comboBoxAccount;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button btnAddProfitSource;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnSaveProfit;
        private System.Windows.Forms.DateTimePicker dateTimePickerProfit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUpdateAcc;
    }
}