using Microsoft.AspNetCore.Mvc;
using System.Net;
using VendingMachineTest.Models;

namespace VendingMachineTest.Controllers;

[ApiController]
[Route("[controller]")]
public class VendingMachineController : Controller
{
    private readonly Inventory _inventory;

    public VendingMachineController()
    {
        _inventory = new Inventory();
    }

    [HttpGet(Name = "GetInventory")]
    public ActionResult<Inventory> GetInventory()
    {
        return Ok(_inventory);
    }

    [HttpPost(Name = "BuyItem")]
    [ProducesResponseType(typeof(Inventory), (int) HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public ActionResult<Item> BuyItem(string itemName)
    {
        if (itemName == _inventory.Chips.Name)
        {
            return Ok(_inventory.BuyChips());
        }
        if (itemName == _inventory.Soda.Name)
        {
            return Ok(_inventory.BuySoda());
        }
        if (itemName == _inventory.CandyBars.Name)
        {
            return Ok(_inventory.BuyCandyBar());
        }

        return NotFound();
    }
}
