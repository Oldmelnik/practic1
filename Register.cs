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
    public partial class Register : Form
    {
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Библиотека13;Integrated Security=True";
        // Инициализация компонентов окна
        public Register()
        {
            InitializeComponent();

        }

        // Регистрация пользователя

        private void btn_reg_Click(object sender, EventArgs e)
        {
            bool fUp = false, fDown = false, fZ = false;
            // Проверка пароля 

            if (textSName.Text != "")
            {
                if (textName.Text != "")
                {
                    if (textDName.Text != "")
                    {
                        if (richTextStreet.Text != "")
                        {
                            if (textPhone.Text != "")
                            {
                                if (textFPass.TextLength >= 7)
                                {
                                    if ((textFPass.Text[0] == '1') && (textFPass.Text[1] == '3'))
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
                                        if ((textFPass.Text == textSPass.Text) && fUp && fDown && fZ)
                                        {
                                            Int32 id = 0;
                                            string sql = String.Format("INSERT INTO Читатель(фамилия, имя, отчество, адрес, телефон, пароль) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}');SELECT CAST(scope_identity() AS int);", textSName.Text, textName.Text, textDName.Text, richTextStreet.Text, textPhone.Text, textFPass.Text);
                                            using (SqlConnection conn = new SqlConnection(connStr))
                                            {
                                                SqlCommand command = new SqlCommand(sql, conn);
                                                conn.Open();
                                                id = (Int32)command.ExecuteScalar();
                                            }
                                            if (id != 0)
                                            {
                                                MessageBox.Show("Регистрация успешно завершена! Ваш id:" + id.ToString(), "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                Close();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Ошибка");
                                                return;
                                            }
                                            
                                        }
                                        else
                                        {
                                            if (!fUp)
                                                MessageBox.Show("В пароле должен быть/nхотя бы один заглавный символ","Ошибка!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            if (!fDown)
                                                MessageBox.Show("В пароле должен быть/nхотя бы один строчный символ", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            if (!fZ)
                                                MessageBox.Show("В пароле должен быть/nхотя бы один символ из набора: \"!@#$%\"", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            if (textFPass.Text != textSPass.Text)
                                                MessageBox.Show("Пароли не совпадают!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                        MessageBox.Show("Пароль должен начинаться с '13'", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }else
                                MessageBox.Show("Пароль должен быть не короче 7 символов", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("Поле с телефоном должно быть заполнено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Поле с адресом должно быть заполнено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Поле с отчеством должно быть заполнено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Поле с именем должно быть заполнено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Поле с фамилией должно быть заполнено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textFPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextStreet_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
