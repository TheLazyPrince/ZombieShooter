using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace game
{



    abstract class Enemy
    {
        int speed;
        int health;
        PictureBox enemyBox;

        public Enemy(int param_speed = 3, int param_health = 10)
        {
            Speed = param_speed;
            Health = param_health;
            EnemyBox = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.AutoSize,
            };
        }        

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public PictureBox EnemyBox
        {
            get { return enemyBox; }
            set { enemyBox = value; }
        }

        abstract public int Attack(PictureBox player, int health);
    }

    abstract class Melee : Enemy
    {
        int damage;
        public Melee(int param_speed, int param_amount, int param_damage) : base(param_speed, param_amount) 
        {
            Damage = param_damage;
        }

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        override public int Attack(PictureBox player, int health)
        {
            if (player.Bounds.IntersectsWith(this.EnemyBox.Bounds))
                health -= Damage;

            return health;
        }
    }

    abstract class Ranged : Enemy
    {
        int range;
        public Ranged(int param_speed, int param_amount, int param_range) : base(param_speed, param_amount) 
        {
            Range = param_range;
        }

        public int Range
        {
            get { return range; }
            set { range = value; }
        }

        override public int Attack(PictureBox player, int health)
        {
            Rectangle scope = this.EnemyBox.Bounds;
            scope.Width += Range;
            scope.Height += Range;
            if (player.Bounds.IntersectsWith(scope))
                health -= 1;
            return health;
        }
    }

    class Regular : Melee
    {
        public Regular() : base(3,3,1) { }
    }

    class Boss : Melee
    {
        public Boss() : base(2, 1, 3) { }
    }

    class Spitter : Ranged
    {
        public Spitter() : base(3,3,4) { }
    }
}
