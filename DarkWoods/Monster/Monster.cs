using System;
using System.Collections.Generic;
using System.Text;

namespace DarkWoods.Monster
{
    abstract class Monster
    {
        private string monsterName;
        private string monsterAtkName;
        private int monsterHp;
        private int monsterMaxHp;
        private int monsterLevel;
        private int monsterExp;
        private int monsterAtkDmg;
        private int monsterGoldDrop;
        private bool monsterIsDead;

        public string MonsterName { get => monsterName; set => monsterName = value; }
        public string MonsterAtkName { get => monsterAtkName; set => monsterAtkName = value; }
        public int MonsterHp { get => monsterHp; set => monsterHp = value; }
        public int MonsterMaxHp { get => monsterMaxHp; set => monsterMaxHp = value; }
        public int MonsterLevel { get => monsterLevel; set => monsterLevel = value; }
        public int MonsterExp { get => monsterExp; set => monsterExp = value; }
        public int MonsterAtkDmg { get => monsterAtkDmg; set => monsterAtkDmg = value; }
        public int MonsterGoldDrop { get => monsterGoldDrop; set => monsterGoldDrop = value; }
        public bool MonsterIsDead { get => monsterIsDead; set => monsterIsDead = value; }


       

        Random rn = new Random();

        public virtual int MonsterAttack()
        {
            return rn.Next(monsterAtkDmg);
        }

      


    }
}
