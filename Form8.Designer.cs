
namespace HomeBank
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTypeExpens = new System.Windows.Forms.TextBox();
            this.btnAddExpens = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(95, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить тип расходов";
            // 
            // textBoxTypeExpens
            // 
            this.textBoxTypeExpens.Location = new System.Drawing.Point(89, 161);
            this.textBoxTypeExpens.Name = "textBoxTypeExpens";
            this.textBoxTypeExpens.Size = new System.Drawing.Size(198, 20);
            this.textBoxTypeExpens.TabIndex = 1;
            // 
            // btnAddExpens
            // 
            this.btnAddExpens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddExpens.Location = new System.Drawing.Point(139, 214);
            this.btnAddExpens.Name = "btnAddExpens";
            this.btnAddExpens.Size = new System.Drawing.Size(97, 28);
            this.btnAddExpens.TabIndex = 2;
            this.btnAddExpens.Text = "Записать";
            this.btnAddExpens.UseVisualStyleBackColor = true;
            this.btnAddExpens.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAddExpens_MouseClick);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(366, 361);
            this.Controls.Add(this.btnAddExpens);
            this.Controls.Add(this.textBoxTypeExpens);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8";
            this.Text = "Добавление статьи расходов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTypeExpens;
        private System.Windows.Forms.Button btnAddExpens;
    }
}