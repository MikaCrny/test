using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bot_GUI
{
    public class RedirectConsoleOutput : TextWriter
    {
        private TextBox textbox;

        public RedirectConsoleOutput(ref TextBox textbox)
        {
            this.textbox = textbox;
        }

        public override void Write(char value)
        {
            textbox.Text += value;
        }

        public override void Write(string value)
        {
            textbox.Text += value;
        }

        public override Task WriteAsync(char value)
        {
            textbox.Text += value;
            return Task.CompletedTask;
        }

        public override Task WriteAsync(string value)
        {
            textbox.Text += value + Environment.NewLine;
            return Task.CompletedTask;
        }

        public override void WriteLine(char value)
        {
            textbox.Text += value + Environment.NewLine;
        }

        public override void WriteLine(string value)
        {
            textbox.Text += value + Environment.NewLine;
        }

        public override Task WriteLineAsync(char value)
        {
            textbox.Text += value;
            return Task.CompletedTask;
        }

        public override Task WriteLineAsync(string value)
        {
            textbox.Text += value + Environment.NewLine;
            return Task.CompletedTask;
        }

        public override void Write(object value)
        {
            textbox.Text += value;
        }

        public override void WriteLine(object value)
        {
            textbox.Text += value + Environment.NewLine;
        }

        public override void Write(string format, object arg0)
        {
            textbox.Text += string.Format(format, arg0);
        }

        public override void Write(string format, object arg0, object arg1)
        {
            textbox.Text += string.Format(format, arg0, arg1);
        }

        public override void Write(string format, object arg0, object arg1, object arg2)
        {
            textbox.Text += string.Format(format, arg0, arg1, arg2);
        }

        public override void Write(string format, params object[] arg)
        {
            textbox.Text += string.Format(format, arg);
        }

        public override void WriteLine(string format, object arg0)
        {
            textbox.Text += string.Format(format, arg0) + Environment.NewLine;
        }

        public override void WriteLine(string format, object arg0, object arg1)
        {
            textbox.Text += string.Format(format, arg0, arg1) + Environment.NewLine;
        }

        public override void WriteLine(string format, object arg0, object arg1, object arg2)
        {
            textbox.Text += string.Format(format, arg0, arg1, arg2) + Environment.NewLine;
        }

        public override void WriteLine(string format, params object[] arg)
        {
            textbox.Text += string.Format(format, arg) + Environment.NewLine;
        }

        public override Encoding Encoding
        {
            get { return Encoding.ASCII; }
        }
    }
}
