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
            

            // other sizes: r2-(2,3), r-3(3,3),r-4(4,3),r-5(5,3)
          
            #endregion

            #region Add to List
            //Add rectangles to the list
           
            #endregion

            #region loop through list
            //loop through the list using count and the [] operator

            Console.WriteLine("loop through the list using count and the [] operator");
           

            Console.WriteLine("Loop through the list using foreach");
            //Loop through the list using foreaach
         
                #endregion


                #region Delete from list
                //Delete from a list Remove And RemoveAt
               
                Console.WriteLine("after delete r5 and index 0");
             
                #endregion

                #region Update  a list

                //Update an object in a list
             
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

            }
            #endregion
        }
    }
}