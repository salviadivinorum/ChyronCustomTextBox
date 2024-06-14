using System.Runtime.InteropServices;

namespace ChyronCustomTextBox.Controls;

public partial class FlatTextBox : TextBox
{
	[DllImport("user32.dll")]
	private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

	private const int WM_NCPAINT = 0x85;

	public FlatTextBox()
	{
		BorderStyle = BorderStyle.None;
	}

	protected override void OnGotFocus(EventArgs e)
	{
		base.OnGotFocus(e);
		RefreshBorder();
	}

	protected override void OnLostFocus(EventArgs e)
	{
		base.OnLostFocus(e);
		RefreshBorder();
	}

	private void RefreshBorder()
	{
		// remove the text box border
		SendMessage(Handle, WM_NCPAINT, 0, 0);
	}
}
