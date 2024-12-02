using Bunit;
using Microsoft.Extensions.DependencyInjection;
using AutoShopWASM.Pages;

namespace TestAutoShopWASM
{
	[Collection("AutoShopWASM")]
	public class TestHome
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbSelectModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbCardModule));
			var componentUnderTest = ctx.RenderComponent<Home>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
