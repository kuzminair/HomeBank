
namespace HomeBank
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAccountName = new System.Windows.Forms.TextBox();
            this.textBoxAccountComment = new System.Windows.Forms.TextBox();
            this.btnSaveAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить новый счет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Наименование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Комментарий";
            // 
            // textBoxAccountName
            // 
            this.textBoxAccountName.Location = new System.Drawing.Point(315, 217);
            this.textBoxAccountName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAccountName.Name = "textBoxAccountName";
            this.textBoxAccountName.Size = new System.Drawing.Size(242, 22);
            this.textBoxAccountName.TabIndex = 1;
            // 
            // textBoxAccountComment
            // 
            this.textBoxAccountComment.Location = new System.Drawing.Point(315, 261);
            this.textBoxAccountComment.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAccountComment.Name = "textBoxAccountComment";
            this.textBoxAccountComment.Size = new System.Drawing.Size(242, 22);
            this.textBoxAccountComment.TabIndex = 1;
            // 
            // btnSaveAccount
            // 
            this.btnSaveAccount.Location = new System.Drawing.Point(301, 346);
            this.btnSaveAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveAccount.Name = "btnSaveAccount";
            this.btnSaveAccount.Size = new System.Drawing.Size(112, 28);
            this.btnSaveAccount.TabIndex = 2;
            this.btnSaveAccount.Text = "Записать";
            this.btnSaveAccount.UseVisualStyleBackColor = true;
            this.btnSaveAccount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSaveAccount_MouseClick);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(690, 583);
            this.Controls.Add(this.btnSaveAccount);
            this.Controls.Add(this.textBoxAccountComment);
            this.Controls.Add(this.textBoxAccountName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form7";
            this.Text = "Добавление счета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAccountName;
        private System.Windows.Forms.TextBox textBoxAccountComment;
        private System.Windows.Forms.Button btnSaveAccount;
    }
}