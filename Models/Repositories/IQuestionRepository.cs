using System;
namespace DevOverflow.Models.Repositories
{
    public interface IQuestionRepository
    {
        IEnumerable<Question> GetAll();
    }
}

