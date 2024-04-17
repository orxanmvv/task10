namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotels = new Hotel();
            bool exit = false;
            do
            {
                Console.WriteLine("Menu\r\n1.Sisteme giris\r\n0.Cixis");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {

                    case 1:
                        do
                        {
                            Console.WriteLine("1.Hotel yarat");
                            Console.WriteLine("2.Butun Hotelleri gor");
                            Console.WriteLine("3.Hotel sec");
                            Console.WriteLine("0.Exit");

                            int choice = Convert.ToInt32(Console.ReadLine());

                            switch (choice)
                            {
                                case 1:
                                   Hotel hotel= Addhotel();
                                    Console.WriteLine("otel yarandi");
                                    break;
                                case 2:
                                    hotels.ShowAllHotel();

                                    break;
                                case 3:
                                    do { Console.WriteLine("1.Room yarat\r\n2.Roomlari gor\r\n3.Rezervasya et(eger hec bir otaq yoxdursa rezervasya xidmeti islemir)\r\n4.Evvelki menuya qayit.\r\n0.Exit"); 
                                    


                                        int choice2=Convert.ToInt32(Console.ReadLine());
                                        switch(choice2)
                                        {


                                            case 1:
                                                break;
                                                case 2:
                                                break;
                                                case 3:
                                                break;
                                                case 4:
                                                case 0: exit = true;
                                                break;
                                                default: exit = false;
                                                break;
                                               
                                        }
                                        
                                    }
                                    while(!exit);

                                    break;
                                case 0:
                                default:
                                    exit = true;
                                    Console.WriteLine("yanlis secim etdiniz");
                                    break;
                            }
                        } while (!exit);
                        break;
                    case 0:
                    default:
                        exit = true;
                        break;
                }
            }
            while (!exit);

            Hotel Addhotel()
            {
                Console.WriteLine("otel adini daxil edin");

                string name = Console.ReadLine();

                Hotel hotel = new Hotel(name);
                return hotel;

            }
            void Getallhotel()
            {

            }
            void gethotel()
            {
                Console.WriteLine("ad daxil edin");
                string name = Console.ReadLine();


            }

        }
    }
}
