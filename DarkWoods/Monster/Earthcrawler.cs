﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DarkWoods.Monster
{
    class Earthcrawler: Monster
    {
        public Earthcrawler(string monsterName, string monsterAtkkName, int monsterHp, int monsterMaxHp, int monsterLevel, int monsterExp, int monsterAtkDmg)
        {
            this.MonsterName = monsterName;
            this.MonsterAtkName = monsterAtkkName;
            this.MonsterHp = monsterHp;
            this.MonsterMaxHp = monsterMaxHp;
            this.MonsterLevel = monsterLevel;
            this.MonsterExp = monsterExp;
            this.MonsterAtkDmg = monsterAtkDmg;
        }

        public static Earthcrawler earthcrawler = new Earthcrawler("Earthcrawler", "Mudblast", 100, 100, 1, 100, 25);

        public override int MonsterAttack()
        {
            Console.WriteLine($"{base.MonsterName} attack you with the {base.MonsterAtkName} attack!");
            return base.MonsterAttack();
        }
    }
}
