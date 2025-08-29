using NUnit.Framework;
using AltTester.AltTesterSDK.Driver;
public class GameTests
{   //Important! If your test file is inside a folder that contains an .asmdef file, please make sure that the assembly definition references NUnit.
    private AltDriver altDriver;
    AltObject submitButton;
    AltObject countLabel;
    //Before any test it connects with the socket
    [SetUp]
    public void SetUp()
    {
        altDriver = new AltDriver(connectTimeout: 30);
        altDriver.LoadScene("SampleScene", true);
        submitButton = altDriver.FindObject(By.NAME, "SubmitButton");
        countLabel = altDriver.FindObject(By.NAME, "Count");
        Thread.Sleep(1000);
    }

    //At the end of the test closes the connection with the socket
    [TearDown]
    public void TearDown()
    {
        Thread.Sleep(1000);
        altDriver.Stop();
    }

    [Test]
    public void CountInteractable()
    {
        bool isInteractable = submitButton.GetComponentProperty<bool>("UnityEngine.UI.Button", "interactable", "UnityEngine.UI");
        Assert.That(isInteractable, Is.True, "Submit button isn't interactable");
        TestContext.Out.WriteLine("Submit button is interactable");
    }

    [Test]
    public void CountIncreasedAfterClick()
    {
        var initialCount = countLabel.GetText();
        submitButton.Tap();
        Assert.That(countLabel.GetText(), Is.GreaterThan(initialCount), "Value isn't increased after click");
    }

    [TestCase(10)]
    // [TestCase(5)]
    // [TestCase(1)]
    public void CountAfterXClicks(int clickCount)
    {
        Assert.That(countLabel.GetText(), Is.EqualTo("0"), "Initial count isn't zero");
        TestContext.Out.WriteLine("Initial count verified as zero");
        submitButton.Tap(clickCount);
        Assert.That(countLabel.GetText(), Is.EqualTo(clickCount.ToString()), "Click count and value isn't matched");
        TestContext.Out.WriteLine($"Value is exactly {clickCount} after {clickCount} clicks");
    }

}