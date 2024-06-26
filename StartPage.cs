using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Binder
{
    public partial class StartPage : Form
    {
        private Dictionary<string, string> inputValue = new Dictionary<string, string>();
        private Dictionary<string, int> registeredHotkeys = new Dictionary<string, int>();
        private int hotkeyIdCounter = 1;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        private const uint MOD_CTRL = 0x0002;

        public StartPage()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            if (m.Msg == WM_HOTKEY)
            {
                int id = m.WParam.ToInt32();
                foreach (var kvp in registeredHotkeys)
                {
                    if (kvp.Value == id)
                    {
                        HandleHotKey(kvp.Key);
                        break;
                    }
                }
            }
            base.WndProc(ref m);
        }

        private void HandleHotKey(string key)
        {
            // Вставляем текст, связанный с комбинацией клавиш
            if (inputValue.ContainsKey(key))
            {
                string textToInsert = inputValue[key];
                Clipboard.SetText(textToInsert);
                SendCtrlV();
            }
        }

        private void SendCtrlV()
        {
            const byte VK_CONTROL = 0x11;
            const byte VK_V = 0x56;
            const uint KEYEVENTF_KEYDOWN = 0x0000;
            const uint KEYEVENTF_KEYUP = 0x0002;

            keybd_event(VK_CONTROL, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(VK_V, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(VK_V, 0, KEYEVENTF_KEYUP, 0);
            keybd_event(VK_CONTROL, 0, KEYEVENTF_KEYUP, 0);
        }

        public Dictionary<string, string> AddValue(string key, string value)
        {
            try
            {
                if (inputValue.ContainsKey(key))
                {
                    MessageBox.Show("Данная кнопка уже занята");
                }
                else
                {
                    inputValue.Add(key, value);

                    // Регистрируем горячую клавишу
                    int vk = (int)key.ToUpper()[0];
                    RegisterHotKey(this.Handle, hotkeyIdCounter, MOD_CTRL, (uint)vk);
                    registeredHotkeys.Add(key, hotkeyIdCounter);
                    hotkeyIdCounter++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }

            listBoxShow.Items.Clear();  // нужно ли ?

            return inputValue;
        }

        public void AddListBox()
        {
            foreach (var item in inputValue)
            {
                listBoxShow.Items.Add($"Клавиша: {item.Key} Текст: {item.Value}");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonInputKeyValue_Click(object sender, EventArgs e)
        {
            BinderPage binderPage = new BinderPage(this);
            binderPage.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            foreach (var id in registeredHotkeys.Values)
            {
                UnregisterHotKey(this.Handle, id);
            }
            base.OnFormClosing(e);
        }
    }
}
