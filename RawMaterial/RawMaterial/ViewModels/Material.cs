﻿namespace RawMaterial.ViewModels
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
}
