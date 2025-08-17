using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Stripe.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class StripeOpenApiRunnerTests : FixturedUnitTest
{

    public StripeOpenApiRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
