namespace RawMaterial.ViewModels
{
    public class Material
    {
        public int Id {  get; set; }

        public string ProductName { get; set; }

        public string Unit { get; set; }

        public string Quantity { get; set; }

        public DateTime Date { get; set; }


    }

    public class MaterialCreateVM
    {
        

        public string ProductName { get; set; }

        public string Unit { get; set; }

        public string Quantity { get; set; }

        public DateTime Date { get; set; }


    }
}
