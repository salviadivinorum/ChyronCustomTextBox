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

	private string customCategory = "Custom";

	public TextBoxDerived()
	{
		BorderStyle = BorderStyle.None;
		Padding = new Padding(borderSize);
		SetStyle(ControlStyles.UserPaint, true);
	}

	[Category("Custom")]
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

	[Category("Custom")]
	public Color BorderColor
	{
		get { return borderColor; }
		set
		{
			borderColor = value;
			Invalidate();
		}
	}

	[Category("Custom")]
	public Color ActiveBorderColor
	{
		get { return activeBorderColor; }
		set
		{
			activeBorderColor = value;
			Invalidate();
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);
		// Use active border color when the control is focused, otherwise use the regular border color.
		Color currentBorderColor = Focused ? activeBorderColor : borderColor;
		using (Graphics g = e.Graphics)
		using (Pen pen = new Pen(currentBorderColor, borderSize))
		{
			g.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
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