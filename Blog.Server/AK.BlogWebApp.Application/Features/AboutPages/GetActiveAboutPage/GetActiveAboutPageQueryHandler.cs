﻿using AK.BlogWebApp.Domain.Entities;
using AK.BlogWebApp.Domain.Repository;
using MediatR;
using TS.Result;

namespace AK.BlogWebApp.Application.Features.AboutPages.GetActiveAboutPage;

public sealed record GetActiveAboutPageQueryHandler(IAboutPageRepository aboutPageRepository) : IRequestHandler<GetActiveAboutPageQuery, Result<AboutPage>>
{
    public async Task<Result<AboutPage>> Handle(GetActiveAboutPageQuery request, CancellationToken cancellationToken)
    {
        var activePage = await aboutPageRepository.GetFirstAsync();
        return activePage;
    }
}
