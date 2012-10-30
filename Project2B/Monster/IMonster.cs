using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2B.Monster
{
    interface IMonster:IActor
    {
        string MonsterName { get; }
        int MonsterHealth { get; }
        void Search();
        void Look();
        void Fight(IActor actor);
        int AttackPower { get; }
    }
}
