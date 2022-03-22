using System;

public interface IStoreSlot
{
    bool IsEmpty { get; }
    IStoreItem Item { get; set; }
    Type ItemType { get; }

    void Clear();
}
