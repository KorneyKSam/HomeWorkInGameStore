using System;

[Serializable]
public class ItemState : IItemState
{
    public int ItemAmount;
    public bool IsItemUnlocked;

    public int Amount { get => ItemAmount; set => ItemAmount = value; }
    public bool IsUnlocked { get => IsItemUnlocked; set => IsItemUnlocked = value; }

    public ItemState()
    {
        ItemAmount = 0;
        IsItemUnlocked = false;
    }
}
