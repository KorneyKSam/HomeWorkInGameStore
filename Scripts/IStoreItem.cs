using System;

public interface IStoreItem
{
    IItemInfo Info { get; }
    IItemState State { get; }
    Type Type { get; }
}
