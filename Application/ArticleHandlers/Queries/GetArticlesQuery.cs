using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ArticleHandlers.Queries
{
    public record GetArticlesQuery : IRequest<List<ArticleDto>>
    {    
    }

    public class GetArticlesQueryHandler : IRequestHandler<GetArticlesQuery, List<ArticleDto>>
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _context;

        public GetArticlesQueryHandler(IMapper mapper, AppDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<List<ArticleDto>> Handle(GetArticlesQuery request, CancellationToken cancellationToken)
        {
            var result = await _context.Articles
                .ProjectTo<ArticleDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
            return result;
        }
    }
}
