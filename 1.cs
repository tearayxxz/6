using System;

namespace ConsoleApp18
{
    class Program
    {
        enum Difficulty
        {
            Easy,
            Normal,
            Hard
        }

        struct Problem
        {
            public string Message;
            public int Answer;

            public Problem(string message, int answer)
            {
                Message = message;
                Answer = answer;
            }        }

        static Problem[] GenerateRandomProblems(int numProblem)
        {
            Problem[] randomProblems = new Problem[numProblem];

            Random rnd = new Random();
            int x, y;

            for (int i = 0; i < numProblem; i++)
            {
                x = rnd.Next(50);
                y = rnd.Next(50);
                if (rnd.NextDouble() >= 0.5)
                    randomProblems[i] =
                    new Problem(String.Format("{0} + {1} = ?", x, y), x + y);
                else
                    randomProblems[i] =
                    new Problem(String.Format("{0} - {1} = ?", x, y), x - y);
            }

            return randomProblems;
        }

        static void Main(string[] args)
        {
            double score = 0;
            double score_sum = 0;
            int numberlevel = 0;
            double correct_answer = 0;
            int many_answer;
            bool check_input = false;
            while (check_input == false)
            {

                Difficulty level;
                level = (Difficulty)numberlevel;
                Console.WriteLine("Score: {0}, Difficulty: {1}", score_sum, level);
                if (numberlevel == 0)
                {
                    numberlevel += 3;
                }
                else if (numberlevel == 1)
                {
                    numberlevel += 4;
                }
                else if (numberlevel == 2)
                {
                    numberlevel += 5;
                }

                int numbersetting = int.Parse(Console.ReadLine());
                if (numbersetting == 0 || numbersetting == 1 || numbersetting == 2)
                {
                    if (numbersetting == 0)
                    {
                        DateTimeOffset.Now.ToUnixTimeSeconds();
                        DateTime foo = DateTime.UtcNow;
                        long unixTime = ((DateTimeOffset)foo).ToUnixTimeSeconds();

                        Problem[] problem = GenerateRandomProblems(numberlevel);
                        foreach (Problem test in problem)
                        {
                            Console.WriteLine(test.Message);
                            int Answer = int.Parse(Console.ReadLine());
                            if (Answer == test.Answer)
                            {
                                correct_answer++;
                            }
                        }
                        many_answer = numberlevel;

                        if (numberlevel == 3)
                        {
                            numberlevel -= 3;
                        }
                        else if (numberlevel == 5)
                        {
                            numberlevel -= 4;
                        }
                        else if (numberlevel == 7)
                        {
                            numberlevel -= 5;
                        }

                        DateTime foo1 = DateTime.UtcNow;
                        long unixTime1 = ((DateTimeOffset)foo1).ToUnixTimeSeconds();

                        double spend_time;
                        spend_time = unixTime1 - unixTime;
                        Console.WriteLine("Time : " + spend_time);
                        double sum_1 = (correct_answer / many_answer)
                            , sum_2 = (25 - Math.Pow(numberlevel, 2)) / (Math.Max(spend_time, 25 - Math.Pow(numberlevel, 2)))
                            , sum_3 = Math.Pow(((2 * numberlevel) + 1), 2);

                        score = sum_1 * sum_2 * sum_3;

                        score_sum += score;

                        correct_answer = 0;
                    }
                    else if (numbersetting == 1)
                    {
                        bool check_level = false;
                        while (check_level == false)
                        {
                            Console.WriteLine("Please input level 0 / 1 / 2");
                            numberlevel = int.Parse(Console.ReadLine());
                            if (numberlevel != 0 && numberlevel != 1 && numberlevel != 2)
                            {
                                Console.WriteLine("Please input level tryagain." + numberlevel);
                            }
                            else
                                check_level = true;
                        }
                    }
                    else if (numbersetting == 2)
                    {
                        check_input = true;
                    }
                }
                else
                    Console.WriteLine("Please input 0 - 2.");
            }
        }
    }
}
