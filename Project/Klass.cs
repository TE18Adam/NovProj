using System;
using Raylib_cs;

namespace Project
{
    public class Pillar
    {
        public float speed = -0.2f;
          // bestämmer spelarens start position i y-led 
       
      
        // skapar en rektangel som sedan kan instansieras i progam.cs
        public Rectangle rect = new Rectangle();

        /* en konstruktor vilket är en klass osm körs automatiskt när en klass startas och den här konstruktorn specifierar 
        y, x, bredd, höjd värde. man parar sedan ihop rektangeln rect med tex fromtop vilket då ger rect dess y värde*/  
        public Pillar(float FromTop, int xpos, int width, int height)
        {
            rect.y = FromTop;
            rect.x = xpos;
            rect.width = width;
            rect.height = height;
        
        } 

    }
}
