using System;
using System.Collections;


namespace DriverLicense
{

        public class StudentAnswer
        {
            //ArrayList studentAnswers will be created
            private ArrayList studentAnswers = new();
            //"Count" will be used in the for loop of the main program
            public int Count => studentAnswers.Count;
            //used to add answers in the main program
            public ApplicationAnswers this[int position]
            {
                get => ((ApplicationAnswers)studentAnswers[position]);
                set => studentAnswers.Insert(position, value);
            }
            
            

          
            
        }


}
