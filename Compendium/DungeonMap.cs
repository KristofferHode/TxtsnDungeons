using System.Threading.Tasks.Dataflow;

namespace DungeonMap;

//Creates "Game board" of rooms for the player to explore 
public class DungeonMap
{
    public DungeonRoom.DungeonRoom StartRoom {get; private set;}
    public DungeonMap()
    {
        StartRoom=BuildMap();
    }
    public DungeonRoom.DungeonRoom BuildMap()
    {
        var AtTheGates =new DungeonRoom.DungeonRoom("The Gates", "The City gates","no occupants",3);
        var Courtyard= new DungeonRoom.DungeonRoom("Courtyards","The courtyard, foul stech fills the place","Corpses, source of the stench.",0);
        
        var Library=new DungeonRoom.DungeonRoom("The Library ","Old books and dusty scrolls","its empty..",2);
            var LibraryCounter=new DungeonRoom.DungeonRoom("Library counter","The librarian left in a hurry it seems..","empty..",1);
        
        var Blacksmith=new DungeonRoom.DungeonRoom("The blacksmith","The kiln still ablaze, they left in a hurry..","its empty..",3);
            var BlacksmithAnvil=new DungeonRoom.DungeonRoom("Anvil","Many a blade has been forged upon this..","none",1);
        
        var Butcher= new DungeonRoom.DungeonRoom("The butchers shop","reeks of rotting flesh, something moves in the backroom..","A hulking mass of rotting flesh, once a man now a bringer of death",1);
        
        //connectin my rooms using compass direction created in Room.cs
        AtTheGates.North= Courtyard;
        Courtyard.South= AtTheGates;
        
        Courtyard.West=Library;
            Library.North= LibraryCounter;
            LibraryCounter.South=Library;
        Library.South=Courtyard;

        Courtyard.East=Blacksmith;
            Blacksmith.North= BlacksmithAnvil;
            BlacksmithAnvil.South=Blacksmith;
        Blacksmith.South=Courtyard;

        Courtyard.North=Butcher;
        Butcher.South=Courtyard;



        return AtTheGates;
    }
}