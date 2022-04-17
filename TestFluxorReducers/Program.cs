using Fluxor;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BasicConcepts.StateActionsReducersTutorial
{
	class Program
	{
		static void Main(string[] args)
		{
			var services = new ServiceCollection();
			services.AddScoped<App>();
			services.AddFluxor(o => o
				.ScanAssemblies(typeof(Program).Assembly));

			IServiceProvider serviceProvider = services.BuildServiceProvider(new ServiceProviderOptions
			{
				ValidateOnBuild = true,
				ValidateScopes = true,
			});

			using var scope = serviceProvider.CreateScope();
			var app = scope.ServiceProvider.GetRequiredService<App>();
			app.Run();
		}
	}
}
