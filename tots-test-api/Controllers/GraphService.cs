using Microsoft.Identity.Client;
using Microsoft.Graph;
using Microsoft.Graph.Auth;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var clientId = "fde82289-6495-4ceb-9745-f0d5e1c9c09a";
        var clientSecret = "e6548bdf-a70b-4749-b796-130c23f6af3b";
        var tenantId = "f8cdef31-a31e-4b4a-93e4-5f571e91255a";

        var confidentialClientApplication = ConfidentialClientApplicationBuilder
            .Create(clientId)
            .WithClientSecret(clientSecret)
            .WithAuthority(new Uri($"https://login.microsoftonline.com/{tenantId}"))
            .Build();

        var authProvider = new ClientCredentialProvider(confidentialClientApplication);

        var graphServiceClient = new GraphServiceClient(authProvider);

        await ListCalendars(graphServiceClient);
    }

    static async Task ListCalendars(GraphServiceClient graphServiceClient)
    {
        try
        {
            var calendars = await graphServiceClient.Me.Calendars
                .Request()
                .GetAsync();

            foreach (var calendar in calendars)
            {
                Console.WriteLine($"Calendar Id: {calendar.Id}, Name: {calendar.Name}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

