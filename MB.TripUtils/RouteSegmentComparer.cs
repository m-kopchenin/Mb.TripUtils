using System.Collections.Generic;

namespace MB.TripUtils
{
	public class RouteSegmentComparer : IComparer<RouteSegment>
	{
		public int Compare(RouteSegment x, RouteSegment y)
		{
			if (ReferenceEquals(x, y))
				return 0;
			if (x == null)
				return 1;
			if (y == null)
				return 1;
			if (x.Source == y.Destination)
				return 1;
			if (x.Destination == y.Source)
				return -1;
			return 0;
		}
	}
}