using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GM4D
{
    public class TextInputPrompt
    {
        public bool PasswordInput { get; set; }
        public string Message { get; set; }
        public string Caption { get; set; }
        public string Input { get; private set; }
        public bool CloseOK { get; private set; }
        private Form form;
        public TextInputPrompt() 
        {
            this.PasswordInput = false;
            this.Message = "";
            this.Caption = "";
        }
        public TextInputPrompt(string message)
        {
            this.PasswordInput = false;
            this.Message = message;
            this.Caption = "";
        }
        public TextInputPrompt(string message, string caption)
        {
            this.PasswordInput = false;
            this.Message = message;
            this.Caption = caption;
        }
        public event FormClosedEventHandler OnTextInputClosed;
        private Label textLabel;
        private TextBox textBox;
        public void Show()
        {
            form = new Form();
            form.Width = 400;
            form.Height = 200;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.Text = this.Caption;
            form.StartPosition = FormStartPosition.CenterParent;
            textLabel = new Label() { Left = 5, Top = 8, Text = this.Message };
            textBox = new TextBox() { Left = textLabel.Width + 15, Top = 5, Width = 100 };
            textBox.UseSystemPasswordChar = this.PasswordInput;
            Button confirmation = new Button() { Text = "Ok", Left = 100, Width = 80, Top = 50 };
            Button cancel = new Button() { Text = "Cancel", Left = 200, Width = 80, Top = 50 };
            confirmation.Click += (sender, e) => {
                this.Input = textBox.Text;
                this.CloseOK = true;
                if (OnTextInputClosed != null) OnTextInputClosed(this, new FormClosedEventArgs(CloseReason.UserClosing)); 
            };
            cancel.Click += (sender, e) => {
                this.CloseOK = false;
                if (OnTextInputClosed != null) OnTextInputClosed(this, new FormClosedEventArgs(CloseReason.UserClosing)); 
            };
            form.Controls.Add(textBox);
            form.Controls.Add(confirmation);
            form.Controls.Add(cancel);
            form.Controls.Add(textLabel);
            form.AcceptButton = confirmation;
            form.ShowDialog();
        }
        public void Close()
        {
            form.Close();
        }
        public void Refresh()
        {
            this.textBox.Clear();
            this.textLabel.Text = this.Message;
            this.textLabel.Refresh();
        }
    }
}
