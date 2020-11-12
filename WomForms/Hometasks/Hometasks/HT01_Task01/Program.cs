using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L01_Task01
{
    enum Answer
    {
        YES,
        NO
    }
    class Question
    {
        public string Text { get; set; }

        public Answer CorrectAnswer { get; set; }

        public Answer UserAnswer { get; private set; }
        public bool IsCorrectAnswer { get; private set; } = false;
        public Question(string text, Answer correctAnswer)
        {
            Text = text;
            CorrectAnswer = correctAnswer;
        }
        public void ShowQuestion()
        {
            DialogResult res = MessageBox.Show(Text, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (res)
            {
                case DialogResult.Yes:
                    UserAnswer = Answer.YES;
                    break;
                case DialogResult.No:
                    UserAnswer = Answer.NO;
                    break;
            }
            if (UserAnswer == CorrectAnswer)
                IsCorrectAnswer = true;
        }
    }

    class Quiz
    {
        private List<Question> quiz = new List<Question>();
        private int score = 0;

        public void AddQuestion(Question q)
        {
            quiz.Add(q);
        }

        public void Start()
        {
            foreach (var item in quiz)
            {
                item.ShowQuestion();
                if (item.IsCorrectAnswer)
                    score += 1;
            }

            MessageBox.Show($"Your score: {score}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz = new Quiz();

            quiz.AddQuestion(new Question("Question 1(Yes)?", Answer.YES));
            quiz.AddQuestion(new Question("Question 2(No)?", Answer.NO));
            quiz.AddQuestion(new Question("Question 3(Yes)?", Answer.YES));
            quiz.AddQuestion(new Question("Question 4(No)?", Answer.NO));
            quiz.AddQuestion(new Question("Question 5(No)?", Answer.NO));
            quiz.Start();
        }
    }
}
