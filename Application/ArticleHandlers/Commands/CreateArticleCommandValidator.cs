using FluentValidation;

namespace Application.ArticleHandlers.Commands;

public class CreateArticleCommandValidator : AbstractValidator<CreateArticleCommand>
{
    public CreateArticleCommandValidator()
    {
        RuleFor(v => v.Title)
            .MaximumLength(20)
            .NotEmpty();
    }
}
