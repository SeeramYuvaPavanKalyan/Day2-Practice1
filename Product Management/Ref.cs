using System;


namespace Product
{
    class Refrigerator : Product
    {
        int capacity;
        string bodymaterial;
        string door;
        internal void Setrefrigeratordata(int productId, string model, string brand, int price, int capacity,
            string bodymaterial, string door)
        {
            base.SetProductData(productId, model, brand, price);
            this.capacity = capacity;
            this.bodymaterial = bodymaterial;
            this.door = door;
        }

        internal void Display()
        {
            base.Display();
            Console.WriteLine($"Capacity : {capacity} Bodymaterial : {bodymaterial} Door : {door}");

        }
    }
}
