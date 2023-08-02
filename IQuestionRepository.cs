using System;
namespace EveryQuestionDeservesAnswer.Models.Repositories
{
    public interface IQuestionRepository
    {
        IEnumerable<Question> GetAll();
        Question GetById(int id);
    }
}

