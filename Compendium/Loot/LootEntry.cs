namespace TxtsnDungeons.Compendium.Loot;
public class LootEntry
{
    public Item Item {get;set;}
    public double DropChance {get;set;}//0.0 to 1.0
    public int MinQuantity{get;set;}=1;
    public int MaxQuantity{get;set;}=1;

    public LootEntry(Item item , double dropChance, int minQuantity,int maxQuantity)
    {
        Item= item;
        DropChance= dropChance;
        MinQuantity= minQuantity;
        MaxQuantity= maxQuantity;
    }
 public LootEntry goldEntry = new LootEntry(gold, 1.0 ,5 ,10);
 public LootEntry swordEntry= new LootEntry(sword,0.25,0,1);
 public LootEntry shieldEntry= new LootEntry(shield,0.25,0,1);
}