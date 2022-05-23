var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapPost("/", () => new {Name = "Lucas Marinho", Age = "35"});
app.MapGet("/AddHeader", (HttpResponse response) => {
    response.Headers.Add("Teste", "Lucas");
    return "Olá";
    });

app.MapPost("/saveproduct", (Product product) => {
    return product.Code + " - " + product.Name;

});


app.Run();
