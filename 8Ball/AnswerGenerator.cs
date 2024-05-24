using System;

namespace _8Ball
{
    internal class AnswerGenerator
    {
        // Масив строк
        private static System.String[] answers = new System.String[]
        {
            "Ask one more time.",
            "I can`t say right away.",
            "Without a doubt.",
            "This is really true",
            "Focus and ask again.",
            "No.",
            "Yes, really.",
            "I don`t think so.",
            "Exactly.",
            "Better not say anything.",
            "Bad point of view.",
            "That`s probably true.",
            "Very doubtful.",
            "As I see, it yes.",
            "My answer it`s no",
            "Sure.",
            "Yes.",
            "You can be sure.",
            "Good point of view.",
            "Vague question, try again."
        };

        // Метод случайной генерации ответа
        public static string GetRandomAnswer()
        { 
            return answers[new Random().Next(answers.Length)];
        }
    }
}