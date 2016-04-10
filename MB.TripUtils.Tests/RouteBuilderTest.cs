using System.Linq;
using NUnit.Framework;

namespace MB.TripUtils.Tests
{
	[TestFixture]
    public class RouteBuilderTest
    {
		[Test]
		public void BuildTest()
		{
			var badRoute = new[] {	new RouteSegment {Source = "Мельбурн", Destination = "Кельн" },
									new RouteSegment { Source = "Москва", Destination = "Париж" },
									new RouteSegment { Source = "Кельн", Destination = "Москва" },
									new RouteSegment { Source = "Кисловодск", Destination = "Мельбурн" }};
			var goodRoute = RouteBuilder.Build(badRoute).ToArray();
			Assert.That(goodRoute.Count(), Is.EqualTo(4));
			Assert.That(goodRoute[0].Source, Is.EqualTo("Кисловодск"));
			Assert.That(goodRoute[0].Destination, Is.EqualTo("Мельбурн"));
			Assert.That(goodRoute[1].Source, Is.EqualTo("Мельбурн"));
			Assert.That(goodRoute[1].Destination, Is.EqualTo("Кельн"));
			Assert.That(goodRoute[2].Source, Is.EqualTo("Кельн"));
			Assert.That(goodRoute[2].Destination, Is.EqualTo("Москва"));
			Assert.That(goodRoute[3].Source, Is.EqualTo("Москва"));
			Assert.That(goodRoute[3].Destination, Is.EqualTo("Париж"));
		}
	}
}
