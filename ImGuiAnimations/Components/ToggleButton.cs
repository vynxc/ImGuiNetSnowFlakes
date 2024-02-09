using System.Numerics;
using ImGuiNET;

namespace ImGuiAnimations.Components;

public class ToggleButton(string text,Action onClick)
{
    private const float ScaleAmount = 1.25f;

    //private const float MinWidth = 100;
   // private const float MaxWidth = MinWidth * ScaleAmount;
    private const float MinHeight = 35;
    private const float MaxHeight = MinHeight * ScaleAmount;

   // private float _currentWidth = MinWidth;
    private float _currentHeight = MinHeight;
    private bool _hovered;
    private const float HoverTransitionSpeed = 0.15f;
    public void Render(bool toggled = false)
    {
        
        if (toggled)
        {
            var rectangleHeight = _currentHeight * 0.65f;

            ImGui.GetWindowDrawList().AddRectFilled(
                ImGui.GetCursorScreenPos() + new Vector2(0, _currentHeight / 2 - rectangleHeight / 2),
                ImGui.GetCursorScreenPos() + new Vector2(5, _currentHeight / 2 + rectangleHeight / 2),
                ImGui.GetColorU32( new Vector4(0.00f, 1.00f, 1.00f, 1.00f)),
                5f);
        }
        ImGui.PushStyleVar(ImGuiStyleVar.FrameRounding, 5f);

        // _currentWidth = Lerp(_currentWidth, MinWidth, HoverTransitionSpeed);
        //  _currentWidth = Lerp(_currentWidth, MaxWidth, HoverTransitionSpeed);
        _currentHeight = Lerp(_currentHeight, _hovered||toggled ? MaxHeight : MinHeight, HoverTransitionSpeed);

        if (ImGui.Button(text, new Vector2(-1, _currentHeight)))
        {
            onClick();
        }
        ImGui.PopStyleVar(1);
        _hovered = ImGui.IsItemHovered();
    }

    private static float Lerp(float a, float b, float t)
    {
        return a + (b - a) * Math.Clamp(t, 0f, 1f);
    }
}