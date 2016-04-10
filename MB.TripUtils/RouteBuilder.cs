using System.Collections.Generic;
using System.Linq;

namespace MB.TripUtils
{
	public static class RouteBuilder
	{
		public static IEnumerable<RouteSegment> Build(IEnumerable<RouteSegment> routeSegments)
		{
			if (routeSegments == null || !routeSegments.Any())
				return routeSegments;
			return routeSegments.OrderBy(segment => segment, new RouteSegmentComparer());
		}
	}
}
