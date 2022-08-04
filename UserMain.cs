using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Учебная_практика
{
    public partial class UserMain : Form
    {
        private DataTable dtBook = new DataTable();
        private DataTable dtOrder = new DataTable();
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Библиотека13;Integrated Security=True";
        string[] table = { "id", "название", "автор", "год", "жанр", "издательство", "местоИзд", "язык", "формат", "КолСтр", "местоХран" };
        int UserID = 0;
        // Инициализация компонентов окна
        public UserMain(int id)
        {
            InitializeComponent();
            UserID = id; 
            dateTimeDrop.CustomFormat = "dd.MM.yyyy";
            dateTimeDrop.Format = DateTimePickerFormat.Custom;
            dateTimeReturn.CustomFormat = "dd.MM.yyyy";
            dateTimeReturn.Format = DateTimePickerFormat.Custom;
            // Обновление таблиц
            UpdateLib();
            UpdateOrder();
        }

        // Обновление таблицы книг

        private void UpdateLib()
        {
                string sql = "SELECT к.id AS 'ID книги', к.название AS 'Название', к.автор AS 'Автор',  к.жанр AS 'Жанр', к.издательство AS 'Издательство', к.местоИзд AS 'Место издательства', к.язык AS 'Язык', к.формат AS 'Формат книги',  к.местоХран AS 'Место хранения' FROM Книга к";
                //int cnt = 0;
                bool fAND = false;
            // условия в запросе

            if (textBoxFPubH.Text != "" || textBoxFPubL.Text != "")
                if (chPubH.Checked || chPubLoc.Checked)
                    sql += "WHERE";

               filter(ref sql, ref fAND, chPubH.Checked, table[5], textBoxFPubH.Text);
             filter(ref sql, ref fAND, chPubLoc.Checked, table[6], textBoxFPubL.Text);

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(sql, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    dtBook.Clear();
                    dtBook.Load(reader);
                    dataGridBooks.DataSource = dtBook;
                    comboBoxID.DataSource = dtBook;
                    comboBoxID.DisplayMember = "ID книги";
                    reader.Close();
                }

        }
        // Установка фильтра

        void filter(ref string ord, ref bool f, bool ch, string col, string str)
            {
                if (ch && (str != ""))
                {
                    if (f)
                        ord += " AND";
                    else
                        f = true;
                    ord += String.Format("({0}='{1}')", col, str);
                }
            }

        // Обновление таблицы заказов

        private void UpdateOrder()
        {
            string sql = String.Format("SELECT к.название AS 'Выданные вам книги', DATEDIFF(day, з.датаВыд, з.датаВоз) AS 'Осталось дней' FROM Заказ з, Книга к WHERE (читатель='{0}') AND (з.книга=к.id)", UserID);
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                dtOrder.Clear();
                dtOrder.Load(reader);
                dataGridOrders.DataSource = dtOrder;
                reader.Close();
            }
        }

        // Применение фильтра таблицы книг

        private void btn_filter_Click(object sender, EventArgs e)
        {
            UpdateLib();
        }

        // Создание заказа

        private void btn_makeOrder_Click(object sender, EventArgs e)
        {
                Int32 id = 0;
                string sql = String.Format("INSERT INTO Заказ(читатель, книга, датаВыд, датаВоз) VALUES ('{0}','{1}','{2}','{3}');SELECT CAST(scope_identity() AS int);", UserID, comboBoxID.Text, dateTimeDrop.Text, dateTimeReturn.Text);
                if (dateTimeDrop.Value <= dateTimeReturn.Value)
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        SqlCommand command = new SqlCommand(sql, conn);
                        conn.Open();
                        id = (Int32)command.ExecuteScalar();
                    }
                }
                    if (id != 0)
                    {
                        UpdateOrder();
                    }
                    else
                    {
                        MessageBox.Show("Дата возврата не может быть раньше даты заказа","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                
        }

        // Смена пароля

        private void btn_ChPass_Click(object sender, EventArgs e)
        {
            string sql = String.Format("UPDATE Читатель Set пароль='{0}' WHERE id='{1}'", textFPass.Text, UserID);
            int count = 0;
            bool fUp = false, fDown = false, fZ = false;
            Regex re = new Regex("^13");
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                // Проверка пароля
                if (textFPass.Text != textSPass.Text)
                    MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if ((textFPass.Text).Length >= 7)
                    {
                        if (re.IsMatch(textFPass.Text))
                        {
                            foreach (char i in textFPass.Text)
                            {
                                if (Char.IsUpper(i))
                                    fUp = true;
                                if (Char.IsLower(i))
                                    fDown = true;
                                if ((i == '!') || (i == '@') || (i == '#') || (i == '$') || (i == '%'))
                                    fZ = true;
                            }
                            if (fUp && fDown && fZ)
                                count = command.ExecuteNonQuery();
                            else
                                MessageBox.Show("Пароль должен содержать минимум 1 заглавную букву/nминимум одну строчную букву/nи минимум один из символов !,@,#,$,%", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Пароль должен начинаться с 13", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Пароль должен быть не короче 7 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (count != 0)
                MessageBox.Show("Пароль усмешно изменен", String.Format("Успех"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimeCreate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textFPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UserMain_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
