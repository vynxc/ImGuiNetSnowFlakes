using System.Numerics;

namespace ImGuiAnimations.Animations.Helpers;

public static class ColorGenerator
{
    public static List<Vector4> GenerateRandomColors(int count)
    {
        var colors = new List<Vector4>();
        var random = new Random();

        for(int i = 0 ; i < count; i++)
        {
            var red = (float)random.NextDouble();
            var green = (float)random.NextDouble();
            var blue = (float)random.NextDouble();
            var alpha = (float)random.NextDouble();

            colors.Add(new Vector4(red, green, blue, alpha));
        }
        
        return colors;
    }
}