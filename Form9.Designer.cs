
namespace HomeBank
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.btnAddProfitSource = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProfitSource = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddProfitSource
            // 
            this.btnAddProfitSource.Location = new System.Drawing.Point(131, 219);
            this.btnAddProfitSource.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProfitSource.Name = "btnAddProfitSource";
            this.btnAddProfitSource.Size = new System.Drawing.Size(112, 28);
            this.btnAddProfitSource.TabIndex = 0;
            this.btnAddProfitSource.Text = "Записать";
            this.btnAddProfitSource.UseVisualStyleBackColor = true;
            this.btnAddProfitSource.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAddProfitSource_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавить источник дохода";
            // 
            // textBoxProfitSource
            // 
            this.textBoxProfitSource.Location = new System.Drawing.Point(77, 163);
            this.textBoxProfitSource.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProfitSource.Name = "textBoxProfitSource";
            this.textBoxProfitSource.Size = new System.Drawing.Size(215, 22);
            this.textBoxProfitSource.TabIndex = 2;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(366, 361);
            this.Controls.Add(this.textBoxProfitSource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddProfitSource);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form9";
            this.Text = "Добавить источник дохода";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProfitSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProfitSource;
    }
}