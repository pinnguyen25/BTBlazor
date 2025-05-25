namespace dotnet03_web_blazor.Data;
public static class DbCarProduct
{
    public static List<ProductCardVM> lstProductCar = new List<ProductCardVM>()
    {
        new ProductCardVM()
        {
            id=1,name="Black car",price=1000,img="/products/black-car.jpg"
        },
        new ProductCardVM()
        {
            id=2,name="Red car",price=2000,img="/products/red-car.jpg"
        },
        new ProductCardVM()
        {
            id=3,name="Silver car",price=3000,img="/products/silver-car.jpg"
        },
        new ProductCardVM()
        {
            id=4,name="Steel car",price=4000,img="/products/steel-car.jpg"
        }
    };
}