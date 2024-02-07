using System.Collections.Generic;
using System.Numerics;
using ClickableTransparentOverlay;
using ImGuiAnimations.Animations.SnowFlake;
using ImGuiNET;


namespace ImGuiAnimations;

public class Renderer : Overlay
{
    private static readonly List<Snowflake> Snowflakes = new();
    private bool _isInitialized;

    private void Init()
    {
        Size = new System.Drawing.Size(1920, 1080);

        Snowflake.CreateMultiColoredSnowFlakes(Snowflakes);
    }

    protected override void Render()
    {
        if (!_isInitialized)
        {
            Init();
            _isInitialized = true;
        }

        ImGui.SetNextWindowSize(new Vector2(800, 500));
        ImGui.SetNextWindowPos(new Vector2(0, 0), ImGuiCond.Once);
        ImGui.SetNextWindowBgAlpha(1);
        ImGui.Begin("Title",
            ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoScrollbar | ImGuiWindowFlags.NoSavedSettings |
            ImGuiWindowFlags.NoCollapse);
        {
            Snowflake.UpdateSnowFlakes(Snowflakes, new Vector3(ImGui.GetMousePos().X, ImGui.GetMousePos().Y, 0),
                new Vector3(ImGui.GetWindowPos().X, ImGui.GetWindowPos().Y, 0), new Vector3(0, 0.005f, 0));
        }
        ImGui.End();
    }
}