using Microsoft.AspNetCore.Mvc;


namespace VendingMachineTest.Tests;

public class ControllerTests
{
    [Fact]
    public void ItemFound_ReturnsOkObjectResult()
    {
        string itemName = "Soda";
        var controller = new VendingMachineController();

        var response = controller.BuyItem(itemName);

        Assert.IsType<OkObjectResult>(response.Result);
    }

    [Fact]
    public void ItemFound_ReturnedItemNameMatchesSentItemName()
    {
        string itemName = "Soda";
        var controller = new VendingMachineController();

        var response = controller.BuyItem(itemName);
        var result = (OkObjectResult) response.Result;
        var item = (Item)result.Value;

        Assert.Equal(itemName, item.Name);
    }

    [Fact]
    public void ItemNotFound_ReturnsNotFound()
    {
        string itemName = "Video Game";
        var controller = new VendingMachineController();

        var response = controller.BuyItem(itemName);
        
        Assert.IsType<NotFoundResult>(response.Result);
    }
}