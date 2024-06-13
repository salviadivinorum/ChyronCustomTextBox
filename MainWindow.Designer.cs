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
		textBoxDerived1 = new Controls.TextBoxDerived();
		label1 = new Label();
		panel2 = new Panel();
		label3 = new Label();
		panel3 = new Panel();
		textBoxDerived2 = new Controls.TextBoxDerived();
		panel4 = new Panel();
		label2 = new Label();
		textBoxDerived3 = new Controls.TextBoxDerived();
		label4 = new Label();
		panel5 = new Panel();
		label5 = new Label();
		textBoxDerived4 = new Controls.TextBoxDerived();
		label6 = new Label();
		panel1.SuspendLayout();
		panel3.SuspendLayout();
		panel4.SuspendLayout();
		panel5.SuspendLayout();
		SuspendLayout();
		// 
		// panel1
		// 
		panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		panel1.Controls.Add(textBoxDerived1);
		panel1.Controls.Add(label1);
		panel1.Location = new Point(0, 30);
		panel1.Name = "panel1";
		panel1.Size = new Size(543, 30);
		panel1.TabIndex = 0;
		// 
		// textBoxDerived1
		// 
		textBoxDerived1.ActiveBorderColor = Color.Red;
		textBoxDerived1.BorderColor = Color.Blue;
		textBoxDerived1.BorderSize = 1;
		textBoxDerived1.BorderStyle = BorderStyle.None;
		textBoxDerived1.DrawBorder = true;
		textBoxDerived1.Location = new Point(100, 6);
		textBoxDerived1.Name = "textBoxDerived1";
		textBoxDerived1.Size = new Size(100, 16);
		textBoxDerived1.TabIndex = 2;
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
		label3.Size = new Size(74, 21);
		label3.TabIndex = 1;
		label3.Text = "Enter value:";
		// 
		// panel3
		// 
		panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		panel3.Controls.Add(textBoxDerived2);
		panel3.Controls.Add(label3);
		panel3.Location = new Point(0, 60);
		panel3.Name = "panel3";
		panel3.Size = new Size(543, 30);
		panel3.TabIndex = 2;
		// 
		// textBoxDerived2
		// 
		textBoxDerived2.ActiveBorderColor = Color.Red;
		textBoxDerived2.BorderColor = Color.Blue;
		textBoxDerived2.BorderSize = 1;
		textBoxDerived2.BorderStyle = BorderStyle.None;
		textBoxDerived2.DrawBorder = true;
		textBoxDerived2.Location = new Point(102, 8);
		textBoxDerived2.Name = "textBoxDerived2";
		textBoxDerived2.Size = new Size(100, 16);
		textBoxDerived2.TabIndex = 2;
		// 
		// panel4
		// 
		panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		panel4.Controls.Add(label2);
		panel4.Controls.Add(textBoxDerived3);
		panel4.Controls.Add(label4);
		panel4.Location = new Point(0, 90);
		panel4.Name = "panel4";
		panel4.Size = new Size(543, 30);
		panel4.TabIndex = 3;
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Location = new Point(270, 8);
		label2.Name = "label2";
		label2.Size = new Size(70, 15);
		label2.TabIndex = 3;
		label2.Text = "10px border";
		// 
		// textBoxDerived3
		// 
		textBoxDerived3.ActiveBorderColor = Color.Red;
		textBoxDerived3.BorderColor = Color.Blue;
		textBoxDerived3.BorderSize = 10;
		textBoxDerived3.BorderStyle = BorderStyle.None;
		textBoxDerived3.DrawBorder = true;
		textBoxDerived3.Location = new Point(103, 9);
		textBoxDerived3.Name = "textBoxDerived3";
		textBoxDerived3.Size = new Size(100, 16);
		textBoxDerived3.TabIndex = 2;
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
		panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		panel5.Controls.Add(label5);
		panel5.Controls.Add(textBoxDerived4);
		panel5.Controls.Add(label6);
		panel5.Location = new Point(0, 120);
		panel5.Name = "panel5";
		panel5.Size = new Size(543, 30);
		panel5.TabIndex = 4;
		// 
		// label5
		// 
		label5.AutoSize = true;
		label5.Location = new Point(273, 8);
		label5.Name = "label5";
		label5.Size = new Size(59, 15);
		label5.TabIndex = 3;
		label5.Text = "no border";
		// 
		// textBoxDerived4
		// 
		textBoxDerived4.ActiveBorderColor = Color.Red;
		textBoxDerived4.BorderColor = Color.Blue;
		textBoxDerived4.BorderSize = 1;
		textBoxDerived4.BorderStyle = BorderStyle.None;
		textBoxDerived4.DrawBorder = false;
		textBoxDerived4.Location = new Point(104, 9);
		textBoxDerived4.Name = "textBoxDerived4";
		textBoxDerived4.Size = new Size(100, 16);
		textBoxDerived4.TabIndex = 2;
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
		// MainWindow
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(643, 223);
		Controls.Add(panel5);
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
		panel5.ResumeLayout(false);
		panel5.PerformLayout();
		ResumeLayout(false);
	}

	#endregion

	private Panel panel1;
	private Label label1;
	private Panel panel2;
	private Label label3;
	private Panel panel3;
	private Panel panel4;
	private Label label4;
	private Panel panel5;
	private Label label6;
	private Controls.TextBoxDerived textBoxDerived1;
	private Controls.TextBoxDerived textBoxDerived2;
	private Controls.TextBoxDerived textBoxDerived3;
	private Controls.TextBoxDerived textBoxDerived4;
	private Label label2;
	private Label label5;
}