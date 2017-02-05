using System;
using System.Collections.Generic;

namespace Twilio
{
	/// <summary>
	/// Base class for list resource data
	/// </summary>
	public class TwilioListBase : TwilioBase
	{
		/// <summary>
		/// The current page number. Zero-indexed, so the first page is 0.
		/// </summary>
		public int Page { get; set; }
		/// <summary>
		/// How many items are in each page
		/// </summary>
		public int PageSize { get; set; }
		/// <summary>
		/// The position in the overall list of the first item in this page.
		/// </summary>
		public int Start { get; set; }
		/// <summary>
		/// The position in the overall list of the last item in this page.
		/// </summary>
		public int End { get; set; }
		/// <summary>
		/// The URI for the first page of this list.
		/// </summary>
		public Uri FirstPageUri { get; set; }
		/// <summary>
		/// The URI for the next page of this list.
		/// </summary>
		public Uri NextPageUri { get; set; }
		/// <summary>
		/// The URI for the previous page of this list.
		/// </summary>
		public Uri PreviousPageUri { get; set; }
	}
}