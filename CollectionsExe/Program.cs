﻿using CollectionsExe.Collections.Exercise;
using CollectionsExe.Collections.Models;

namespace CollectionsExe
{
    internal class Program
    {
        #region LIST
       
        static void Main(string[] args)
        {
            #region Define List
            //Define a list of rectangles
            List<Rectangle> rectangles = new List<Rectangle>();

            //Define 5 rectangles:
            // using empty c'tor:r1-size (2,3)
            Rectangle r1 = new Rectangle() { Length=2, Width=3};

            // other sizes: r2-(2,3), r-3(3,3),r-4(4,3),r-5(5,3)
            Rectangle r2 = new Rectangle(2, 3);
            Rectangle r3 = new Rectangle(3, 3);
            Rectangle r4 = new Rectangle(5,3);
            Rectangle r5= new Rectangle(5,3);   
          
            #endregion

            #region Add to List
            //Add rectangles to the list
            rectangles.Add(r1);
            rectangles.Add(r2);
            rectangles.Add(r3);
            rectangles.Add(r4);
            rectangles.Add(r5);
            rectangles.Add(new Rectangle(5, 6));
            #endregion

            #region loop through list
            //loop through the list using count and the [] operator

            Console.WriteLine("loop through the list using count and the [] operator");
           for(int i = 0;i< rectangles.Count; i++)
            {
                Console.WriteLine(rectangles[i]);
            }

            Console.WriteLine("Loop through the list using foreach");
            //Loop through the list using foreach
            foreach(Rectangle r in rectangles)
            {
                Console.WriteLine(r);   
            }

            #endregion


            #region Delete from list
            //Delete from a list Remove And RemoveAt
            rectangles.Remove(r3);
            rectangles.RemoveAt(3);
                Console.WriteLine("after delete r5 and index 0");

            #endregion

            #region Update  a list

            //Update an object in a list
            rectangles[0] = r5;
            rectangles[0].Length = 4;
                Console.WriteLine("after placing r5 in index 0");
                
                #endregion

                #region transforming list to array and to new list
                //Copy to array ToArray()
               
                //Copy ToList()

                Console.WriteLine("Copied list");
              //todo

                Console.WriteLine("Array");
            //todo
            #endregion
            Rectangle[] rectanglesArr= rectangles.ToArray();
            List<Rectangle> list = rectangles.ToList();
            
            #endregion
            StudentList l= new StudentList(); 
            l.Students
        }
    }
}