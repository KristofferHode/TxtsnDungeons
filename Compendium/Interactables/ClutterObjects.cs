using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using TxtsnDungeons.Compendium.Loot;

public class ClutterObjects
//create scatter objects to loot in rooms
{
    public string Name{get;set;}
    public string Description{get;set;}
    
    public ClutterObjects(string name, string description)
    {
        Name=name;
        Description=description;
    }
    public static ClutterObjects Crate= new ClutterObjects("Crate","a wooden crate");
    public static ClutterObjects BookShelf=new ClutterObjects("Bookshelf"," a dusty bookshelf filled with dusty books");
    public static ClutterObjects BarrelFull=new ClutterObjects("Barrel","a barrel, its filled with some sort of liquid..");
    public static ClutterObjects BarrelEmpty=new ClutterObjects("Barrel","a barrel, its empty..");

}