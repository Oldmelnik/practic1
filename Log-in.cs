/*
# Практическая работа по предмету МДК.03.01 "Технология разработки программного обеспечения"
# Название: Библиотека13
# Разработал: Смирнов Юрий Дмитриевич, группа ТМП-62,
# Дата и номер версии: 28.04.2020 v1.1
# Язык: C#
# Краткое описание: 
#    Программа для информационной системой для библиотеки.
# Задание:
#   Разработать информационную систему, предназначенную для работников библиотеки.
# Такая система должна обеспечивать хранение сведений об имеющихся в библиотеке книгах,
# о читателях и их заказах. Читатели проходят обязательную регистрацию, при которой 
# о них собирается стандартная информация
# Формы:
# Log-in - форма авторизации пользователя;
# Register- форма регистрации пользователя;
# UserMain - форма профиля авторизованного пользователя, предоставляет заказ книг;
# AdminMain - форма администратора;
# AdminBook - форма работы с таблицей книг;
# AdminReader - форма работы с таблицей читателей;
# AdminOrder - форма работы с таблицей заказов;
# AdminPass - форма авторизации администратора
*/
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

namespace Учебная_практика
{
    public partial class LoginForm : Form
    {
        private DataTable dtReader = new DataTable();
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Библиотека13;Integrated Security=True";
        // Инициализация компонентов окна
        public LoginForm()
        {
            InitializeComponent();
        }

        // Переход к регистрации пользователя

        private void btn_reg_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }

        // Переход в профиль пользователя

        private void btn_login_Click(object sender, EventArgs e)
        {
                string sql = String.Format("SELECT * FROM Читатель WHERE (ID ='{0}') AND (пароль='{1}')", textID.Text, textPass.Text);
                dtReader.Clear();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(sql, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    dtReader.Load(reader);
                    reader.Close();
                }
                if (dtReader.Rows.Count == 1) // Проверка пароля пользователя
                {
                    UserMain profile = new UserMain(int.Parse(textID.Text));
                    profile.Show();
                   // Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminb_Click(object sender, EventArgs e)
        {
            AdminPass adm = new AdminPass();
            adm.Show();
        }
    }
}
