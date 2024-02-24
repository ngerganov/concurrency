using NUnit.Framework;

namespace Task_7._2;

public class Tests
{
    [Test]
    public async Task Divide_WhenDenominatorIsZero_ThrowsDivideByZero()
    {
        await AssertExtensions.ThrowsAsync<DivideByZeroException>(async () =>
        {
            await MyClass.DivideAsync(4, 0);
        });
    }
}