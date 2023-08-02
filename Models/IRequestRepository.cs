using System;
namespace EveryQuestionDeservesAnswer.Models
{
	public interface IRequestRepository
	{
		void Add(RequestDelegate request);
		void DeleteById(int id);
		IEnumerable<HttpRequest> GetAll();
		RequestDelegate GetById(int id);
		void Modify(RequestDelegate request);
	}
}

