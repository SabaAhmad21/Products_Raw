using Microsoft.AspNetCore.Mvc;
using RawMaterial.Infrastructure.Interface;
using RawMaterial.ViewModels;

namespace RawMaterial.Controllers
{

    public class MaterialController : Controller
    {
        private IMaterialRepository _materialRepository;

        public MaterialController(IMaterialRepository materialRepository)
        {
            _materialRepository = materialRepository;
        }

        [HttpGet]
        public IActionResult Materials()
        {
            return View(_materialRepository.GetAllMaterial());
        }


        [HttpGet]
        public IActionResult CreateMaterial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateMaterial(CreateMaterialVM guiMaterial)
        {
            if(ModelState.IsValid)
            {
                if(_materialRepository.CreateMaterial(guiMaterial))
                {
                    ModelState.AddModelError("", "Material Created Successfully");
                }
                else
                {
                    ModelState.AddModelError("", "Something went wrong");
                }
                return View();
            }
            return View();
        }

        public IActionResult UpdateMaterial(int id)
        {


            return View(_materialRepository.GetMaterialById(id));

        }

    


        [HttpPost]
        public IActionResult UpdateMaterial(UpdateMaterialVM model)
        {

            //return View(model);
            _materialRepository.UpdateMaterial(model);

            return RedirectToAction("Materials", new { Controller = "Material" });

        }
        public IActionResult DeleteMaterial(int id)
        {
            _materialRepository.DeleteMaterial(id);

            return RedirectToAction("Materials", new { Controller = "Material" });
        }

    }
}
