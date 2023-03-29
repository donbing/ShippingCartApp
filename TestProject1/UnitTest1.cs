namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void Test1()
    {
        // given
        // items 'apples' are for sale at 20p each
        var applesProduct = new ProductItem("apples", 0.2);
        
        // when
        // I have added an 1 'apples' to my shopping cart
        var cart = new ShoppingCart();
        cart.AddProduct(applesProduct, 1);

        cart.totalCost.Should.Be(0.2);
        // then
        // my shopping cart total should be 20p
    }
}

public class ShoppingCart
{
    public double totalCost;

    public void AddProduct(ProductItem applesProduct, int i)
    {

    }
}

public class ProductItem
{
    private readonly string _apples;
    private readonly double _d;

    public ProductItem(string apples, double d)
    {
        _apples = apples;
        _d = d;
    }
}