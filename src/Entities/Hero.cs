namespace src.Entities
{
    public abstract class Hero
    {
        public Hero(string name, int level, string heroType)
        {
            this.Name = name;
            this.level = level;
            this.heroType = heroType;
        }
        public Hero()
        {
            
        }
        public string Name;
        public int level;
        public string heroType;
        public override string ToString()
        {
            return this.Name + " " + this.level + " "+ this.heroType;
        }
        public virtual string Attack()
        {
            return this.Name + " "+ "Atacou com sua espada";
        }
        public string Attack(int Bonus)
        {
            if (Bonus>6)
            {
                return this.Name + " "+ "Lançou magia super efetiva com bônus de" + " "+ Bonus;
            }
            else
            {
                return this.Name + " "+"Lançou uma magia com força fraca com bônus de " +Bonus ;
            }
            
        }

    }
}