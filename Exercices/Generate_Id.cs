using System.Threading;

public static class IdGenerator
{
    private static int _lastId = 0;

    public static int GerarProximoId()
    {
        return Interlocked.Increment(ref _lastId);
    }
}
