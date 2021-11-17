namespace WindowsFormsApp1.VIew
{
    partial class FormComponent
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNameComponent = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLavel = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonUpgrate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameComponent
            // 
            this.labelNameComponent.AutoSize = true;
            this.labelNameComponent.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameComponent.Location = new System.Drawing.Point(3, 158);
            this.labelNameComponent.Name = "labelNameComponent";
            this.labelNameComponent.Size = new System.Drawing.Size(106, 28);
            this.labelNameComponent.TabIndex = 0;
            this.labelNameComponent.Text = "Компонент";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 152);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelLavel
            // 
            this.labelLavel.AutoSize = true;
            this.labelLavel.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLavel.Location = new System.Drawing.Point(3, 189);
            this.labelLavel.Name = "labelLavel";
            this.labelLavel.Size = new System.Drawing.Size(79, 28);
            this.labelLavel.TabIndex = 3;
            this.labelLavel.Text = "Уровень";
            this.labelLavel.Click += new System.EventHandler(this.labelLavel_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuy.Location = new System.Drawing.Point(3, 220);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(190, 37);
            this.buttonBuy.TabIndex = 4;
            this.buttonBuy.Text = "Купить";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonUpgrate
            // 
            this.buttonUpgrate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonUpgrate.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpgrate.Location = new System.Drawing.Point(0, 260);
            this.buttonUpgrate.Name = "buttonUpgrate";
            this.buttonUpgrate.Size = new System.Drawing.Size(196, 36);
            this.buttonUpgrate.TabIndex = 5;
            this.buttonUpgrate.Text = "Улучшить";
            this.buttonUpgrate.UseVisualStyleBackColor = true;
            this.buttonUpgrate.Click += new System.EventHandler(this.buttonUpgrate_Click);
            // 
            // FormComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.buttonUpgrate);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.labelLavel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelNameComponent);
            this.Name = "FormComponent";
            this.Size = new System.Drawing.Size(196, 296);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameComponent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLavel;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonUpgrate;
    }
}
