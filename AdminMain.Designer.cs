namespace Учебная_практика
{
    partial class AdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMain));
            this.btn_book = new System.Windows.Forms.Button();
            this.btn_reader = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_book
            // 
            this.btn_book.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_book.Location = new System.Drawing.Point(52, 49);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(107, 66);
            this.btn_book.TabIndex = 0;
            this.btn_book.Text = "Книги";
            this.btn_book.UseVisualStyleBackColor = true;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // btn_reader
            // 
            this.btn_reader.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_reader.Location = new System.Drawing.Point(52, 196);
            this.btn_reader.Name = "btn_reader";
            this.btn_reader.Size = new System.Drawing.Size(107, 62);
            this.btn_reader.TabIndex = 1;
            this.btn_reader.Text = "Читатели";
            this.btn_reader.UseVisualStyleBackColor = true;
            this.btn_reader.Click += new System.EventHandler(this.btn_reader_Click);
            // 
            // btn_order
            // 
            this.btn_order.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_order.Location = new System.Drawing.Point(52, 121);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(107, 63);
            this.btn_order.TabIndex = 2;
            this.btn_order.Text = "Заказы";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Меню";
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(211, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.btn_reader);
            this.Controls.Add(this.btn_book);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMain";
            this.Text = "Администратор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.Button btn_reader;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Label label1;
    }
}