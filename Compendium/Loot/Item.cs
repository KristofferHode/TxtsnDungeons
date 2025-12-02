using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace TxtsnDungeons.Compendium.Loot;
public class Item

{
    public string? Name{get;set;}
    public string? Description{get;set;}
    public int Value{get;set;}

    public Item (string name, string description,int value)//Utvid senere for stats, rarity, type ect
    {
        Name = name;
        Description= description;
        Value= value;

    }
}
