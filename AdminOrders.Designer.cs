namespace Учебная_практика
{
    partial class AdminOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminOrders));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboReader = new System.Windows.Forms.ComboBox();
            this.comboBook = new System.Windows.Forms.ComboBox();
            this.dateTimeDrop = new System.Windows.Forms.DateTimePicker();
            this.dateTimeReturn = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_reader = new System.Windows.Forms.Button();
            this.btn_book = new System.Windows.Forms.Button();
            this.btn_drop = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_upd = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.dataGridDebtor = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDebtor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 272);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboReader
            // 
            this.comboReader.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboReader.FormattingEnabled = true;
            this.comboReader.Location = new System.Drawing.Point(23, 384);
            this.comboReader.Name = "comboReader";
            this.comboReader.Size = new System.Drawing.Size(121, 22);
            this.comboReader.TabIndex = 1;
            // 
            // comboBook
            // 
            this.comboBook.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBook.FormattingEnabled = true;
            this.comboBook.Location = new System.Drawing.Point(274, 385);
            this.comboBook.Name = "comboBook";
            this.comboBook.Size = new System.Drawing.Size(121, 22);
            this.comboBook.TabIndex = 2;
            // 
            // dateTimeDrop
            // 
            this.dateTimeDrop.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeDrop.Location = new System.Drawing.Point(484, 326);
            this.dateTimeDrop.Name = "dateTimeDrop";
            this.dateTimeDrop.Size = new System.Drawing.Size(123, 20);
            this.dateTimeDrop.TabIndex = 3;
            this.dateTimeDrop.Value = new System.DateTime(2020, 4, 20, 0, 0, 0, 0);
            // 
            // dateTimeReturn
            // 
            this.dateTimeReturn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeReturn.Location = new System.Drawing.Point(484, 413);
            this.dateTimeReturn.Name = "dateTimeReturn";
            this.dateTimeReturn.Size = new System.Drawing.Size(123, 20);
            this.dateTimeReturn.TabIndex = 4;
            this.dateTimeReturn.Value = new System.DateTime(2020, 4, 20, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Читатель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(277, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Книга";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(481, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата выдачи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(481, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата возврата";
            // 
            // comboBoxID
            // 
            this.comboBoxID.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(23, 315);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(90, 22);
            this.comboBoxID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID  изменения/удаления";
            // 
            // btn_reader
            // 
            this.btn_reader.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_reader.Location = new System.Drawing.Point(23, 420);
            this.btn_reader.Name = "btn_reader";
            this.btn_reader.Size = new System.Drawing.Size(75, 29);
            this.btn_reader.TabIndex = 11;
            this.btn_reader.Text = "Изменить";
            this.btn_reader.UseVisualStyleBackColor = true;
            this.btn_reader.Click += new System.EventHandler(this.btn_reader_Click);
            // 
            // btn_book
            // 
            this.btn_book.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_book.Location = new System.Drawing.Point(274, 420);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(75, 29);
            this.btn_book.TabIndex = 12;
            this.btn_book.Text = "Изменить ";
            this.btn_book.UseVisualStyleBackColor = true;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // btn_drop
            // 
            this.btn_drop.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_drop.Location = new System.Drawing.Point(519, 352);
            this.btn_drop.Name = "btn_drop";
            this.btn_drop.Size = new System.Drawing.Size(88, 25);
            this.btn_drop.TabIndex = 13;
            this.btn_drop.Text = "Изменить";
            this.btn_drop.UseVisualStyleBackColor = true;
            this.btn_drop.Click += new System.EventHandler(this.btn_drop_Click);
            // 
            // btn_return
            // 
            this.btn_return.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_return.Location = new System.Drawing.Point(519, 439);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(88, 25);
            this.btn_return.TabIndex = 14;
            this.btn_return.Text = "Изменить";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add.Location = new System.Drawing.Point(142, 315);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 25);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_upd
            // 
            this.btn_upd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_upd.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_upd.Location = new System.Drawing.Point(223, 315);
            this.btn_upd.Name = "btn_upd";
            this.btn_upd.Size = new System.Drawing.Size(106, 25);
            this.btn_upd.TabIndex = 16;
            this.btn_upd.Text = "Изменить все";
            this.btn_upd.UseVisualStyleBackColor = false;
            this.btn_upd.Click += new System.EventHandler(this.btn_upd_Click);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_del.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_del.Location = new System.Drawing.Point(335, 315);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 25);
            this.btn_del.TabIndex = 17;
            this.btn_del.Text = "Удалить";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // dataGridDebtor
            // 
            this.dataGridDebtor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDebtor.Location = new System.Drawing.Point(645, 44);
            this.dataGridDebtor.Name = "dataGridDebtor";
            this.dataGridDebtor.Size = new System.Drawing.Size(272, 429);
            this.dataGridDebtor.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(824, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Задолжники";
            // 
            // AdminOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(929, 485);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridDebtor);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_upd);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_drop);
            this.Controls.Add(this.btn_book);
            this.Controls.Add(this.btn_reader);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeReturn);
            this.Controls.Add(this.dateTimeDrop);
            this.Controls.Add(this.comboBook);
            this.Controls.Add(this.comboReader);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminOrders";
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDebtor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboReader;
        private System.Windows.Forms.ComboBox comboBook;
        private System.Windows.Forms.DateTimePicker dateTimeDrop;
        private System.Windows.Forms.DateTimePicker dateTimeReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_reader;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.Button btn_drop;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_upd;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.DataGridView dataGridDebtor;
        private System.Windows.Forms.Label label6;
    }
}