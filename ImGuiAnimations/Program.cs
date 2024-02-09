using ImGuiAnimations;
using System.Runtime.InteropServices;

[DllImport("kernel32.dll")]
static extern IntPtr GetConsoleWindow();

[DllImport("user32.dll")]
static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
var handle = GetConsoleWindow();

ShowWindow(handle, 0);

var renderer = new Renderer();
await renderer.Run();
