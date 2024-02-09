using System.Numerics;
using ImGuiNET;

namespace ImGuiAnimations.Animations.Helpers.Theme;

public class MaterialFlat: ITheme
{
    public void Style()
    {
        var style = ImGuiNET.ImGui.GetStyle();
	
	style.Alpha = 1.0f;
	style.DisabledAlpha = 0.5f;
	style.WindowPadding = new Vector2(8.0f, 8.0f);
	style.WindowRounding = 0.0f;
	style.WindowBorderSize = 1.0f;
	style.WindowMinSize = new Vector2(32.0f, 32.0f);
	style.WindowTitleAlign = new Vector2(0.0f, 0.5f);
	style.WindowMenuButtonPosition = ImGuiDir.Left;
	style.ChildRounding = 0.0f;
	style.ChildBorderSize = 1.0f;
	style.PopupRounding = 0.0f;
	style.PopupBorderSize = 1.0f;
	style.FramePadding = new Vector2(4.0f, 3.0f);
	style.FrameRounding = 0.0f;
	style.FrameBorderSize = 0.0f;
	style.ItemSpacing = new Vector2(8.0f, 4.0f);
	style.ItemInnerSpacing = new Vector2(4.0f, 4.0f);
	style.CellPadding = new Vector2(4.0f, 2.0f);
	style.IndentSpacing = 21.0f;
	style.ColumnsMinSpacing = 6.0f;
	style.ScrollbarSize = 14.0f;
	style.ScrollbarRounding = 0.0f;
	style.GrabMinSize = 10.0f;
	style.GrabRounding = 0.0f;
	style.TabRounding = 0.0f;
	style.TabBorderSize = 0.0f;
	style.TabMinWidthForCloseButton = 0.0f;
	style.ColorButtonPosition = ImGuiDir.Left;
	style.ButtonTextAlign = new Vector2(0.5f, 0.5f);
	style.SelectableTextAlign = new Vector2(0.0f, 0.0f);
	
	style.Colors[(int)ImGuiCol.Text] = new Vector4(0.8313725590705872f, 0.8470588326454163f, 0.8784313797950745f, 1.0f);
	style.Colors[(int)ImGuiCol.TextDisabled] = new Vector4(0.8313725590705872f, 0.8470588326454163f, 0.8784313797950745f, 0.501960813999176f);
	style.Colors[(int)ImGuiCol.WindowBg] = new Vector4(0.1725490242242813f, 0.1921568661928177f, 0.2352941185235977f, 1.0f);
	style.Colors[(int)ImGuiCol.ChildBg] = new Vector4(0.0f, 0.0f, 0.0f, 0.1587982773780823f);
	style.Colors[(int)ImGuiCol.PopupBg] = new Vector4(0.1725490242242813f, 0.1921568661928177f, 0.2352941185235977f, 1.0f);
	style.Colors[(int)ImGuiCol.Border] = new Vector4(0.2039215713739395f, 0.2313725501298904f, 0.2823529541492462f, 1.0f);
	style.Colors[(int)ImGuiCol.BorderShadow] = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
	style.Colors[(int)ImGuiCol.FrameBg] = new Vector4(0.105882354080677f, 0.1137254908680916f, 0.1372549086809158f, 0.501960813999176f);
	style.Colors[(int)ImGuiCol.FrameBgHovered] = new Vector4(0.3098039329051971f, 0.6235294342041016f, 0.9333333373069763f, 0.250980406999588f);
	style.Colors[(int)ImGuiCol.FrameBgActive] = new Vector4(0.3098039329051971f, 0.6235294342041016f, 0.9333333373069763f, 1.0f);
	style.Colors[(int)ImGuiCol.TitleBg] = new Vector4(0.105882354080677f, 0.1137254908680916f, 0.1372549086809158f, 1.0f);
	style.Colors[(int)ImGuiCol.TitleBgActive] = new Vector4(0.105882354080677f, 0.1137254908680916f, 0.1372549086809158f, 1.0f);
	style.Colors[(int)ImGuiCol.TitleBgCollapsed] = new Vector4(0.105882354080677f, 0.1137254908680916f, 0.1372549086809158f, 1.0f);
	style.Colors[(int)ImGuiCol.MenuBarBg] = new Vector4(0.105882354080677f, 0.1137254908680916f, 0.1372549086809158f, 1.0f);
	style.Colors[(int)ImGuiCol.ScrollbarBg] = new Vector4(0.01960784383118153f, 0.01960784383118153f, 0.01960784383118153f, 0.0f);
	style.Colors[(int)ImGuiCol.ScrollbarGrab] = new Vector4(0.5333333611488342f, 0.5333333611488342f, 0.5333333611488342f, 1.0f);
	style.Colors[(int)ImGuiCol.ScrollbarGrabHovered] = new Vector4(0.3333333432674408f, 0.3333333432674408f, 0.3333333432674408f, 1.0f);
	style.Colors[(int)ImGuiCol.ScrollbarGrabActive] = new Vector4(0.6000000238418579f, 0.6000000238418579f, 0.6000000238418579f, 1.0f);
	style.Colors[(int)ImGuiCol.CheckMark] = new Vector4(0.3098039329051971f, 0.6235294342041016f, 0.9333333373069763f, 1.0f);
	style.Colors[(int)ImGuiCol.SliderGrab] = new Vector4(0.239215686917305f, 0.5215686559677124f, 0.8784313797950745f, 1.0f);
	style.Colors[(int)ImGuiCol.SliderGrabActive] = new Vector4(0.2588235437870026f, 0.5882353186607361f, 0.9803921580314636f, 1.0f);
	style.Colors[(int)ImGuiCol.Button] = new Vector4(0.1529411822557449f, 0.1725490242242813f, 0.2117647081613541f, 0.501960813999176f);
	style.Colors[(int)ImGuiCol.ButtonHovered] = new Vector4(0.1529411822557449f, 0.1725490242242813f, 0.2117647081613541f, 1.0f);
	style.Colors[(int)ImGuiCol.ButtonActive] = new Vector4(0.3098039329051971f, 0.6235294342041016f, 0.9333333373069763f, 1.0f);
	style.Colors[(int)ImGuiCol.Header] = new Vector4(0.1529411822557449f, 0.1725490242242813f, 0.2117647081613541f, 1.0f);
	style.Colors[(int)ImGuiCol.HeaderHovered] = new Vector4(0.3098039329051971f, 0.6235294342041016f, 0.9333333373069763f, 0.250980406999588f);
	style.Colors[(int)ImGuiCol.HeaderActive] = new Vector4(0.3098039329051971f, 0.6235294342041016f, 0.9333333373069763f, 1.0f);
	style.Colors[(int)ImGuiCol.Separator] = new Vector4(0.4274509847164154f, 0.4274509847164154f, 0.4980392158031464f, 0.5f);
	style.Colors[(int)ImGuiCol.SeparatorHovered] = new Vector4(0.09803921729326248f, 0.4000000059604645f, 0.7490196228027344f, 0.7799999713897705f);
	style.Colors[(int)ImGuiCol.SeparatorActive] = new Vector4(0.09803921729326248f, 0.4000000059604645f, 0.7490196228027344f, 1.0f);
	style.Colors[(int)ImGuiCol.ResizeGrip] = new Vector4(0.105882354080677f, 0.1137254908680916f, 0.1372549086809158f, 1.0f);
	style.Colors[(int)ImGuiCol.ResizeGripHovered] = new Vector4(0.3098039329051971f, 0.6235294342041016f, 0.9333333373069763f, 0.250980406999588f);
	style.Colors[(int)ImGuiCol.ResizeGripActive] = new Vector4(0.3098039329051971f, 0.6235294342041016f, 0.9333333373069763f, 1.0f);
	style.Colors[(int)ImGuiCol.Tab] = new Vector4(0.1529411822557449f, 0.1725490242242813f, 0.2117647081613541f, 1.0f);
	style.Colors[(int)ImGuiCol.TabHovered] = new Vector4(0.3098039329051971f, 0.6235294342041016f, 0.9333333373069763f, 0.250980406999588f);
	style.Colors[(int)ImGuiCol.TabActive] = new Vector4(0.3098039329051971f, 0.6235294342041016f, 0.9333333373069763f, 1.0f);
	style.Colors[(int)ImGuiCol.TabUnfocused] = new Vector4(0.1529411822557449f, 0.1725490242242813f, 0.2117647081613541f, 1.0f);
	style.Colors[(int)ImGuiCol.TabUnfocusedActive] = new Vector4(0.3098039329051971f, 0.6235294342041016f, 0.9333333373069763f, 1.0f);
	style.Colors[(int)ImGuiCol.PlotLines] = new Vector4(0.6078431606292725f, 0.6078431606292725f, 0.6078431606292725f, 1.0f);
	style.Colors[(int)ImGuiCol.PlotLinesHovered] = new Vector4(1.0f, 0.4274509847164154f, 0.3490196168422699f, 1.0f);
	style.Colors[(int)ImGuiCol.PlotHistogram] = new Vector4(0.8980392217636108f, 0.6980392336845398f, 0.0f, 1.0f);
	style.Colors[(int)ImGuiCol.PlotHistogramHovered] = new Vector4(1.0f, 0.6000000238418579f, 0.0f, 1.0f);
	style.Colors[(int)ImGuiCol.TableHeaderBg] = new Vector4(0.105882354080677f, 0.1137254908680916f, 0.1372549086809158f, 1.0f);
	style.Colors[(int)ImGuiCol.TableBorderStrong] = new Vector4(0.2039215713739395f, 0.2313725501298904f, 0.2823529541492462f, 1.0f);
	style.Colors[(int)ImGuiCol.TableBorderLight] = new Vector4(0.2039215713739395f, 0.2313725501298904f, 0.2823529541492462f, 0.5021458864212036f);
	style.Colors[(int)ImGuiCol.TableRowBg] = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
	style.Colors[(int)ImGuiCol.TableRowBgAlt] = new Vector4(1.0f, 1.0f, 1.0f, 0.03862661123275757f);
	style.Colors[(int)ImGuiCol.TextSelectedBg] = new Vector4(0.2039215713739395f, 0.2313725501298904f, 0.2823529541492462f, 1.0f);
	style.Colors[(int)ImGuiCol.DragDropTarget] = new Vector4(1.0f, 1.0f, 0.0f, 0.8999999761581421f);
	style.Colors[(int)ImGuiCol.NavHighlight] = new Vector4(0.2588235437870026f, 0.5882353186607361f, 0.9764705896377563f, 1.0f);
	style.Colors[(int)ImGuiCol.NavWindowingHighlight] = new Vector4(0.2039215713739395f, 0.2313725501298904f, 0.2823529541492462f, 0.7529411911964417f);
	style.Colors[(int)ImGuiCol.NavWindowingDimBg] = new Vector4(0.105882354080677f, 0.1137254908680916f, 0.1372549086809158f, 0.7529411911964417f);
	style.Colors[(int)ImGuiCol.ModalWindowDimBg] = new Vector4(0.105882354080677f, 0.1137254908680916f, 0.1372549086809158f, 0.7529411911964417f);

    }
}