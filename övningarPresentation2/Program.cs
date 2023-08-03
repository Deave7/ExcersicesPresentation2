namespace övningarPresentation2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skriv t.ex. Övning1(); om du vill testa koden från övning 1
        }

        static void Övning1()
        {
            ushort variabel1 = 52139;
            sbyte varabel2 = -115;
            int variabel3 = 4825932;
            byte variabel4 = 97;
            short variabel5 = -10000;
        }

        static void Övning2()
        {
            //Initierar variabler, väljer datatyp efter storlek på värdet
            double variabel1 = 34.567839023;
            float variabel2 = 12.345f;
            double variabel3 = 8923.1234857;
            float variabel4 = 3456.091f;
        }

        static void Övning3()
        {
            double a = 5.3; //initierar variablen a med värdet 5.3
            double b = 6.01; //initierar variablen a med värdet 6.01
            double precision = 0.000001; //initierar variablen precision med värdet 0.000001

            bool areClose = Math.Abs(a - b) < precision; //OM variablen AreClose = 0 med mindre precision än 0.000001 blir det false. Fel som är mindre än vår precision returnerar true 

            Console.WriteLine(areClose); //Skriver ut variablen are close alltså, false eller true 
        }

        static void Övning4()
        {
            int value = 254; //intierar variablen värde och ger den värdet 254
            int toBase = 16; //initierar variablen toBase och ger den vädet 16 (hexadeciamalens längd)

            string hex = Convert.ToString(value, toBase); //intierar variablen hex och sätter värdet till:  -> Converterar heltalet 254 till dess hexdecimal genom att änvända ToString och sedan ge den metoden våra variabler value och toBase
            Console.WriteLine(hex); //Skriver ut variablen hex
        }

        static void Övning5()
        {
            int hex = 0x48; //intierar variablen hex med prefix för hexadecimal och värdet som motsvarar 72 i unicode
            char myChar = Convert.ToChar(hex); //intierar variablen myChar -> konverterar variablen hex till en char och sätter det värdet till variablen
            Console.WriteLine(myChar); //Skriver ut variablen myChar
        }

        static void Övning6()
        {
            bool isBlonde = false; //Intierar variablen isBlond och sätter värdet false eftersom jag inte är blond
        }

        static void Övning7()
        {
            string word1 = "Hej"; //intierar variablen word1 med värdet Hej
            string word2 = "Världen"; //intierar variablen word1 med värdet Världen

            object bothStrings = word1 + " " + word2; //initerar objektet bothStrings till word1 mellanslag word2

            //Det verkar som att vi inte alls behöver typecasta fast det står så i exemplet? Jag kanske har missförstått något. 
            string bothWords = bothStrings.ToString(); //eftersom jag sparade bothStrings som ett objekt så typecastar vi det till ens sträng som heter bothWords som vi också intierar


            Console.WriteLine(bothWords); //vi skriver ut värdet inuti bothWords
        }

        static void Övning8()
        {
            string example1 = "Att \"använda\" citattecken kan vara besvärligt."; //Anväder \" för att få in citattecken utan att avsluta strängen
            string example2 = @"Att ""använda"" cittatecken kan vara besvärligt."; //Använder @ för att kunna använda "" utan att avsluta strängen 

            Console.WriteLine(example1); //Skriver ut resultatet
            Console.WriteLine(example2); //Skriver ut resultatet
        }

        static void Övning9()
        {
            Console.WriteLine("   \u00A9");
            Console.WriteLine("  \u00A9\u00A9\u00A9");
            Console.WriteLine(" \u00A9\u00A9\u00A9\u00A9\u00A9");

        }

        static void Övning10()
        {
            //Initierar variabler 
            string firstName = "Gustav";
            string lastName = "Syrén";
            string dateOfBirth= "1996-07-20";
            int emplyeeID = 2750001;

            object employee1 = firstName + " " + lastName + " " + dateOfBirth + " " + emplyeeID; //Sparar variablerna i ett objekt
            Console.WriteLine(employee1); //skriver ut objektet
        }

        static void Övning11()
        {
            //initierar variabler 
            int helTal1 = 5; 
            int helTal2 = 10;

            (helTal1, helTal2) = (helTal2, helTal1); // vänstra sidan av likamedteckenet kommera att få värdena från höger sida 

            //Kollar om det över fungerat
            Console.WriteLine(helTal1); 
            Console.WriteLine(helTal2);
        }

        static void Övning12()
        {
            for (int i = 0; i < 255; i++) // kör loopen tills i < 255, lägg till +1 till i efter varje varv
            {
                char symbol = (char)i; //tvingar värdet i att skrivas som en symbol. 
                Console.WriteLine("Symbol number: {0}, symbol: {1}", i, symbol); //Skriver ut strängen, där {0} ersätts av i och {1} ersätts av symbol
            }
        }

        static void Övning13()
        {
            //Intierar en int och en double som null, då behövs "?" efter annars går det ej att sätt null 
            int? oneInt = null;
            double? oneDouble = null;

            Console.WriteLine(oneInt); //Ser att det blir helt tomt eftersom variablen är null
            Console.WriteLine(oneDouble); //Ser att det blir helt tomt eftersom variablen är null

            oneInt = 1;
            oneDouble = 1;

            Console.WriteLine(oneInt); //Här skrivs 1 ut som vanligt
            Console.WriteLine(oneDouble); //Här skrivs 1 ut som vanligt


        }

        static void Övning14()
        {
            //initierar variabler till passande typ
            string accountFirstName = "Gustav";
            string accountLastName = "Syrén";
            decimal balance = 100;
            string bankName = "Sparbanken";
            string bicCode = "ABCDEF1234";
            long creditCard1 = 0123456789123456;
            long creditCard2 = 0123456789123456;
            long creditCard3 = 0123456789123456;

            //sparar variablerna i ett objekt och skriver ut objektet
            object bankAccount = accountFirstName + " " + accountLastName + " " + bankName + " " + bicCode + " " + balance + " " + creditCard1 + " " + creditCard2 + " " + creditCard3;
            Console.WriteLine(bankAccount);
        }
    }
}