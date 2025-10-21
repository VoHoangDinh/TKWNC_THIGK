namespace WEB_API.Models
{
    public interface IThietBiRepository
    {
        Task<IEnumerable<tbThietBi>> GetThietBiByNhom(int maNhom);
        Task<tbThietBi> GetThietBiById(int maThietBi);
    }
}