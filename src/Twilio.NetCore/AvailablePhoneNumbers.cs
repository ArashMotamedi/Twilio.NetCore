﻿using RestSharp;
using RestSharp.Validation;

namespace Twilio
{
	public partial class TwilioRestClient
	{
		/// <summary>
		/// Search available local phone numbers. Makes a GET request to the AvailablePhoneNumber List resource.
		/// </summary>
		/// <param name="isoCountryCode">Two-character ISO country code (US or CA)</param>
		/// <param name="options">Search filter options. Only properties with values set will be used.</param>
		public virtual AvailablePhoneNumberResult ListAvailableLocalPhoneNumbers(string isoCountryCode, AvailablePhoneNumberListRequest options)
		{
			Require.Argument("isoCountryCode", isoCountryCode);

			var request = new RestRequest();
			request.Resource = "Accounts/{AccountSid}/AvailablePhoneNumbers/{IsoCountryCode}/Local.json";
			request.AddUrlSegment("IsoCountryCode", isoCountryCode);

			AddNumberSearchParameters(options, request);

			return Execute<AvailablePhoneNumberResult>(request);
		}

		/// <summary>
		/// Search available toll-free phone numbers.  Makes a GET request to the AvailablePhoneNumber List resource.
		/// </summary>
		/// <param name="isoCountryCode">Two-character ISO country code (US or CA)</param>
		public virtual AvailablePhoneNumberResult ListAvailableTollFreePhoneNumbers(string isoCountryCode)
		{
            return ListAvailableTollFreePhoneNumbers(isoCountryCode, string.Empty);
		}

        /// <summary>
        /// Search available toll-free phone numbers.  Makes a GET request to the AvailablePhoneNumber List resource.
        /// </summary>
        /// <param name="isoCountryCode">Two-character ISO country code (US or CA)</param>
        /// <param name="contains">Value to use when filtering search. Accepts numbers or characters.</param>
		public virtual AvailablePhoneNumberResult ListAvailableTollFreePhoneNumbers(string isoCountryCode, string contains)
        {
            var options = new AvailablePhoneNumberListRequest() { Contains = contains };
            return ListAvailableTollFreePhoneNumbers(isoCountryCode, options);
        }

        /// <summary>
		/// Search available toll-free phone numbers.  Makes a GET request to the AvailablePhoneNumber List resource.
		/// </summary>
		/// <param name="isoCountryCode">Two-character ISO country code (US or CA)</param>
		/// <param name="contains">Value to use when filtering search. Accepts numbers or characters.</param>
		public virtual AvailablePhoneNumberResult ListAvailableTollFreePhoneNumbers(string isoCountryCode, AvailablePhoneNumberListRequest options)
		{
			Require.Argument("isoCountryCode", isoCountryCode);

			var request = new RestRequest();
			request.Resource = "Accounts/{AccountSid}/AvailablePhoneNumbers/{IsoCountryCode}/TollFree.json";
			request.AddUrlSegment("IsoCountryCode", isoCountryCode);

            AddNumberSearchParameters(options, request);

			return Execute<AvailablePhoneNumberResult>(request);
		}

        /// <summary>
        /// Search available mobile phone numbers.  Makes a GET request to the AvailablePhoneNumber List resource.
        /// </summary>
        /// <param name="isoCountryCode">Two-character ISO country code (US or CA)</param>
        /// <param name="options">Search filter options. Only properties with values set will be used.</param>
		public virtual AvailablePhoneNumberResult ListAvailableMobilePhoneNumbers(string isoCountryCode, AvailablePhoneNumberListRequest options)
        {
            Require.Argument("isoCountryCode", isoCountryCode);

            var request = new RestRequest();
            request.Resource = "Accounts/{AccountSid}/AvailablePhoneNumbers/{IsoCountryCode}/Mobile.json";
            request.AddUrlSegment("IsoCountryCode", isoCountryCode);

            AddNumberSearchParameters(options, request);

            return Execute<AvailablePhoneNumberResult>(request);
        }
	}
}
