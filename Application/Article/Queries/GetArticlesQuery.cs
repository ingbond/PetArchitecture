using AutoMapper;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Article.Queries
{
    public record GetArticlesQuery : IRequest<List<ArticleDto>>
    {    
    }

    public class GetArticlesQueryHandler : IRequestHandler<GetArticlesQuery, List<ArticleDto>>
    {
        private readonly IMapper _mapper;

        public GetArticlesQueryHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Task<List<ArticleDto>> Handle(GetArticlesQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new List<ArticleDto>());
        }
    }
}
