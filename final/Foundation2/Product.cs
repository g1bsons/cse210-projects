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
    public string GetName()
    {
        return _name;
    }
    public string GetProductId()
    {
        return _productId;
    }
    public double GetUnitPrice()
    {
        return _unitPrice;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
}