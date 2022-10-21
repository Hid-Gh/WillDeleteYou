using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dream_Hotel.User_Control
{
    class CustomTextBox : TextBox
    {
        private string _placeHolder;
        private bool isTyped = false; 
        public string PlaceHolder
        {
            get { return _placeHolder; }
            set
            {
                _placeHolder = value; Text = value; ForeColor = SystemColors.ControlDarkDark;
            }
        }

        public bool IsPassword { get; set; } = false;
        public bool Writting { get { return isTyped; } }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (!isTyped)
                ForeColor = Color.Black;
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {

            if (Text == PlaceHolder && !isTyped)
            {
                SelectionStart = 0;
            }
            
            base.OnMouseDown(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (Text == PlaceHolder && !isTyped && (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down))  
                e.SuppressKeyPress = true;

            else if (Text == PlaceHolder && !isTyped && (e.KeyCode == Keys.A || e.KeyCode == Keys.C) &&  e.Control)
                e.SuppressKeyPress = true;


            else if (Text == PlaceHolder && !isTyped && e.KeyCode == Keys.V && e.Control)
            {
                Clear();
                ForeColor = Color.Black;
                isTyped = true;

                if (IsPassword)
                    PasswordChar = '\u25CF';
            }
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            if (string.IsNullOrEmpty(Text))
            {
                Text = PlaceHolder;
                ForeColor = SystemColors.ControlDarkDark;
                isTyped = false;

                if (IsPassword)
                    PasswordChar = '\0';
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (Text == PlaceHolder && !char.IsControl(e.KeyChar) && !isTyped)
            {
                Clear();
                ForeColor = Color.Black;
                isTyped = true;

                if (IsPassword)
                    PasswordChar = '\u25CF';
            }
        }

    }
}
