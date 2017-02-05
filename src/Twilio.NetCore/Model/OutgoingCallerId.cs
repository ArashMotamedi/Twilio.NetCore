using System;

namespace Twilio
{
	/// <summary>
	/// An OutgoingCallerId instance resource represents a single Twilio OutgoingCallerId.
	/// </summary>
	public class OutgoingCallerId : TwilioBase
	{
		/// <summary>
		/// A 34 character string that uniquely identifies this resource.
		/// </summary>
		public string Sid { get; set; }
		/// <summary>
		/// The date that this resource was created
		/// </summary>
		public DateTime DateCreated { get; set; }
		/// <summary>
		/// The date that this resource last updated
		/// </summary>
		public DateTime DateUpdated { get; set; }
		/// <summary>
		/// A human readable descriptive text for this resource, up to 64 characters long. By default, the FriendlyName is a nicely formatted version of the phone number.
		/// </summary>
		public string FriendlyName { get; set; }
		/// <summary>
		/// The unique id of the Account responsible for this Caller Id.
		/// </summary>
		public string AccountSid { get; set; }
		/// <summary>
		/// The incoming phone number. Formatted with a '+' and country code e.g., +16175551212 (E.164 format).
		/// </summary>
		public string PhoneNumber { get; set; }
	}
}