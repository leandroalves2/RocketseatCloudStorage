using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Util.Store;
using RocketseatCloudStorage.Application.UseCases.Users.UploadProfilePhoto;
using RocketseatCloudStorage.Domain.Storage;
using RocketseatCloudStorage.Infrastructure.Storage;
using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUploadProfilePhotoUseCase, UploadProfilePhotoUseCase>();
builder.Services.AddScoped<IStorageService>(options =>
{
    var clientId = builder.Configuration.GetValue<string>("CloudStorage:ClientId");
    var ClientSecret = builder.Configuration.GetValue<string>("CloudStorage:ClientSecret");

    var apiCodeFlow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
    {
        ClientSecrets = new ClientSecrets
        {
            ClientId = clientId,
            ClientSecret = ClientSecret

        }, 
        Scopes = [Google.Apis.Drive.v3.DriveService.Scope.Drive],
        DataStore = new FileDataStore("RocketseatCloudStorage")
    }); 

    return new GoogleDriveStorageService(apiCodeFlow);
});

var app = builder.Build();

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
