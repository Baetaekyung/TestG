[System.Flags]
public enum SingletonFlags
{
    None = 0,
    NoAutoInstance = 1,
    DontDestroy = 1 << 1,
    AllowMultiple = 1 << 2 //unused
}