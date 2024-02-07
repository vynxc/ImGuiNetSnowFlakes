using System.Numerics;
using ImGuiAnimations.Animations.Helpers;
using ImGuiNET;

namespace ImGuiAnimations.Animations.SnowFlake;

/// <summary>
/// Represents a snowflake.
/// </summary>
internal class Snowflake
{
    /// <summary>
    /// The minimum size value.
    /// </summary>
    private readonly float _minSize;

    /// <summary>
    /// The maximum size value.
    /// </summary>
    private readonly float _maxSize;

    /// <summary>
    /// Color value stored as a 4 component vector.
    /// </summary>
    private readonly Vector4 _color;

    /// <summary>
    /// Represents the position of an object in 3D space.
    /// </summary>
    private Vector3 _position;

    /// <summary>
    /// Represents the velocity of an object in 3D space.
    /// </summary>
    private Vector3 _velocity;

    /// <summary>
    /// Represents the acceleration value in a 3-dimensional space.
    /// </summary>
    private Vector3 _acceleration;

    /// <summary>
    /// Private variable to store the radius of a circle.
    /// </summary>
    private float _radius;

    /// <summary>
    /// Represents the width of an object or element.
    /// </summary>
    private readonly int _width;

    /// <summary>
    /// The _height variable represents the height of an object.
    /// </summary>
    /// <remarks>
    /// This variable is a private readonly integer and is used to store the height value of an object.
    /// It is declared as "readonly" to ensure that its value cannot be changed once it is set during object creation.
    /// </remarks>
    private readonly int _height;

    /// <summary>
    /// Represents the X-coordinate of a window.
    /// </summary>
    private int _windowX;

    /// <summary>
    /// The Y coordinate of the window.
    /// </summary>
    private int _windowY;

    /// code.
    private Snowflake(float minSize, float maxSize, int windowX, int windowY, int width,
        int height, Vector4 color)
    {
        _minSize = minSize;
        _maxSize = maxSize;
        _color = color;
        _width = width;
        _height = height;
        _windowX = windowX;
        _windowY = windowY;
        _position = new Vector3(RandomNumberGenerator.RandomFloat(windowX, windowX + width),
            RandomNumberGenerator.RandomFloat(windowY - 80, windowY - 10),
            0);
        _velocity = new Vector3(0, 0, 0);
        _acceleration = new Vector3(0, 0, 0);
        _radius = GetRandomSize(minSize, maxSize);
    }

    /// <summary>
    /// Generates a random size within the specified range.
    /// </summary>
    /// <param name="min">The minimum size.</param>
    /// <param name="max">The maximum size.</param>
    /// <returns>A random size within the specified range.</returns>
    private float GetRandomSize(float min, float max)
    {
        var random = RandomNumberGenerator.RandomFloat(0f, 1f);
        var r = (float)Math.Pow(random, 3f);
        return VectorCalculations.Constrain(r * max, min, max);
    }

    /// <summary>
    /// Applies a force to the object. </summary> <param name="force">
    /// The force vector to apply to the object. </param>
    /// /
    private void ApplyForce(Vector3 force)
    {
        var f = force;
        f *= _radius;
        _acceleration += f;
    }

    /// <summary>
    /// Updates the position and velocity of the object.
    /// </summary>
    private void Update()
    {
        _velocity += _acceleration;
        _velocity = Vector3.Clamp(_velocity, new Vector3(-_radius * 0.2f, -_radius * 0.2f, 0),
            new Vector3(_radius * 0.2f, _radius * 0.2f, 0));
        _position += _velocity;
        _acceleration *= 0f;

        if (OffScreen()) Randomize();
    }

    /// <summary>
    /// Checks if the current position is off-screen based on the window size and object dimensions.
    /// </summary>
    /// <returns>
    /// Returns a boolean value indicating if the current position is off-screen.
    /// </returns>
    private bool OffScreen()
    {
        var offScreen = _position.Y > _windowY + _height + _radius || _position.X < _windowX - _radius ||
                        _position.X > _windowX + _width + _radius;
        return offScreen;
    }

    /// <summary>
    /// Randomizes the position, velocity, acceleration, and radius of an object.
    /// </summary>
    private void Randomize()
    {
        _position = new Vector3(RandomNumberGenerator.RandomFloat(_windowX, _windowX + _width),
            RandomNumberGenerator.RandomFloat(_windowY - 80, _windowY - 10), 0);
        _velocity = new Vector3(0, 0, 0);
        _acceleration = new Vector3(0, 0, 0);

        _radius = GetRandomSize(_minSize, _maxSize);
    }

    /// <summary>
    /// Renders a filled circle using ImGui.
    /// </summary>
    private void Render()
    {
        ImGui.GetWindowDrawList().AddCircleFilled(
            new Vector2(_position.X, _position.Y), _radius,
            ImGui.GetColorU32(_color));
    }

