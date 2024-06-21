namespace Binder
{
    partial class StartPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonInputKeyValue = new Button();
            listBoxShow = new ListBox();
            SuspendLayout();
            // 
            // buttonInputKeyValue
            // 
            buttonInputKeyValue.Location = new Point(24, 27);
            buttonInputKeyValue.Name = "buttonInputKeyValue";
            buttonInputKeyValue.Size = new Size(174, 49);
            buttonInputKeyValue.TabIndex = 0;
            buttonInputKeyValue.Text = "Задать комбинацию клавиш";
            buttonInputKeyValue.UseVisualStyleBackColor = true;
            buttonInputKeyValue.Click += buttonInputKeyValue_Click;
            // 
            // listBoxShow
            // 
            listBoxShow.FormattingEnabled = true;
            listBoxShow.Location = new Point(256, 27);
            listBoxShow.Name = "listBoxShow";
            listBoxShow.Size = new Size(509, 384);
            listBoxShow.TabIndex = 1;
            listBoxShow.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // StartPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxShow);
            Controls.Add(buttonInputKeyValue);
            Name = "StartPage";
            Text = "Binder";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonInputKeyValue;
        private ListBox listBoxShow;
    }
}
