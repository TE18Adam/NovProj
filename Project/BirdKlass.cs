using System;
using Raylib_cs;

namespace Project
{
    public class BirdKlass
    {
        public float yPos =+ 0.5f;
        
        public Rectangle Brect = new Rectangle();

        public BirdKlass(float PfromTop, int Pxpos, int pwidth, int pheight)
        {
            Brect.y = PfromTop;
            Brect.x = Pxpos;
            Brect.width = pwidth;
            Brect.height = pheight;
            
        }

        public void Update()
        {     
            // om man trycker ned space så påverkas yPos med värdet visat nedanför i en negativ riktning
            if( Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
            {
                yPos -= 0.5f;   
            }

           else
            {
                yPos += 0.0006f;
            } 
        }


    }
}
