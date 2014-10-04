﻿// Cliff Browne - X00014810
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
            public int Coordinate
            {
                get;
                set;
            }
            /* 3.	Implement appropriate properties for the class. */
            protected Vertex(int x, int y)
            {
                this.Coordinate = x;
                this.Coordinate = y;
            }
        }

        /* 1.	Implement a Shape class which stores the color 
         * (e.g. red, blue etc.) of a Shape.  */
        class Shape
        {
            protected string Colour;
            /* 2.	Implement a constructor to set the 
            color for the shape. */
            public String Colour
            {
                get;
                set;
            }
            /* 3.	Implement appropriate properties for the class. */


            /* 4.	Implement 2 methods in Shape, one to return details 
             * of the Shape (ToString() ) and one to allow a shape to 
             * be translated in 2D space (Translate(..)). 
             * The amount to be translated should be passed as a 
             * parameter to the translate method 
             * (as a reference to a Vertex object i.e. 
             * the amount the object is to be translated with respect to
             * the X and Y axes).  */
        }

        /* 1.	Implement a Line class as a subclass of Shape. 
         * A line is to represented by 2 vertices (the endpoints for the
         * line). */
        class Line : Shape
        {
            /* Implement a constructor for Line which take 5 parameters 
         * indicating the x and y coordinates of each vertex and the 
         * color of the line. */
            public Line ()
            {

            }

            /* 2.	Implement appropriate properties for the class. */

            /* 3.	Override the ToString() method to display information
             * about the line. */

            /* 4.	Override the Translate() method to translate the line in 
             * 2D space.  */

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
