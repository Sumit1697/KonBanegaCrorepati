using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Net;
using System.Xml.Schema;

namespace KonBanegaCrorepati
{
    internal class StartKBC
    {
        public void Start(string username) {
            Console.WriteLine($"\n\n\t\t ********************** Welcome {username} lets Start the game **********************\n");
            try
            {
                int amountEarned = 0;
                int incrementedAmount = 0;
                List<string> questions = Questions.GetQuestions();
                List<string[]> options = Options.GetOptions();
                List<string> answer = CorrectAnswers.GetCorrectAnswers();
                for(int i = 0; i < questions.Count; i++)
                {
                    char optionLetters = 'A';
                    Console.WriteLine($"\n\n{i + 1}) {questions[i]}");
                    foreach (string option in options[i])
                    {
                        Console.Write($"{optionLetters}) {option} \t");
                        optionLetters++;
                    }
                    if (i > 0 && i <= 5)
                    {
                        incrementedAmount = 1000;
                    }
                    else
                    {
                        incrementedAmount = 2 * incrementedAmount;
                    }
                    int totalAmountEarned = amountEarned = incrementedAmount + amountEarned;
                    if (totalAmountEarned == 5000)
                    {
                        incrementedAmount = 5000;
                    }
                    Console.Write("\n\nPlease Choose Anyone of the Following Answers: ");
                    string selectedOption = Console.ReadLine();
                    selectedOption = selectedOption.ToUpper();
                    if (selectedOption.Equals(answer[i]))
                    {
                        Console.WriteLine("\nCorrect Answer");
                        if(i == questions.Count - 1)
                        {
                            Console.WriteLine($"Congratulations You Won the Game total amount Earned is {totalAmountEarned} Has Earned a total Amount of: ");
                        }
                    }
                    else if (string.IsNullOrEmpty(selectedOption) || selectedOption != answer[i])
                    {
                        Console.WriteLine("\nWrong Answer");
                        Console.WriteLine($"\n\n ************** {username} Has Earned a total Amount of: {totalAmountEarned} Has Earned a total Amount of: ");
                        break;
                    } else
                    {
                        Console.WriteLine($"\n\n ************** {username} Has Earned a total Amount of: {totalAmountEarned} ***********************");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  
            }
        }
    }

    internal class Questions
    {
        public static List<string> GetQuestions()
        {
            List<string> list = new List<string>();
            list.Add("The language of Lakshadweep. a Union Territory of India, is?");
            list.Add("In which group of places the Kumbha Mela is held every twelve years?");
            list.Add("The International Literacy Day is observed on?");
            list.Add("The first captain of Indian Cricket team in Test matches was?");
            list.Add("What is the highest individual score by a batsman in Test cricket?");
            //Simple Question Ends here?
            list.Add("Who is the only cricketer to have scored a century in all three formats of international cricket (Test, One Day Internationals, and T20 Internationals)?");
            list.Add("Who was the first Indian cricketer to score a triple century in Test cricket?");
            list.Add("Which Indian state is known as the \"Land of Five Rivers\"?");
            list.Add("Which Indian state is the largest producer of coffee?");
            list.Add("Who wrote the Indian national anthem, \"Jana Gana Mana\"?");
            //medium quesions ends here
            list.Add("Which Indian mathematician is known for discovering an infinite series that evaluates to the mathematical constant π (pi) in the 14th century, well before European mathematicians rediscovered similar formulas?");
            list.Add("Who was the founder of the Maurya Empire in ancient India?");
            list.Add("What is the name of the highest civilian award in India?");
            list.Add("Which Indian state is known as the \"Land of the Gods\" due to its numerous Hindu temples and pilgrimage sites?");
            list.Add("Who was the first Indian woman to win an Olympic medal?");
            //super hard question
            list.Add("Which planet in our solar system has the highest average surface temperature?");
            list.Add("What is the name of the deepest known point in the Earth's oceans?");
            list.Add("Who invented the first successful mechanical calculator, known as the Pascaline?");
            list.Add("What is the name of the largest living species of tortoise?");
            list.Add("In Greek mythology, who was the goddess of wisdom and warfare?");
            //last question
            list.Add("What is the name of the oldest known civilization in the Indian subcontinent, dating back to approximately 3300 BCE?");
            return list;

        }
    }

    internal class Options
    {
        public static List<string[]> GetOptions()
        {
            List<string[]> optionList = new List<string[]>();
            optionList.Add(new string[]
            {
                "Tamil", "Telegu", "Hindi", "Malayalam"
            });

            optionList.Add(new string[]
            {
                "Ujjain, Purl, Prayagraj , Haridwar", "Prayagraj, Haridwar, Ujjain, Nasik", "Rameshwaram, Purl, Badrinath, Dwarika", "Chittakoot, Ujjain, Prayagraj, Haridwar"
            });

            optionList.Add(new string[]
            {
                "Sep 8", "Nov 28", "May 2", "Sep 22"
            });

            optionList.Add(new string[]
            {
                "C K Nayudu", "Madan Lal", "Kapil Dev", "Mohinder Amarnath"
            });

            optionList.Add(new string[]
            {
                "375", "400", "401", "535"
            });

            //simple question ends here

            optionList.Add(new string[] {
                "Chris Gayle", "AB de Villiers", "Brendon McCullum", "Kumar Sangakkara"
            });

            optionList.Add(new string[]
            {
                "Sunil Gavaskar","Sachin Tendulkar", "Virender Sehwag", "Rahul Dravid"
            });

            optionList.Add(new string[]
            {
                "Punjab", "Gujarat", "Maharashtra", "Rajasthan"
            });

            optionList.Add(new string[]
            {
                "Kerala", "Tamil Nadu", "Karnataka" ,"Assam"
            });

            optionList.Add(new string[]
            {
                "Rabindranath Tagore", "Mahatma Gandhi", "Jawaharlal Nehru", "Subhas Chandra Bose"
            });

            //Medium Question ends here

            optionList.Add(new string[]
            {
                "Aryabhata" ,"Brahmagupta", "Bhaskara II", "Madhava of Sangamagrama"
            });

            optionList.Add(new string[]
            {
                "Ashoka the Great", "Chandragupta Maurya" ,"Bindusara", "Ashoka's grandfather"
            });

            optionList.Add(new string[]
            {
                "Padma Bhushan", "Bharat Ratna", "Padma Vibhushan", "Padma Shri"
            });

            optionList.Add(new string[]
            {
                "Uttarakhand", "Himachal Pradesh", "Rajasthan", "Gujarat"
            });

            optionList.Add(new string[]
            {
                "Karnam Malleswari", "Saina Nehwal", "Mary Kom", "P. T. Usha"
            });

            optionList.Add(new string[]
            {
                "Venus", "Mercury" ,"Earth", "Mars"
            });

            optionList.Add(new string[]
            {
                "Mariana Trench", "Puerto Rico Trench", "Sunda Trench", "Java Trench"
            });

            optionList.Add(new string[]
            {
                "Isaac Newton", "Blaise Pascal", "Gottfried Wilhelm Leibniz", "Charles Babbage"
            });

            optionList.Add(new string[]
            {
                "Galápagos tortoise", "Aldabra giant tortoise", "Gopher tortoise", "Radiated tortoise"
            });

            optionList.Add(new string[]
            {
                "A) Hera", "Athena" ,"C) Artemis", "D) Aphrodite"
            });

            //last question options

            optionList.Add(new string[]
            {
                "Indus Valley Civilization", "Vedic Civilization", "C) Maurya Empire", "D) Gupta Empire"
            });


            return optionList;
        }


    }

    internal class CorrectAnswers
    {
        public static List<string> GetCorrectAnswers()
        {
            List<string> correctanswers = new List<string>();
            correctanswers.Add("D");
            correctanswers.Add("B");
            correctanswers.Add("A");
            correctanswers.Add("A");
            correctanswers.Add("B");
            correctanswers.Add("B");
            correctanswers.Add("C");
            correctanswers.Add("A");
            correctanswers.Add("C");
            correctanswers.Add("A");
            correctanswers.Add("D");
            correctanswers.Add("B");
            correctanswers.Add("B");
            correctanswers.Add("A");
            correctanswers.Add("A");
            correctanswers.Add("A");
            correctanswers.Add("A");
            correctanswers.Add("B");
            correctanswers.Add("B");
            correctanswers.Add("B");
            correctanswers.Add("A");

            return correctanswers;
        }

    }
}
