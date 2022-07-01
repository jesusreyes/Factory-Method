using Microsoft.AspNetCore.Mvc;
public class ProductDetailController: Controller
{
    public IActionResult Index(decimal total)
    {
        //Factories
        LocalEarnFactory localEarnFactory = new LocalEarnFactory(0.20m);
        ForeignEarnFactory foreignEarnFactory = new ForeignEarnFactory(0.30m, 20);

        //Products
        var localEarn = localEarnFactory.GetEarn();
        var foreignEarn = foreignEarnFactory.GetEarn();

        //Total
        ViewBag.TotalLocal = total + localEarn.Earn(total);
        ViewBag.TotalForeign = total + foreignEarn.Earn(total);

        return View();
    }
}