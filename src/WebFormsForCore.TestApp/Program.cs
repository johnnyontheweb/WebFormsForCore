#if NETCOREAPP

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Web;
using System.Threading;
using System;

namespace WebFormsForCore.Test
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			var app = builder.Build();

			app.UseWebForms(options => options.HandleAllRequestsWithWebForms().PhysicalPath(AppDomain.CurrentDomain.BaseDirectory));
			
			app.Run();

		}
	}
}

#endif