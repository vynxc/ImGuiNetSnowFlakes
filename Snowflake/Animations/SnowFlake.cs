using System.Drawing;
using System.Numerics;
using ImGuiNET;

namespace Snowflake.Animations;

public class SnowFlake
{
    private static Vector3 gravity;
    float x, y, z;
    float minSize;
    float maxSize;
    Vector4 color;
    Vector3 position;
    Vector3 velocity;
    Vector3 accelaretion;
    float radius;
    int width;
    int height;
    int windowX;
    int windowY;
    static float Min(float a, float b)
    {
        return (((a) < (b)) ? (a) : (b));
    }
    static float Max(float a, float b)
    {
        return (((a) > (b)) ? (a) : (b));
    }
    static float Constrain(float n, float low, float high)
    {
        return Max(Min(n, high), low);
    }
    static float Map(float n, float start1, float stop1, float start2, float stop2, bool withinBounds = false)
    {
        var newVal = (n - start1) / (stop1 - start1) * (stop2 - start2) + start2;
        if (!withinBounds)
            return newVal;

        return start2 < stop2 ? Constrain(newVal, start2, stop2) : Constrain(newVal, stop2, start2);
    }
    private static readonly Random Random = new Random();

    float RandomFloat(float a, float b)
    {
        double randomValue = Random.NextDouble();
        float diff = b - a;
        float r = (float)randomValue * diff;
        return a + r;
    }
    float GetRandomSize(float min, float max)
    {
        var random = RandomFloat(0f, 1f);
        var r = Math.Pow(random, 3f);
        return Constrain((float)r * max, min, max);
    }

    public SnowFlake(float minSize,float maxSize,int windowX,int windowY,int width,int height,Vector4 color)
    {
        this.minSize = minSize;
        this.maxSize = maxSize;
        this.color = color;
        this.width = width;
        this.height = height;
        this.windowX = windowX;
        this.windowY = windowY;
        this.position = new Vector3(RandomFloat(windowX, windowX + width), RandomFloat(windowY - 100, windowY - 10),0);
        this.velocity = new Vector3(0, 0, 0);
        this.accelaretion = new Vector3(0, 0, 0);
        this.radius = GetRandomSize(minSize, maxSize);
    }
    void ApplyForce(Vector3 force)
    {
        Vector3 f = force;
        f *= radius;
        accelaretion += f;
    }
    public void Update()
    {
        velocity += accelaretion;
       //velocity.Limit(radius * 0.2f);
       position += velocity;
       accelaretion *= 0f;
       if (OffScreen())
           Randomize();
    }

    void Render()
    {
        ImGui.GetWindowDrawList().AddCircleFilled(new Vector2(position.X, position.Y), radius, ImGui.GetColorU32(color));
    }
    bool OffScreen()
    {
        return (position.Y > windowY + height + radius || position.X < windowX - radius || position.X > windowX + width + radius);
    }
    void Randomize()
    {
        position = new Vector3(RandomFloat(windowX, windowX + width), RandomFloat(windowY - 100, windowY - 10), 0);
        velocity = new Vector3(0, 0, 0);
        accelaretion = new Vector3(0, 0, 0);
        radius = GetRandomSize(minSize, maxSize);
    }

    public static void CreateSnowFlakes(ref List<SnowFlake> snowFlakes, int limit, float minSize, float maxSize, int windowX, int windowY, int width, int height,Vector3 newGravity, Vector4 color)
    {
        gravity = newGravity;
        for (int i = 0; i < limit; i++)
        {
            snowFlakes.Add(new SnowFlake(minSize, maxSize, windowX, windowY, width, height, color));
        }
    }
    
    public static void UpdateSnowFlakes(ref List<SnowFlake> snowFlakes,Vector3 mouse, Vector3 windowPos)
    {
        mouse.X -= windowPos.X;
        mouse.Y -= windowPos.Y;
        foreach (var flake in snowFlakes)
        {
            var xOff = flake.position.X / (flake.windowX + flake.width);
            var yOff = flake.position.Y / (flake.windowY + flake.height);
            var wx = Map(mouse.X - flake.windowX, 0, flake.width, -0.002f, 0.002f, true);
            var wind = new Vector3(wx + (xOff * .002f), (yOff * .002f),0);
            wind *= .5f;
            flake.ApplyForce(gravity);
            flake.ApplyForce(wind);
            flake.Update();
            flake.Render();
        }
    }
    
    public static void ChangeWindowPos(ref List<SnowFlake> snowFlakes,int windowX, int windowY)
    {
        foreach (var flake in snowFlakes)
        {
            flake.position.X += windowX - flake.windowX;
            flake.position.Y += windowY - flake.windowY;
            flake.windowX = windowX;
            flake.windowY = windowY;
        }
    }
    
}