//MINIMAL API
using Microsoft.AspNetCore.Mvc;                     // biblioteca com METODO #2
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseStaticFiles();                               // habilita o uso de wwwroot
app.UseDefaultFiles();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/hello-world", () => 
{
    return Results.Ok(new 
    {
        mensagem = "Hello World!"
    });
});



app.Run();

public class dadosEntrada{
    
    public int x { get ; set; }
    public int y { get ; set; }
}















//METODO #1 - SIMPLES
// app.MapGet("/api", (int x) => $"Recebido: {x}");
// app.Logger.LogInformation("Aplicação Iniciada");


// //METODO #2 - USANDO BIBLIOTECA Microsoft.AspNetCore.Mvc
// app.MapGet("/api/{x}", ([FromRoute]int x, [FromQuery]int y) => $"Recebido: {x} e {y}");


// //METODO #3 - USANDO UMA FUNCTION
// app.MapPost("/api", ([FromBody] dadosEntrada entradas) => $"Recebido: {entradas.x} e {entradas.y}");


//METODO #4 - RETORNANDO .JSON
// app.MapGet("/hello", () => {
//     var resultado = new {                     // gera um .JSON como resposta
//         mensagem = "Hello World!"
//     };

//     return Results.Ok(resultado);             //Erro 200
//     //return Results.BadRequest(resultado);   //Erro 400
//     // return Results.StatusCode(500);        //Define o erro manualmente
// });
