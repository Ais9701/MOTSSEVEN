using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbaApp
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void enterbutton_Click(object sender, EventArgs e)
        {
            if (logintextBox.Text == "admin")
            {
                if (passwordtextBox.Text == "123")
                {
                    Form ifrm = new FormMenu();
                    ifrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
                    ifrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
                    ifrm.Show(); // отображаем Form2
                    this.Hide(); // скрываем Form1 (this - текущая форма)
                }
            }
            else
                MessageBox.Show("Неправильный логин или пароль");
            logintextBox.Clear();
            passwordtextBox.Clear();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
