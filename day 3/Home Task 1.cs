public static class Cache<T>
{
    public static T? _Value {get;set;}
    public static void Add(T Value)
    {
        _Value=Value;
    }
    public static T Get()
    {
        return _Value;
    }
  

}
