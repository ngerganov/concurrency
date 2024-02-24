using Nito.AsyncEx;
using NUnit.Framework;

namespace Task_7._3;

public class Tests
{
    [Test]
    public void MyMethodAsync_DoesNotThrow()
    {
        AsyncContext.Run(async () =>
        {
            var objectUnderTest = new MyClassWrapper();
            await objectUnderTest.MyTaskMethodAsync();
        });
    }
}