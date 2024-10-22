// See https://aka.ms/new-console-template for more information
{
string again = "a";
        
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("***** Trojúhelník *****");
            Console.WriteLine("****************************");
            Console.WriteLine("******* Filip Skalický ********");
            Console.WriteLine("****************************");
            Console.WriteLine();
             
            Console.Write("Zadejte výšku trojúhelníku (celé číslo): ");
            int height = int.Parse(Console.ReadLine());
            // for(int i=1; i <= 10 ; i++) {
            //     Console.WriteLine(i);
            // }
            // int j = 1;
            // while(j <= 10) {
            //     Console.WriteLine(j);
            //     j++;
            // }
            for(int i = 1; i<= height; i++) 
                 {
                    Console.WriteLine(new string ( '*', i));
                    
                    // zpoždění
                    
                }
                
            
            
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();
            }
}