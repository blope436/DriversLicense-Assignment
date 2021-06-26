using System;

using DriverLicense;
//ac will be used to store the answers
StudentAnswer ac = new();


//The students answers will get input into the ac variable
ac[0] = new ApplicationAnswers("B","D","A","B","A","A","B","B","A","B","C","D","A","B","A","C","C","B","D","A");


//For loop to read all the answers
for (int index = 0; index < ac.Count; index++)
{
  
    Console.WriteLine(ac[index]);
    
}



