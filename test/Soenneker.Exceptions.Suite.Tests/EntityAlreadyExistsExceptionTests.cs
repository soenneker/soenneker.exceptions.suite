using Soenneker.Tests.HostedUnit;

namespace Soenneker.Exceptions.Suite.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class EntityAlreadyExistsExceptionTests : HostedUnitTest
{
    public EntityAlreadyExistsExceptionTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
