using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Binder
{
    public partial class BinderPage : Form
    {
        private StartPage startPage;

        // Конструктор, принимающий экземпляр StartPage
        public BinderPage(StartPage startPage)
        {
            InitializeComponent();
            this.startPage = startPage;
        }

        private void buttonEnterKey_Click(object sender, EventArgs e)
        {
            if (textBoxKey.Text.Length > 1)
            {
                // Если длина больше 1 символа, то обрезаем текст до 1 символа
                textBoxKey.Text = textBoxKey.Text.Substring(0, 1);
                // Перемещаем курсор в конец текста
                textBoxKey.SelectionStart = textBoxKey.Text.Length;
            }

            startPage.AddValue(textBoxKey.Text.ToUpper(), textBoxValue.Text); // Приводим к верхнему регистру
            this.Close();
            startPage.AddListBox();
        }
    }
}
