namespace ChyronCustomTextBox.Controls;

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public partial class TextBoxInPanel : Panel
{
	private TextBox textBox = new TextBox();
	private Color borderColor = Color.Blue;
	private Color activeBorderColor = Color.Red;
	private int borderSize = 8;

	private const string customCategory = "Custom";

	public TextBoxInPanel()
	{
		// Configure the panel
		Padding = new Padding(BorderSize); // Use padding to create space for the border
		BackColor = BorderColor; // The background color of the panel serves as the border color
		AutoSize = false; // Set AutoSize to false to manually set the size

		// Configure the TextBox
		textBox.Dock = DockStyle.Fill; // Fill the panel, leaving space for the border based on padding
		textBox.BorderStyle = BorderStyle.None; // Remove the TextBox's own border

		// Add the TextBox to the panel
		Controls.Add(textBox);

		// Set a default size for the panel that is larger than the default TextBox size
		// to account for the border. This size can be adjusted based on your design needs.
		Size = new Size(textBox.Width + Padding.Left + Padding.Right, textBox.Height + Padding.Top + Padding.Bottom);

		// Adjust the size of the panel to accommodate the TextBox and border
		AdjustPanelSize();
	}

	[Category(customCategory)]
	public int BorderSize
	{
		get { return borderSize; }
		set
		{
			borderSize = value;
			Padding = new Padding(borderSize);
			AdjustPanelSize();
			Invalidate(); // Redraw to reflect the change
		}
	}

	[Category(customCategory)]
	public Color BorderColor
	{
		get { return borderColor; }
		set
		{
			borderColor = value;
			BackColor = borderColor;
			Invalidate(); // Redraw to reflect the change
		}
	}

	[Category(customCategory)]
	public Color ActiveBorderColor
	{
		get { return activeBorderColor; }
		set
		{
			activeBorderColor = value;
			Invalidate(); // Redraw to reflect the change
		}
	}

	[Browsable(true)]
	[Category(customCategory)]
	public override string Text
	{
		get { return textBox.Text; }
		set { textBox.Text = value; }
	}

	[Category(customCategory)]
	public bool Multiline
	{
		get => textBox.Multiline;
		set => textBox.Multiline = value;
	}

	protected override void OnEnter(EventArgs e)
	{
		base.OnEnter(e);
		BackColor = activeBorderColor;
	}

	protected override void OnLeave(EventArgs e)
	{
		base.OnLeave(e);
		BackColor = borderColor;
	}

	private void AdjustPanelSize()
	{
		int newWidth = textBox.Width + (BorderSize * 2);
		int newHeight = textBox.Height + (BorderSize * 2);

		Size = new Size(newWidth, newHeight);
	}


}
