using Soenneker.Tests.HostedUnit;

namespace Soenneker.Stripe.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class StripeOpenApiRunnerTests : HostedUnitTest
{

    public StripeOpenApiRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
