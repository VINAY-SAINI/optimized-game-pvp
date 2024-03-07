using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

namespace pvp1
{
    public enum ChoosenPlayer
    {
        UnderTaker,
        JohnCena,
        BrockLesnar

    }
    class Player
    {
        protected string _name;
        protected int _maxHealth;
        protected int _health;
        protected int _minHeal;
        protected int _maxHeal;
        protected int _minDamage;
        protected int _maxDamage;
        public Player(string name, int health, int maxHealth, int minHeal, int maxHeal, int minDamge, int maxDamage)
        {
            _name = name;
            _health = health;
            _maxHeal = maxHeal;
            _minHeal = minHeal;
            _maxDamage = maxDamage;
            _minDamage = minDamge;
            _maxHealth = maxHealth;
        }
        public string Name
        {
            get { return _name; }
        }
        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }
        public virtual void Healing()
        {
            if (this._health >= this._maxHealth)
            {
                Console.WriteLine("Health is Already maximized");
            }
            int randomHeal = new Random().Next(this._minHeal, this._maxHeal + 1);
            _health = Math.Min(_maxHealth, this._health + randomHeal);
            Console.WriteLine($"{this._name} healed. Health: {this._health}");
        }
        public virtual void Attack(Player target)
        {
            int randomDamage = new Random().Next(this._minDamage, this._maxDamage + 1);
            target._health -= randomDamage;
            Console.WriteLine($"{this._name} attacked {target._name}. Health of {target._name}: {target._health}");
            if (target._health <= 0)
            {
                Console.WriteLine($"{this._name} wins!");
            }
        }

    }
    class UnderTaker : Player
    {
        public static int DamageAvoid = 5;
        public UnderTaker() : base(name: "UnderTaker", health: 150, maxHealth: 150, minHeal: 10, maxHeal: 15, minDamge: 10, maxDamage: 20)
        {

        }
    }
    class BrockLesnar : Player
    {
        public BrockLesnar() : base(name: "BrockLesnar", health: 100, maxHealth: 100, minHeal: 15, maxHeal: 25, minDamge: 20, maxDamage: 25)
        {

        }
        public override void Attack(Player target)
        {
            int randomDamage = new Random().Next(this._minDamage, this._maxDamage + 1);
            target.Health -= randomDamage;
            Console.WriteLine($"{this._name} attacked {target.Name}. Health of {target.Name}: {target.Health}");
            if (target.Name == ChoosenPlayer.UnderTaker.ToString())
            {
                target.Health += UnderTaker.DamageAvoid;
            }

            if (target.Health <= 0)
            {
                Console.WriteLine($"{this._name} wins!");
            }
        }
    }
    class JohnCena : Player
    {
        public JohnCena() : base(name: "JohnCena", health: 70, maxHealth: 100, minHeal: 20, maxHeal: 30, minDamge: 25, maxDamage: 35)
        {

        }
        public override void Attack(Player target)
        {
            int randomDamage = new Random().Next(this._minDamage, this._maxDamage + 1);
            target.Health -= randomDamage;
            Console.WriteLine($"{this._name} attacked {target.Name}. Health of {target.Name}: {target.Health}");
            if (target.Name == ChoosenPlayer.UnderTaker.ToString())
            {
                target.Health += UnderTaker.DamageAvoid;
            }

            if (target.Health <= 0)
            {
                Console.WriteLine($"{this._name} wins!");
            }
        }
    }


}
