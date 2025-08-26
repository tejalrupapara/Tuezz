using System;

namespace LineApplication
{
    class Line
    {
        private double length;   // Length of a line

        public Line()
        {
            length = 10;
            Console.WriteLine("Object is being created, length = {0}", length);
        }

        public void setLength(double len)
        {
            length = len;
        }

        public double getLength()
        {
            return length;
        }

        class TestLine
        {
            static void Main(string[] args)
            {
                Line line = new Line();    // Object creation (length = 10)

                // First call
                Console.WriteLine("Length of line : {0}", line.getLength());

                // Now set length to 6 (this line was missing!)
                line.setLength(6);

                // Second call
                Console.WriteLine("Length of line : {0}", line.getLength());

                Console.ReadKey();
            }
        }
    }
}