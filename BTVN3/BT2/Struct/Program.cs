class Struct
{
    public struct Product
    {
        public string Name { get; set; }
        public string Discription { get; set; }
        public int ProductID { get; set; }
        public int Price { get; set; }

        public Product ( string _name , string _desc, int _productid , int _price )
        {
            Name = _name;
            Discription = _desc;
            ProductID = _productid;
            Price = _price;
        }
        var strProduct = new Product("Xe bus" , )
    }
}