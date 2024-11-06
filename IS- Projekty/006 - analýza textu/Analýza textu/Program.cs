string again = "a";
        
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("*******************************************");
            Console.WriteLine("***** Analýza textu *****");
            Console.WriteLine("*******************************************");
            Console.WriteLine("************* Filip Skalický *****************");
            Console.WriteLine("*******************************************");
            Console.WriteLine();

            Console.WriteLine("\nZadejte váš text:");
            string myText = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(myText);
            Console.WriteLine(myText[0]);
            Console.WriteLine(myText.Length);
            
            string samohlasky = "AÁaáEÉĚeéěIÍiíOÓoóUŮÚuůúYÝyý";
            string souhlasky = "BbCcČčDdĎďFfGgHhJjKkLlMmNnŇňPpQqRrŘřSsŠšTtŤťVvWwXxZzŽž";
            string cislice = "0123456789";
            
            int pocetSamohlasek = 0;
            int pocetSouhlasek = 0;
            int pocetCislic = 0;
            int pocetOstatnich = 0;

            foreach(char znak in myText) {
                if(samohlasky.Contains(znak)) {
                    pocetSamohlasek++;
                }
                else if(souhlasky.Contains(znak)) {
                    pocetSouhlasek++;
                }
                else if(cislice.Contains(znak)) {
                    pocetCislic++;
                }
                else
                    pocetOstatnich++;
            }

            Console.WriteLine();
            Console.WriteLine("Pocet samohlásek: {0}", pocetSamohlasek);
            Console.WriteLine("Pocet souhlásek: {0}", pocetSouhlasek);
            Console.WriteLine("Pocet číslic: {0}", pocetCislic);
            Console.WriteLine("Pocet ostatních zanků: {0}", pocetOstatnich);


Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();
        }