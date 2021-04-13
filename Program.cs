using System;

namespace EnthusiasticMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            // Let the moose speak!
            MooseSays("H I, I'M  E N T H U S I A S T I C !");
            MooseSays("I really am enthusiastic");

            // REFACTORED question and answer methods
            MooseQuestion("Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!");
            MooseQuestion("Are you enthusiastic?", "Yay!", "You should try it!");
            MooseQuestion("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
            MooseQuestion("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
            
            // original question and answer method
            // CanadaQuestion();
            // EnthusiasticQuestion();
            // LoveCSharpQuestion();
            // SecretQuestion();
        }
    // new method for MooseQuestions
        static void MooseQuestion(string question, string answer1, string answer2)
        {
            bool isTrue = MooseAsks(question);
            if (isTrue)
            {
                MooseSays(answer1);
            }
            else
            {
                MooseSays(answer2);
            }
        }
// Old way of asking questions
        // static void CanadaQuestion()
        // {
        //     bool isTrue = MooseAsks("Is Canada real?");
        //     if (isTrue)
        //     {
        //         MooseSays("Really? It seems very unlikely.");
        //     }
        //     else
        //     {
        //         MooseSays("I  K N E W  I T !!!");
        //     }
        // }
        static void MooseSays(string message)
        {

            Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
            ");
        }

        static bool MooseAsks(string question)
        {
            Console.Write($"{question} (Y/N): ");
            string answer = Console.ReadLine().ToLower();

            while (answer != "y" && answer != "n")
            {
                Console.Write($"{question} (Y/N): ");
                answer = Console.ReadLine().ToLower();
            }

            if (answer == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
