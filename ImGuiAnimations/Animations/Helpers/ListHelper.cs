namespace ImGuiAnimations.Animations.Helpers;

public static class ListHelper
{
    public static T GetRandomItem<T>(List<T> list)
    {
        Random random = new Random();
        int index = random.Next(list.Count);
        return list[index];
    }
}