namespace Учебная_практика
{
    partial class UserMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMain));
            this.dataGridOrders = new System.Windows.Forms.DataGridView();
            this.btn_makeOrder = new System.Windows.Forms.Button();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridBooks = new System.Windows.Forms.DataGridView();
            this.btn_filter = new System.Windows.Forms.Button();
            this.textBoxFPubH = new System.Windows.Forms.TextBox();
            this.textBoxFPubL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chPubH = new System.Windows.Forms.CheckBox();
            this.chPubLoc = new System.Windows.Forms.CheckBox();
            this.dateTimeDrop = new System.Windows.Forms.DateTimePicker();
            this.dateTimeReturn = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textFPass = new System.Windows.Forms.TextBox();
            this.textSPass = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_ChPass = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridOrders
            // 
            this.dataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrders.Location = new System.Drawing.Point(12, 23);
            this.dataGridOrders.Name = "dataGridOrders";
            this.dataGridOrders.Size = new System.Drawing.Size(560, 150);
            this.dataGridOrders.TabIndex = 0;
            this.dataGridOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOrders_CellContentClick);
            // 
            // btn_makeOrder
            // 
            this.btn_makeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_makeOrder.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_makeOrder.Location = new System.Drawing.Point(623, 205);
            this.btn_makeOrder.Name = "btn_makeOrder";
            this.btn_makeOrder.Size = new System.Drawing.Size(117, 23);
            this.btn_makeOrder.TabIndex = 1;
            this.btn_makeOrder.Text = "Оформить заказ";
            this.btn_makeOrder.UseVisualStyleBackColor = false;
            this.btn_makeOrder.Click += new System.EventHandler(this.btn_makeOrder_Click);
            // 
            // comboBoxID
            // 
            this.comboBoxID.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(619, 68);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(121, 22);
            this.comboBoxID.TabIndex = 2;
            this.comboBoxID.SelectedIndexChanged += new System.EventHandler(this.comboBoxID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(616, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "id книги";
            // 
            // dataGridBooks
            // 
            this.dataGridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBooks.Location = new System.Drawing.Point(12, 257);
            this.dataGridBooks.Name = "dataGridBooks";
            this.dataGridBooks.Size = new System.Drawing.Size(984, 219);
            this.dataGridBooks.TabIndex = 4;
            // 
            // btn_filter
            // 
            this.btn_filter.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_filter.Location = new System.Drawing.Point(471, 208);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(85, 23);
            this.btn_filter.TabIndex = 5;
            this.btn_filter.Text = "Сортировать";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // textBoxFPubH
            // 
            this.textBoxFPubH.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFPubH.Location = new System.Drawing.Point(205, 208);
            this.textBoxFPubH.Name = "textBoxFPubH";
            this.textBoxFPubH.Size = new System.Drawing.Size(100, 20);
            this.textBoxFPubH.TabIndex = 11;
            // 
            // textBoxFPubL
            // 
            this.textBoxFPubL.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFPubL.Location = new System.Drawing.Point(344, 208);
            this.textBoxFPubL.Name = "textBoxFPubL";
            this.textBoxFPubL.Size = new System.Drawing.Size(100, 20);
            this.textBoxFPubL.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(202, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Издательство";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(341, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Место издания";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(12, 241);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "База библиотеки";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(9, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "Ваши заказы";
            // 
            // chPubH
            // 
            this.chPubH.AutoSize = true;
            this.chPubH.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chPubH.Location = new System.Drawing.Point(181, 193);
            this.chPubH.Name = "chPubH";
            this.chPubH.Size = new System.Drawing.Size(15, 14);
            this.chPubH.TabIndex = 33;
            this.chPubH.UseVisualStyleBackColor = true;
            // 
            // chPubLoc
            // 
            this.chPubLoc.AutoSize = true;
            this.chPubLoc.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chPubLoc.Location = new System.Drawing.Point(323, 193);
            this.chPubLoc.Name = "chPubLoc";
            this.chPubLoc.Size = new System.Drawing.Size(15, 14);
            this.chPubLoc.TabIndex = 34;
            this.chPubLoc.UseVisualStyleBackColor = true;
            // 
            // dateTimeDrop
            // 
            this.dateTimeDrop.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeDrop.Location = new System.Drawing.Point(619, 115);
            this.dateTimeDrop.Name = "dateTimeDrop";
            this.dateTimeDrop.Size = new System.Drawing.Size(139, 20);
            this.dateTimeDrop.TabIndex = 41;
            // 
            // dateTimeReturn
            // 
            this.dateTimeReturn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeReturn.Location = new System.Drawing.Point(619, 168);
            this.dateTimeReturn.Name = "dateTimeReturn";
            this.dateTimeReturn.Size = new System.Drawing.Size(139, 20);
            this.dateTimeReturn.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(616, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 14);
            this.label15.TabIndex = 43;
            this.label15.Text = "Дата доставки";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(616, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 14);
            this.label16.TabIndex = 44;
            this.label16.Text = "Дата возврата";
            // 
            // textFPass
            // 
            this.textFPass.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textFPass.Location = new System.Drawing.Point(865, 112);
            this.textFPass.Name = "textFPass";
            this.textFPass.Size = new System.Drawing.Size(100, 20);
            this.textFPass.TabIndex = 45;
            this.textFPass.UseSystemPasswordChar = true;
            this.textFPass.TextChanged += new System.EventHandler(this.textFPass_TextChanged);
            // 
            // textSPass
            // 
            this.textSPass.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSPass.Location = new System.Drawing.Point(865, 164);
            this.textSPass.Name = "textSPass";
            this.textSPass.Size = new System.Drawing.Size(100, 20);
            this.textSPass.TabIndex = 46;
            this.textSPass.UseSystemPasswordChar = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(862, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 14);
            this.label17.TabIndex = 47;
            this.label17.Text = "Новый пароль";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(862, 147);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 14);
            this.label18.TabIndex = 48;
            this.label18.Text = "Повторите  пароль";
            // 
            // btn_ChPass
            // 
            this.btn_ChPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_ChPass.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ChPass.Location = new System.Drawing.Point(865, 205);
            this.btn_ChPass.Name = "btn_ChPass";
            this.btn_ChPass.Size = new System.Drawing.Size(100, 23);
            this.btn_ChPass.TabIndex = 49;
            this.btn_ChPass.Text = "Сменить пароль";
            this.btn_ChPass.UseVisualStyleBackColor = false;
            this.btn_ChPass.Click += new System.EventHandler(this.btn_ChPass_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "Сортировать по:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(616, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "Оформление";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(861, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Смена пароля";
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1001, 485);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ChPass);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textSPass);
            this.Controls.Add(this.textFPass);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dateTimeReturn);
            this.Controls.Add(this.dateTimeDrop);
            this.Controls.Add(this.chPubLoc);
            this.Controls.Add(this.chPubH);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxFPubL);
            this.Controls.Add(this.textBoxFPubH);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.dataGridBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.btn_makeOrder);
            this.Controls.Add(this.dataGridOrders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserMain";
            this.Text = "Ваш профиль";
            this.Load += new System.EventHandler(this.UserMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOrders;
        private System.Windows.Forms.Button btn_makeOrder;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridBooks;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.TextBox textBoxFPubH;
        private System.Windows.Forms.TextBox textBoxFPubL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chPubH;
        private System.Windows.Forms.CheckBox chPubLoc;
        private System.Windows.Forms.DateTimePicker dateTimeDrop;
        private System.Windows.Forms.DateTimePicker dateTimeReturn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textFPass;
        private System.Windows.Forms.TextBox textSPass;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_ChPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}