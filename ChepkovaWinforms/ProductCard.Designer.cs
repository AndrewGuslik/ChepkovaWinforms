namespace ChepkovaWinforms
{
    partial class ProductCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCard));
            this.Iimg = new System.Windows.Forms.PictureBox();
            this.Iarticul = new System.Windows.Forms.Label();
            this.IprodName = new System.Windows.Forms.Label();
            this.Iprice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Iimg)).BeginInit();
            this.SuspendLayout();
            // 
            // Iimg
            // 
            this.Iimg.Image = ((System.Drawing.Image)(resources.GetObject("Iimg.Image")));
            this.Iimg.Location = new System.Drawing.Point(22, 31);
            this.Iimg.Name = "Iimg";
            this.Iimg.Size = new System.Drawing.Size(100, 50);
            this.Iimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Iimg.TabIndex = 1;
            this.Iimg.TabStop = false;
            // 
            // Iarticul
            // 
            this.Iarticul.AutoSize = true;
            this.Iarticul.Location = new System.Drawing.Point(154, 48);
            this.Iarticul.Name = "Iarticul";
            this.Iarticul.Size = new System.Drawing.Size(53, 15);
            this.Iarticul.TabIndex = 2;
            this.Iarticul.Text = "Артикул";
            // 
            // IprodName
            // 
            this.IprodName.AutoSize = true;
            this.IprodName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IprodName.Location = new System.Drawing.Point(246, 31);
            this.IprodName.Name = "IprodName";
            this.IprodName.Size = new System.Drawing.Size(145, 15);
            this.IprodName.TabIndex = 3;
            this.IprodName.Text = "Наименование продукта";
            // 
            // Iprice
            // 
            this.Iprice.AutoSize = true;
            this.Iprice.Location = new System.Drawing.Point(485, 31);
            this.Iprice.Name = "Iprice";
            this.Iprice.Size = new System.Drawing.Size(67, 15);
            this.Iprice.TabIndex = 4;
            this.Iprice.Text = "Стоимость";
            // 
            // ProductCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.Iprice);
            this.Controls.Add(this.IprodName);
            this.Controls.Add(this.Iarticul);
            this.Controls.Add(this.Iimg);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(617, 118);
            ((System.ComponentModel.ISupportInitialize)(this.Iimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Iimg;
        private Label Iarticul;
        private Label IprodName;
        private Label Iprice;
    }
}
