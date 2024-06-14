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
		textBox2 = new TextBox();
		label1 = new Label();
		label3 = new Label();
		label2 = new Label();
		textBoxDerived2 = new Controls.TextBoxDerived();
		textBoxBordered1 = new Controls.TextBoxBordered();
		label7 = new Label();
		label4 = new Label();
		textBoxInPanel1 = new Controls.TextBoxInPanel();
		label5 = new Label();
		label6 = new Label();
		flatTextBox1 = new Controls.FlatTextBox();
		label8 = new Label();
		label9 = new Label();
		label10 = new Label();
		SuspendLayout();
		// 
		// textBox2
		// 
		textBox2.Location = new Point(213, 27);
		textBox2.Name = "textBox2";
		textBox2.Size = new Size(100, 23);
		textBox2.TabIndex = 2;
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Location = new Point(5, 30);
		label1.Margin = new Padding(4, 1, 4, 1);
		label1.Name = "label1";
		label1.Padding = new Padding(3);
		label1.Size = new Size(104, 21);
		label1.TabIndex = 1;
		label1.Text = "Standard TextBox";
		// 
		// label3
		// 
		label3.AutoSize = true;
		label3.Location = new Point(5, 64);
		label3.Margin = new Padding(4, 1, 4, 1);
		label3.Name = "label3";
		label3.Padding = new Padding(3);
		label3.Size = new Size(154, 21);
		label3.TabIndex = 1;
		label3.Text = "TextBox - OnPaint override";
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Location = new Point(352, 64);
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
		textBoxDerived2.Location = new Point(213, 64);
		textBoxDerived2.Name = "textBoxDerived2";
		textBoxDerived2.Size = new Size(100, 16);
		textBoxDerived2.TabIndex = 2;
		// 
		// textBoxBordered1
		// 
		textBoxBordered1.ActiveBorderColor = Color.Red;
		textBoxBordered1.BorderColor = Color.Green;
		textBoxBordered1.BorderSize = 10;
		textBoxBordered1.BorderStyle = BorderStyle.None;
		textBoxBordered1.DrawBorder = true;
		textBoxBordered1.Location = new Point(213, 105);
		textBoxBordered1.Name = "textBoxBordered1";
		textBoxBordered1.Size = new Size(100, 16);
		textBoxBordered1.TabIndex = 5;
		// 
		// label7
		// 
		label7.AutoSize = true;
		label7.Location = new Point(352, 105);
		label7.Name = "label7";
		label7.Size = new Size(70, 15);
		label7.TabIndex = 4;
		label7.Text = "10px border";
		// 
		// label4
		// 
		label4.AutoSize = true;
		label4.Location = new Point(5, 104);
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
		textBoxInPanel1.Location = new Point(213, 178);
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
		label5.Location = new Point(12, 189);
		label5.Name = "label5";
		label5.Size = new Size(93, 15);
		label5.TabIndex = 8;
		label5.Text = "TextBox in Panel";
		// 
		// label6
		// 
		label6.AutoSize = true;
		label6.Location = new Point(352, 189);
		label6.Name = "label6";
		label6.Size = new Size(70, 15);
		label6.TabIndex = 9;
		label6.Text = "10px border";
		// 
		// flatTextBox1
		// 
		flatTextBox1.BorderStyle = BorderStyle.None;
		flatTextBox1.Location = new Point(213, 139);
		flatTextBox1.Name = "flatTextBox1";
		flatTextBox1.Size = new Size(100, 16);
		flatTextBox1.TabIndex = 10;
		// 
		// label8
		// 
		label8.AutoSize = true;
		label8.Location = new Point(12, 140);
		label8.Name = "label8";
		label8.Size = new Size(70, 15);
		label8.TabIndex = 11;
		label8.Text = "Flat TextBox";
		// 
		// label9
		// 
		label9.AutoSize = true;
		label9.Location = new Point(12, 234);
		label9.Name = "label9";
		label9.Size = new Size(195, 15);
		label9.TabIndex = 13;
		label9.Text = "UserControl with TextBox and Panel";
		// 
		// label10
		// 
		label10.AutoSize = true;
		label10.Location = new Point(352, 140);
		label10.Name = "label10";
		label10.Size = new Size(108, 15);
		label10.TabIndex = 14;
		label10.Text = "no borders TextBox";
		// 
		// MainWindow
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(643, 300);
		Controls.Add(textBox2);
		Controls.Add(label2);
		Controls.Add(label1);
		Controls.Add(label7);
		Controls.Add(textBoxDerived2);
		Controls.Add(textBoxBordered1);
		Controls.Add(label3);
		Controls.Add(label10);
		Controls.Add(label9);
		Controls.Add(label4);
		Controls.Add(label8);
		Controls.Add(flatTextBox1);
		Controls.Add(label6);
		Controls.Add(label5);
		Controls.Add(textBoxInPanel1);
		Name = "MainWindow";
		Text = "MainWindow";
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion
	private Label label1;
	private Label label3;
	private Label label4;
	private Controls.TextBoxDerived textBoxDerived2;
	private Label label2;
	private Controls.TextBoxInPanel textBoxInPanel1;
	private TextBox textBox2;
	private Label label5;
	private Label label7;
	private Label label6;
	private Controls.TextBoxBordered textBoxBordered1;
	private Controls.FlatTextBox flatTextBox1;
	private Label label8;
	private Label label9;
	private Label label10;
}