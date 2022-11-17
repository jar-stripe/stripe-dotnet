// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionCustomTextSubmit : StripeEntity<SessionCustomTextSubmit>
    {
        /// <summary>
        /// Text may be up to 500 characters in length.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
