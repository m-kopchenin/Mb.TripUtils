using System.Collections.Generic;
using System.Linq;

namespace MB.TripUtils
{
	public static class RouteBuilder
	{
		//public static IEnumerable<RouteSegment> Build(IEnumerable<RouteSegment> routeSegments)
		//{
		//	if (routeSegments == null || !routeSegments.Any())
		//		return routeSegments;

		//	var d = new Dictionary<string, RouteSegment>();
		//	foreach (var routeSegment in routeSegments)
		//	{
		//		if (string.IsNullOrWhiteSpace(routeSegment.Source) || string.IsNullOrWhiteSpace(routeSegment.Destination))
		//			continue;
		//		RouteSegment rs;
		//		if (!d.TryGetValue(routeSegment.Destination, out rs))
		//			d.Add(routeSegment.Destination, null);
		//		d.Add(routeSegment.Source, d[routeSegment.Destination]);

		//		d.ContainsKey()

		//	}
		//	return null;
		//}

		public static IEnumerable<RouteSegment> Build(IEnumerable<RouteSegment> routeSegments)
		{
			if (routeSegments == null || !routeSegments.Any())
				return routeSegments;
			return routeSegments.OrderBy(segment => segment, new RouteSegmentComparer());
		}
	}
}
