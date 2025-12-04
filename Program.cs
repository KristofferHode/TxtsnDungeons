using System.IO.Pipelines;
using System.Net.Quic;
using System.Security.Cryptography.X509Certificates;
using DungeonRoom;
namespace TxtsnDungeons;

class Program
{
    static void Main(string[] args)
    {   Console.WriteLine("=== Adventure awaits thee traveler ===");
        
        var map = new DungeonMap.DungeonMap();
        var CurrentRoom = map.StartRoom;

        while (true)
        {
            Console.WriteLine ($"You are in {CurrentRoom.RoomName}");
            Console.WriteLine(CurrentRoom.RoomDescription);

            Console.WriteLine("Where do you want to go?");
            string inputDirection = Console.ReadLine()?.ToLower()??"";
            
             DungeonRoom.DungeonRoom? nextRoom =inputDirection switch
            {
                "north"=>CurrentRoom.North,
                "south"=>CurrentRoom.South,
                "west"=>CurrentRoom.West,
                "east"=>CurrentRoom.East,
                _=>null
            };
            
            if (nextRoom == null)
            {
                Console.WriteLine("You cant go that way");
            }
            else
            {
                CurrentRoom =nextRoom;
            }  
        }
    }
}
