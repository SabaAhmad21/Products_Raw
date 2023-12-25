using System.ComponentModel.DataAnnotations;

namespace RawMaterial.ViewModels
{
    public class MaterialVM
    {
        public int Id {  get; set; }

        public string ProductName { get; set; }

        public string Unit { get; set; }

        public string Quantity { get; set; }

        public DateTime Date { get; set; }


    }

    public class CreateMaterialVM
    {
        

        public string ProductName { get; set; }

        public string Unit { get; set; }

        public string Quantity { get; set; }

        public DateTime Date { get; set; }


    }

    public class UpdateMaterialVM
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int Id { get; set; }
        public string ProductName { get; set; }

        public string Unit { get; set; }

        public string Quantity { get; set; }

        public DateTime Date { get; set; }


    }
}
