namespace DungeonRoom
{
    //Create Rooms in the dungeon to explore
    public class DungeonRoom
    {
        public string? RoomName {get; set;}
        public string? RoomDescription{get; set;}
        public string? RoomOccupant {get; set;}
        public int RoomExit{get; set;}
        //Directions to other rooms
        public DungeonRoom? North {get;set;}
        public DungeonRoom? South {get;set;}
        public DungeonRoom? West {get;set;}
        public DungeonRoom? East {get;set;}



        public DungeonRoom(string name, string description, string occupant, int exit)
        {   //Sets parameter for DungeonRoom content
            RoomName= name;
            RoomDescription= description;
            RoomOccupant= occupant;
            RoomExit= exit; 
         }
         
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {RoomName}, Discription: {RoomDescription}, Occupant: {RoomOccupant},Exit:{RoomExit}");
        }


    }
}
