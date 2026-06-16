
using Api.Features.Quotes.CreateQuote;

public static class QuotesEndpoints
{
    public static RouteGroupBuilder MapQuotesEndpoints(this RouteGroupBuilder app)
    {
        var group = app.MapGroup("/quotes")
            .WithTags("Quotes");

        group.MapGet("/", CreateQuote.Handle);
        
        return group;
    }
}