using System.Collections.Generic;

namespace Binder
{
    public partial class StartPage : Form
    {
        Dictionary<string, string> inputValue = new Dictionary<string, string>();
        /// <summary>
        /// �������� ��������� ������� � ����� � ������ Dictionary
        /// </summary>
        /// <param name="dictionary"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Dictionary<string, string> AddValue(string key, string value)
        {
            try
            {
                if (inputValue.ContainsKey(key))
                {
                    MessageBox.Show("������ ������ ��� ������");
                }
                else
                {
                    inputValue.Add(key, value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("��������� ������: " + ex.Message);
            }

            listBoxShow.Items.Clear();  // ����� �� ?

            return inputValue;

        }

        /// <summary>
        /// �������� ������ � �������
        /// </summary>
        public void AddListBox()
        {
            foreach (var item in inputValue)
            {
                listBoxShow.Items.Add($"�������: { item.Key} �����: {item.Value}");
            }

        }


        public StartPage()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonInputKeyValue_Click(object sender, EventArgs e)
        {
            BinderPage BinderPage = new BinderPage(this);
            BinderPage.Show();
        }
    }
}
