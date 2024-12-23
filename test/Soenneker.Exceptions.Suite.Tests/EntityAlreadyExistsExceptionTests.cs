using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Exceptions.Suite.Tests;

[Collection("Collection")]
public class EntityAlreadyExistsExceptionTests : FixturedUnitTest
{
    public EntityAlreadyExistsExceptionTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
