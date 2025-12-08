using System.Reflection.Metadata;
using Microsoft.VisualBasic;

namespace TxtsnDungeons;
public class MonsterStats
{
    public int MonsterHP{get;set;}
    public int MonsterATK{get;set;}
    public int MonsterDEF{get;set;}

    public MonsterStats(int monsterHP, int monsterATK, int monsterDEF)
    {
        MonsterHP=monsterHP;
        MonsterATK=monsterATK;
        MonsterDEF=monsterDEF;
    }
    public static MonsterStats WeakMonster=new MonsterStats(5,4,3);
    public static MonsterStats MediumMonster=new MonsterStats(10,8,6);
    
    
}