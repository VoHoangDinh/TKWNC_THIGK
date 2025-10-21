namespace WEB_API.Models
{
    public interface INhomRepository
    {
        Task<IEnumerable<tbNhom>> GetAllNhom();
    }
}