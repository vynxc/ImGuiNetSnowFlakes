using System.Numerics;
using ImGuiNET;

namespace ImGuiAnimations.Animations.Helpers.Theme;

public class Nebula: ITheme
{
    public void Style()
    {
        var style = ImGui.GetStyle();
        style.Alpha = 1.0f;
        style.WindowRounding = 3;
        style.GrabRounding = 1;
        style.GrabMinSize = 20;
        style.FrameRounding = 3;
        style.Colors[(int)ImGuiCol.Text] = new Vector4(0.00f, 1.00f, 1.00f, 1.00f);
        style.Colors[(int)ImGuiCol.TextDisabled] = new Vector4(0.00f, 0.40f, 0.41f, 1.00f);
        style.Colors[(int)ImGuiCol.WindowBg] = new Vector4(0.00f, 0.00f, 0.00f, 1.00f);
        style.Colors[(int)ImGuiCol.ChildBg] = new Vector4(0.00f, 0.00f, 0.00f, 0.00f);
        style.Colors[(int)ImGuiCol.Border] = new Vector4(0.00f, 1.00f, 1.00f, 0.65f);
        style.Colors[(int)ImGuiCol.BorderShadow] = new Vector4(0.00f, 0.00f, 0.00f, 0.00f);
        style.Colors[(int)ImGuiCol.FrameBg] = new Vector4(0.44f, 0.80f, 0.80f, 0.18f);
        style.Colors[(int)ImGuiCol.FrameBgHovered] = new Vector4(0.44f, 0.80f, 0.80f, 0.27f);
        style.Colors[(int)ImGuiCol.FrameBgActive] = new Vector4(0.44f, 0.81f, 0.86f, 0.66f);
        style.Colors[(int)ImGuiCol.TitleBg] = new Vector4(0.14f, 0.18f, 0.21f, 0.73f);
        style.Colors[(int)ImGuiCol.TitleBgCollapsed] = new Vector4(0.00f, 0.00f, 0.00f, 0.54f);
        style.Colors[(int)ImGuiCol.TitleBgActive] = new Vector4(0.00f, 1.00f, 1.00f, 0.27f);
        style.Colors[(int)ImGuiCol.MenuBarBg] = new Vector4(0.00f, 0.00f, 0.00f, 0.20f);
        style.Colors[(int)ImGuiCol.ScrollbarBg] = new Vector4(0.22f, 0.29f, 0.30f, 0.71f);
        style.Colors[(int)ImGuiCol.ScrollbarGrab] = new Vector4(0.00f, 1.00f, 1.00f, 0.44f);
        style.Colors[(int)ImGuiCol.ScrollbarGrabHovered] = new Vector4(0.00f, 1.00f, 1.00f, 0.74f);
        style.Colors[(int)ImGuiCol.ScrollbarGrabActive] = new Vector4(0.00f, 1.00f, 1.00f, 1.00f);
        style.Colors[(int)ImGuiCol.CheckMark] = new Vector4(0.00f, 1.00f, 1.00f, 0.68f);
        style.Colors[(int)ImGuiCol.SliderGrab] = new Vector4(0.00f, 1.00f, 1.00f, 0.36f);
        style.Colors[(int)ImGuiCol.SliderGrabActive] = new Vector4(0.00f, 1.00f, 1.00f, 0.76f);
        style.Colors[(int)ImGuiCol.Button] = new Vector4(0.00f, 0.65f, 0.65f, 0.46f);
        style.Colors[(int)ImGuiCol.ButtonHovered] = new Vector4(0.01f, 1.00f, 1.00f, 0.43f);
        style.Colors[(int)ImGuiCol.ButtonActive] = new Vector4(0.00f, 1.00f, 1.00f, 0.62f);
        style.Colors[(int)ImGuiCol.Header] = new Vector4(0.00f, 1.00f, 1.00f, 0.33f);
        style.Colors[(int)ImGuiCol.HeaderHovered] = new Vector4(0.00f, 1.00f, 1.00f, 0.42f);
        style.Colors[(int)ImGuiCol.HeaderActive] = new Vector4(0.00f, 1.00f, 1.00f, 0.54f);
        style.Colors[(int)ImGuiCol.ResizeGrip] = new Vector4(0.00f, 1.00f, 1.00f, 0.54f);
        style.Colors[(int)ImGuiCol.ResizeGripHovered] = new Vector4(0.00f, 1.00f, 1.00f, 0.74f);
        style.Colors[(int)ImGuiCol.ResizeGripActive] = new Vector4(0.00f, 1.00f, 1.00f, 1.00f);
        style.Colors[(int)ImGuiCol.PlotLines] = new Vector4(0.00f, 1.00f, 1.00f, 1.00f);
        style.Colors[(int)ImGuiCol.PlotLinesHovered] = new Vector4(0.00f, 1.00f, 1.00f, 1.00f);
        style.Colors[(int)ImGuiCol.PlotHistogram] = new Vector4(0.00f, 1.00f, 1.00f, 1.00f);
        style.Colors[(int)ImGuiCol.PlotHistogramHovered] = new Vector4(0.00f, 1.00f, 1.00f, 1.00f);
        style.Colors[(int)ImGuiCol.TextSelectedBg] = new Vector4(0.00f, 1.00f, 1.00f, 0.22f);
        style.Colors[(int)ImGuiCol.ModalWindowDimBg] = new Vector4(0.04f, 0.10f, 0.09f, 0.51f);
    }
}