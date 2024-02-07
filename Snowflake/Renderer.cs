using System.Numerics;
using ClickableTransparentOverlay;
using ImGuiNET;
using Snowflake.Animations;

namespace Snowflake;

public class Renderer:Overlay
{
    private List<SnowFlake> snow = new ();
    bool _isInitialized = false;
    private void Init()
    {
        SnowFlake.CreateSnowFlakes(ref snow, 300, 5, 25, 0, 0, 1920, 1080, new Vector3(0, 0.005f,0), new Vector4(255, 255, 255, 100));
        Style();
    }
    protected override void Render()
    {
        if (!_isInitialized)
        {
            Init();
            _isInitialized = true;
        }
        ImGui.Begin("Title",
            ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoScrollbar | ImGuiWindowFlags.NoSavedSettings |
            ImGuiWindowFlags.NoCollapse);
        {
            SnowFlake.UpdateSnowFlakes(ref snow, new Vector3(ImGui.GetMousePos().X, ImGui.GetMousePos().Y, 0), new Vector3(ImGui.GetWindowPos().X, ImGui.GetWindowPos().Y, 0));
        }
        ImGui.End();
    }
    private void Style()
    {
        var style = ImGui.GetStyle();
        style.Colors[(int)ImGuiCol.WindowBg] = new System.Numerics.Vector4(34, 34, 34, 50);
        style.Colors[(int)ImGuiCol.TitleBg] = new System.Numerics.Vector4(59, 59, 59, 255);
        style.Colors[(int)ImGuiCol.TitleBgActive] = new System.Numerics.Vector4(59, 59, 59, 255);
        style.Colors[(int)ImGuiCol.FrameBg] = new System.Numerics.Vector4(59, 59, 59, 137);
        style.Colors[(int)ImGuiCol.Button] = new System.Numerics.Vector4(98, 98, 98, 102);
        style.Colors[(int)ImGuiCol.ButtonHovered] = new System.Numerics.Vector4(98, 98, 98, 255);
        style.Colors[(int)ImGuiCol.ButtonActive] = new System.Numerics.Vector4(81, 81, 81, 255);
    }
}