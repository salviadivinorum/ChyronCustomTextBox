namespace ChyronCustomTextBox.Controls;

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public partial class TextBoxDerived : TextBox
{
	private int borderSize = 1;
	private Color borderColor = Color.Blue;
	private Color activeBorderColor = Color.Red;
	private bool drawBorder = true;

	private const string customCategory = "Custom";

	public TextBoxDerived()
	{
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

	protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);
		if (drawBorder)
		{
			using (Graphics g = e.Graphics)
			{
				using (Pen pen = new Pen(this.Focused ? activeBorderColor : borderColor, borderSize))
				{
					g.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
				}
			}
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

}