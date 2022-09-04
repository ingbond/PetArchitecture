using Application.ArticleHandlers.Commands;
using Application.ArticleHandlers.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ArticlesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArticleDto>>> Get()
        {
            return await _mediator.Send(new GetArticlesQuery());
        }

        [HttpPut]
        public async Task<ActionResult<Guid>> Insert(CreateArticleCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
