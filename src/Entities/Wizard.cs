namespace src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType)
        {
            this.Name = name;
            this.level = level;
            this.heroType = heroType;
        }
        public override string Attack()
        {
            return this.Name + " "+ "Lançou magia";
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