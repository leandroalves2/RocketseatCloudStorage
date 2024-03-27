using FileTypeChecker.Types;
using Microsoft.AspNetCore.Http;
using RocketseatCloudStorage.Domain.Storage;

namespace RocketseatCloudStorage.Application.UseCases.Users.UploadProfilePhoto;
public interface IUploadProfilePhotoUseCase
{
    public void Execute(IFormFile file);
}
