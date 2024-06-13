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
		labelTextBox1 = new Label();
		label1 = new Label();
		panel2 = new Panel();
		legend = new Label();
		label3 = new Label();
		labelTextBox2 = new Label();
		panel3 = new Panel();
		panel4 = new Panel();
		label2 = new Label();
		label4 = new Label();
		panel5 = new Panel();
		label5 = new Label();
		label6 = new Label();
		textBoxDerived1 = new Controls.TextBoxDerived();
		textBoxDerived2 = new Controls.TextBoxDerived();
		textBoxDerived3 = new Controls.TextBoxDerived();
		textBoxDerived4 = new Controls.TextBoxDerived();
		panel1.SuspendLayout();
		panel2.SuspendLayout();
		panel3.SuspendLayout();
		panel4.SuspendLayout();
		panel5.SuspendLayout();
		SuspendLayout();
		// 
		// panel1
		// 
		panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		panel1.Controls.Add(textBoxDerived1);
		panel1.Controls.Add(labelTextBox1);
		panel1.Controls.Add(label1);
		panel1.Location = new Point(0, 30);
		panel1.Name = "panel1";
		panel1.Size = new Size(700, 30);
		panel1.TabIndex = 0;
		// 
		// labelTextBox1
		// 
		labelTextBox1.AutoSize = true;
		labelTextBox1.Location = new Point(250, 3);
		labelTextBox1.Margin = new Padding(4, 1, 4, 1);
		labelTextBox1.Name = "labelTextBox1";
		labelTextBox1.Padding = new Padding(3);
		labelTextBox1.Size = new Size(77, 21);
		labelTextBox1.TabIndex = 2;
		labelTextBox1.Text = "5, Red, Lime";
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Location = new Point(5, 3);
		label1.Margin = new Padding(4, 1, 4, 1);
		label1.Name = "label1";
		label1.Padding = new Padding(3);
		label1.Size = new Size(74, 21);
		label1.TabIndex = 1;
		label1.Text = "Enter value:";
		// 
		// panel2
		// 
		panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		panel2.Controls.Add(legend);
		panel2.Location = new Point(0, 0);
		panel2.Name = "panel2";
		panel2.Size = new Size(700, 30);
		panel2.TabIndex = 1;
		// 
		// legend
		// 
		legend.AutoSize = true;
		legend.Location = new Point(250, 5);
		legend.Margin = new Padding(4, 1, 4, 1);
		legend.Name = "legend";
		legend.Padding = new Padding(3);
		legend.Size = new Size(244, 21);
		legend.TabIndex = 3;
		legend.Text = "BorderSize, BordedColor, ActiveBorderColor";
		// 
		// label3
		// 
		label3.AutoSize = true;
		label3.Location = new Point(5, 3);
		label3.Margin = new Padding(4, 1, 4, 1);
		label3.Name = "label3";
		label3.Padding = new Padding(3);
		label3.Size = new Size(74, 21);
		label3.TabIndex = 1;
		label3.Text = "Enter value:";
		// 
		// labelTextBox2
		// 
		labelTextBox2.AutoSize = true;
		labelTextBox2.Location = new Point(250, 3);
		labelTextBox2.Margin = new Padding(4, 1, 4, 1);
		labelTextBox2.Name = "labelTextBox2";
		labelTextBox2.Padding = new Padding(3);
		labelTextBox2.Size = new Size(40, 21);
		labelTextBox2.TabIndex = 2;
		labelTextBox2.Text = "color";
		// 
		// panel3
		// 
		panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		panel3.Controls.Add(textBoxDerived2);
		panel3.Controls.Add(labelTextBox2);
		panel3.Controls.Add(label3);
		panel3.Location = new Point(0, 60);
		panel3.Name = "panel3";
		panel3.Size = new Size(700, 30);
		panel3.TabIndex = 2;
		// 
		// panel4
		// 
		panel4.Controls.Add(textBoxDerived3);
		panel4.Controls.Add(label2);
		panel4.Controls.Add(label4);
		panel4.Location = new Point(0, 90);
		panel4.Name = "panel4";
		panel4.Size = new Size(700, 30);
		panel4.TabIndex = 3;
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Location = new Point(250, 3);
		label2.Margin = new Padding(4, 1, 4, 1);
		label2.Name = "label2";
		label2.Padding = new Padding(3);
		label2.Size = new Size(40, 21);
		label2.TabIndex = 2;
		label2.Text = "color";
		// 
		// label4
		// 
		label4.AutoSize = true;
		label4.Location = new Point(5, 3);
		label4.Margin = new Padding(4, 1, 4, 1);
		label4.Name = "label4";
		label4.Padding = new Padding(3);
		label4.Size = new Size(74, 21);
		label4.TabIndex = 1;
		label4.Text = "Enter value:";
		// 
		// panel5
		// 
		panel5.Controls.Add(textBoxDerived4);
		panel5.Controls.Add(label5);
		panel5.Controls.Add(label6);
		panel5.Location = new Point(0, 120);
		panel5.Name = "panel5";
		panel5.Size = new Size(700, 30);
		panel5.TabIndex = 4;
		// 
		// label5
		// 
		label5.AutoSize = true;
		label5.Location = new Point(250, 3);
		label5.Margin = new Padding(4, 1, 4, 1);
		label5.Name = "label5";
		label5.Padding = new Padding(3);
		label5.Size = new Size(40, 21);
		label5.TabIndex = 2;
		label5.Text = "color";
		// 
		// label6
		// 
		label6.AutoSize = true;
		label6.Location = new Point(5, 3);
		label6.Margin = new Padding(4, 1, 4, 1);
		label6.Name = "label6";
		label6.Padding = new Padding(3);
		label6.Size = new Size(74, 21);
		label6.TabIndex = 1;
		label6.Text = "Enter value:";
		// 
		// textBoxDerived1
		// 
		textBoxDerived1.ActiveBorderColor = Color.Red;
		textBoxDerived1.BorderColor = Color.Blue;
		textBoxDerived1.BorderSize = 1;
		textBoxDerived1.BorderStyle = BorderStyle.None;
		textBoxDerived1.Location = new Point(86, 7);
		textBoxDerived1.Name = "textBoxDerived1";
		textBoxDerived1.Size = new Size(100, 16);
		textBoxDerived1.TabIndex = 3;
		// 
		// textBoxDerived2
		// 
		textBoxDerived2.ActiveBorderColor = Color.Red;
		textBoxDerived2.BorderColor = Color.Blue;
		textBoxDerived2.BorderSize = 1;
		textBoxDerived2.BorderStyle = BorderStyle.None;
		textBoxDerived2.Location = new Point(86, 7);
		textBoxDerived2.Name = "textBoxDerived2";
		textBoxDerived2.Size = new Size(100, 16);
		textBoxDerived2.TabIndex = 3;
		// 
		// textBoxDerived3
		// 
		textBoxDerived3.ActiveBorderColor = Color.Red;
		textBoxDerived3.BorderColor = Color.FromArgb(255, 255, 128);
		textBoxDerived3.BorderSize = 1;
		textBoxDerived3.BorderStyle = BorderStyle.None;
		textBoxDerived3.Location = new Point(86, 6);
		textBoxDerived3.Name = "textBoxDerived3";
		textBoxDerived3.Size = new Size(100, 16);
		textBoxDerived3.TabIndex = 3;
		// 
		// textBoxDerived4
		// 
		textBoxDerived4.ActiveBorderColor = Color.Red;
		textBoxDerived4.BorderColor = Color.Blue;
		textBoxDerived4.BorderSize = 0;
		textBoxDerived4.BorderStyle = BorderStyle.None;
		textBoxDerived4.Location = new Point(86, 6);
		textBoxDerived4.Name = "textBoxDerived4";
		textBoxDerived4.Size = new Size(100, 16);
		textBoxDerived4.TabIndex = 3;
		// 
		// MainWindow
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 450);
		Controls.Add(panel5);
		Controls.Add(panel4);
		Controls.Add(panel3);
		Controls.Add(panel2);
		Controls.Add(panel1);
		Name = "MainWindow";
		Text = "MainWindow";
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		panel2.ResumeLayout(false);
		panel2.PerformLayout();
		panel3.ResumeLayout(false);
		panel3.PerformLayout();
		panel4.ResumeLayout(false);
		panel4.PerformLayout();
		panel5.ResumeLayout(false);
		panel5.PerformLayout();
		ResumeLayout(false);
	}

	#endregion

	private Panel panel1;
	private Label label1;
	private Label labelTextBox1;
	private Panel panel2;
	private Label legend;
	private Label label3;
	private Label labelTextBox2;
	private Panel panel3;
	private Panel panel4;
	private Label label2;
	private Label label4;
	private Panel panel5;
	private Label label5;
	private Label label6;
	private Controls.TextBoxDerived textBoxDerived1;
	private Controls.TextBoxDerived textBoxDerived2;
	private Controls.TextBoxDerived textBoxDerived3;
	private Controls.TextBoxDerived textBoxDerived4;
}