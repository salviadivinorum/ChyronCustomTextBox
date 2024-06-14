namespace ChyronCustomTextBox;

partial class MainWindow
{
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		panel1 = new Panel();
		textBox2 = new TextBox();
		label1 = new Label();
		panel2 = new Panel();
		label3 = new Label();
		panel3 = new Panel();
		label2 = new Label();
		textBoxDerived2 = new Controls.TextBoxDerived();
		panel4 = new Panel();
		label7 = new Label();
		label4 = new Label();
		textBoxInPanel1 = new Controls.TextBoxInPanel();
		label5 = new Label();
		label6 = new Label();
		textBoxBordered1 = new Controls.TextBoxBordered();
		panel1.SuspendLayout();
		panel3.SuspendLayout();
		panel4.SuspendLayout();
		SuspendLayout();
		// 
		// panel1
		// 
		panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		panel1.Controls.Add(textBox2);
		panel1.Controls.Add(label1);
		panel1.Location = new Point(0, 30);
		panel1.Name = "panel1";
		panel1.Size = new Size(543, 30);
		panel1.TabIndex = 0;
		// 
		// textBox2
		// 
		textBox2.Location = new Point(172, 7);
		textBox2.Name = "textBox2";
		textBox2.Size = new Size(100, 23);
		textBox2.TabIndex = 2;
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Location = new Point(5, 3);
		label1.Margin = new Padding(4, 1, 4, 1);
		label1.Name = "label1";
		label1.Padding = new Padding(3);
		label1.Size = new Size(104, 21);
		label1.TabIndex = 1;
		label1.Text = "Standard TextBox";
		// 
		// panel2
		// 
		panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		panel2.Location = new Point(0, 0);
		panel2.Name = "panel2";
		panel2.Size = new Size(543, 30);
		panel2.TabIndex = 1;
		// 
		// label3
		// 
		label3.AutoSize = true;
		label3.Location = new Point(5, 3);
		label3.Margin = new Padding(4, 1, 4, 1);
		label3.Name = "label3";
		label3.Padding = new Padding(3);
		label3.Size = new Size(154, 21);
		label3.TabIndex = 1;
		label3.Text = "TextBox - OnPaint override";
		// 
		// panel3
		// 
		panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		panel3.Controls.Add(label2);
		panel3.Controls.Add(textBoxDerived2);
		panel3.Controls.Add(label3);
		panel3.Location = new Point(0, 60);
		panel3.Name = "panel3";
		panel3.Size = new Size(543, 30);
		panel3.TabIndex = 2;
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Location = new Point(352, 8);
		label2.Name = "label2";
		label2.Size = new Size(70, 15);
		label2.TabIndex = 3;
		label2.Text = "10px border";
		// 
		// textBoxDerived2
		// 
		textBoxDerived2.ActiveBorderColor = Color.Red;
		textBoxDerived2.BorderColor = Color.Blue;
		textBoxDerived2.BorderSize = 10;
		textBoxDerived2.BorderStyle = BorderStyle.None;
		textBoxDerived2.DrawBorder = true;
		textBoxDerived2.Location = new Point(172, 8);
		textBoxDerived2.Name = "textBoxDerived2";
		textBoxDerived2.Size = new Size(100, 16);
		textBoxDerived2.TabIndex = 2;
		// 
		// panel4
		// 
		panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		panel4.Controls.Add(textBoxBordered1);
		panel4.Controls.Add(label7);
		panel4.Controls.Add(label4);
		panel4.Location = new Point(0, 90);
		panel4.Name = "panel4";
		panel4.Size = new Size(543, 38);
		panel4.TabIndex = 3;
		// 
		// label7
		// 
		label7.AutoSize = true;
		label7.Location = new Point(352, 6);
		label7.Name = "label7";
		label7.Size = new Size(70, 15);
		label7.TabIndex = 4;
		label7.Text = "10px border";
		// 
		// label4
		// 
		label4.AutoSize = true;
		label4.Location = new Point(5, 3);
		label4.Margin = new Padding(4, 1, 4, 1);
		label4.Name = "label4";
		label4.Padding = new Padding(3);
		label4.Size = new Size(160, 21);
		label4.TabIndex = 1;
		label4.Text = "TextBox - WndProc override";
		// 
		// textBoxInPanel1
		// 
		textBoxInPanel1.ActiveBorderColor = Color.Red;
		textBoxInPanel1.BackColor = Color.Blue;
		textBoxInPanel1.BorderColor = Color.Blue;
		textBoxInPanel1.BorderSize = 10;
		textBoxInPanel1.Location = new Point(172, 150);
		textBoxInPanel1.Multiline = false;
		textBoxInPanel1.Name = "textBoxInPanel1";
		textBoxInPanel1.Padding = new Padding(10);
		textBoxInPanel1.Size = new Size(100, 36);
		textBoxInPanel1.TabIndex = 7;
		textBoxInPanel1.Text = "hello";
		// 
		// label5
		// 
		label5.AutoSize = true;
		label5.Location = new Point(5, 150);
		label5.Name = "label5";
		label5.Size = new Size(93, 15);
		label5.TabIndex = 8;
		label5.Text = "TextBox in Panel";
		// 
		// label6
		// 
		label6.AutoSize = true;
		label6.Location = new Point(352, 150);
		label6.Name = "label6";
		label6.Size = new Size(70, 15);
		label6.TabIndex = 9;
		label6.Text = "10px border";
		// 
		// textBoxBordered1
		// 
		textBoxBordered1.ActiveBorderColor = Color.Red;
		textBoxBordered1.BorderColor = Color.Green;
		textBoxBordered1.BorderSize = 10;
		textBoxBordered1.BorderStyle = BorderStyle.None;
		textBoxBordered1.DrawBorder = true;
		textBoxBordered1.Location = new Point(174, 13);
		textBoxBordered1.Name = "textBoxBordered1";
		textBoxBordered1.Size = new Size(100, 16);
		textBoxBordered1.TabIndex = 5;
		// 
		// MainWindow
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(643, 223);
		Controls.Add(label6);
		Controls.Add(label5);
		Controls.Add(textBoxInPanel1);
		Controls.Add(panel4);
		Controls.Add(panel3);
		Controls.Add(panel2);
		Controls.Add(panel1);
		Name = "MainWindow";
		Text = "MainWindow";
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		panel3.ResumeLayout(false);
		panel3.PerformLayout();
		panel4.ResumeLayout(false);
		panel4.PerformLayout();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Panel panel1;
	private Label label1;
	private Panel panel2;
	private Label label3;
	private Panel panel3;
	private Panel panel4;
	private Label label4;
	private Controls.TextBoxDerived textBoxDerived2;
	private Label label2;
	private Controls.TextBoxInPanel textBoxInPanel1;
	private TextBox textBox2;
	private Label label5;
	private Label label7;
	private Label label6;
	private Controls.TextBoxBordered textBoxBordered1;
}