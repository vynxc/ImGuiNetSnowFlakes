using System.Numerics;
using ImGuiNET;

namespace ImGuiAnimations.Animations;

public static class ColoredBar
{
    private static float _staticHue;
    public static void Render(bool isVertical = false)
    {
        var rainbowSpeed = 0.001f;
        var drawList = ImGui.GetWindowDrawList();
        var panelPos = ImGui.GetWindowPos();
        _staticHue -= rainbowSpeed;

        if (_staticHue < -1f)
            _staticHue += 1f;

        int length = isVertical ? (int)ImGui.GetWindowHeight() : (int)ImGui.GetWindowWidth();

        for (var i = 0; i < length; i++)
        {
            var hue = _staticHue + 1f / (float)length * i;

            if (hue < 0f)
                hue += 1f;

            ImGui.ColorConvertHSVtoRGB(hue, 1, 1, out var r, out var g, out var b);
            var color = ImGui.GetColorU32(new Vector4(r, g, b, 1));

            if (isVertical)
            {
                drawList.AddRectFilled(
                    panelPos with { Y = panelPos.Y + i }, 
                    new Vector2(panelPos.X + 4, panelPos.Y + i + 1), 
                    color
                );
            }
            else
            {
                drawList.AddRectFilled(
                    panelPos with { X = panelPos.X + i }, 
                    new Vector2(panelPos.X + i + 1, panelPos.Y + 4), 
                    color
                );
            }
        }
    }
}