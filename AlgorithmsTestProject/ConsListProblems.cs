namespace AlgorithmsTestProject;

public static class ConsListProblems
{
    public static IConsList<T> InsertBefore<T>(this IConsList<T> self, 
        int index, T value)
    {
        var x = new ConsList<T>(value, self.Skip(index));
        return new ConsList<T>(, x);
    }

    public static IConsList<T> RemoveAt<T>(this IConsList<T> self, 
        int index)
    {
        throw new NotImplementedException();
    }
}