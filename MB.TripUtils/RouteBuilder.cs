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

			var srcDstDict = new Dictionary<string, string>();
			var sources = new List<string>();
			var destinations = new List<string>();
			foreach (var routeSegment in routeSegments)
			{
				if (string.IsNullOrWhiteSpace(routeSegment.Source) || string.IsNullOrWhiteSpace(routeSegment.Destination))
					continue;
				sources.Add(routeSegment.Source);
				destinations.Add(routeSegment.Destination);
				if (!srcDstDict.ContainsKey(routeSegment.Source))
					srcDstDict.Add(routeSegment.Source, routeSegment.Destination);

			}
			var start = sources.Except(destinations).FirstOrDefault();
			var result = new List<RouteSegment>();
			if (!string.IsNullOrWhiteSpace(start))
				while (srcDstDict.ContainsKey(start))
				{
					result.Add(new RouteSegment { Source = start, Destination = srcDstDict[start] });
					start = srcDstDict[start];
				}
			return result;
		}
	}
}
