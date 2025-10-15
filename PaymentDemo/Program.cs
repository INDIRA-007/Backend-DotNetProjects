using Microsoft.AspNetCore.Builder;
using PaymentDemo.Interfaces;
using PaymentDemo.PaymentGateway;
using PaymentDemo.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IPaymentGateway, StripeGateway>();
builder.Services.AddScoped<PaymentService>();



var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseSwagger();
//app.UseSwagger();

app.Run();
