using RawMaterial.Infrastructure.Interface;
using RawMaterial.Models;
using RawMaterial.ViewModels;

namespace RawMaterial.Infrastructure.Implementation
{
    public class MaterialRepository : IMaterialRepository
    {
        private readonly ProductDbContext _context;

        public MaterialRepository(ProductDbContext context)
        {
            _context = context;
        }

        public bool CreateMaterial(CreateMaterialVM guiMaterial)
        {
            Material DbEntity = new Material();
            DbEntity.ProductName = guiMaterial.ProductName;
            DbEntity.Quantity = guiMaterial.Quantity;
            DbEntity.Unit= guiMaterial.Unit;
            DbEntity.Date = guiMaterial.Date;
            _context.Materials.Add(DbEntity);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteMaterial(int id)
        {
            var material = _context.Materials.Where(p => p.Id == id).FirstOrDefault();
            _context.Remove(material);
            _context.SaveChanges();
            return true;
        }



        public IEnumerable<MaterialVM> GetAllMaterial()
        {
            var materials = _context.Materials.ToList();
            List<MaterialVM> ListMaterial = new List<MaterialVM>();
            foreach(var model in materials)
            {
                MaterialVM materialVM = new MaterialVM();
                materialVM.Id = model.Id;
                materialVM.ProductName = model.ProductName;
                materialVM.Unit = model.Unit;
                materialVM.Quantity = model.Quantity;
                materialVM.Date = (DateTime)model.Date;
                ListMaterial.Add(materialVM);
            }
            return ListMaterial;
        }

        public bool UpdateMaterial(MaterialVM model)
        {
           var material =_context.Materials.Where(p => p.Id == model.Id).FirstOrDefault();
            if (material != null)
            {
                material.Unit = model.Unit;
                material.Quantity = model.Quantity;
                material.Date = (DateTime)model.Date;
                material.ProductName = model.ProductName;

            }
            _context.Update(material);
            _context.SaveChanges();
            return true;

        }
    }


    }

      
