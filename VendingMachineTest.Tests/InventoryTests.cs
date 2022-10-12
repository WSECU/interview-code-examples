namespace VendingMachineTest.Tests;

public class InventoryTests
{
    [Fact]
    public void BuyItem_ReducesInventory()
    {
        var inv = new Inventory();

        int originalCount = inv.Soda.Quantity;
        inv.BuySoda();
        int newCount = inv.Soda.Quantity;

        Assert.NotEqual(newCount, originalCount);
        Assert.True(newCount < originalCount);
        Assert.True(newCount == (originalCount - 1));
    }
}
