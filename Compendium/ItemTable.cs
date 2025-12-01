namespace TxtsnDungeons;
public class Item
{
    public string? Name{get;set;}
    public string? Description{get;set;}
    public int Value{get;set;}

    public Item(string Name, string Description,int Value)//Utvid senere for stats, rarity, type ect
    {
        Name= name;
        Description= description;
        Value= value;
    }
    
    
}