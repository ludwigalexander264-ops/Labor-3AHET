using System;
using System.Collections.Generic;

namespace _002_Werkzeugausgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 3;
            List<Tool> tools = new List<Tool>();
            tools.Add(new Tool());
            tools.Add(new Tool());
            tools.Add(new Tool());


            bool stayalive = true;
            tools[0].SetDescription("Hammer");
            tools[0].SetId(00001);
            tools[0].SetIsAvailable(true);

            tools[1].SetDescription("Zange");
            tools[1].SetId(00002);
            tools[1].SetIsAvailable(true);

            tools[2].SetDescription("Schraubenzieher");
            tools[2].SetId(00003);
            tools[2].SetIsAvailable(true);
            

            do
            {
                Console.WriteLine("Werkzeuge auflisten[l]");
                Console.WriteLine("Werkzeug hinzufügen[h]");
                Console.WriteLine("Werkzeug ausleihen[a]");
                Console.WriteLine("Werkzeug retournieren[r]");
                Console.WriteLine("Beenden[b]");
                char input = Console.ReadKey().KeyChar;
                switch (input)
                {
                    case 'b':
                        stayalive = false;
                        break;
                    case 'l':
                        foreach (Tool tool in tools)
                        {
                            tool.Print();
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();

                        break; 
                    case 'h':

                        Console.WriteLine("Bezeichnung:");
                        string Bezeichnung = Console.ReadLine();

                        Console.WriteLine("ID:");
                        int ID = int.Parse(Console.ReadLine());

                        tools.Add(new Tool());
                        tools[j].SetDescription(Bezeichnung);
                        tools[j].SetId(ID);
                        j++;
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();

                        break;
                    case 'a':
                        Console.WriteLine("Welche id hat das Werkzeug");
                        int GesuchteID = int.Parse(Console.ReadLine());
                        foreach (Tool tool in tools)
                        {
                            if (GesuchteID == tool.GetId())
                            {
                                tool.SetFalse();
                            }
                        }
                        Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

                        break;
                    case 'r':
                        Console.WriteLine("Welche id hat das Werkzeug");
                        int gesuchteID = int.Parse(Console.ReadLine());
                        foreach (Tool tool in tools)
                        {
                            if (gesuchteID == tool.GetId())
                            {
                                tool.SetTrue();
                            }
                        }
                        Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
                        break;
                }
            }
            while (stayalive);
            ;
        }
    }
}
