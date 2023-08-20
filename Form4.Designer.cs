
namespace HomeBank
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.btnPeriodAll = new System.Windows.Forms.Button();
            this.btnPeriodChoice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSourcePr = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewProfit = new System.Windows.Forms.DataGridView();
            this.btnAddProfitSource = new System.Windows.Forms.Button();
            this.btnAddProfit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxAccount = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.processCalc = new System.Diagnostics.Process();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPeriodAll
            // 
            this.btnPeriodAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPeriodAll.Location = new System.Drawing.Point(273, 225);
            this.btnPeriodAll.Name = "btnPeriodAll";
            this.btnPeriodAll.Size = new System.Drawing.Size(134, 43);
            this.btnPeriodAll.TabIndex = 0;
            this.btnPeriodAll.Text = "За все время";
            this.btnPeriodAll.UseVisualStyleBackColor = true;
            this.btnPeriodAll.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPeriodAll_MouseClick);
            // 
            // btnPeriodChoice
            // 
            this.btnPeriodChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPeriodChoice.Location = new System.Drawing.Point(105, 225);
            this.btnPeriodChoice.Name = "btnPeriodChoice";
            this.btnPeriodChoice.Size = new System.Drawing.Size(118, 43);
            this.btnPeriodChoice.TabIndex = 1;
            this.btnPeriodChoice.Text = "За период";
            this.btnPeriodChoice.UseVisualStyleBackColor = true;
            this.btnPeriodChoice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPeriodChoice_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(298, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "СТАТИСТИКА ПО ДОХОДАМ";
            // 
            // comboBoxSourcePr
            // 
            this.comboBoxSourcePr.FormattingEnabled = true;
            this.comboBoxSourcePr.Location = new System.Drawing.Point(406, 300);
            this.comboBoxSourcePr.Name = "comboBoxSourcePr";
            this.comboBoxSourcePr.Size = new System.Drawing.Size(158, 21);
            this.comboBoxSourcePr.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Источник дохода";
            // 
            // dataGridViewProfit
            // 
            this.dataGridViewProfit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProfit.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProfit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProfit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProfit.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProfit.Location = new System.Drawing.Point(102, 339);
            this.dataGridViewProfit.Name = "dataGridViewProfit";
            this.dataGridViewProfit.Size = new System.Drawing.Size(620, 260);
            this.dataGridViewProfit.TabIndex = 4;
            // 
            // btnAddProfitSource
            // 
            this.btnAddProfitSource.Location = new System.Drawing.Point(502, 274);
            this.btnAddProfitSource.Name = "btnAddProfitSource";
            this.btnAddProfitSource.Size = new System.Drawing.Size(28, 23);
            this.btnAddProfitSource.TabIndex = 5;
            this.btnAddProfitSource.Text = "+";
            this.btnAddProfitSource.UseVisualStyleBackColor = true;
            this.btnAddProfitSource.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAddProfitSource_MouseClick);
            // 
            // btnAddProfit
            // 
            this.btnAddProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddProfit.Location = new System.Drawing.Point(465, 229);
            this.btnAddProfit.Name = "btnAddProfit";
            this.btnAddProfit.Size = new System.Drawing.Size(257, 39);
            this.btnAddProfit.TabIndex = 5;
            this.btnAddProfit.Text = "Внести новые доходы";
            this.btnAddProfit.UseVisualStyleBackColor = true;
            this.btnAddProfit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAddProfit_MouseClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Location = new System.Drawing.Point(536, 274);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(28, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnUpdate_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Выбрать счет";
            // 
            // comboBoxAccount
            // 
            this.comboBoxAccount.FormattingEnabled = true;
            this.comboBoxAccount.Location = new System.Drawing.Point(570, 300);
            this.comboBoxAccount.Name = "comboBoxAccount";
            this.comboBoxAccount.Size = new System.Drawing.Size(152, 21);
            this.comboBoxAccount.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(197, 279);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(76, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2023, 6, 18, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Начало периода";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Конец периода";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(197, 303);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(76, 20);
            this.dateTimePicker2.TabIndex = 6;
            this.dateTimePicker2.Value = new System.DateTime(2023, 6, 18, 0, 0, 0, 0);
            // 
            // labelUpdate
            // 
            this.labelUpdate.AutoSize = true;
            this.labelUpdate.Location = new System.Drawing.Point(13, 425);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(0, 13);
            this.labelUpdate.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 606);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "*";
            // 
            // btnCalc
            // 
            this.btnCalc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalc.BackgroundImage")));
            this.btnCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalc.Location = new System.Drawing.Point(315, 274);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(50, 50);
            this.btnCalc.TabIndex = 11;
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
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 684);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnAddProfit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddProfitSource);
            this.Controls.Add(this.dataGridViewProfit);
            this.Controls.Add(this.comboBoxAccount);
            this.Controls.Add(this.comboBoxSourcePr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPeriodChoice);
            this.Controls.Add(this.btnPeriodAll);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мои доходы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPeriodAll;
        private System.Windows.Forms.Button btnPeriodChoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSourcePr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewProfit;
        private System.Windows.Forms.Button btnAddProfitSource;
        private System.Windows.Forms.Button btnAddProfit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxAccount;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalc;
        private System.Diagnostics.Process processCalc;
    }
}