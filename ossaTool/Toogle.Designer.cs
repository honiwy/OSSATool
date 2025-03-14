﻿    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    namespace ossaTool
    {
        public class Toggle : Control
        {
            private float diameter;
            private Rectangle rect;
            private RectangleF circle;
            private bool isON;
            private float artis;
            private Color borderColor;
            private bool textEnabled;
            private string OnTex = "";
            private string OffTex = "";
            private Color OnCol;
            private Color OffCol;
            private Timer painTicker = new Timer();
            public event SliderChangedEventHandler SliderValueChanged;

            public Toggle()
            {
                this.Cursor = Cursors.Hand;
                this.DoubleBuffered = true;
                this.artis = 4f;
                this.diameter = 30f;
                this.textEnabled = true;
                this.rect = new Rectangle(2f * this.diameter, this.diameter + 2f, this.diameter / 2f, 1f, 1f);
                this.circle = new RectangleF(1f, 1f, this.diameter, this.diameter);
                this.isON = false;
                this.borderColor = Color.LightGray;
                this.painTicker.Tick += new EventHandler(this.paintTicker_Tick);
                this.painTicker.Interval = 1;
                this.OnCol = Color.FromArgb(94, 148, 255);
                this.OffCol = Color.DarkGray;
                this.ForeColor = Color.White;
                this.OnTex = "ON";
                this.OffTex = "OFF";
            }

            protected override void OnEnabledChanged(EventArgs e)
            {
                base.Invalidate();
                base.OnEnabledChanged(e);
            }

            protected override void OnMouseDown(MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.isON = !this.isON;
                    this.IsOn = this.isON;
                    base.OnMouseClick(e);
                }
            }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = (SmoothingMode)SmoothingMode.HighQuality;
            if (base.Enabled)
            {
                Pen pen;
                using (SolidBrush brush = new SolidBrush(this.isON ? this.OnCol : this.OffCol))
                {
                    e.Graphics.FillPath((Brush)brush, this.rect.Path);
                }
                using (pen = new Pen(this.borderColor, 2f))
                {
                    e.Graphics.DrawPath(pen, this.rect.Path);
                }
                if (this.textEnabled)
                {
                    e.Graphics.FillEllipse(Brushes.SteelBlue, this.circle);
                    using (pen = new Pen(Color.LightGray, 1.2f))
                    {
                        e.Graphics.DrawEllipse(pen, this.circle);
                    }
                    using (Font font = new Font("Century Gothic", (8.2f * this.diameter) / 30f, (FontStyle)FontStyle.Bold))
                    {
                        int height = TextRenderer.MeasureText(this.OnTex, font).Height;
                        float num2 = (this.diameter - height) / 2f;
                        if (this.IsOn) {
                            e.Graphics.DrawString(this.Text, font, new SolidBrush(Color.White), this.diameter + 3f, num2 + 1f);
                            e.Graphics.DrawString(this.OnTex, font, new SolidBrush(this.ForeColor), 5f, num2 + 1f);
                        }
                        else
                        {
                            e.Graphics.DrawString(this.Text, font, new SolidBrush(Color.White), 5f, num2 + 1f);
                            e.Graphics.DrawString(this.OffTex, font, new SolidBrush(this.ForeColor), this.diameter + 2f, num2 + 1f);
                        }
                    }
                }
                else
                {
                    e.Graphics.FillPath(Brushes.SteelBlue, this.rect.Path);
                    e.Graphics.FillEllipse(Brushes.SteelBlue, this.circle);
                    e.Graphics.DrawEllipse(Pens.DarkGray, this.circle);
                }
            }
            base.OnPaint(e);
        }

            protected override void OnResize(EventArgs e)
            {
                base.Width = (base.Height - 2) * 2;
                this.diameter = base.Width / 2;
                this.artis = (4f * this.diameter) * 30f;
                this.rect = new Rectangle(2f * this.diameter, this.diameter + 2f, this.diameter / 2f, 1f, 1f);
                this.circle = new RectangleF(!this.isON ? 1f : ((base.Width - this.diameter) - 1f), 1f, this.diameter, this.diameter);
                base.OnResize(e);
            }

            private void paintTicker_Tick(object sender, EventArgs e)
            {
                float x = this.circle.X;
                if (this.isON)
                {
                    if ((x + this.artis) <= ((base.Width - this.diameter) - 1f))
                    {
                        x += this.artis;
                        this.circle = new RectangleF(x, 1f, this.diameter, this.diameter);
                        base.Invalidate();
                    }
                    else
                    {
                        x = (base.Width - this.diameter) - 1f;
                        this.circle = new RectangleF(x, 1f, this.diameter, this.diameter);
                        base.Invalidate();
                        this.painTicker.Stop();
                    }
                }
                else if ((x - this.artis) >= 1f)
                {
                    x -= this.artis;
                    this.circle = new RectangleF(x, 1f, this.diameter, this.diameter);
                }
                else
                {
                    x = 1f;
                    this.circle = new RectangleF(x, 1f, this.diameter, this.diameter);
                    base.Invalidate();
                    this.painTicker.Stop();
                }
            }

            public bool TextEnabled
            {
                get =>
                    this.textEnabled;
                set
                {
                    this.textEnabled = value;
                    base.Invalidate();
                }
            }

            public bool IsOn
            {
                get =>
                    this.isON;
                set
                {
                    this.painTicker.Stop();
                    this.isON = value;
                    this.painTicker.Start();
                    if (this.SliderValueChanged != null)
                    {
                        this.SliderValueChanged(this, EventArgs.Empty);
                    }
                }
            }

            public Color BorderColor
            {
                get =>
                    this.borderColor;
                set
                {
                    this.borderColor = value;
                    base.Invalidate();
                }
            }

            protected override Size DefaultSize
                => new Size(60, 35);
            public delegate void SliderChangedEventHandler(object sender, EventArgs e);


        public string OnText
            {
                get =>
                    this.OnTex;
                set
                {
                    this.OnTex = value;
                    base.Invalidate();
                }
            }
            public string OffText
            {
                get =>
                    this.OffTex;
                set
                {
                    this.OffTex = value;
                    base.Invalidate();
                }
            }

            public Color OnColor
            {
                get =>
                    this.OnCol;
                set
                {
                    this.OnCol = value;
                    base.Invalidate();
                }
            }

            public Color OffColor
            {
                get =>
                    this.OffCol;
                set
                {
                    this.OffCol = value;
                    base.Invalidate();
                }
            }
        }

        internal class Rectangle
        {
            private Point location;
            private float radius;
            private GraphicsPath grPath;
            private float x;
            private float y;
            private float width;
            private float height;

            public Rectangle() { }
            public Rectangle(float width, float height, float radius, float x = 0f, float y = 0f)
            {

                this.location = new Point(0, 0);
                this.radius = radius;
                this.x = x;
                this.y = y;
                this.width = width;
                this.height = height;
                this.grPath = new GraphicsPath();
                if (radius <= 0f)
                {
                    this.grPath.AddRectangle(new RectangleF(x, y, width, height));
                }
                else
                {
                    RectangleF ef = new RectangleF(x, y, 2f * radius, 2f * radius);
                    RectangleF ef2 = new RectangleF((width - (2f * radius)) - 1f, x, 2f * radius, 2f * radius);
                    RectangleF ef3 = new RectangleF(x, (height - (2f * radius)) - 1f, 2f * radius, 2f * radius);
                    RectangleF ef4 = new RectangleF((width - (2f * radius)) - 1f,
                        (height - (2f * radius)) - 1f, 2f * radius, 2f * radius);

                    this.grPath.AddArc(ef, 180f, 90f);
                    this.grPath.AddArc(ef2, 270f, 90f);
                    this.grPath.AddArc(ef4, 0f, 90f);
                    this.grPath.AddArc(ef3, 90f, 90f);
                    this.grPath.CloseAllFigures();
                }
            }

            public GraphicsPath Path =>
                this.grPath;

            public RectangleF Rect =>
                new RectangleF(this.x, this.y, this.width, this.height);

            public float Radius
            {
                get =>
                    this.radius;
                set =>
                    this.radius = value;
            }
        }
    }


