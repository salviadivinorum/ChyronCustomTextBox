using System.ComponentModel;
using System.Runtime.InteropServices;

namespace ChyronCustomTextBox.Controls;
public partial class TextBoxBordered : TextBox
{
	private int borderSize = 1;
	private Color borderColor = Color.Green;
	private Color activeBorderColor = Color.Red;
	private bool drawBorder = true;

	private const string customCategory = "Custom";

	public TextBoxBordered()
	{
		InitializeComponent();

		BorderStyle = BorderStyle.None;
		Padding = new Padding(borderSize);
		SetStyle(ControlStyles.UserPaint, true);
	}

	[Category(customCategory)]
	public int BorderSize
	{
		get { return borderSize; }
		set
		{
			borderSize = value;
			Padding = new Padding(borderSize);
			Invalidate();
		}
	}

	[Category(customCategory)]
	public Color BorderColor
	{
		get { return borderColor; }
		set
		{
			borderColor = value;
			Invalidate();
		}
	}

	[Category(customCategory)]
	public Color ActiveBorderColor
	{
		get { return activeBorderColor; }
		set
		{
			activeBorderColor = value;
			Invalidate();
		}
	}

	[Category(customCategory)]
	public bool DrawBorder
	{
		get { return drawBorder; }
		set
		{
			drawBorder = value;
			this.Invalidate();
		}
	}

	protected override void OnEnter(EventArgs e)
	{
		base.OnEnter(e);
		Invalidate();
	}

	protected override void OnLeave(EventArgs e)
	{
		base.OnLeave(e);
		Invalidate();
	}

	protected override void OnResize(EventArgs e)
	{
		base.OnResize(e);
		Invalidate();
	}


	// from Stackoverflow

	[DllImport("user32")]
	private static extern IntPtr GetWindowDC(IntPtr hwnd);
	struct RECT
	{
		public int left, top, right, bottom;
	}
	struct NCCALSIZE_PARAMS
	{
		public RECT newWindow;
		public RECT oldWindow;
		public RECT clientWindow;
		IntPtr windowPos;
	}

	int clientPadding = 2;
	int actualBorderWidth = 8;

	protected override void WndProc(ref Message m)
	{
		//We have to change the clientsize to make room for borders
		//if not, the border is limited in how thick it is.
		if (m.Msg == 0x83) //WM_NCCALCSIZE   
		{
			if (m.WParam == IntPtr.Zero)
			{
				RECT rect = (RECT)Marshal.PtrToStructure(m.LParam, typeof(RECT));
				rect.left += clientPadding;
				rect.right -= clientPadding;
				rect.top += clientPadding;
				rect.bottom -= clientPadding;
				Marshal.StructureToPtr(rect, m.LParam, false);
			}
			else
			{
				NCCALSIZE_PARAMS rects = (NCCALSIZE_PARAMS)Marshal.PtrToStructure(m.LParam, typeof(NCCALSIZE_PARAMS));
				rects.newWindow.left += clientPadding;
				rects.newWindow.right -= clientPadding;
				rects.newWindow.top += clientPadding;
				rects.newWindow.bottom -= clientPadding;
				Marshal.StructureToPtr(rects, m.LParam, false);
			}
		}
		if (m.Msg == 0x85) //WM_NCPAINT    
		{
			IntPtr wDC = GetWindowDC(Handle);
			using (Graphics g = Graphics.FromHdc(wDC))
			{
				ControlPaint.DrawBorder(g, new Rectangle(0, 0, Size.Width, Size.Height), borderColor, actualBorderWidth, ButtonBorderStyle.Solid,
			  borderColor, actualBorderWidth, ButtonBorderStyle.Solid, borderColor, actualBorderWidth, ButtonBorderStyle.Solid,
			  borderColor, actualBorderWidth, ButtonBorderStyle.Solid);
			}
			return;
		}
		base.WndProc(ref m);
	}
}
