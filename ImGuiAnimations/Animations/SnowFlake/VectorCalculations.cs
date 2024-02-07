namespace ImGuiAnimations.Animations.SnowFlake;

/// <summary>
/// The VectorCalculations class provides mathematical operations for working with vectors.
/// </summary>
public static class VectorCalculations
{
    /// <summary>
    /// Constrains a value between a minimum and maximum value.
    /// </summary>
    /// <param name="n">The value to constrain.</param>
    /// <param name="low">The minimum value.</param>
    /// <param name="high">The maximum value.</param>
    /// <returns>The constrained value.</returns>
    public static float Constrain(float n, float low, float high)
    {
        return Math.Max(Math.Min(n, high), low);
    }

    /// <summary>
    /// Maps a value from one range to another range.
    /// </summary>
    /// <param name="n">The value to be mapped.</param>
    /// <param name="start1">The lower bound of the input range.</param>
    /// <param name="stop1">The upper bound of the input range.</param>
    /// <param name="start2">The lower bound of the output range.</param>
    /// <param name="stop2">The upper bound of the output range.</param>
    /// <param name="withinBounds">Indicates whether the mapped value should be constrained within the output range.</param>
    /// <returns>
    /// The mapped value.
    /// </returns>
    public static float Map(float n, float start1, float stop1, float start2, float stop2, bool withinBounds = false)
    {
        var newVal = (n - start1) / (stop1 - start1) * (stop2 - start2) + start2;
        return !withinBounds ? newVal :
            start2 < stop2 ? Constrain(newVal, start2, stop2) : Constrain(newVal, stop2, start2);
    }
}