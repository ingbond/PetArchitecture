using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ArticleHandlers.Commands
{
    public class CreateArticleCommand : IRequest<Guid>
    {
        public string Title { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
    }

    public class CreateArticleCommandHandler : IRequestHandler<CreateArticleCommand, Guid>
    {
        private readonly AppDbContext _context;

        public CreateArticleCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateArticleCommand request, CancellationToken cancellationToken)
        {
            var entity = new Article
            {
                Text = request.Title,
                Title = request.Text,
                Created = DateTime.Now,
                Modified = DateTime.Now
            };

            _context.Articles.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
