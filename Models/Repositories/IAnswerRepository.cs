using System;
namespace DevOverflow.Models.Repositories
{
    public interface IAnswerRepository
    {
        IEnumerable<Answer> GetAll();
    }
}

