using System;
using System.Collections.Generic;

namespace DriverLicense 
{
    //Create ApplicaionAnswers class
    public class ApplicationAnswers
    {
            //Create values that will be used along with the program
            //"correct" will be used to store the number of correct answers
            public int correct {get; set;} = 0;
            //"wrong" will be used to store the number of wrong answers
            public int wrong {get; set;} = 0;
            //All of the "answerStudnt 1-20" will be used to store the value of each answer entered by the user
            public string answerStudent {get; set;}
            public string answerStudent2 {get; set;}
            public string answerStudent3 {get; set;}
            public string answerStudent4 {get; set;}
            public string answerStudent5 {get; set;}
            public string answerStudent6 {get; set;}
            public string answerStudent7 {get; set;}
            public string answerStudent8 {get; set;}
            public string answerStudent9 {get; set;}
            public string answerStudent10 {get; set;}
            public string answerStudent11 {get; set;}
            public string answerStudent12 {get; set;}
            public string answerStudent13 {get; set;}
            public string answerStudent14 {get; set;}
            public string answerStudent15 {get; set;}
            public string answerStudent16 {get; set;}
            public string answerStudent17 {get; set;}
            public string answerStudent18 {get; set;}
            public string answerStudent19 {get; set;}
            public string answerStudent20 {get; set;}
            //The WrongItems list will hold all of the values that were wrong
            public List<string> wrongItems = new();
            //The numberAnswers List will be used to store the value of number that corresponds to the wrong value in the WrongItems List
            public List<int> numberAnswers = new();
            //studentAnswers is an array that will hold the answers entered by the student
            public string[] studentAnswers = new string[20];
            //correctAnswers will is an array list that will hold all of the correct answers- this will be used to determine the right and wrong answers
            public string[] correctAnswers {get;set;} = {"B","D","A","A","C","A","B","A","C","D","B","C","D","A","D","C","C","B","D","A"};
            //Constructors
            public ApplicationAnswers(){}

            public ApplicationAnswers(string answers,string answer2,string answers3,string answer4, string answers5,string answer6, string answers7,string answers8,string answers9,string answer10,string answers11,string answer12,string answers13,string answer14,string answers15,string answer16,string answers17,string answer18,string answers19,string answer20)
            {
                answerStudent = answers;
                answerStudent2 = answer2;
                answerStudent3 = answers3;
                answerStudent4 = answer4;
                answerStudent5 = answers5;
                answerStudent6 = answer6;
                answerStudent7 = answers7;
                answerStudent8 = answers8;
                answerStudent9 = answers9;
                answerStudent10 = answer10;
                answerStudent11 = answers11;
                answerStudent12 = answer12;
                answerStudent13 = answers13;
                answerStudent14 = answer14;
                answerStudent15 = answers15;
                answerStudent16 = answer16;
                answerStudent17 = answers17;
                answerStudent18 = answer18;
                answerStudent19 = answers19;
                answerStudent20 = answer20;

            }
            
