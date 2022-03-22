using System;

public class Potion : IStoreItem
{
    public Type Type => GetType();

    public IItemInfo Info { get; }

    public IItemState State { get; }

    public Potion(IItemInfo info)
    {
        Info = info;
        State = new ItemState();
    }
}
