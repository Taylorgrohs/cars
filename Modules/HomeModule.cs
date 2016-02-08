using Nancy;
using Car.Objects;

namespace Car
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["form.html"];
      };
      Get["/cars"] = _ => {
        CarVariables myCarVariables = new CarVariables
        {
          MakeModel = Request.Query["MakeModel"],
          Price = Request.Query["Price"],
          Miles = Request.Query["Miles"]
        };
        return View["cars.html", myCarVariables];
      };
    }
  }
}
