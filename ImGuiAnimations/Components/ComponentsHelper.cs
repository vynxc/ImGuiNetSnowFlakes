using System.Numerics;
using ImGuiAnimations.Animations;
using ImGuiAnimations.Pages;
using ImGuiNET;

namespace ImGuiAnimations.Components;

/// <summary>
/// A helper class for managing components.
/// </summary>
public static class ComponentsHelper
{
    /// <summary>
    /// Represents the currently selected tab index.
    /// </summary>
    private static int _selectedTab;

    /// <summary>
    /// Represents a collection of pages.
    /// </summary>
    private static readonly List<Page> Pages =
    [
        new Page("Home", new Home()),
        new Page("Aim", new Aim()),
        new Page("Exploits", new Exploits()),
        new Page("Theme", new Theme())
    ];

    /// <summary>
    /// The list of tuples containing the name and corresponding toggle button.
    /// </summary>
    private static readonly List<(string,ToggleButton)> Buttons= new();

    /// <summary>
    /// Displays a vertical tab bar with a list of pages.
    /// </summary>
    public static void VerticalTabBar()
    {
        ImGui.BeginChild("TabsAndContent", new Vector2(125, -1), ImGuiChildFlags.Border, ImGuiWindowFlags.None);
        {

            for (var i = 0; i < Pages.Count; ++i)
            {
                if (!Buttons.Select(x => x.Item1).Contains(Pages[i].Name))
                {
                    var i1 = i;
                    var button = new ToggleButton(Pages[i].Name, () => { _selectedTab = i1; });
                    Buttons.Add((Pages[i].Name, button));
                }

            }

            for (var i = 0; i < Buttons.Count; i++)
            {
                Buttons[i].Item2.Render(_selectedTab == i);
            }
        }
        ImGui.EndChild();
        RenderPage();

    }

    /// <summary>
    /// Renders a page using the ImGui framework.
    /// </summary>
    private static void RenderPage()
    {
        ImGui.SameLine();
        ImGui.BeginChild("Content" ,new Vector2(-1, -1));
        {
            Pages[_selectedTab].RenderPage.Render();
        }
      
    }
}