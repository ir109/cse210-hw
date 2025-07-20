using System;

public class Product
{
    private string _productName;
    private string _productID;
    private double _pricePerUnit;
    private int _productQuantity;
    public Product(string productName, string productID, double pricePerUnit, int productQuantity)
    {
        _productName = productName;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _productQuantity = productQuantity;
    }
    public double GetTotalCost()
    {
        return _pricePerUnit * _productQuantity;
    }
    public string GetPackingInfo()
    {
        return $"{_productName} (ID: {_productID})";
    }
}
