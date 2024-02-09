using System.Numerics;
using ImGuiNET;

namespace ImGuiAnimations.Pages;

public class Home : IPage
{
    public void Render()
    {
        var scale = 1.5f; 
        ImGui.GetIO().FontGlobalScale = scale;
        ImGui.Text("Home Page");
        ImGui.GetIO().FontGlobalScale = 1.0f;
        ImGui.BeginChild("HomeContent", new Vector2(-1, -1),ImGuiChildFlags.Border);
        {
            ImGui.TextWrapped("Welcome to ImGuiAnimations! \n \nThis is a simple example of how to create a tab system using ImGui.NET. \n \nThis project is part of the ImGuiAnimations series. \n \nYou can find the source code on GitHub.");

        }
    }
}