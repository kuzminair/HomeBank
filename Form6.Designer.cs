
namespace HomeBank
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewAccount = new System.Windows.Forms.DataGridView();
            this.labelAccount = new System.Windows.Forms.Label();
            this.btnAccountUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSumma = new System.Windows.Forms.Label();
            this.btnChangeAccount = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(271, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Мои счета";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(130, 190);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(114, 38);
            this.btnAddAccount.TabIndex = 1;
            this.btnAddAccount.Text = "Добавить счет";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAddAccount_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Остатки по счетам";
            // 
            // dataGridViewAccount
            // 
            this.dataGridViewAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAccount.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAccount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAccount.Location = new System.Drawing.Point(53, 248);
            this.dataGridViewAccount.Name = "dataGridViewAccount";
            this.dataGridViewAccount.Size = new System.Drawing.Size(517, 177);
            this.dataGridViewAccount.TabIndex = 3;
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(29, 403);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(0, 13);
            this.labelAccount.TabIndex = 4;
            // 
            // btnAccountUpdate
            // 
            this.btnAccountUpdate.Location = new System.Drawing.Point(250, 190);
            this.btnAccountUpdate.Name = "btnAccountUpdate";
            this.btnAccountUpdate.Size = new System.Drawing.Size(114, 38);
            this.btnAccountUpdate.TabIndex = 5;
            this.btnAccountUpdate.Text = "Обновить данные";
            this.btnAccountUpdate.UseVisualStyleBackColor = true;
            this.btnAccountUpdate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAccountUpdate_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "*";
            // 
            // labelSumma
            // 
            this.labelSumma.AutoSize = true;
            this.labelSumma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumma.Location = new System.Drawing.Point(129, 428);
            this.labelSumma.Name = "labelSumma";
            this.labelSumma.Size = new System.Drawing.Size(72, 20);
            this.labelSumma.TabIndex = 7;
            this.labelSumma.Text = "ИТОГО:";
            // 
            // btnChangeAccount
            // 
            this.btnChangeAccount.Location = new System.Drawing.Point(370, 190);
            this.btnChangeAccount.Name = "btnChangeAccount";
            this.btnChangeAccount.Size = new System.Drawing.Size(114, 38);
            this.btnChangeAccount.TabIndex = 1;
            this.btnChangeAccount.Text = "Перевод между счетами";
            this.btnChangeAccount.UseVisualStyleBackColor = true;
            this.btnChangeAccount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnChangeAccount_MouseClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(370, 428);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 27);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Удалить счет";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDelete_MouseClick);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(601, 595);
            this.Controls.Add(this.labelSumma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAccountUpdate);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.dataGridViewAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChangeAccount);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Мои счета";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewAccount;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.Button btnAccountUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSumma;
        private System.Windows.Forms.Button btnChangeAccount;
        private System.Windows.Forms.Button btnDelete;
    }
}