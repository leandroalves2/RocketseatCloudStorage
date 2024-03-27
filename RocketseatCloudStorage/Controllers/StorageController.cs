using Microsoft.AspNetCore.Mvc;
using RocketseatCloudStorage.Application.UseCases.Users.UploadProfilePhoto;

namespace RocketseatCloudStorage.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StorageController : ControllerBase
{
    [HttpPost]
    public IActionResult UploadImage([FromServices] IUploadProfilePhotoUseCase useCase , IFormFile file)
    {
        useCase.Execute(file);

        return Created();
    }
}
