using System;

class Turtle
{
    // Attribute hier
    private int xposition;
    private int yposition;
    private char richtung;
    private char farbe;

    // Standard Constructor
    public Turtle(int x, int y, char f)
    {
        xposition = x;
        yposition = y;
        farbe = f;

        richtung = 'r';
    }

    public void zeichne()
    {
        Console.ForegroundColor = FarbeZuConsoleColor(farbe);

        Console.SetCursorPosition(xposition, yposition);
        Console.Write("X");

        Console.ResetColor();
    }
    public void laufe(int strecke)
    {
        for (int i = 0; i < strecke; i++)
        {
            switch (richtung)
            {
                case 'r':
                    xposition++;
                    break;

                case 'l':
                    xposition--;
                    break;

                case 'o':
                    yposition--;
                    break;

                case 'u':
                    yposition++;
                    break;
            }

            zeichne();
        }
    }

    // I DON'T NEED THIS!
    //public void reset(int x, int y)
    //{
    //    xposition = x;
    //    yposition = y;
    //    richtung = 'u';
    //}
    public void springe(int x, int y)
    {
        xposition += x;
        yposition += y;
    }
    public void drehe()
    {
        switch (richtung)
        {
            case 'r':
                richtung = 'u';
                break;

            case 'u':
                richtung = 'l';
                break;

            case 'l':
                richtung = 'o';
                break;

            case 'o':
                richtung = 'r';
                break;
        }
    }

    public void anderefarbe(char f)
    {
        if (f == 'r' || f == 'b' || f == 'g' || f == 'y')
        {
            farbe = f;
        }
    }

    private ConsoleColor FarbeZuConsoleColor(char f)
    {
        switch (f)
        {
            case 'r':
                return ConsoleColor.Red;

            case 'b':
                return ConsoleColor.Blue;

            case 'g':
                return ConsoleColor.Green;

            case 'y':
                return ConsoleColor.Yellow;
            case 'f':
                return ConsoleColor.White;

            default:
                return ConsoleColor.White;
        }
    }
}

class Program
{
    static void Main()
    {

        Console.Clear();

        Turtle c = new Turtle(30, 0, 'f');

        c.laufe(10);
        c.zeichne();
        c.drehe();
        c.drehe();
        c.laufe(10);

        c.drehe();
        c.drehe();
        c.drehe();
        c.laufe(10);
        c.zeichne();

        c.drehe();
        c.drehe();
        c.drehe();
        c.laufe(10);
        c.zeichne();

        Turtle s_h_1 = new Turtle(55, 4, 'f');
        
        s_h_1.laufe(18);
        s_h_1.zeichne();

        Turtle s_h_2 = new Turtle(55, 6, 'f');

        s_h_2.laufe(18);
        s_h_2.zeichne();

        Turtle s_v_1 = new Turtle(62, 0, 'f');

        s_v_1.drehe();
        s_v_1.laufe(9);
        s_v_1.zeichne();

        Turtle s_v_2 = new Turtle(66, 0, 'f');

        s_v_2.drehe();
        s_v_2.laufe(9);
        s_v_2.zeichne();

        Console.SetCursorPosition(0,20);    
        Console.ResetColor();
    }
}
