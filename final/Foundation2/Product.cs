using System;

class Product
{
    private string _name;
    private string _productId;
    private double _unitPrice;
    private int _quantity;

    public Product(string name, string productId, double unitPrice, int quantity)
    {
        _name = name;
        _productId = productId;
        _unitPrice = unitPrice;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _unitPrice * _quantity;
    }
    public string GetProductInfo()
    {
        return _name + ", " + _productId;
    }
}