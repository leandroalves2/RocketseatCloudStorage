using FileTypeChecker.Extensions;
using FileTypeChecker.Types;
using Microsoft.AspNetCore.Http;
using RocketseatCloudStorage.Domain.Entities;
using RocketseatCloudStorage.Domain.Storage;

namespace RocketseatCloudStorage.Application.UseCases.Users.UploadProfilePhoto;
public class UploadProfilePhotoUseCase : IUploadProfilePhotoUseCase
{
    private readonly IStorageService _storageService;
    public UploadProfilePhotoUseCase(IStorageService storageService)
    {
        _storageService = storageService;
        _storageService = storageService;
    }

    public void Execute(IFormFile file)
    {
        var fileStream = file.OpenReadStream();

        var IsImage = fileStream.Is<JointPhotographicExpertsGroup>();

        if (IsImage == false)
            throw new Exception("The file is note an image.");

        var user = GetFromDatabase();

        _storageService.Upload(file, user);
    }

    private User GetFromDatabase()
    {
        return new User
        {
            Id = 1,
            Name = "Leandro",
            Email = "teste.teste@teste.com",
            RefreshToken = "teste",
            AccessToken = "teste"
        };
    }
}