using System;
using System.Threading;

namespace projektDT071G
{
    class Program
    {
        //Projekt DT071G av Alice Fagerberg

        static void Main(string[] args)
        {
            //Instans av SavedGames
            SavedGames savedgame = new SavedGames();
            while (true)
            {
                //Konsollmenyn för spelet
                Console.Clear(); Console.CursorVisible = false;
                Console.WriteLine("RÖVARSPRÅKET - Play and learn\n\n");

                Console.WriteLine("SPELA\n");
                Console.WriteLine("1.Nybörjare");
                Console.WriteLine("2.Medel");
                Console.WriteLine("3.Expert\n\n");
                Console.WriteLine("4. Quick guide\n");
                Console.WriteLine("5. Ta bort spel i spelloggen\n");
                Console.WriteLine("X. Exit\n\n");
  
                Console.WriteLine("\n\nSPELLOGGEN\n_________________________________________________________________\n");

                int i = 0;
                foreach (LangGame langgame in savedgame.getGames())
                {

                    //Skriver ut utförda spel i spelloggen
                    Console.WriteLine("[" + i++ + "] Spel:" + langgame.Level + " - Status: " + langgame.Status + "\n Titel: " + langgame.Title + " | " + langgame.Datum);
                    Console.WriteLine("_________________________________________________________________\n");

                }

                int input = (int)
                Console.ReadKey(true).Key;
                switch (input)
                {
                    case '1':
                       
                        Console.Clear(); 

                        //Välkomnande till spel Nybörjare
                        Console.WriteLine("\nVälkommen till nybörjare i rövarspråket. Du ska översätta en liten mening!\nTryck enter för att sätta igång");
                        Console.ReadLine();

                        // countdown till start av spel
                        Console.Clear(); Console.Write("\n  3"); Thread.Sleep(1000);
                        Console.Clear(); Console.Write("\n  2"); Thread.Sleep(1000);
                        Console.Clear(); Console.Write("\n  1"); Thread.Sleep(1000);

                        Console.Clear();
                        Console.CursorVisible = true;
                        //Klassinstanser
                        LangGame obj = new LangGame();

                        obj.Level = "Nybörjare";
                        string date = DateTime.Now.ToString("dd-MM-yyyy");
                        string time = DateTime.Now.ToString("HH:mm");
                        obj.Datum = date + " " + time;

                        // mening att översätta
                        Console.WriteLine("Översätt meningen:\nMitt namn är Bond, James Bond\n");
                        string myAnswer = Console.ReadLine();
                            //Kontroll om rätt mening eller inte - spara som ej avklarad vid felaktig/tom input
                            if (myAnswer != "Momitottot nonamomnon äror Bobonondod, Jojamomesos Bobonondod")
                            {
                                Console.Write("Ajsiken! det blev fel. Spelet avklarades ej och du får ingen nybörjartitel.\nGå tillbaka till huvudmenyn för att se din status för spelet eller om du vill spela igen\nTryck enter");
                                Console.ReadLine();
                                obj.Status = "Ej avklarad";
                                obj.Title = "Erhåller ingen titel";

                                savedgame.addGame(obj);
                            }
                            else//Spara som avklarad vid rätt input
                            {
                                Console.Write("Det var rätt! Du erhåller titeln nybörjare. Gå tillbaka till huvudmenyn för att se din status för spelet eller om du vill spela mer\nTryck enter");
                                Console.ReadLine();
                                obj.Status = "Avklarad";
                                obj.Title = "Erhåller titeln NYBÖRJARE";

                                savedgame.addGame(obj);
                            }
                        



                        break;

                    case '2':
                        Console.Clear();

                        //Välkomnande till spel
                        Console.WriteLine("\nVälkommen till Medel i rövarspråket. Nu blir det en lite längre mening...\nTryck enter för att sätta igång");
                        Console.ReadLine();

                        // countdown till start av spel
                        Console.Clear(); Console.Write("\n  3"); Thread.Sleep(1000);
                        Console.Clear(); Console.Write("\n  2"); Thread.Sleep(1000);
                        Console.Clear(); Console.Write("\n  1"); Thread.Sleep(1000);

                        Console.Clear();
                        Console.CursorVisible = true;

                        //Översätt meningen
                        Console.Write("Översätt meningen:\nJag är ett litet stycke dynamit maskerad som sockerbit\n");
                        string myAnswer2 = Console.ReadLine();

                        LangGame obj2 = new LangGame();

                        obj2.Level = "Medel";
                        string date2 = DateTime.Now.ToString("dd-MM-yyyy");
                        string time2 = DateTime.Now.ToString("HH:mm");
                        obj2.Datum = date2 + " " + time2;


                        if (myAnswer2 !="Jojagog äror etottot lolitotetot sostotycockoke dodynonamomitot momasoskokeroradod sosomom dodocockokerorbobitot")
                        {
                            Console.Write("Ajsiken! det blev fel. Spelet avklarades ej och du får ingen medeltitel.\nGå tillbaka till huvudmenyn för att se din status för spelet eller om du vill spela igen\nTryck enter");
                            Console.ReadLine();
                            obj2.Status = "Ej avklarad";
                            obj2.Title = "Erhåller ingen titel";

                            savedgame.addGame(obj2);
                        }
                        else
                        {
                            Console.Write("Det var rätt! Du erhåller titeln medel. Gå tillbaka till huvudmenyn för att se din status för spelet eller om du vill spela mer\n Tryck enter");
                            Console.ReadLine();
                            obj2.Status = "Avklarad";
                            obj2.Title = "Erhåller titeln MEDEL";

                            savedgame.addGame(obj2);
                        }


                        break;
                    case '3':
                        Console.Clear();

                        //Välkomnande till spel
                        Console.WriteLine("\nVälkommen till Expert i rövarspråket. Nu blir det lite hett om öronen...\nTryck enter för att sätta igång");
                        Console.ReadLine();

                        // countdown till start av spel
                        Console.Clear(); Console.Write("\n  3"); Thread.Sleep(1000);
                        Console.Clear(); Console.Write("\n  2"); Thread.Sleep(1000);
                        Console.Clear(); Console.Write("\n  1"); Thread.Sleep(1000);

                        Console.Clear();
                        Console.CursorVisible = true;

                        //Översätt meningen
                        Console.Write("Översätt meningen:\nSju sjösjuka sjömän sköttes av sju undersköna sjuksköterskor på skeppet Shang Hai\n");
                        string myAnswer3 = Console.ReadLine();

                        LangGame obj3 = new LangGame();

                        obj3.Level = "Expert";
                        string date3 = DateTime.Now.ToString("dd-MM-yyyy");
                        string time3 = DateTime.Now.ToString("HH:mm");
                        obj3.Datum = date3 + " " + time3;


                        if (myAnswer3 != "Sosjoju sosjojösosjojukoka sosjojömomänon soskokötottotesos avov sjoju unondoderorsoskokönona sosjojukoksoskokötoterorsoskokoror popå soskokepoppopetot Soshohanongog Hohai")
                        {
                            Console.Write("Ajsiken! det blev fel. Spelet avklarades ej och du får ingen experttitel.\nGå tillbaka till huvudmenyn för att se din status för spelet eller om du vill spela igen\nTryck enter");
                            Console.ReadLine();
                            obj3.Status = "Ej avklarad";
                            obj3.Title = "Erhåller ingen titel";

                            savedgame.addGame(obj3);
                        }
                        else
                        {
                            Console.Write("Det var rätt! Du erhåller titeln expert. Gå tillbaka till huvudmenyn för att se din status för spelet eller om du vill spela mer\n Tryck enter");
                            Console.ReadLine();
                            obj3.Status = "Avklarad";
                            obj3.Title = "Erhåller titeln EXPERT";

                            savedgame.addGame(obj3);
                        }


                        break;
                    case '4':
                        Console.Clear(); Console.CursorVisible = false;

                        Console.Write("QUICK GUIDE \n\n");
                        Console.Write("Hallå käre spelare! Välkommen till RÖVARSPRÅKET, där du får lära dig det gamla (och kanske inte så hederliga) rövarspråket\n");
                        Console.Write("Det finns tre nivåer där du i vardera nivå får översätta ord och meningar och testa dina rövarspråkskunskaper\n\n");
                        Console.Write("MEN HUR SER SPRÅKET UT DÅ?\n");
                        Console.Write("Jo det ska vi tala om - På alla konsonanter lägger du till ett 'o' med samma konsonant igen därefter\nEtt 'Hej' blir tex 'Hohejoj' och tar vi tex 'Banan' så blir det 'bobanonanon'");
                        Console.Write("\n\n Sådär jah, så ser spelet ut och mer övslöjas inte - Happy learning!\nTryck enter");
                        Console.ReadLine();


                        break;
                    case '5':
                        Console.CursorVisible = true;
                        Console.SetCursorPosition(0, 16);
                        Console.WriteLine("Radera ett spel utifrån index - tryck 1 och enter | Rensa hela spelloggen - tryck 2 och enter | Gå tillbaka - enter");

                        string myDelete = Console.ReadLine();
                        if(myDelete == "1") 
                        {
                            Console.SetCursorPosition(0, 17);
                            Console.Write("Ange index( [0], [1] etc..) på det spel du vill radera:");
                            string index = Console.ReadLine();
                            //Raderar spel utifrån index
                            savedgame.deleteGame(Convert.ToInt32(index));
                        }

                        if(myDelete == "2")
                        {
                            Console.SetCursorPosition(0, 17);
                            Console.WriteLine("Rensar hela spelloggen...");
                            Thread.Sleep(2000);

                            savedgame.deleteAllGames();
                        }


                        break;

                    case 88:
                        //Avslutar konsolappen
                        Environment.Exit(0);
                        break;
                }

                  

            }
        }

       
    }
}
