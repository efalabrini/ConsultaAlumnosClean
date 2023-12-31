﻿
using ConsultaAlumnosClean.Domain.Entities;

namespace ConsultaAlumnosClean.Domain.Interfaces;

public interface IQuestionRepository : IRepositoryBase<Question>
{
   
    IOrderedQueryable<Question> GetPendingQuestions(int userId, bool withResponses);
    
    bool IsQuestionIdValid(int questionId);

    Task<Question?> GetByIdAsync(int id, CancellationToken cancellationToken = default);

}