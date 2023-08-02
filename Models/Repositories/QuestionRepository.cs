using System;
namespace EveryQuestionDeservesAnswer.Models.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly List<Question> _question;

        public QuestionRepository()
        {
            _question = new List<Question>()
            {
                new Question()
                {
                    Id = 1,
                    Title = "Michela Lettieri",
                    Description = "When Is Michela Birthday?",
                    Author = "Michela Lettieri",
                    Answers = new List<Answer>() {
                        new Answer
                        {
                            Id=1,
                            Author = "Michela Lettieri",
                            Description= "15-04-1996",
                            IsAccepted= true,
                            Question = new Question()
                        },
                        new Answer
                        {
                            Id=2,
                            Author = "Michela Lettieri",
                            Description= "05-08-1995",
                            IsAccepted= false,
                            Question = new Question()
                        },
                        new Answer
                        {
                            Id=3,
                            Author = "Michela Lettieri",
                            Description= "01-07-1994",
                            IsAccepted= false,
                            Question = new Question()
                        },
                        new Answer
                        {
                            Id=4,
                            Author = "Michela Lettieri",
                            Description= "21-12-1993",
                            IsAccepted= false,
                            Question = new Question()
                        },
                    }
                },
                new Question()
                {
                    Id = 2,
                    Title = "Test",
                    Description = "Test",
                    Author = "Test",
                    Answers = new List<Answer>() {}
                }
            };
        }

        public IEnumerable<Question> GetAll()
        {
            return new List<Question>(this._question);
        }

        public Question GetById(int id)
        {
            return _question.Where(question => question.Id == id).Select(question => new Question
            {
                Id = question.Id,
                Author = question.Author,
                Title = question.Title,
                Description = question.Description,
                Answers = question.Answers,
            }).First();
        }
    }
}

