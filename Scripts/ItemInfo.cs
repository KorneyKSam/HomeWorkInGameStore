using UnityEngine;

[CreateAssetMenu(fileName = "ItemInfo", menuName = "Item")]
public class ItemInfo : ScriptableObject, IItemInfo
{
    [SerializeField] private int id;
    [SerializeField] private string name;
    [SerializeField] private string description;
    [SerializeField] private Sprite icon;

    public int Id => id;

    public string Name => name;

    public string Description => description;

    public Sprite Icon => icon;
}
