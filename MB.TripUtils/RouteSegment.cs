using System;

namespace MB.TripUtils
{
	public class RouteSegment : IComparable<RouteSegment>
	{
		public string Source { get; set; }
		public string Destination { get; set; }

		public int CompareTo(RouteSegment other)
		{
			if (ReferenceEquals(this, other))
				return 0;
			if (other == null)
				return -1;
			if (Source == other.Destination)
				return 1;
			if (Destination == other.Source)
				return -1;
			return 0;
		}
	}
}