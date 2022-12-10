using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;

namespace Iths.CiDemo.Api.Tests.Integration.Helpers;

public class TestWebApplicationFactory : WebApplicationFactory<Program>
{
    protected override IHost CreateHost(IHostBuilder builder)
    {
        builder.ConfigureServices(services =>
        {
            //TODO: Replace services later
        });

        return base.CreateHost(builder);
    }
}
