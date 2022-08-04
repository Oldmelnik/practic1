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
    public partial class AdminMain : Form
    {
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Библиотека13;Integrated Security=True";

        // Инициализация компонентов окна
        public AdminMain()
        {
            InitializeComponent();
        }


        private void btn_book_Click(object sender, EventArgs e)
        {
            AdminBooks adminBook = new AdminBooks();
            adminBook.Show();
        }


        private void btn_reader_Click(object sender, EventArgs e)
        {
            AdminReaders reader = new AdminReaders();
            reader.Show();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            AdminOrders order = new AdminOrders();
            order.Show();
        }

        // Изменение пароля администратора
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
            Локальные параметры:
            fUp - флаг заглавной буквы;
            fDown - флаг прописной буквы;
            fZ - флаг допустимых символов;
            re - шаблон пароля;
            count - количество обновленных записей;
            sql - запрос смены пароля администратора;
            conn - подключение к базе данных;
            command - инструкция, выполняемая над подключенной базе данных.
        */
       
    }
}

