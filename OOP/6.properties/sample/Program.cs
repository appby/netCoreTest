Product prd = new Product();
prd.Name="Apple Iphone 13";
Console.WriteLine(prd.Name);
prd.Price=-1000;
Console.WriteLine(prd.Price);

class Product
{
    private string _name;// private ozelliklere sınıf içinde erişilir dışardan erişilemez
    public string Name 
    { 
        get
        {
            return _name;
        } 
        set
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new Exception("Name Alanı Zorunludur");
            }
            else
            {
                _name = value;
            }
        } 
    }

    private double _price;
    public double Price 
    { 
        get // sınıf türetilip nesne cagrilirsa get calisir
        {
            return _price;
        } 
        set// sınıf türetilip, nesneye atama yapılırsa set calisir
        {
            if (value<0)
            {
                _price=0;
            }
            else
            {
                _price = value;
            }
        } 
    }

    public bool isApprooved { get; } // sadece okunabilir bir nesene oldu get bırakıldığı için sadece
}

