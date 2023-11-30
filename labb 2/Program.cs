namespace labb_2
{
    internal class Program


    {
        static void Main(string[]args)
        {
            //int familysize = 0;
            Console.WriteLine("Hur stor familj har du?");
            int familySize = Convert.ToInt32(Console.ReadLine());

            string[] names = new string [familySize];
            double[] age = new double [familySize];
            double totalage = 0;
            double mediaage = 0;
            int menuSelector = 0;
            int Bigfamily = 0;
         
            while (menuSelector != 5) //en whileloop där variabeln menuSelector är villkoret som avgör om loopen ska fortsätta eller ej

            {
                Console.WriteLine(
                 
                    "Välj ett av alternativen: " +
                    "\n1.) Familjemedlems Namn " +
                    "\n2.) Ålder på familjemedlemerna" +
                    "\n3.) Summan av ålder på familjen" +
                    "\n4.) Medelålder på familjen" +
                    "\n5.) Avsluta" +
                    "\n------------------------------------------------"
                    );

              
               
                menuSelector = int.Parse(Console.ReadLine());
                
                switch (menuSelector)


                {
                    case 1:

                        if (Bigfamily < familySize)
                        {
                            Console.WriteLine("Familjemedlems Namn");
                            names[Bigfamily] = Console.ReadLine();
                          
                            Console.WriteLine("Ålder på familjemedlemerna");
                            age[Bigfamily] = double.Parse(Console.ReadLine());
                            Bigfamily++;
                        }
                        else
                       
                        {
                            Console.Clear();
                            Console.WriteLine("tyvärr det fullt");
                        }
                         break;
               
                    case 2:

                        if (Bigfamily == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Namnge nån familjmedlem genom att välja altnativ 1 \n");
                        }
                         else

                        {
                            Console.Clear();

                            for (int i = 0; i < Bigfamily; i++)
                            {
                                Console.WriteLine(names[i] + " är " + age[i]);
                            }
                        }
                        break;

                    case 3:

                        totalage = 0;

                        for (int i = 0; i < Bigfamily; i++)

                        {
                            totalage += age[i];
                        }
                        Console.WriteLine(totalage.ToString("0.00"));     
                        break;

                    case 4:
                        mediaage = 0; 

                        for(int i = 0; i < Bigfamily; i++)

                        {
                            mediaage += age[i];
                        }
                        mediaage = mediaage / Bigfamily;
                        Console.WriteLine(mediaage.ToString("0.00"));
                        break;

                    case 5:
                        Console.WriteLine("Tack för att du har varit här.");
                        break;

                    default: //här ser ni default-case i switch-satsen som är det case som körs ifall inget annat case körs.
                        Console.WriteLine("Felaktig indata, du behöver ange ett nummer mellan 1 - 5\n");
                        break;


                }


            }
        }
    }
}