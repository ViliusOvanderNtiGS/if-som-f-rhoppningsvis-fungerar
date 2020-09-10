using System;

namespace if_förfan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vem är du?");

            string name = Console.ReadLine();
            string response;


            if (name == "John")
            {
                Console.WriteLine("Hejsan John");
            }
            else
            {
                Console.WriteLine("Jag brydde mig igentligen inte om ditt namn.");
            }

            Intro();
            response = Console.ReadLine();

            if (response == "Ja" || response == "ja")
            {
                Console.WriteLine("Ok kom nu in.");
                Yes1();
                response = Console.ReadLine();
                if (response == "Cheesburgare" || response == "cheesburgare")
                {
                    Cheesburgare();
                }
                else if (response == "Fritterat smör" || response == "fritterat smör")
                {
                    smor();
                }
                else if (response == "Gå ut" || response == "gå ut")
                {
                    Console.WriteLine("Du går ut och dör av kylan");
                }
                else if (response == "Revolver" || response == "revolver")
                {
                    Draw();
                    response = Console.ReadLine();
                    if (response == "Draw 1" || response == "draw 1" || response == "Draw 2" || response == "draw 2" || response == "Draw 3" || response == "draw 3" || response == "Draw 5" || response == "draw 5")
                    {
                        DieBullet();
                    }
                    else if (response == "Draw 4" || response == "draw 4")
                    {
                        DieGubbe();
                        response = Console.ReadLine();
                        if (response == "Utforska" || response == "utforska")
                        {
                            Utforska();
                        }
                        else if (response == "Gå ut" || response == "gå ut")
                        {
                            Gaut2();
                        }
                    }
                }






            }
            else if (response == "Nej" || response == "nej")
            {
                Console.WriteLine("Nej uch vad dum och ful du är hejdå gå tillbaka till dum och ful fabriken, säger nissen.");
                Console.WriteLine("Du dör i kylan för du är dum och ful");
            }
            Console.ReadLine();





            Console.ReadLine();

        }

        static void Intro()
        {
            Console.WriteLine("Det är vinter i 1899 amerika och du har vandrat ut i snön och hittar ett hus.");
            Console.WriteLine("Du ser kall ut, vill du in och ha en Cheesburgare? säger en röst från någon från huset");
            Console.WriteLine("Ja/Nej");
        }

        static void Yes1()
        {
            Console.WriteLine("Du går in i huset ser en tallrik med fritterat smör och en tallrik med en cheesburgare");
            Console.WriteLine("Du ser ochså en gubbe som säger:");
            Console.WriteLine("Nu så kan du äta din cheesburgare");
            Console.WriteLine("(Cheesburgare/Fritterat smör/Revolver/Gå ut)");
        }
        static void Cheesburgare()
        {
            Console.WriteLine("Du sätter dig ner och börjar äta på Cheesburgaren");
            Console.WriteLine("Den var god. Du ber om en till.");
            Console.WriteLine("Du äter up den också och nu vill du ha en till");
            Console.WriteLine("Du börjar käna dig sömnig, du känner du en smäll i ditt huvud");
            Console.WriteLine("Gubben tog alla dina ägodelare och slängde ut dig i kylan");
            Console.WriteLine("Du blev rånad och dog");
        }
        static void smor()
        {
            Console.WriteLine("Du sätter handen på hjärtat och säger");
            Console.WriteLine("Nöh");
            Console.WriteLine("Du får en hjärt-attack och dör direkt");
        }
        static void Draw()
        {
            Console.WriteLine("Du drar fram din revolver");
            Console.WriteLine("Gubben gör samma sak och ni hamnar i en cooling mexican stand off");
            Console.WriteLine("(Draw 1/Draw 2/Draw 3/Draw 4/Draw 5)");

        }
        static void DieBullet()
        {
            Console.WriteLine("Gubben var snabbare än dig och sköt dig");
            Console.WriteLine("Nu ligger du död på golvet");
        }

        static void DieGubbe()
        {
            Console.WriteLine("Du skjuter gubben snabbt och du vann stand off saken");
            Console.WriteLine("Men Gubben skjöt din fina tröja");
            Console.WriteLine("Gubben är död dock så det är lungt");
            Console.WriteLine("(Utforska/Gå ut)");

        }
        static void Utforska()
        {
            Console.WriteLine("Du kollar runt och ser att en tavla är lite knasig");
            Console.WriteLine("du tittar bakom den och ser en satans mycket pengar");
            Console.WriteLine("du ser också en tröja som inte har hål i sig");
            Console.WriteLine("du tar allt");
            Console.WriteLine("Du går ut rikare än tidigare");
        }
        static void Gaut2()
        {
            Console.WriteLine("Du går ut i kylan, med hål i tröjan och fattig");
            Console.WriteLine("Du dör av kylan");
        }
    }
}
