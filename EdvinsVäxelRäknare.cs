using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace räkna_växel
{

    //static == vi behöver inte initiera classen den tillhör för att komma åt innehållet
    //void == ingenting returneras
       
    static class EdvinsVäxelRäknare
    {
        
            
        //static void startaKassan definierar en metod, som heter startaKassan, som kan kallas på när som helst och som inte returnerar någonting
        public static void StartaKassan()
                                                       {

            bool påAv = true;
           
            //do är en del av do/while loopen och vi kommer loopa koden inom kamelerna "while" vårt värde i "while" raden uppfylls          
           do

            {
                // vi frågar om vi har en ny kund
               Console.WriteLine("Ny kund? Tryck enter.\n Om inte, tryck n, enter, 1, enter, 1, enter");
               
                //vi läser svaret, om svaret är någonting annat än n så har vi ny kund och vi räknar växel, om svaret är n har vi ingen ny kund och programmet avslutas efter ett par entertryck (senare kodrader)
            String köraKassa = Convert.ToString(Console.ReadLine());

                if (köraKassa == "n")

                {
                    påAv = false;
                }

                else
                {
                    påAv = true;
                }
                
                //cv == console.writeline() snabbt                
                Console.WriteLine("Enter cost");

                //double == definerar att kommande string är numerisk och kan innehålla decimaler, denna typ heter kostnad, = är tilldela och convert.ToDouble konverterar stringen till double, Console.Readline() hämtar string ifrån konsollen
                double kostnad = Convert.ToDouble(Console.ReadLine());


                //vi avrundar kostnaden till närmaste 50-öring, denna lösning adapterades från stackoverflow
                double avrundadKostnad = Math.Round(2 * kostnad) / 2;

        //Skriver texten i konsollen
        Console.WriteLine("Enter betalning");

            //double definierar pengarIn som en string som är numerisk och kan innehålla decimaler och tilldelar den värdet som vi läser ifrån konsollen och konverterar den till Double, vilket innebär att den är numerisk och kan innehålla decimaler
            double pengarIn = Convert.ToDouble(Console.ReadLine());

            // för att inte bli lurad av kunden måste programmet säga till om vi fått för lite pengar, därför använder vi if-satsen för att se om vi får negativ växel, om pengarIn - kostnad är under 0 så ska vi be om mer pengar
            if (pengarIn - avrundadKostnad < 0)


                Console.WriteLine("Detta belopp räcker inte");
                                    
            else
            {
                    
                    // writeline skriver ut vad vi får tillbaka, \n att vi får ny rad, {} att vi behandlar variabler i en string, pengarIn - kostnad är beräkningen
                    double pengarTillbaka = pengarIn - avrundadKostnad;
                    double tusenlapp = 1000;
                    double antalTusenlappar = Math.Floor(pengarTillbaka/tusenlapp);
                    Console.WriteLine("antal tusenlappar är " + antalTusenlappar);
                    double femHundraLapp = 500;
                    double antalFemHundraLappar = Math.Floor((pengarTillbaka%1000)/femHundraLapp);
                    Console.WriteLine("antal femhundralappar är " + antalFemHundraLappar);
                    double hundraLapp = 100;
                    double antalHundraLappar = Math.Floor((pengarTillbaka % 500) / hundraLapp);
                    Console.WriteLine("antal hundralappar är " + antalHundraLappar);
                    double femtioLapp = 50;
                    double antalFemtioLappar = Math.Floor((pengarTillbaka % 100) / femtioLapp);
                    Console.WriteLine("antal femtiolappar är " + antalFemtioLappar);
                    double tjugoLapp = 20;
                    double antalTjugoLappar = Math.Floor((pengarTillbaka % 50) / tjugoLapp);
                    Console.WriteLine("antal tjugolappar är " + antalTjugoLappar);
                    double tior = 10;
                    double antalTior = Math.Floor((pengarTillbaka % 20) / tior);
                    Console.WriteLine("antal tior är " + antalTior);
                    double femmor = 5;
                    double antalFemmor = Math.Floor((pengarTillbaka % 10) / femmor);
                    Console.WriteLine("antal femmor är " + antalFemmor);
                    double enKronor = 1;
                    double antalEnKronor = Math.Floor((pengarTillbaka % 5) / enKronor);
                    Console.WriteLine("antal enkronor är " + antalEnKronor);
                    double femtioÖringar = 0.5;
                    double antalFemtioÖringar = Math.Floor(pengarTillbaka % 1/femtioÖringar);
                    Console.WriteLine("antal femtioöringar är " + antalFemtioÖringar);
                }



            }
   //while loopen sluts här, om vi skriver n + enter + 1, enter + 1, enter så stängs programmet av.    
           while (påAv);
            

        }


    }

}
