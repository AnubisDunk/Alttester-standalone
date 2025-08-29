public static class Helper
{
   public static void LogMessage(string message)
    {
        string testName = TestContext.CurrentContext.Test.Name;
        TestContext.Out.WriteLine($"[Test: {testName}] {message}");
    }
}