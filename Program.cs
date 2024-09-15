using LH_PETS___Fabi;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Projeto Web - LH Pets versão 1");

Banco banco = new Banco();
app. MapGet("/listaClientes", (HttpContext context) => {
     context.Response.WriteAsync(banco.GetListaString());

});

app.UseStaticFiles();

app.Run();
