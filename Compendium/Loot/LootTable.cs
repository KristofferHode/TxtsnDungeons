

using System.Reflection.Metadata.Ecma335;
using TxtsnDungeons;
namespace TxtsnDungeons.Compendium.Loot;
public class LootTable
{
    private List<LootEntry>_entries;
    private Random _random=new Random();

    public LootTable(List<LootEntry> entries)
    {
        _entries = entries;
    }

    public List<Item> RollLoot()
    {
        List<Item>DroppedItems = new List<Item>();
        foreach(var entry in _entries)
        {
            if (_random.NextDouble() <= entry.DropChance)
            {
                int quantity= _random.Next(entry.MinQuantity,entry.MaxQuantity+1);
                for (int i = 0; i < quantity; i++)
                {
                    DroppedItems.Add(entry.Item);
                }
            }
        }return DroppedItems;
    }
    




}