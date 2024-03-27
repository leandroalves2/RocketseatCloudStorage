using Microsoft.AspNetCore.Http;
using RocketseatCloudStorage.Domain.Entities;

namespace RocketseatCloudStorage.Domain.Storage;
public interface IStorageService
{
    string Upload(IFormFile file, User user);
}
