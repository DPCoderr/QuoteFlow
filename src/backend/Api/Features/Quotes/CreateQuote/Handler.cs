using Api.Features.Quotes.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Companion;


namespace Api.Features.Quotes.CreateQuote;

public static class CreateQuote
{
    public static IResult Handle()
    {
        var model = InvoiceDocumentDataSource.GetInvoiceDetails();
        var document = new InvoiceDocument(model);
        
        var pdfBytes = document.GeneratePdf();
        // document.ShowInCompanion();
        
        return TypedResults.File(
            fileContents: pdfBytes,
            contentType: "application/pdf",
            fileDownloadName: "Invoice.pdf"
            );
    }
}
