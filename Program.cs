using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Rand
    {
        public int Run(int min, int max)
        {
            int range = (max - min) + 1;
            Random rng = new Random();
            return min + rng.Next() % range;
        }
    }
    public class Hero
    {
        public string Name;
        private int Strength;
        private int Dexterity;
        private int Intelligence;
        public Int32 HP;
        public Int32 MP;

        private void Init(int strength = 5, int dexterity = 5, int intelligence = 5)
        {
            this.Strength = strength;
            this.Dexterity = dexterity;
            this.Intelligence = intelligence;
            HP = 61 + strength;
            MP = 15 + (3 * intelligence);
        }

        public int GetStrength() { return Strength; }
        public int GetDexterity() { return Dexterity; }
        public int GetIntelligence() { return Intelligence; }

        public Hero(string name, string myclass)
        {
            Name = name;
            switch (myclass)
            {
                case "Wojownik": Init(8, 5, 2); break;
                case "Zabójca": Init(3, 9, 3); break;
                case "Czarodziej": Init(4, 2, 9); break;
                default: Init(); break;
            }
        }
    }
    public class Wrog
    {
        public string Mob;
        private int Strength2;
        private int Dexterity2;
        private int Intelligence2;
        public Int32 HP;
        public Int32 MP;
        private void Mobek(int strength2 = 5, int dexterity2 = 5, int intelligence2 = 5)
        {
            this.Strength2 = strength2;
            this.Dexterity2 = dexterity2;
            this.Intelligence2 = intelligence2;
            HP = 61 + strength2;
            MP = 15 + (3 * intelligence2);
        }
        public int GetStrength2() { return Strength2; }
        public int GetDexterity2() { return Dexterity2; }
        public int GetIntelligence2() { return Intelligence2; }

        public Wrog(string mob, string type)
        {
            Mob = mob;
            switch (type)
            {
                case "Zombie": Mobek(7, 5, 3); break;
                case "Deamon": Mobek(4, 8, 3); break;
                case "Witch": Mobek(3, 4, 8); break;
                case "Youtuber": Mobek(14, 0, 1); break;
                case "Kapral": Mobek(1, 19, 0); break;
                default: Mobek(); break;
            }
        }
        public static Double Niechcemisie(Random balans, int balance)
        {
            balans = new Random(); balance = balans.Next(3);
            return balance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w mojej grze :3\n\n1. Rozpocznij grę\n2. Wyjdź\n");
            System.ConsoleKey key = Console.ReadKey().Key;
            switch(key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    break;
            }
            Int32 maxExp = 100, Exp = 0, lvl = 1, lvlp = 1, pudzian = 3;

            Console.WriteLine("Jak nazwiesz swojego bohatera?\n");
            String przywolywacz;
            przywolywacz = Console.ReadLine();
            Console.WriteLine();
            Console.Clear();


        down:
            Console.WriteLine("Wybierz klasę postaci:\n\n1.Wojownik\n2.Zabójca\n3.Czarodziej\n");
            Int32 nrKlasy;
            nrKlasy = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();
            int dodge = 0, dodge2 = 0, xd = 1;
            string wybranaKlasa = "";

            switch (nrKlasy)
            {
                case 1: { wybranaKlasa = "Wojownik"; } break;
                case 2: { wybranaKlasa = "Zabójca"; } break;
                case 3: { wybranaKlasa = "Czarodziej"; } break;
                default: { Console.Clear(); goto down; }
            }
            string ult;
            if (wybranaKlasa == "Wojownik") ult = "Demaciańska Sprawiedliwość"; else if (wybranaKlasa == "Zabójca") ult = "Skrytobójcze Wykończenie"; else ult = "Piroklazm";
            Int32 MC = 13;

            Hero hero = new Hero(przywolywacz, wybranaKlasa);
            Console.WriteLine("Twój bohater: | " + przywolywacz + " | " + wybranaKlasa + " | Poziom " + lvl + " | Siła: {0} Zręczność: {1} Inteligencja: {2} | Mana: {3} HP: {4}", hero.GetStrength(), hero.GetDexterity(), hero.GetIntelligence(), hero.MP, hero.HP);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
            String imieWrogaEssa = "";
            String rodzajWroga = "";
            String typeczek;
            Int32 sila = hero.GetStrength(), zrecznosc = hero.GetDexterity(), inteligencja = hero.GetIntelligence();

        losowanie:
            int konkret;
           
            Random potwor = new Random();
            konkret = potwor.Next(1, 4);
            if (przywolywacz == "14") konkret = 14;
            if (lvl == pudzian) konkret = 20;

            if (konkret == 1) typeczek = "Zombie";
            else if (konkret == 2) typeczek = "Deamon";
            else if (konkret == 14) typeczek = "Leksiu";
            else if (konkret == 20) typeczek = "Pudzianson667";
            else typeczek = "Witch";

            if (typeczek == "Zombie") rodzajWroga = "Zombie";
            if (typeczek == "Deamon") rodzajWroga = "Deamon";
            if (typeczek == "Witch") rodzajWroga = "Witch";
            if (typeczek == "Leksiu") rodzajWroga = "Youtuber";
            if (typeczek == "Pudzianson667") rodzajWroga = "Kapral";

            Wrog hero2 = new Wrog(imieWrogaEssa, rodzajWroga);
            Int32 sila2, zrezcnosc2, inteligencja2;
            sila2 = hero2.GetStrength2(); zrezcnosc2 = hero2.GetDexterity2(); inteligencja2 = hero2.GetIntelligence2();

            if (lvl > 1)
            {
                sila2 += xd;  zrezcnosc2 += xd;  inteligencja2 += xd;
                if (lvl > 1) lvlp = lvl - 1;
                xd++;
            }

            string kappa;

            if (rodzajWroga == "Zombie") { imieWrogaEssa = "Sion"; kappa = "Zombie"; }
            else if (rodzajWroga == "Deamon") { imieWrogaEssa = "Nocturne"; kappa = "Demon"; }
            else if (rodzajWroga == "Youtuber") { imieWrogaEssa = "Leksiu"; kappa = "Wygnaniec xd"; }
            else if (rodzajWroga == "Kapral") { imieWrogaEssa = "Pudzianson667"; kappa = "Kapral"; }
            else { imieWrogaEssa = "Morgana"; kappa = "Wiedźma"; }

            Int32 zakl;
            Int32 fireball = inteligencja + inteligencja * 3;
            Int32 backstab = zrecznosc + zrecznosc * 3; 
            Int32 kingsblessing = sila + sila * 3;

            if (wybranaKlasa == "Wojownik")
                zakl = kingsblessing;
            else if (wybranaKlasa == "Zabójca")
                zakl = backstab;
            else
                zakl = fireball;

            Int32 zakl2;
            Int32 fireball2 = inteligencja2 + inteligencja2 * 3;
            Int32 backstab2 = zrezcnosc2 + zrezcnosc2 * 3;
            Int32 kingsblessing2 = sila2 + sila2 * 3;
            Int32 tinder = sila2 * 3;
            Int32 ukaszenie = zrezcnosc2 * 2;

            if (rodzajWroga == "Zombie")
                zakl2 = kingsblessing2;
            else if (rodzajWroga == "Deamon")
                zakl2 = backstab2;
            else if (rodzajWroga == "Youtuber")
                zakl2 = tinder;
            else if (rodzajWroga == "Kapral")
                zakl2 = ukaszenie;
            else
                zakl2 = fireball2;
        down2:
            hero2.HP = 61 + sila2;
            hero2.MP = 15 + (3 * inteligencja2);
            Console.WriteLine("Bohaterze! Znaleziono przeciwnika. Czy chesz podjąć się walki?\n\n| " + imieWrogaEssa + " | " + kappa + " | Poziom " + lvlp + " | Siła: {0} Zręczność: {1} Inteligencja: {2} | Mana: {3} HP: {4}\n", sila2, zrezcnosc2, inteligencja2, hero2.MP, hero2.HP);
            if (imieWrogaEssa == "Pudzianson667") Console.WriteLine("Pudzian: 'Tanio skóry nie sprzedam!'\n");
            Console.WriteLine("tak/nie\n");
            String d1 = Console.ReadLine();
            Console.Clear();
            if (d1 == "tak")

            {
                Console.WriteLine("Walka rozpoczęta!\n");

                hero.HP = 61 + sila;
                hero.MP = 15 + (3 * inteligencja);

                Random ktoZaczyna = new Random();
                int start = ktoZaczyna.Next(1, 3);
                if (start == 1)
                    goto zaczynasz;
                else
                    goto niezaczynasz;

                niezaczynasz:
                Console.WriteLine("Przeciwnik zaczyna\n");
                Console.ReadKey();
                Console.Clear();
            przec:
            powrot:
                Random ruch = new Random();
                int akcja = ruch.Next(1, 4);
                if (hero2.MP < MC) akcja = ruch.Next(1, 3);
                if (akcja == 1)
                {
                    Random skip = new Random(); int proc = skip.Next(1, 101);
                    if (dodge >= proc) Console.WriteLine("Przeciwnik atakuje\n\nUnikasz!\n");
                    else
                    {
                        hero.HP -= sila2 * 2;
                        Console.WriteLine("Przeciwnik atakuje zadając {0} obrażeń!\n\n" + przywolywacz + ": Ouch! Pozostałe HP: {1}\n", sila2 * 2, hero.HP);
                    }
                    dodge2 = 0;
                    Console.ReadKey();
                    Console.Clear();
                    if (hero.HP <= 0 || hero2.HP <= 0) goto dedek;
                }
                else if (akcja == 2)
                {
                    Random unik = new Random(); 
                    dodge2 = unik.Next(1, 11); 
                    dodge2 *= zrezcnosc2;
                    Console.WriteLine("Przeciwnik broni się\n\nSzansa na unik (atak): {0}% | Szansa na unik (specjalna): {1}%\n", dodge2, dodge2 / 2);
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    if (hero2.MP < MC) 
                    { 
                        Console.WriteLine("Za mało many\n"); 
                        goto powrot; 
                    }
                    Random zar = new Random(); int car = zar.Next(2);
                    if (car == 0)
                    {
                        hero2.HP = hero2.HP + hero2.HP / 5; 
                        Console.WriteLine("Przeciwnik się leczy. Obecne HP przeciwnika: {0}", hero2.HP);
                    }
                    else 
                    {
                        Random skip = new Random(); int proc = skip.Next(1, 101);
                        if (dodge / 2 >= proc) Console.WriteLine("Przeciwnik używa zaklęcia\n\nUnikasz!\n");
                        else
                        {
                            hero.HP -= zakl2;
                            hero2.MP -= MC;
                            Console.WriteLine("Przeciwnik używa umiejętności specjalnej zadając {0} obrażeń!\n\n" + przywolywacz + ": Ouch! Pozostałe HP: {1}\n\nPozostała Mana przciwnika: {2}\n", zakl2, hero.HP, hero2.MP);
                        }
                    }
                    dodge2 = 0;
                    Console.ReadKey();
                    Console.Clear();
                    if (hero.HP <= 0 || hero2.HP <= 0) goto dedek;
                }
                Console.WriteLine("Co robisz?\n");
                goto ty;

            zaczynasz:
                Console.WriteLine("Zaczynasz. Co robisz?\n");
            ty:
            powrot2:
                Console.WriteLine("1. Atak\n2. Obrona\n3. Zaklęcie\n");
                Int32 h;
                h = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (h)
                {
                    case 1:
                        Random skip = new Random(); 
                        int proc = skip.Next(1, 101);
                        if (dodge2 >= proc) 
                            Console.WriteLine("Przeciwnik unika!\n");
                        else
                        {
                            hero2.HP -= sila * 2;
                            Console.WriteLine("Atakujesz! Zadajesz {0} obrażeń\n\n" + imieWrogaEssa + ":'Ouch!' Pozostałe HP przeciwnika: {1}\n", sila * 2 ,hero2.HP);
                        }
                        dodge = 0;
                        Console.ReadKey();
                        Console.Clear();
                        if (hero.HP <= 0 || hero2.HP <= 0) 
                            goto dedek;
                        break;
                    case 2:
                        Random unik = new Random(); 
                        dodge = unik.Next(1, 11); 
                        dodge *= zrecznosc;
                        Console.WriteLine("Bronisz się\n\nSzansa na unik (atak): {0}% | Szansa na unik (specjalna): {1}%\n", dodge, dodge / 2);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        if (hero.MP < MC) 
                        { 
                            Console.WriteLine("Za mało many\n"); 
                            goto powrot2; 
                        }
                        Random skip2 = new Random(); 
                        int proc2 = skip2.Next(1, 101);
                        Console.WriteLine("Wybierz umiejętność specjalną, której chcesz użyć\n\n1. Leczenie \n2. {0}\n", ult);
                        Int32 czar = Int32.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (czar)
                        {
                            case 1:
                                hero.HP = hero.HP + hero.HP / 5;
                                Console.WriteLine("Leczysz się. Obecne HP: {0}\n", hero.HP);
                                break;
                            case 2:
                                if (dodge2 >= proc2) Console.WriteLine("Przeciwnik unika!\n");
                                else
                                {
                                    hero2.HP -= zakl;
                                    hero.MP -= MC;
                                    Console.WriteLine("Rzucasz zaklęcie {0}. Zadajesz {1} obrażeń\n\n" + imieWrogaEssa + ":'Ouch!' Pozostałe HP przeciwnika: {2}\n\nPozostała Mana: {3}\n", ult,  zakl, hero2.HP, hero.MP);
                                }
                                break;
                        }
                        dodge = 0;
                        Console.ReadKey();
                        Console.Clear();
                        if (hero.HP <= 0 || hero2.HP <= 0) goto dedek;
                        break;
                }
            dedek:
                if (hero.HP <= 0 || hero2.HP <= 0) Console.Write("Walka zakończona. ");
                if (hero.HP <= 0) { Console.WriteLine("Przegrałeś...\n"); Console.ReadKey(); Console.Clear(); goto koniec; }
                if (hero2.HP <= 0) 
                { 
                    Console.WriteLine("Wygrałeś!!!\n");
                    if (imieWrogaEssa == "Pudzianson667") { Exp=maxExp; pudzian += 5; }
                    Exp += 90; 
                    if (Exp >= maxExp)
                    {
                        lvl++;
                        Exp -= maxExp;
                        maxExp += maxExp * 2 / 3;
                        Console.WriteLine("Zdobyłeś poziom " + lvl + "!\n");
                        Console.ReadKey();
                        Console.Clear();
                    pocoxd:
                        int pkt = 3;
                        do
                        {
                            Console.WriteLine("Masz {0} punkt/y umiejętności.\n\n1. Zwiększ siłę\n2. Zwiększ zręczność\n3. Zwiększ inteligencję\n", pkt);
                            pkt--;
                            int upg = Int32.Parse(Console.ReadLine());
                            Console.Clear();
                            switch (upg)
                            {
                                case 1:
                                    sila += 1; hero.HP = 61 + sila; hero.MP = 15 + (3 * inteligencja);
                                    Console.WriteLine("Twoja siła wzrosła\nObecne statystyki:\n\n| Siła: {0} Zręczność: {1} Inteligencja: {2} | Mana: {3} HP: {4}\n", sila, zrecznosc, inteligencja, hero.MP, hero.HP);
                                    Console.ReadKey(); Console.Clear();
                                  /*  Random balans = new Random(); int balance = balans.Next(1, 4);
                                    if (balance == 1) sila2++; else if (balance == 2) zrezcnosc2++; else inteligencja2++;
                                    if (lvl > 1) lvlp = lvl - 1;*/
                                    break;
                                case 2:
                                    zrecznosc += 1; hero.HP = 61 + sila; hero.MP = 15 + (3 * inteligencja);
                                    Console.WriteLine("Twoja zręczność wzrosła\nObecne statystyki:\n\n| Siła: {0} Zręczność: {1} Inteligencja: {2} | Mana: {3} HP: {4}\n", sila, zrecznosc, inteligencja, hero.MP, hero.HP);
                                    Console.ReadKey(); Console.Clear();
                                  /*  Random balans2 = new Random(); int balance2 = balans2.Next(1, 4);
                                    if (balance2 == 1) sila2++; else if (balance2 == 2) zrezcnosc2++; else inteligencja2++;
                                    if (lvl > 1) lvlp = lvl - 1;*/
                                    break;
                                case 3:
                                    inteligencja += 1; hero.HP = 61 + sila; hero.MP = 15 + (3 * inteligencja);
                                    Console.WriteLine("Twoja inteligencja wzrosła\n\nObecne statystyki:\n\n| Siła: {0} Zręczność: {1} Inteligencja: {2} | Mana: {3} HP: {4}\n", sila, zrecznosc, inteligencja, hero.MP, hero.HP);
                                    Console.ReadKey(); Console.Clear();
                                 /*   Random balans3 = new Random(); int balance3 = balans3.Next(1, 4);
                                    if (balance3 == 1) sila2++; else if (balance3 == 2) zrezcnosc2++; else inteligencja2++;
                                    if (lvl > 1) lvlp = lvl - 1;*/
                                    break;
                                default: goto pocoxd;
                            }
                        } while (pkt > 0);
                    }
                    goto dalej;
                }
                goto przec;
            }
            else if (d1 == "nie")
            {
                Console.WriteLine("Podróżujesz dalej w poszukiwaniu następnego przeciwnika\n");
                Console.ReadKey(); Console.Clear();
                goto losowanie;
            }
            else { Console.Clear() ; goto down2; }

            dalej:
            if (d1 == "nie" || hero2.HP <= 0)
            {
                Console.WriteLine("Podróżujesz dalej w poszukiwaniu następnego przeciwnika\n");
                Console.ReadKey();
                Console.Clear();
                goto losowanie;
            }

        koniec:
            if(hero.HP <= 0) Console.WriteLine("Poniosłeś porażkę.\n\nAby spróbować swych sił ponownie, zrestartuj grę\n");
            Console.ReadKey();
        }
    }
}