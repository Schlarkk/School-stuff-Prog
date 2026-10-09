using System;
using System.Collections.Generic;

class Speler
{
    public string Naam;
    public int HP;
    public int Score;

    public void Vertel()
    {
        Console.WriteLine("Ik ben " + Naam + ", mijn HP is " + HP + " en mijn score is " + Score + ".");
    }
}

class PROGles1
{
    static void Main(string[] args)
    {
        Opdracht("1.1"); Opdracht1_1();
        Opdracht("1.2"); Opdracht1_2();
        Opdracht("1.3"); Opdracht1_3();
        Opdracht("1.4"); Opdracht1_4();
        Opdracht("1.5"); Opdracht1_5();
        Opdracht("1.6"); Opdracht1_6();
        Opdracht("1.7"); Opdracht1_7();
        Opdracht("1.8"); Opdracht1_8();
        Opdracht("1.9"); Opdracht1_9();
        Opdracht("1.10"); Opdracht1_10();
        Opdracht("1.11"); Opdracht1_11();
    }

    static void Opdracht(string nummer)
    {
        Console.WriteLine();
        Console.WriteLine("--- Opdracht " + nummer + " ---");
    }

    // 1.1 Variabelen: Spelersnaam en Score
    static void Opdracht1_1()
    {
        string naam = "Erwin";
        int score = 1000;
        bool leeft = true;

        Console.WriteLine("Naam : " + naam);
        Console.WriteLine("Score : " + score);
        Console.WriteLine("Alive : " + leeft);
    }

    // 1.2 Variabelen: Berekening met HP
    static void Opdracht1_2()
    {
        int hp = 100;

        hp = hp - 35;
        Console.WriteLine("HP : " + hp);

        hp = hp - 80;
        if (hp > 0)
        {
            Console.WriteLine("Speler Leeft nog!");
        }
        else
        {
            Console.WriteLine("Speler is dood!");
        }
    }

    // 1.3 Functies: Begroeting
    static void Begroet(string naam)
    {
        Console.WriteLine("Welkom, " + naam + "!");
    }

    static void Opdracht1_3()
    {
        Begroet("Grace");
    }

    // 1.4 Functies: Max van twee getallen
    static int Max(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        return b;
    }

    static void Opdracht1_4()
    {
        Console.WriteLine("Result : " + Max(40, 25));
        Console.WriteLine("Result : " + Max(15, 60));
    }

    // 1.5 Functies: Schade berekenen
    static int BerekenSchade(int aanval, int verdediging)
    {
        int schade = aanval - verdediging;
        if (schade < 0)
        {
            schade = 0;
        }
        return schade;
    }

    static void Opdracht1_5()
    {
        Console.WriteLine("schade : " + BerekenSchade(1200, 200));
        Console.WriteLine("schade : " + BerekenSchade(50, 200)); // minimaal 0
    }

    // 1.6 Arrays: Vijanden
    static void Opdracht1_6()
    {
        string[] vijanden = { "Orc", "Knight", "Wizard", "Ogre", "Dragon" };

        for (int i = 0; i < vijanden.Length; i++)
        {
            Console.WriteLine(vijanden[i]);
        }
    }

    // 1.7 Arrays: Hoogste score
    static void Opdracht1_7()
    {
        int[] scores = { 500, 10000, 250, 7500, 3000 };
        int hoogste = scores[0];

        for (int i = 1; i < scores.Length; i++)
        {
            if (scores[i] > hoogste)
            {
                hoogste = scores[i];
            }
        }

        Console.WriteLine("highest : " + hoogste);
    }

    // 1.8 Classes: Speler
    static void Opdracht1_8()
    {
        Speler mario = new Speler();
        mario.Naam = "Mario";
        mario.HP = 10;
        mario.Score = 1000;

        Speler luigi = new Speler();
        luigi.Naam = "Luigi";
        luigi.HP = 4;
        luigi.Score = 500;

        Console.WriteLine("Speler.name : " + mario.Naam);
        Console.WriteLine("Speler.HP : " + mario.HP);
        Console.WriteLine("Speler.Score : " + mario.Score);
        Console.WriteLine();
        Console.WriteLine("Speler.name : " + luigi.Naam);
        Console.WriteLine("Speler.HP : " + luigi.HP);
        Console.WriteLine("Speler.Score : " + luigi.Score);
    }

    // 1.9 Classes: Methode toevoegen (Vertel() staat in de class Speler bovenaan)
    static void Opdracht1_9()
    {
        Speler mario = new Speler();
        mario.Naam = "Mario";
        mario.HP = 10;
        mario.Score = 1000;

        Speler luigi = new Speler();
        luigi.Naam = "Luigi";
        luigi.HP = 4;
        luigi.Score = 500;

        mario.Vertel();
        luigi.Vertel();
    }

    // 1.10 Combinatie: Array van Spelers
    static void DrukSpelersAf(Speler[] spelers)
    {
        foreach (Speler speler in spelers)
        {
            speler.Vertel();
        }
    }

    static void Opdracht1_10()
    {
        Speler[] spelers = new Speler[3];

        spelers[0] = new Speler { Naam = "Mario", HP = 10, Score = 1000 };
        spelers[1] = new Speler { Naam = "Luigi", HP = 4, Score = 500 };
        spelers[2] = new Speler { Naam = "Peach", HP = 8, Score = 800 };

        DrukSpelersAf(spelers);
    }

    // 1.11 Lists: Vijanden
    static void Opdracht1_11()
    {
        List<string> vijanden = new List<string>();

        vijanden.Add("Orc");
        vijanden.Add("Knight");
        vijanden.Add("Wizard");
        vijanden.Add("Ogre");
        vijanden.Add("Dragon");

        vijanden.Remove("Wizard");

        foreach (string vijand in vijanden)
        {
            Console.WriteLine(vijand);
        }

        Console.WriteLine("Aantal vijanden : " + vijanden.Count);
    }
}