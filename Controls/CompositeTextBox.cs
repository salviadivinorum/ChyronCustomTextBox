namespace ChyronCustomTextBox.Controls
{
	using System;
	using System.ComponentModel;
	using System.Drawing;
	using System.Windows.Forms;

	public partial class CompositeTextBox : UserControl
	{
		private TextBox textBox;
		private Panel borderPanel;

		private int borderSize = 2;
		private Color borderColor = Color.Blue;
		private Color activeBorderColor = Color.Red;
		private bool drawBorder = true;

		private const string customCategory = "Custom";

		public CompositeTextBox()
		{
			InitializeComponents();
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
				borderPanel.BackColor = value;
			}
		}

		[Category(customCategory)]
		public Color ActiveBorderColor
		{
			get { return activeBorderColor; }
			set { activeBorderColor = value; }
		}

		[Category(customCategory)]
		public bool DrawBorder
		{
			get { return drawBorder; }
			set
			{
				drawBorder = value;
				Invalidate();
			}
		}

		[Browsable(true)]
		[Category(customCategory)]
		public override string Text
		{
			get { return textBox.Text; }
			set { textBox.Text = value; }
		}

		private void InitializeComponents()
		{
			borderPanel = new Panel
			{	
				Dock = DockStyle.Fill,
				BackColor = borderColor,
				AutoSize = false,
			};

			textBox = new TextBox
			{
				Dock = DockStyle.Fill,
				BorderStyle = BorderStyle.None,
				Location = new Point(borderSize, borderSize),
				Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
			};

			Controls.Add(borderPanel);
			borderPanel.Controls.Add(textBox);

			//AdjustPanelSize();

			textBox.GotFocus += TextBox_GotFocus;
			textBox.LostFocus += TextBox_LostFocus;
		}

		private void AdjustPanelSize()
		{
			int newWidth = textBox.Width + (BorderSize * 2);
			int newHeight = textBox.Height + (BorderSize * 2);

			Size = new Size(newWidth, newHeight);
		}

		private void TextBox_GotFocus(object sender, EventArgs e)
		{
			borderPanel.BackColor = activeBorderColor;
		}

		private void TextBox_LostFocus(object sender, EventArgs e)
		{
			borderPanel.BackColor = borderColor;
		}

		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			AdjustPanelSize();
			Invalidate();
		}
	}
}
