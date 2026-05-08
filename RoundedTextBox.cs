using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsApp1
{
    [DefaultEvent(nameof(TextChanged))]
    public partial class RoundedTextBox : UserControl
    {
        private int _borderRadius = 12;
        private int _borderSize = 2;

        private Color _borderColor = Color.Silver;
        private Color _borderFocusColor = Color.DodgerBlue;

        private Color _fillColor = Color.White;

        // simulated transparency (designer-safe)
        private bool _transparentBackground = false;

        private string _placeholderText = "Search..";
        private Color _placeholderColor = Color.Gray;

        private bool _isPlaceholderActive;

        public RoundedTextBox()
        {
            InitializeComponent();

            DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);

            innerTextBox.BackColor = _fillColor;
            innerTextBox.ForeColor = Color.Black;

            innerTextBox.GotFocus += (_, __) => { RemovePlaceholder(); Invalidate(); };
            innerTextBox.LostFocus += (_, __) => { ApplyPlaceholder(); Invalidate(); };
            innerTextBox.TextChanged += (_, __) =>
            {
                if (!_isPlaceholderActive)
                    base.OnTextChanged(__);
            };

            AdjustInnerTextBox();
            UpdateRegion();
            ApplyPlaceholder();
        }

        // ---------------- Appearance (Designer Properties) ----------------

        [Category("Appearance")]
        [Description("Text shown when empty and not focused.")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string PlaceholderText
        {
            get => _placeholderText;
            set
            {
                _placeholderText = value ?? "";
                ApplyPlaceholder();
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Color of placeholder text.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color PlaceholderColor
        {
            get => _placeholderColor;
            set
            {
                _placeholderColor = value;
                if (_isPlaceholderActive)
                    innerTextBox.ForeColor = _placeholderColor;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Fill color inside the rounded border.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color FillColor
        {
            get => _fillColor;
            set
            {
                _fillColor = value;
                innerTextBox.BackColor = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Simulate transparent background by painting parent behind the control (runtime only).")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool TransparentBackground
        {
            get => _transparentBackground;
            set { _transparentBackground = value; Invalidate(); }
        }

        [Category("Rounded Border")]
        [Description("Corner radius of the border.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = Math.Max(1, value); UpdateRegion(); Invalidate(); }
        }

        [Category("Rounded Border")]
        [Description("Border thickness.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BorderSize
        {
            get => _borderSize;
            set { _borderSize = Math.Max(1, value); AdjustInnerTextBox(); Invalidate(); }
        }

        [Category("Rounded Border")]
        [Description("Border color when not focused.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        [Category("Rounded Border")]
        [Description("Border color when focused.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BorderFocusColor
        {
            get => _borderFocusColor;
            set { _borderFocusColor = value; Invalidate(); }
        }

        // ---------------- Typical TextBox Properties ----------------

        [Category("Behavior")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool UseSystemPasswordChar
        {
            get => innerTextBox.UseSystemPasswordChar;
            set => innerTextBox.UseSystemPasswordChar = value;
        }

        [Category("Behavior")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Multiline
        {
            get => innerTextBox.Multiline;
            set { innerTextBox.Multiline = value; AdjustInnerTextBox(); Invalidate(); }
        }

        [Category("Behavior")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int MaxLength
        {
            get => innerTextBox.MaxLength;
            set => innerTextBox.MaxLength = value;
        }

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public HorizontalAlignment TextAlign
        {
            get => innerTextBox.TextAlign;
            set => innerTextBox.TextAlign = value;
        }

        [Category("Appearance")]
        public override Font Font
        {
            get => innerTextBox.Font;
            set { innerTextBox.Font = value; AdjustInnerTextBox(); Invalidate(); }
        }

        [Category("Appearance")]
        public override Color ForeColor
        {
            get => innerTextBox.ForeColor;
            set
            {
                if (!_isPlaceholderActive)
                    innerTextBox.ForeColor = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get => _isPlaceholderActive ? "" : innerTextBox.Text;
            set
            {
                _isPlaceholderActive = false;
                innerTextBox.ForeColor = Color.Black;
                innerTextBox.Text = value ?? "";
                ApplyPlaceholder();
                Invalidate();
            }
        }

        [Category("Layout")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Padding Padding
        {
            get => base.Padding;
            set { base.Padding = value; AdjustInnerTextBox(); Invalidate(); }
        }

        // ---------------- Layout / Painting ----------------

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustInnerTextBox();
            UpdateRegion();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            innerTextBox.Focus();
        }

        private void AdjustInnerTextBox()
        {
            int left = Padding.Left + BorderSize;
            int top = Padding.Top + BorderSize;
            int right = Padding.Right + BorderSize;
            int bottom = Padding.Bottom + BorderSize;

            innerTextBox.Location = new Point(left, top);
            innerTextBox.Width = Math.Max(0, Width - left - right);
            innerTextBox.Height = Math.Max(0, Height - top - bottom);

            if (!innerTextBox.Multiline)
            {
                innerTextBox.AutoSize = false;
                int h = TextRenderer.MeasureText("A", innerTextBox.Font).Height + 2;
                innerTextBox.Height = Math.Max(innerTextBox.Height, h);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = ClientRectangle;
            rect.Inflate(-1, -1);

            int radius = Math.Min(BorderRadius, Height / 2);
            using GraphicsPath path = GetRoundPath(rect, radius);

            // background
            if (TransparentBackground && Parent != null && !DesignMode)
            {
                using Bitmap bmp = new Bitmap(Parent.Width, Parent.Height);
                Parent.DrawToBitmap(bmp, Parent.ClientRectangle);
                e.Graphics.DrawImage(bmp, -Left, -Top);
            }
            else
            {
                using SolidBrush bg = new SolidBrush(Parent?.BackColor ?? SystemColors.Control);
                e.Graphics.FillRectangle(bg, ClientRectangle);
            }

            // fill
            using (SolidBrush fill = new SolidBrush(FillColor))
                e.Graphics.FillPath(fill, path);

            // border
            Color border = innerTextBox.Focused ? BorderFocusColor : BorderColor;
            using Pen pen = new Pen(border, BorderSize) { Alignment = PenAlignment.Inset };
            e.Graphics.DrawPath(pen, path);
        }

        private void UpdateRegion()
        {
            Rectangle rect = ClientRectangle;
            rect.Inflate(-1, -1);

            int radius = Math.Min(BorderRadius, Height / 2);
            using GraphicsPath path = GetRoundPath(rect, radius);
            Region = new Region(path);
        }

        private GraphicsPath GetRoundPath(Rectangle rect, int radius)
        {
            int d = radius * 2;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        // ---------------- Placeholder logic ----------------

        private void ApplyPlaceholder()
        {
            if (innerTextBox.Focused) return;

            // If user typed real text, don't overwrite it
            if (!string.IsNullOrEmpty(innerTextBox.Text) && !_isPlaceholderActive)
                return;

            if (string.IsNullOrEmpty(innerTextBox.Text) && !string.IsNullOrEmpty(PlaceholderText))
            {
                _isPlaceholderActive = true;
                innerTextBox.ForeColor = PlaceholderColor;
                innerTextBox.Text = PlaceholderText;
            }
            else if (_isPlaceholderActive)
            {
                innerTextBox.ForeColor = PlaceholderColor;
            }
        }

        private void RemovePlaceholder()
        {
            if (_isPlaceholderActive)
            {
                _isPlaceholderActive = false;
                innerTextBox.Text = "";
                innerTextBox.ForeColor = Color.Black;
            }
        }

        private void innerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoundedTextBox_Load(object sender, EventArgs e)
        {

        }
    }
}