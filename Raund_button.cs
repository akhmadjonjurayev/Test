using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Test_Markazi
{
    class Raund_button:Button
    {
        private Color _buttonColor = Color.Red;//
        private Color _textColor = Color.White;//
        private Color _onHoverTextColor = Color.Gray;//
        private Color button_orqasi = Color.Green;//
        private Color mauseColor = Color.White;//
        private bool _isHoverning;
        public Raund_button()
        {
            DoubleBuffered = true;
            MouseEnter += (sender, e) =>
            {
                _isHoverning = true;
                Invalidate();
            };
            MouseLeave += (sender, e) =>
            {
                _isHoverning = false;
                Invalidate();
            };
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush brush = new SolidBrush(_isHoverning ? mauseColor : _buttonColor);
            Brush b = new SolidBrush(button_orqasi);
            g.FillRectangle(b, 0, 0, Width, Height);
            g.FillEllipse(brush, 0, 0, Width, Height);
            brush = new SolidBrush(_isHoverning ? _onHoverTextColor : _textColor);
            SizeF stringSize = g.MeasureString(Text, Font);
            g.DrawString(Text, Font, brush, (Width - stringSize.Width) / 2, (Height - stringSize.Height) / 2);

        }
        public Color Text_rangi_sisqoncha_borligida
        {
            get { return _onHoverTextColor; }
            set
            {
                _onHoverTextColor = value;
                Invalidate();
            }
        }
        public Color Text_rangi
        {
            get { return _textColor; }
            set
            {
                _textColor = value;
                Invalidate();
            }
        }
        public Color Button_orqasi
        {
            get { return button_orqasi; }
            set
            {
                button_orqasi = value;
                Invalidate();
            }
        }
        public Color ButtonColor
        {
            get { return _buttonColor; }
            set
            {
                _buttonColor = value;
                Invalidate();
            }
        }
        public Color Button_color_mause
        {
            get { return mauseColor; }
            set
            {
                mauseColor = value;
                Invalidate();
            }
        }
    }
}
