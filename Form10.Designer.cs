
namespace HomeBank
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.label1 = new System.Windows.Forms.Label();
            this.cBChoiceAccount1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBChoiceAccount2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Счет-отправитель";
            // 
            // cBChoiceAccount1
            // 
            this.cBChoiceAccount1.FormattingEnabled = true;
            this.cBChoiceAccount1.Location = new System.Drawing.Point(262, 126);
            this.cBChoiceAccount1.Name = "cBChoiceAccount1";
            this.cBChoiceAccount1.Size = new System.Drawing.Size(162, 21);
            this.cBChoiceAccount1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Счет-получатель";
            // 
            // cBChoiceAccount2
            // 
            this.cBChoiceAccount2.FormattingEnabled = true;
            this.cBChoiceAccount2.Location = new System.Drawing.Point(262, 176);
            this.cBChoiceAccount2.Name = "cBChoiceAccount2";
            this.cBChoiceAccount2.Size = new System.Drawing.Size(162, 21);
            this.cBChoiceAccount2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Сумма для перевода";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTransfer.Location = new System.Drawing.Point(214, 280);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(136, 39);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "Перевести";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTransfer_MouseClick);
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(262, 230);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(162, 20);
            this.textBoxSum.TabIndex = 3;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(548, 524);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.cBChoiceAccount2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBChoiceAccount1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form10";
            this.Text = "Перевод между счетами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBChoiceAccount1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBChoiceAccount2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox textBoxSum;
    }
}