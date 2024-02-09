using System.Numerics;
using System.Reflection;
using ImGuiAnimations.Animations.Helpers.Theme;
using ImGuiNET;

namespace ImGuiAnimations.Pages;

public class Theme : IPage
{
    private static readonly IEnumerable<Type> ThemeTypes = Assembly.GetExecutingAssembly().GetTypes()
        .Where(t => typeof(ITheme).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract);
    public void Render()
    {
        foreach (var themeType in ThemeTypes)
        {
            var buttonWidth = ImGui.CalcTextSize(themeType.Name).X+ImGui.GetStyle().FramePadding.X*2;
            var remainingWidth = ImGui.GetContentRegionAvail().X;
            if (remainingWidth < buttonWidth)
            {
                ImGui.NewLine();
            }

            if (ImGui.Button(themeType.Name, new Vector2(buttonWidth, 0)))
            {
                var theme = (ITheme?)Activator.CreateInstance(themeType);
                if (theme != null)
                    theme.Style();
            }

            ImGui.SameLine();
        }

        ImGui.NewLine();
        
    }
}