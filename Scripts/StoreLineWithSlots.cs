using System;
using System.Collections.Generic;

public class StoreLineWithSlots
{
    private List<IStoreSlot> slots;

    public StoreLineWithSlots(int capacity)
    {
        slots = new List<IStoreSlot>(capacity);
        for (int i = 0; i < capacity; i++)
        {
            slots.Add(new StoreSlot());
        }
    }

    public bool TryToAddItem(IStoreItem storeItem)
    {
        bool result = false;
        var emptySlot = slots.Find(slot => slot.IsEmpty);
        if (emptySlot != null)
        {
            emptySlot.Item = storeItem;
            result = true;
        }
        return result;
    }

    public void RemoveAllItems(Type itemType)
    {
        var slotsWithItem = GetAllSlots(itemType);
        if (slotsWithItem.Length == 0)
        {
            return;
        }
        foreach (var slot in slotsWithItem)
        {
            slot.Clear();
        }
    }

    public IStoreSlot[] GetAllSlots(Type itemType)
    {
        return slots.FindAll(slot => slot.ItemType == itemType).ToArray();
    }
}
