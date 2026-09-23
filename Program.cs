using System.Drawing;

class Turtle
{
    // Current X Position of the turtle
    private int x_position;

    // Current Y Position of the turtle 
    private int y_position;

    /**
     * The turtle's "facing direction"—either right, left, up, or down. The next movement takes place in the direction specified here.
     * ***/
    private int richtung;


    // Color  of  the  trail  left  by  the  tortoise.  (Blue,  red,  yellow,  or  green)
    private Color farbe;

    // Default Constructor
    public Turtle()
    {
        x_position = 0;
        y_position = 0;
        richtung = 0;
        farbe = Color.LimeGreen;
    }

    public void zeichne()
    {
        x_position++;
    }

    public void laufe(int distance)
    {
        distance = x_position - distance;
    }

    public void springe(int x, int y)
    {
        x_position = x;
        y_position = y;
    }

   
}
