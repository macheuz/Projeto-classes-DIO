namespace src.Entities
{
    public class Villain : Hero
    {
        public Villain(string name, int leve, string villainType)
        {
            this.Name = name;
            this.level = level;
            this.heroType = villainType;
        }
        public string Attack(int Bonus)
        {
            if (Bonus>6)
            {
                return this.Name + " "+ "Causou um forte dano de" + " "+ Bonus;
            }
            else
            {
                return this.Name + " "+"Causou um impacto de " +Bonus ;
            }
            
        }
        public override string Attack()
        {
            return this.Name + "Causou um dano no oponente ";
        }
    }
}