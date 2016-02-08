using System;
using System.Collections.Generic;

class Car
{
  private string _makeModel;
  private int _price;
  private int _miles;
    public void SetMakeModel(string carMakeModel)
    {
      _makeModel = carMakeModel;
    }
    public string GetMakeModel()
    {
      return _makeModel;
    }

    public void SetPrice(int carPrice)
    {
      _price = carPrice;
    }
    public int GetPrice()
    {
      return _price;
    }

    public void SetMiles(int carMiles)
    {
      _miles = carMiles;
    }
    public int GetMiles()
    {
      return _miles;
    }

    public bool WorthBuying(int maxPrice, int maxMiles)
    {
      return (_price < (maxPrice + 100) && _miles < maxMiles);
    }
  }

public class Program
{
  public static void Main()
  {

    Car firstCar = new Car();
    firstCar.SetMakeModel("2014 Porsche 911");
    firstCar.SetPrice(114991);
    firstCar.SetMiles(7864);

    Car secondCar = new Car();
    secondCar.SetMakeModel("2011 Ford F450");
    secondCar.SetPrice(55995);
    secondCar.SetMiles(14241);

    Car thirdCar = new Car();
    thirdCar.SetMakeModel("2013 Lexus RX 350");
    thirdCar.SetPrice(44700);
    thirdCar.SetMiles(20000);

    Car fourthCar = new Car();
    fourthCar.SetMakeModel("2018 Mercedes Benz CLS550");
    fourthCar.SetPrice(39900);
    fourthCar.SetMiles(37979);

    List<Car> Cars = new List<Car>() { firstCar, secondCar, thirdCar, fourthCar };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("Enter maximum miles: ");
    string stringMaxMiles = Console.ReadLine();
    int maxMiles = int.Parse(stringMaxMiles);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach(Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice, maxMiles))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    if(CarsMatchingSearch.Count != 0)
    {
      foreach(Car automobile in CarsMatchingSearch)
      {

        Console.WriteLine(automobile.GetMakeModel());
        Console.WriteLine("Price: $" + automobile.GetPrice());
        Console.WriteLine("Miles: " + automobile.GetMiles());
      }
    }
    else
    {
        Console.WriteLine("Sorry no matches found");
    }
  }
}
