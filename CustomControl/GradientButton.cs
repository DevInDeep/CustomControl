using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace CustomControl
{
    public class GradientButton : Control
    {
        private LinearGradientBrush _brush;
        private readonly Font _font;
        private string _text = string.Empty;
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get => _text; set
            {
                _text = value;
                Invalidate();
            }
        }
        public GradientButton()
        {
            _brush = new LinearGradientBrush(
               new Point(0,10),
               new Point(200,10),
               Color.FromArgb(255, 255, 0, 0),
               Color.FromArgb(255, 0, 0, 255));
            _font = new Font(new FontFamily("Arial"), 16, FontStyle.Regular, GraphicsUnit.Pixel);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.FillRoundedRectangle(_brush, 0, 0, Width, Height, 20);
            SizeF fontSize = graphics.MeasureString(_text, _font);
            //Center Font
            var x = (Width - fontSize.Width) / 2;   
            var y = (Height - fontSize.Height) / 2;
            graphics.DrawString(_text, _font, new SolidBrush(Color.White), new PointF(x,y));
        }
    }
}
