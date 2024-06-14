namespace ChyronCustomTextBox.Controls;

using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public partial class TextBoxPaint : TextBox
{
	private const int WM_NCPAINT = 0x85;
	private Color m_BorderColor = Color.Blue;
	private int m_BorderSize = 1;
	private ButtonBorderStyle m_BorderStyle = ButtonBorderStyle.Solid;
	private BorderSideOptions m_BorderSides = BorderSideOptions.All;

	private const string customCategory = "Custom";

	public TextBoxPaint()
	{
		BorderStyle = ButtonBorderStyle.None;
		SetStyle(ControlStyles.UserPaint, true);
	}

	[Category(customCategory)]
	[DefaultValue(BorderSideOptions.All)]
	public BorderSideOptions BorderSides
	{
		get => m_BorderSides;
		set
		{
			if (m_BorderSides != value)
			{
				m_BorderSides = value;
				Parent?.Invalidate(Bounds, true);
			}
		}
	}

	[Category(customCategory)]
	[DefaultValue(typeof(Color), "Blue")]
	public Color BorderColor
	{
		get => m_BorderColor;
		set
		{
			if (m_BorderColor != value)
			{
				m_BorderColor = value;
				Parent?.Invalidate(Bounds, true);
			}
		}
	}

	[Category(customCategory)]
	[DefaultValue(1)]
	public int BorderSize
	{
		get => m_BorderSize;
		set
		{
			if (m_BorderSize != value)
			{
				m_BorderSize = value;
				Parent?.Invalidate(Bounds, true);
			}
		}
	}

	[Category(customCategory)]
	[DefaultValue(ButtonBorderStyle.Solid)]
	public new ButtonBorderStyle BorderStyle
	{
		get => m_BorderStyle;
		set
		{
			if (m_BorderStyle != value)
			{
				m_BorderStyle = value;
				Parent?.Invalidate(Bounds, true);
			}
		}
	}

	protected override void WndProc(ref Message m)
	{
		base.WndProc(ref m);
		if (m.Msg == WM_NCPAINT)
		{
			DrawCustomBorder();
		}
	}

	private void DrawCustomBorder()
	{
		using (Graphics g = Graphics.FromHwnd(Handle))
		{
			Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
			using (Pen pen = new Pen(BorderColor, BorderSize))
			{
				g.DrawRectangle(pen, rect);
			}
		}
	}

	public enum BorderSideOptions
	{
		Left,
		Right,
		Top,
		Bottom,
		All
	}

	[DllImport("user32")]
	private static extern IntPtr GetWindowDC(IntPtr hwnd);

	[DllImport("user32")]
	private static extern int ReleaseDC(IntPtr hwnd, IntPtr hDc);

	[DllImport("user32.dll")]
	private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

	private const int EM_SETMARGINS = 0xd3;
	private const int EC_LEFTMARGIN = 0x1;
	private const int EC_RIGHTMARGIN = 0x2;

	protected override void OnSizeChanged(EventArgs e)
	{
		base.OnSizeChanged(e);
		UpdateTextMargins();
	}

	private void UpdateTextMargins()
	{
		int newMargins = (BorderSize << 16) | BorderSize;
		SendMessage(Handle, EM_SETMARGINS, (IntPtr)(EC_LEFTMARGIN | EC_RIGHTMARGIN), (IntPtr)newMargins);
	}
}
