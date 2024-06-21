namespace Binder
{
    partial class BinderPage
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
            textBoxKey = new TextBox();
            buttonEnterKey = new Button();
            label1 = new Label();
            textBoxValue = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxKey
            // 
            textBoxKey.Location = new Point(222, 92);
            textBoxKey.Name = "textBoxKey";
            textBoxKey.Size = new Size(137, 27);
            textBoxKey.TabIndex = 0;
            // 
            // buttonEnterKey
            // 
            buttonEnterKey.Location = new Point(243, 313);
            buttonEnterKey.Name = "buttonEnterKey";
            buttonEnterKey.Size = new Size(94, 29);
            buttonEnterKey.TabIndex = 1;
            buttonEnterKey.Text = "Применить";
            buttonEnterKey.UseVisualStyleBackColor = true;
            buttonEnterKey.Click += buttonEnterKey_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 22);
            label1.Name = "label1";
            label1.Size = new Size(245, 20);
            label1.TabIndex = 2;
            label1.Text = "Введите кнопку для запоминания\r\n";
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(61, 160);
            textBoxValue.Multiline = true;
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(458, 115);
            textBoxValue.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 122);
            label2.Name = "label2";
            label2.Size = new Size(276, 20);
            label2.TabIndex = 4;
            label2.Text = "Введите текст для введенной клавиши";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 55);
            label3.Name = "label3";
            label3.Size = new Size(492, 20);
            label3.TabIndex = 5;
            label3.Text = "(При введении нескольких символов, будет выбран первый символ)\r\n";
            // 
            // BinderPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 378);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxValue);
            Controls.Add(label1);
            Controls.Add(buttonEnterKey);
            Controls.Add(textBoxKey);
            Name = "BinderPage";
            Text = "BinderPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxKey;
        private Button buttonEnterKey;
        private Label label1;
        private TextBox textBoxValue;
        private Label label2;
        private Label label3;
    }
}