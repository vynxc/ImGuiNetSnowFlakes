namespace ImGuiAnimations.Animations.SnowFlake;

public static class RandomNumberGenerator
{
    private static readonly Random Random = new();

    public static float RandomFloat(float a, float b)
    {
        var randomValue = Random.NextDouble();
        var diff = b - a;
        var r = (float)randomValue * diff;
        return a + r;
    }
}