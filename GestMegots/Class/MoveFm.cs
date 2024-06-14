using System.Runtime.InteropServices;

namespace GestMegots.Class;

public class MoveFm
{
    public const int WmNclbuttondown = 0xA1;
    public const int HtCaption = 0x2;

    [DllImportAttribute("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
    [DllImportAttribute("user32.dll")]
    public static extern bool ReleaseCapture();
}