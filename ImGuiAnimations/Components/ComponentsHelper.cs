using System.Numerics;
using ImGuiNET;

namespace ImGuiAnimations.Components;

public static class ComponentsHelper
{
    private static List<(string,ToggleButton)> _buttons= new();
    public static void VerticalTabBar(List<(string,Action)> tabNames, ref int selectedTab)
    {
       

        for (var i = 0; i < tabNames.Count; ++i)
        {
            if (!_buttons.Select(x => x.Item1).Contains(tabNames[i].Item1))
            {
                var button = new ToggleButton(tabNames[i].Item1, tabNames[i].Item2);
                _buttons.Add((tabNames[i].Item1, button));
            }
           
        }
        for (var j = 0; j < _buttons.Count; j++)
        {
            _buttons[j].Item2.Render();
        }

        Console.WriteLine(_buttons.Count);

    }
}