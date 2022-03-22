using System;
using System.Collections.Generic;

public class StoreWithSlots : IStore
{
    private List<StoreLineWithSlots> StoreLines { get; }
    private Index lastLine = ^1;
    private int lineCapacity;

    public StoreWithSlots(int lineCapacity)
    {
        this.lineCapacity = lineCapacity;
    }

    public bool HasItem(Type type, out IStoreItem storeItem)
    {
        throw new NotImplementedException();
    }

    public void AddItem(IStoreItem storeItem)
    {
        bool isAdded = StoreLines[lastLine].TryToAddItem(storeItem);
        if (!isAdded)
        {
            StoreLines.Add(new StoreLineWithSlots(lineCapacity));
            StoreLines[lastLine].TryToAddItem(storeItem);
        }
    }

    public void RemoveItem(Type type)
    {
        foreach (var storeLine in StoreLines)
        {
            storeLine.RemoveAllItems(type);
        }
    }
}
