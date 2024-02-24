using Nito.AsyncEx;
using NUnit.Framework;

namespace Task_7._1;

public class Tests
{
    [Test]
    public void MyMethodAsync_ReturnsExpectedValue()
    {
        AsyncContext.Run(async () =>
        {
            var objectUnderTest = new SynchronousSuccess();
            int expectedValue = 13;
            int result = await objectUnderTest.SomethingAsync();
            Assert.That(result, Is.EqualTo(expectedValue));
        });
    }
}