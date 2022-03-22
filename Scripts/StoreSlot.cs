using System;

public class StoreSlot : IStoreSlot
{
    public bool IsEmpty => Item == null;
    public IStoreItem Item { get; set; }
    public Type ItemType => Item.Type;

    public void Clear()
    {
        if (IsEmpty)
        {
            return;
        }
        Item = null;
    }
}
