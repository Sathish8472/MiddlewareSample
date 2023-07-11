internal class EnvironmentMiddleware
{
    private RequestDelegate next;

    public string EnvironmentName { get; }

    public EnvironmentMiddleware(RequestDelegate next, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
    {
        this.next = next;
        this.EnvironmentName = env.EnvironmentName;
    }

    public async Task Invoke(HttpContext context)
    {
        Console.WriteLine($"This is Environment Middleware");
        await next(context);
    }
}