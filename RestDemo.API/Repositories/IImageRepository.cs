using RestDemo.API.Models.Domain;

namespace RestDemo.API.Repositories
{
    public interface IImageRepository
    {
        Task<Image> Upload(Image image);
    }
}
