using System;
namespace EveryQuestionDeservesAnswer.Models.Repositories
{
    public interface IAnswerRepository
    {
        IEnumerable<Answer> GetAll();
    }
}

