using System.Collections.Generic;
using System.Numerics;
using ClickableTransparentOverlay;
using ImGuiAnimations.Animations;
using ImGuiAnimations.Animations.SnowFlake;
using ImGuiAnimations.Components;
using ImGuiAnimations.Pages;
using ImGuiNET;


namespace ImGuiAnimations;

public class Renderer : Overlay
{
    private static readonly List<Snowflake> Snowflakes = new();
    private bool _isInitialized;

    private void Init()
    {
        Size = new System.Drawing.Size(1920, 1080);
        Style();
        Snowflake.CreateMultiColoredSnowFlakes(Snowflakes, 5, 230, 2, 3);
    }

    protected override void Render()
    {
        if (!_isInitialized)
        {
            Init();
            _isInitialized = true;
        }

        ImGui.SetNextWindowSize(new Vector2(500, 300), ImGuiCond.Once);
        ImGui.SetNextWindowPos(new Vector2(0, 0), ImGuiCond.Once);
        ImGui.SetNextWindowBgAlpha(1);
        ImGui.Begin("Title",
            ImGuiWindowFlags.NoScrollbar |
            ImGuiWindowFlags.NoCollapse );
        {
            Snowflake.UpdateSnowFlakes(Snowflakes, new Vector3(ImGui.GetMousePos().X, ImGui.GetMousePos().Y, 0),
                new Vector3(ImGui.GetWindowPos().X, ImGui.GetWindowPos().Y, 0), new Vector3(0, 0.005f, 0));
            ImGui.BeginChild("RgbBar", new Vector2(-1, -1));
            {
                ColoredBar.Render(true);
                ImGui.SameLine();
                ComponentsHelper.VerticalTabBar();
            }
            ImGui.EndChild();
        }
        ImGui.End();
    }

    private void Style()
    {
       
    }

   
       
}