using System;
using System.Collections.Generic;

namespace gfdfgdfg
{
    class Program
    {
        static string[] menuItems;
        static string[] menuItems1;
        static int counter = 0;
        static int counter1 = 0;
        struct notes
        {
            public DateTime date;
            public string title;
            public string descriptions;

        }
        static notes[] note = new notes[6];

        //вывод информации о заметках
        static void printnote(string d, string e)
        {
            Console.Clear();
            if (d == "Назад")
                printmenu();
            else
            {
                for (int i = 0; i < note.Length; i++)
                {
                    if (note[i].title == d)
                    {
                        Console.WriteLine((note[i].date).ToString("dd.MM.yyyy"));
                        Console.WriteLine(note[i].title);
                        Console.WriteLine(note[i].descriptions);

                    }
                }
            }
            ConsoleKeyInfo key;
            key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.Enter:
                    printmenu1(e);
                    break;

            }



        }

        //меню дат
        static int printmenu()
        {
            counter = 0;


            menuItems = new string[3];
            menuItems[0] = "11.11.2022";
            menuItems[1] = "15.11.2022";
            menuItems[2] = "22.11.2022";

            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (counter == i)
                    {

                        Console.WriteLine("→" + menuItems[i]);

                    }
                    else
                        Console.WriteLine(" " + menuItems[i]);
                }

                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        printmenu1(menuItems[counter]);
                        return counter;
                    case ConsoleKey.UpArrow:
                        counter--;
                        if (counter == -1)
                            counter = menuItems.Length - 1;
                        break;
                    case ConsoleKey.DownArrow:
                        counter++;
                        if (counter == menuItems.Length)
                            counter = 0;
                        break;
                }
            }
            while (true);

        }

        //меню названий
        static int printmenu1(string d)
        {
            counter1 = 0;

            menuItems1 = new string[6];
            int k = 0;
            for (int i = 0; i < note.Length; i++)
            {
                if ((note[i].date).ToString("dd.MM.yyyy") == d)
                {

                    menuItems1[k] = note[i].title;
                    k++;
                }
            }
            menuItems1[k] = "Назад";
            k++;

            ConsoleKeyInfo key;
            do
            {
                Console.Clear();



                for (int i = 0; i < k; i++)
                {

                    if (counter1 == i)
                    {

                        Console.WriteLine("→" + menuItems1[i]);

                    }
                    else
                        Console.WriteLine(" " + menuItems1[i]);


                }

                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        printnote(menuItems1[counter1], d);
                        return counter1;
                    case ConsoleKey.UpArrow:
                        counter1--;
                        if (counter1 == -1)
                            counter1 = k - 1;
                        break;
                    case ConsoleKey.DownArrow:
                        counter1++;
                        if (counter1 == k)
                            counter1 = 0;
                        break;
                }
            }
            while (true);

        }
        static void Main(string[] args)
        {
            //int v;

            note[0].date = Convert.ToDateTime("11.11.2022");
            note[0].title = "Дела";
            note[0].descriptions = "Погулять с собакой";

            note[1].date = Convert.ToDateTime("15.11.2022");
            note[1].title = "Кот";
            note[1].descriptions = "День рождение кота";

            note[2].date = Convert.ToDateTime("15.11.2022");
            note[2].title = "Почта";
            note[2].descriptions = "Забрать посылку";

            note[3].date = Convert.ToDateTime("22.11.2022");
            note[3].title = "Лес";
            note[3].descriptions = "Прогулка с друзьями";


            note[4].date = Convert.ToDateTime("22.11.2022");
            note[4].title = "Курсовая работа";
            note[4].descriptions = "Начать делать курсовую работу";
            printmenu();
        }
    }
}