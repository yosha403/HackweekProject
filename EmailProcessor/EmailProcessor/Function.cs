using System.Threading.Tasks;
using System.Net.Http.Headers;
using Amazon.Lambda.Core;
using EmailProcessor.ServiceLayer;
using EmailProcessor.ServiceLayer.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Http;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace EmailProcessor;

public class Function
{
    
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public string FunctionHandler(string input, ILambdaContext context)
    {
        return input.ToUpper();
    }
    private static void ConfigureServices(IServiceCollection serviceCollection)
    {
        serviceCollection.AddHttpClient<IExtractResponseServiceLayer, ExtractResponseServiceLayer>(client =>
        {
            client.BaseAddress = new Uri("https://bqvu92uv72.execute-api.us-east-2.amazonaws.com/Dev");
            client.DefaultRequestHeaders.Add("Accept", "application/json");
        });

        serviceCollection.AddScoped<IExtractResponseServiceLayer, ExtractResponseServiceLayer>();
    }
}
