using FluxorSampleApp.Shared;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(cfg => cfg
        .AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

var cartItems = new List<Item>();

app.MapGet("/cart-items", async () =>
{
    // Simulate db retrieve logic
    await Task.Delay(2000);

    return cartItems;
});

app.MapPost("/cart-items", async (Item itemToAdd) =>
{
    // Simulate db save logic
    await Task.Delay(2000);

    cartItems.Add(itemToAdd);
});

app.Run();