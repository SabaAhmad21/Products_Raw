using RawMaterial.Models;
using RawMaterial.ViewModels;

namespace RawMaterial.Infrastructure.Interface
{
    public interface IMaterialRepository
    {
       bool CreateMaterial (CreateMaterialVM guiMaterial);

        IEnumerable<MaterialVM> GetAllMaterial();

        bool DeleteMaterial(int id);

        bool UpdateMaterial(MaterialVM material);

    }
}
