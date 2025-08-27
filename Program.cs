using CRUD_ENDPOINT_CURSOS.Models;
using Newtonsoft.Json;
using System.Globalization;

Venda venda = new Venda(1, "Mesa", 1, 210.0M, DateTime.Parse("23/01/2024"));

string serializado = JsonConvert.SerializeObject(venda);

File.WriteAllText("Arquivos/venda.json", serializado);

Console.WriteLine(serializado);

//LeituraArq leitura = new LeituraArq();
//var (sucesso, linhas, quantLinhas) = leitura.LerArquivo("Arquivos/TextFile.txt");

//if (sucesso)
//{
//    Console.WriteLine($"Quantidade de linhas: {quantLinhas}");
//    foreach (var linha in linhas)
//    {
//        Console.WriteLine(linha);
//    }
//}
//else
//{
//    Console.WriteLine("Não foi possível ler o arquivo.");
//}

//Queue<int> fila = new Queue<int>();

//fila.Enqueue(1);
//fila.Enqueue(2);

//foreach (var item in fila)
//{
//    Console.WriteLine(item);
//}

//// tupla
//(int id, string NomeCurso, string TurmaCurso) tupla = (1, "Curso", "C#");

//ValueTuple<int, string, string> tupla2 = (1, "Curso", "C#");

//Console.WriteLine($"ID: {tupla.id}");
//Console.WriteLine($"Nome do curso: {tupla.NomeCurso}");
//Console.WriteLine($"Nome da turma: {tupla.TurmaCurso}");


//Console.WriteLine(tupla);

// puxar o metodo 1 do arquivo ExemploExcecao.cs
//ExemploExcecao exemplo = new ExemploExcecao();
//exemplo.Metodo1();

//try { 
//    // array de linhas para a leitura do arquivo
//    string[] linhas = File.ReadAllLines("Arquivos/TextFile.txt");

//    foreach (string linha in linhas)
//    {
//        Console.WriteLine(linha);
//    }

//} catch (FileNotFoundException ex) 
//{
//    Console.WriteLine($"O arquivo não foi encontrado: {ex.Message}");
//} catch (IOException ex) 
//{
//    Console.WriteLine($"Ocorreu um erro de I/O: {ex.Message}");
//} catch (Exception ex) 
//{
//    Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
//} finally {
//       Console.WriteLine("Execução finalizada.");
//}

//using CRUD_ENDPOINT_CURSOS.Data;
//using Microsoft.EntityFrameworkCore;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();

//builder.Services.AddDbContext<AppDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseAuthorization();

//app.MapControllers();

//app.Run();
