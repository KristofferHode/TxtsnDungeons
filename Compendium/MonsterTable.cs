using System.Reflection;

public class Monsters
{
    // Create monsters for the dungeon 
    public string? MonsterName{get;set;}
    public string? MonsterDescription{get;set;}

    public Monsters(string name, string description)
    {
        MonsterName= name;
        MonsterDescription= description;
    }   
    public Monsters Goblin = new Monsters ("Goblin","a filthy goblin");
    public Monsters Hobgoblin = new Monsters ("Hobgoblin"," a bigger and stronger version of its meek cousin");
    public Monsters Gorger= new Monsters ("Gorger", "starved to madness, what the Gorger lacks in mass it more then makes up for with fierce voilence");
    public Monsters Ogre= new Monsters ("Ogre","Brutal and always hungry. These hulking masses of muscle and fat are a force to be reckond with.");
    
    
 }
