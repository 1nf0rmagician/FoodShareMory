using System;

namespace MyApplication
{
    [Flags]
    public enum DietyRestrictions
    {
        None = 0,
        Vegetarian = 1 << 1,
        Vegan = 1 << 2,
        GlutenFree = 1 << 3,
        LactoseFree = 1 << 4
    }
}