    /// <summary>
    /// Adds snowflakes to the given list up to the specified limit.
    /// Each snowflake is created with a random size between the given minimum and maximum sizes.
    /// The snowflakes are positioned within the window defined by the given coordinates and dimensions.
    /// The snowflakes fall according to the new gravity vector and have the given color.
    /// </summary>
    /// <param name="snowFlakes">The list to which the snowflakes are added.</param>
    /// <param name="limit">The maximum number of snowflakes to be added.</param>
    /// <param name="minSize">The minimum size of each snowflake.</param>
    /// <param name="maxSize">The maximum size of each snowflake.</param>
    /// <param name="windowX">The X coordinate of the top-left corner of the window.</param>
    /// <param name="windowY">The Y coordinate of the top-left corner of the window.</param>
    /// <param name="width">The width of the window.</param>
    /// <param name="height">The height of the window.</param>
    /// <param name="color">The color of the snowflakes. Default is Vector4(255, 255, 255, 100)</param>
    public static void CreateSnowFlakes(List<Snowflake> snowFlakes, int limit=250, float minSize=5, float maxSize=10,
        int windowX=0, int windowY=0, int width = 1920, int height=1080,
        Vector4? color=null)
    {
        color ??= new Vector4(255, 255, 255, 100);
        for (var i = 0; i < limit; i++)
            snowFlakes.Add(new Snowflake(minSize, maxSize, windowX, windowY, width, height, color.Value));
    }


    /// <summary>
    /// Adds snowflakes to the given list up to the specified limit.
    /// Each snowflake is created with a random size between the given minimum and maximum sizes.
    /// The snowflakes are positioned within the window defined by the given coordinates and dimensions.
    /// The snowflakes fall according to the new gravity vector and have the given color.
    /// </summary>
    /// <param name="snowFlakes">The list to which the snowflakes are added.</param>
    /// <param name="limit">The maximum number of snowflakes to be added.</param>
    /// <param name="minSize">The minimum size of each snowflake.</param>
    /// <param name="maxSize">The maximum size of each snowflake.</param>
    /// <param name="windowX">The X coordinate of the top-left corner of the window.</param>
    /// <param name="windowY">The Y coordinate of the top-left corner of the window.</param>
    /// <param name="width">The width of the window.</param>
    /// <param name="height">The height of the window.</param>
    /// <param name="colors">The colors of the snowflakes. Default [new Vector4(255, 255, 255, 100)] </param>
    public static void CreateMultiColoredSnowFlakes(List<Snowflake> snowFlakes,
        List<Vector4> colors, int limit=250, float minSize=5, float maxSize=10,
        int windowX=0, int windowY=0, int width = 1920, int height=1080)
    {
        if(colors.Count == 0) colors.Add(new Vector4(255, 255, 255, 100));
        
        for (var i = 0; i < limit; i++)
            snowFlakes.Add(new Snowflake(minSize, maxSize, windowX, windowY, width, height, ListHelper.GetRandomItem(colors)));
    }
    
    /// <summary>
    /// Adds snowflakes to the given list up to the specified limit.
    /// Each snowflake is created with a random size between the given minimum and maximum sizes.
    /// The snowflakes are positioned within the window defined by the given coordinates and dimensions.
    /// The snowflakes fall according to the new gravity vector and have the given color.
    /// </summary>
    /// <param name="snowFlakes">The list to which the snowflakes are added.</param>
    /// <param name="limit">The maximum number of snowflakes to be added.</param>
    /// <param name="minSize">The minimum size of each snowflake.</param>
    /// <param name="maxSize">The maximum size of each snowflake.</param>
    /// <param name="windowX">The X coordinate of the top-left corner of the window.</param>
    /// <param name="windowY">The Y coordinate of the top-left corner of the window.</param>
    /// <param name="width">The width of the window.</param>
    /// <param name="height">The height of the window.</param>
    /// <param name="colorsCount">The count colors to randomly generate for the snowflakes. </param>
    public static void CreateMultiColoredSnowFlakes(List<Snowflake> snowFlakes,
        int colorsCount=5, int limit=250, float minSize=5, float maxSize=10,
        int windowX=0, int windowY=0, int width = 1920, int height=1080)
    {
        var colors = ColorGenerator.GenerateRandomColors(colorsCount);
        for (var i = 0; i < limit; i++)
            snowFlakes.Add(new Snowflake(minSize, maxSize, windowX, windowY, width, height, ListHelper.GetRandomItem(colors)));
    }
    
    /// Updates the positions of snowflakes based on mouse position and window position.
    /// @param snowFlakes The list of snowflakes to update.
    /// @param mouse The current position of the mouse.
    /// @param windowPos The position of the window relative to the screen.
    /// /
    public static void UpdateSnowFlakes(List<Snowflake> snowFlakes, Vector3 mouse, Vector3 windowPos, Vector3 gravity)
    {
        mouse.X -= windowPos.X;
        mouse.Y -= windowPos.Y;

        foreach (var flake in snowFlakes)
        {
            var xOff = flake._position.X / (flake._windowX + flake._width);
            var yOff = flake._position.Y / (flake._windowY + flake._height);
            var wx = VectorCalculations.Map(mouse.X - flake._windowX, 0, flake._width,
                -0.002f, 0.002f, true);
            var wind = new Vector3(wx + xOff * .002f, yOff * .002f, 0);
            wind *= .5f;

            flake.ApplyForce(gravity);
            flake.ApplyForce(wind);
            flake.Update();
            flake.Render();
        }
    }

    /// <summary>
    /// Changes the position of the snowflakes within a window.
    /// </summary>
    /// <param name="snowFlakes">A reference to the list of snowflakes.</param>
    /// <param name="windowX">The new X coordinate of the window.</param>
    /// <param name="windowY">The new Y coordinate of the window.</param>
    public static void ChangeWindowPos(ref List<Snowflake> snowFlakes, int windowX, int windowY)
    {
        foreach (var flake in snowFlakes)
        {
            flake._position.X += windowX - flake._windowX;
            flake._position.Y += windowY - flake._windowY;
            flake._windowX = windowX;
            flake._windowY = windowY;
        }
    }
}