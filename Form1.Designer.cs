
namespace HomeBank
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExpense = new System.Windows.Forms.Button();
            this.btnProfit = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.btnAddProfit = new System.Windows.Forms.Button();
            this.btnShowProfit = new System.Windows.Forms.Button();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.btnShowExpense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExpense
            // 
            this.btnExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExpense.Location = new System.Drawing.Point(185, 438);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(142, 69);
            this.btnExpense.TabIndex = 0;
            this.btnExpense.Text = "РАСХОДЫ";
            this.btnExpense.UseVisualStyleBackColor = true;
            this.btnExpense.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnExpense_MouseClick);
            // 
            // btnProfit
            // 
            this.btnProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProfit.Location = new System.Drawing.Point(185, 330);
            this.btnProfit.Name = "btnProfit";
            this.btnProfit.Size = new System.Drawing.Size(142, 64);
            this.btnProfit.TabIndex = 1;
            this.btnProfit.Text = "ДОХОДЫ";
            this.btnProfit.UseVisualStyleBackColor = true;
            this.btnProfit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnProfit_MouseClick);
            // 
            // btnAccount
            // 
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAccount.Location = new System.Drawing.Point(185, 220);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(142, 67);
            this.btnAccount.TabIndex = 2;
            this.btnAccount.Text = "МОИ СЧЕТА";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAccount_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(209, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "ДОМАШНИЙ БАНК";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddAccount.Location = new System.Drawing.Point(360, 220);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(142, 29);
            this.btnAddAccount.TabIndex = 2;
            this.btnAddAccount.Text = "Добавить";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAddAccount_MouseClick);
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowAccount.Location = new System.Drawing.Point(360, 258);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(142, 29);
            this.btnShowAccount.TabIndex = 2;
            this.btnShowAccount.Text = "Аналитика";
            this.btnShowAccount.UseVisualStyleBackColor = true;
            this.btnShowAccount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnShowAccount_MouseClick);
            // 
            // btnAddProfit
            // 
            this.btnAddProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddProfit.Location = new System.Drawing.Point(360, 330);
            this.btnAddProfit.Name = "btnAddProfit";
            this.btnAddProfit.Size = new System.Drawing.Size(142, 29);
            this.btnAddProfit.TabIndex = 2;
            this.btnAddProfit.Text = "Добавить";
            this.btnAddProfit.UseVisualStyleBackColor = true;
            this.btnAddProfit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAddProfit_MouseClick);
            // 
            // btnShowProfit
            // 
            this.btnShowProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowProfit.Location = new System.Drawing.Point(360, 365);
            this.btnShowProfit.Name = "btnShowProfit";
            this.btnShowProfit.Size = new System.Drawing.Size(142, 29);
            this.btnShowProfit.TabIndex = 2;
            this.btnShowProfit.Text = "Аналитика";
            this.btnShowProfit.UseVisualStyleBackColor = true;
            this.btnShowProfit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnShowProfit_MouseClick);
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddExpense.Location = new System.Drawing.Point(360, 438);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(142, 29);
            this.btnAddExpense.TabIndex = 2;
            this.btnAddExpense.Text = "Добавить";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAddExpense_MouseClick);
            // 
            // btnShowExpense
            // 
            this.btnShowExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowExpense.Location = new System.Drawing.Point(360, 478);
            this.btnShowExpense.Name = "btnShowExpense";
            this.btnShowExpense.Size = new System.Drawing.Size(142, 29);
            this.btnShowExpense.TabIndex = 2;
            this.btnShowExpense.Text = "Аналитика";
            this.btnShowExpense.UseVisualStyleBackColor = true;
            this.btnShowExpense.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnShowExpense_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(676, 671);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowExpense);
            this.Controls.Add(this.btnShowProfit);
            this.Controls.Add(this.btnShowAccount);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.btnAddProfit);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnProfit);
            this.Controls.Add(this.btnExpense);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Домашний банк";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExpense;
        private System.Windows.Forms.Button btnProfit;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.Button btnAddProfit;
        private System.Windows.Forms.Button btnShowProfit;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Button btnShowExpense;
    }
}

