using Bunit;
using Microsoft.Extensions.DependencyInjection;
using AutoShopWASM.Pages;

namespace TestAutoShopWASM
{
	[Collection("AutoShopWASM")]
	public class TestProduct_Details
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbRatingModule),
				typeof(IgbBadgeModule),
				typeof(IgbSelectModule),
				typeof(IgbButtonGroupModule),
				typeof(IgbToggleButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbButtonModule),
				typeof(IgbCardModule));
			var componentUnderTest = ctx.RenderComponent<Product_Details>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
