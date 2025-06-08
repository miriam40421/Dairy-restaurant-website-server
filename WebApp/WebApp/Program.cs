
using Dal;
using Dal.Models;
using Microsoft.EntityFrameworkCore;
using I_Bll;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//DependencyInjection ����� ������ ������� 
//���� ������ ����� �� ������ ����+
//builder.Services.AddScoped<I_Dall.IDalRepository<Dto.DtoCustomer>, Dal.DalClasses.DalCustomer>();
builder.Services.AddScoped<I_Dall.Customer, Dal.DalClasses.DalCustomer>();
builder.Services.AddScoped<I_Bll.ICustomerBll, Bll.Bllcotumer>();

builder.Services.AddScoped<I_Dall.Product, Dal.DalClasses.DalPrudact>();
builder.Services.AddScoped<I_Bll.IBllPrudacts, Bll.BllPrudacts>();

builder.Services.AddScoped<I_Dall.IDalRepository<Dto.DtoCategory>, Dal.DalClasses.DalCategory>();
builder.Services.AddScoped<I_Bll.IBllCategory, Bll.BllCategory>();


builder.Services.AddScoped<I_Dall.Order, Dal.DalClasses.DalOrder>();
builder.Services.AddScoped<I_Bll.IBllOrder, Bll.BllOrder>();

//builder.Services.AddScoped<Dal.DalClasses.DalPrudact>();
//builder.Services.AddScoped<I_Bll.IBllPrudacts, Bll.BllPrudacts>();

builder.Services.AddScoped<I_Dall.IdalDetail, Dal.DalClasses.DalDetails>();
builder.Services.AddScoped<I_Bll.IBllDetails, Bll.BllDetails1>();

//(����� �� ����� ���� ����� ������� ������ ( ���� ���� ����
builder.Services.AddDbContext<BigBiteContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionStrings")).LogTo(Console.WriteLine));

builder.Services.AddCors(opotion => opotion.AddPolicy("AllowAll",//����� �� ������
    p => p.AllowAnyOrigin()//����� �� ����
    .AllowAnyMethod()//�� ����� - �������
    .AllowAnyHeader()));

var app = builder.Build();

app.UseRouting();
app.UseCors("AllowAll");
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

