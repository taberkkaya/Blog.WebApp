﻿using AK.BlogWebApp.Domain.Entities;
using AK.BlogWebApp.Domain.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.Documents.GetDocumentById;

public sealed class GetDocumentByIdCommandHandler(
    IDocumentRepository documentRepository
    ) : IRequestHandler<GetDocumentByIdCommand, Result<Document>>
{
    public async Task<Result<Document>> Handle(GetDocumentByIdCommand request, CancellationToken cancellationToken)
    {
        var doc = await documentRepository.Where(p => p.Id == request.Id).Include(p => p.DocumentCategory).FirstAsync();

        if (doc is null)
        {
            return Result<Document>.Failure("Doküman bulunamadı");
        }

        return doc;
    }
}