            //Method that will contain all of the calculations and display whether the student passed or failed
            public override string ToString()
            {  
                        //Each different value entered by the user will be saved in different parts of the array
                        studentAnswers[0] = answerStudent;
                        studentAnswers[1] = answerStudent2;
                        studentAnswers[2] = answerStudent3;
                        studentAnswers[3] = answerStudent4;
                        studentAnswers[4] = answerStudent5;
                        studentAnswers[5] = answerStudent6;
                        studentAnswers[6] = answerStudent7;
                        studentAnswers[7] = answerStudent8;
                        studentAnswers[8] = answerStudent9;
                        studentAnswers[9] = answerStudent10;
                        studentAnswers[10] = answerStudent11;
                        studentAnswers[11] = answerStudent12;
                        studentAnswers[12] = answerStudent13;
                        studentAnswers[13] = answerStudent14;
                        studentAnswers[14] = answerStudent15;
                        studentAnswers[15] = answerStudent16;
                        studentAnswers[16] = answerStudent17;
                        studentAnswers[17] = answerStudent18;
                        studentAnswers[18] = answerStudent19;
                        studentAnswers[19] = answerStudent20;
                    //These if else statements will dtermine whether an answer is right or wrong
                    //If an answer if right 1 will get added to "correct" and if it is wrong 1 will get added to "wrong"
                    if(correctAnswers[0] == "B" && studentAnswers[0] != "B")
                    {
                        wrong +=1;
                        wrongItems.Add(studentAnswers[0]);
                        numberAnswers.Add(1);
                        
                    }
                    else
                    {
                        correct +=1;
                       
                    }
                    if(correctAnswers[1] == "D" && studentAnswers[1] != "D")
                    {
                        wrong +=1;
                        wrongItems.Add(studentAnswers[1]);
                        numberAnswers.Add(2);
                        

                    }
                    else
                    {
                        correct +=1;
                        
                    }
                    if(correctAnswers[2] == "A" && studentAnswers[2] != "A")
                    {
                        wrong +=1;
                        wrongItems.Add(studentAnswers[2]);
                        numberAnswers.Add(3);
                        

                    }
                    else
                    {
                        correct +=1;
                        
                    }
                    if(correctAnswers[3] == "A" && studentAnswers[3] != "A")
                    {
                        wrong +=1;
                        wrongItems.Add(studentAnswers[3]);
                        numberAnswers.Add(4);
                        

                    }
                    else
                    {
                        correct +=1;
                        
                    }
                    if(correctAnswers[4] == "C" && studentAnswers[4] != "C")
                    {
                        wrong +=1;
                        wrongItems.Add(studentAnswers[4]);
                        numberAnswers.Add(5);
                        

                    }
                    else
                    {
                        correct +=1;
                        
                    }
                    if(correctAnswers[5] == "A" && studentAnswers[5] != "A")
                    {
                        wrong +=1;
                        wrongItems.Add(studentAnswers[5]);
                        numberAnswers.Add(6);
                       

                    }
                    else
                    {
                        correct +=1;
                      
                    }
                    if(correctAnswers[6] == "B" && studentAnswers[6] != "B")
                    {
                        wrong +=1;
                        wrongItems.Add(studentAnswers[6]);
                        numberAnswers.Add(7);
                       
                    }
                    else
                    {
                        correct +=1;
                       
                    }
                    if(correctAnswers[7] == "A" && studentAnswers[7] != "A")
                    {
                        wrong +=1;
                        wrongItems.Add(studentAnswers[7]);
                        numberAnswers.Add(8);
                       

                    }
                    else
                    {
                        correct +=1;
                       
                    }
                    if(correctAnswers[8] == "C" && studentAnswers[8] != "C")
                    {
                        wrong +=1;
                        wrongItems.Add(studentAnswers[8]);
                        numberAnswers.Add(9);
                        

                    }
                    else
                    {
                        correct +=1;
                        
                    }

                    if(correctAnswers[9] == "D" && studentAnswers[9] != "D")
                    {
                        wrong +=1;
                        wrongItems.Add(studentAnswers[9]);
                        numberAnswers.Add(10);
                       

                    }
                    else
                    {
                        correct +=1;
                        
                    }
                    if(correctAnswers[10] == "B" && studentAnswers[10] != "B")
                    {
                        wrong +=1;
                        wrongItems.Add(studentAnswers[10]);
                        numberAnswers.Add(11);
                        

                    }
                    else
                    {
                        correct +=1;
                        
                    }
                    if(correctAnswers[11] == "C" && studentAnswers[11] != "C")
                    {
                        wrong +=1;
                        wrongItems.Add(studentAnswers[11]);
                        numberAnswers.Add(12);
                        

                    }
                    else
                    {
                        correct +=1;
                        
                    }
                    if(correctAnswers[12] == "D" && studentAnswers[12] != "D")
                    {
                        wrong +=1;
                        wrongItems.Add(studentAnswers[12]);
                        numberAnswers.Add(13);
                       

                    }
                    else
                    {
                        correct +=1;
                        
                    }
                    if(correctAnswers[13] == "A" && studentAnswers[13] != "A")
                    {
                        wrong +=1;
                        wrongItems.Add(studentAnswers[13]);
                        numberAnswers.Add(14);
                        

                    }
                    else
                    {
                        correct +=1;
                        
                    }
                    if(correctAnswers[14] == "D" && studentAnswers[14] != "D")
                    {
                        wrong +=1;
                        wrongItems.Add(studentAnswers[14]);
                        numberAnswers.Add(15);
                       

                    }
                    else
                    {
                        correct +=1;
                        
                    }
                    if(correctAnswers[15] == "C" && studentAnswers[15] != "C")
                    {
                        wrong +=1;
                        wrongItems.Add(studentAnswers[15]);
                        numberAnswers.Add(16);
                        

                    }
                    else
                    {
                        correct +=1;
                        
                    }
                    if(correctAnswers[16] == "C" && studentAnswers[16] != "C")
                    {
                        wrong +=1;
                        wrongItems.Add(studentAnswers[16]);
                        numberAnswers.Add(17);
                        

                    }
                    else
                    {
                        correct +=1;
                        
                    }
                    if(correctAnswers[17] == "B" && studentAnswers[17] != "B")
                    {
                        wrong +=1;
                        wrongItems.Add(studentAnswers[17]);
                        numberAnswers.Add(18);
                        

                    }
                    else
                    {
                        correct +=1;
                        
                    }
                    if(correctAnswers[18] == "D" && studentAnswers[18] != "D")
                    {
                        wrong +=1;
                        wrongItems.Add(studentAnswers[18]);
                        numberAnswers.Add(19);
                        

                    }
                    else
                    {
                        correct +=1;
                        
                    }
                    if(correctAnswers[19] == "A" && studentAnswers[19] != "A")
                    {
                        wrong +=1;
                        wrongItems.Add(studentAnswers[19]);
                        numberAnswers.Add(20);
                        

                    }
                    else
                    {
                        correct +=1;
                    
                    } 

                //This if else statement will display whether the student passed or failed
                //15 correct answers are required to pass     
                if (correct >= 15)
                {
                    Console.WriteLine("The student has passed.");
                    
                }
                else
                {
                    Console.WriteLine("The student has failed.");
                    

                }
                //The list of wrong answers will be displayed using a for loop to get all
                //of the wrong answers from the list
                Console.WriteLine("\nList of Wrong answers:");

                for (int index2 = 0; index2 < wrong; index2++)
                {
                    Console.WriteLine("{0}. {1}\n",numberAnswers[index2],wrongItems[index2]);

                }
                //The number of right and wrong answers will be displayed
                return $"Number of wrong answers: {wrong}\nNumber of correct answers: {correct}\n";

                
                
            }
            

    }

}
