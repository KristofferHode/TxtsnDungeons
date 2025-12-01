namespace TxtsnDungeons;

public class LootEntry
{
    public ItemTable Item {get;set;}
    public double DropChance {get;set;}//0.0 to 1.0
    public int MinQuantity{get;set;}=1;
    public int MaxQuantity{get;set;}=1;

    public LootEntry(ItemTable Name, double DropChance, int MinQuantity,int MaxQuantity)
    {
        Name= name;
        DropChance= dropChance;
        MinQuantity= minQuantity;
        MaxQuantity= maxQuantity;
    }
 LootEntry goldEntry = new LootEntry(gold, 1.0 ,5 ,10);   
}