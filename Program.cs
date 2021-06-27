using System;

namespace räkna_växel
{
    /* Räkna växel
 * För att räkna växel behöver vi ett program där vi kan mata in hur mycket någonting kostar och hur mycket som betalas.
 * Därefter behöver programmet räkna ut skillnaden och avrunda detta till närmsta 50 öre.
 * 
 * För att vara praktiskt så börjar vi med att vi knappar in vad det kostar, sedan hur mycket vi betalar, varpå skillnaden matas ut av programmet.
 * 
 */
    // class == någonting som håller properties eller metoder, sp ví kan skapa nya typer av variabler
    // Här skapar vi alltså en ny class som är edvinsVäxelRäknare
    class Program
    {
        //static == vi behöver inte initiera classen den tillhör för att komma åt innehållet
        //void == ingenting returneras

        static void Main(string[] args) 
        {
            EdvinsVäxelRäknare.StartaKassan();

        }
    }
}



