using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_C_.src.entities
{
    public class Knight : Characters
    {
        public string attack;
        
        public Knight(string name, int level, int hp, int mana, string attack) : base(name, level, hp, mana)
        {
            this.attack = attack;
        }

        public override void Attack(Characters alvoPrincipal)
        {
            System.Console.WriteLine($"O personagem {this.name} atacou usando {this.attack}!");
            System.Console.WriteLine($"{alvoPrincipal.name} agora tem {alvoPrincipal.hp - this.level} de vida!");
            alvoPrincipal.hp -= this.level;
        }
    }
}