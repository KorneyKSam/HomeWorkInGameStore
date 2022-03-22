using UnityEngine;

public interface IItemInfo
{
    int Id { get; }
    string Name { get; }
    string Description { get; }
    Sprite Icon { get; }
}
