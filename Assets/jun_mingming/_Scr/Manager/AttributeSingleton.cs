using System;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public sealed class AttributeSingleton : Attribute
{
    public readonly SingletonFlags Flags;

    public AttributeSingleton(SingletonFlags flag)
    {
        Flags = flag;
    }
}