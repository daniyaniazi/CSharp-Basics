using System;

namespace Delegates
{
    public delegate void rectDel(double width, double height);
   // MultiClassDelegates
    class Rectangle
    {
        // both the method have same sognature i,e : return type  and params list
        public void getArea(double width , double height)
        {
            Console.WriteLine(width * height);

        }
        public void getPerimeter(double width, double height)
        {
            Console.WriteLine(2 *(width +height));

        }
        static void Main()
        {
            Rectangle rect1 = new Rectangle();
            rectDel reddel1 = new rectDel(rect1.getArea);
            reddel1 += rect1.getPerimeter;
            reddel1.Invoke(12, 33);
            //rect1.getArea(12.34, 57.88);
            //rect1.getPerimeter(12.34, 57.88);
            Console.ReadLine();
        }
    }
}
