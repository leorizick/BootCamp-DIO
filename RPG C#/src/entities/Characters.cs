using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_C_.src.entities
{
    public abstract class Characters
    {
        public string name;
        public int level;
        public int hp;
        public int mana;
        
        public Characters(string name, int level, int hp, int mana)
        {
            this.name = name;
            this.level = level;
            this.hp = hp;
            this.mana = mana;
            
        }

        public virtual void Attack(Characters alvoPrincipal){
            
        }
    }
}