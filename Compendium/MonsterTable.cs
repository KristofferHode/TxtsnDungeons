using System.Reflection;

public class Monsters
{
    // Create monsters for the dungeon 
    private string? MonsterName{get;set;}
    private string? MonsterDescription{get;set;}

    public Monsters(string name, string description)
    {
        MonsterName= name;
        MonsterDescription= description;
    }   
    public Monsters Goblin = new Monsters ("Goblin","a filthy goblin");
    
 }
