/*
# Практическая работа по предмету МДК.03.01 "Технология разработки программного обеспечения"
# Название: Библиотека13
# Разработал: Смирнов Юрий Дмитриевич, группа ТМП-62,
# Дата и номер версии: 28.04.2020 v1.3
# Язык: C#
# Краткое описание: 
#    Программа для информационной системой для библиотеки.
# Задание:
#   Разработать информационную систему, предназначенную для работников библиотеки.
# Такая система должна обеспечивать хранение сведений об имеющихся в библиотеке книгах,
# о читателях и их заказах. Читатели проходят обязательную регистрацию, при которой 
# о них собирается стандартная информация
# Формы:
# BeginForm - форма основной программы, предоставляет выбор роли;
# LoginForm - форма авторизации пользователя;
# RegForm - форма регистрации пользователя;
# UserProfileForm - форма профиля авторизованного пользователя, предоставляет заказ книг;
# AdminForm - форма администратора;
# AdminFormBook - форма работы с таблицей книг;
# AdminFormReader - форма работы с таблицей читателей;
# AdminFormOrder - форма работы с таблицей заказов;
# AdminFormEtc - форма работы с вспомогательными таблицами.
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
    public partial class AdminPass : Form
    {
        public AdminPass()
        {
            InitializeComponent();
        }


        private void btn_admin_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "123") // Проверка пароля
            {
                AdminMain admin = new AdminMain();
                admin.Show();
            }
            else
            {
                MessageBox.Show("Неверный пароль()", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
