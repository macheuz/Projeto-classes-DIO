using System;
using static System.Console;
using src.Entities;

class projetoDio{

    static void Main(){

        Knight arus= new Knight("Arus", 23, "Knight");
        Wizard jennica = new Wizard("Jennica", 23, "White Wizard");
        Villain devil = new Villain("Devil", 65, "Maleficus");
        WriteLine("Insira o bônus de ataque do seu heroi: ");
        int BonusL = Convert.ToInt32(ReadLine());
        WriteLine(arus.Attack(BonusL));
        WriteLine("Insira o bônus de ataque do seu mago: ");
        BonusL = Convert.ToInt32(ReadLine());
        WriteLine(jennica.Attack(BonusL));
        WriteLine("Insira o bônus de ataque do seu vilão: ");
        BonusL = Convert.ToInt32(ReadLine());
        WriteLine(devil.Attack(BonusL));

    }


}