using System;

public interface IStore
{
    void AddItem(IStoreItem storeItem);
    void RemoveItem(Type type);
    bool HasItem(Type type, out IStoreItem storeItem);
}
