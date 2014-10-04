// Cliff Browne - X00014810
// EAD Lab 2 - Polymorphism
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You are required to design and implement a program in C# 
 * which stores information about simple shapes. 
 * The program will be made up of several classes: */
namespace Polymorphism
{
    /* Vertex class
  1.	Implement a Vertex class which stores the x and y coordinates
        of a vertex (e.g. the endpoint of a line, the origin of a circle)
        in 2-dimensional space. 
   4.	Test the Vertex class. */
        public class Vertex
        {
           /* Implement a constructor for Vertex which accepts the 
           x and y coordinate (both are integers). */
            public int X
            {
                get;
                set;
            }

            public int Y
            {
                get;
                set;
            }
            /* 3.	Implement appropriate properties for the class. */
            public Vertex(int x, int y)
            {
                X = x;
                Y = y;
            }

            public override string ToString()
            {
                return "The coordinate for X is: " + X + " and the coordinate for Y is: " + Y + ".";
            }
        }

        /* 1.	Implement a Shape class which stores the color 
         * (e.g. red, blue etc.) of a Shape.  */
        // Enumerated type defining the color variables of the shape
        public enum ShapeColor
        {
            Red, Blue, Green
        }
        
        // abstract class Shape (2D)
        public abstract class Shape
        {
            public ShapeColor Color
            {
                get;
                set;
            }

            /* 2.	Implement a constructor to set the 
            color for the shape. */
            public Shape (ShapeColor color)
            {
                Color = Color;                
            }

            /* 3.	Implement appropriate properties for the class. */
            public override string ToString()
            {
 	            return "A " + Color + " shape";;
            }

            public abstract void Translate(Vertex amount);
        }

            /* 4.	Implement 2 methods in Shape, one to return details 
             * of the Shape (ToString() ) and one to allow a shape to 
             * be translated in 2D space (Translate(..)). 
             * The amount to be translated should be passed as a 
             * parameter to the translate method 
             * (as a reference to a Vertex object i.e. 
             * the amount the object is to be translated with respect to
             * the X and Y axes).  */
        

        /* 1.	Implement a Line class as a subclass of Shape. 
         * A line is to represented by 2 vertices (the endpoints for the
         * line). */
        public class Line : Shape
        {
            /* Implement a constructor for Line which take 5 parameters 
         * indicating the x and y coordinates of each vertex and the 
         * color of the line. */
            private Vertex v1, v2;
            
            public Line(int x1, int y1, int x2, int y2, ShapeColor sc)
                : base (sc)
            {
                this.v1 = new Vertex(x1, y1);
                this.v2 = new Vertex(x2, y2);
            }
            /* 2.	Implement appropriate properties for the class. */
            public int X1
            {
                get
                {
                    return v1.X;
                }
                set
                {
                    v1.X = value;
                }
            }

            public int Y1
            {
                get
                {
                    return v1.Y;
                }
                set
                {
                    v1.Y = value;
                }
            }

            public int X2
            {
                get
                {
                    return v2.X;
                }
                set
                {
                    v2.X = value;
                }
            }

            public int Y2
            {
                get
                {
                    return v2.Y;
                }
                set
                {
                    v2.Y = value;
                }
            }
            
            /* 3.	Override the ToString() method to display information
             * about the line. */
            public override string ToString()
            {
                return "A " + Color + " line from " + X1 + " , " + Y1 + " to " + X2 + " , " + Y2 + ".";
            }

            /* 4.	Override the Translate() method to translate the line in 
             * 2D space.  */
            public override void Translate(Vertex amount)
            {
                v1.X += amount.X;
                v2.X += amount.X;
                v1.Y += amount.Y;
                v2.Y += amount.Y;
            }

            // 5.	Test the class. 
        }

        /* 1.	Implement a Circle class as a subclass of Shape. 
         * A circle is to represented by an origin vertex and a radius. 
         * Implement a constructor for Circle which take 4 parameters 
         * indicating the x and y coordinates of the origin, the radius, 
         * and the color of the circle. */
        class Circle : Shape
        {

        }    
        // 2.	Implement appropriate properties for the class.
        
        /* 3.	Override the ToString() method to display information about the
         * circle. */ 

        /* 4.	 Override the Translate() method to translate the Circle in 2D 
         * space. */ 

        /* 5.	Define a method Area() which calculates and returns the area of 
         * the circle. */

        // 6.	Test the class. 
        

    class Program
        {
            static void Main(string[] args)
            {
            }
    }
}
