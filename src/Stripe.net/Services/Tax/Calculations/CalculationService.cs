// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CalculationService : Service<Calculation>,
        ICreatable<Calculation, CalculationCreateOptions>,
        IRetrievable<Calculation, CalculationGetOptions>
    {
        public CalculationService()
        {
        }

        public CalculationService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/tax/calculations";

        /// <summary>
        /// <p>Calculates tax based on the input and returns a Tax <c>Calculation</c> object.</p>.
        /// </summary>
        public virtual Calculation Create(CalculationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Calculation>(HttpMethod.Post, $"/v1/tax/calculations", options, requestOptions);
        }

        /// <summary>
        /// <p>Calculates tax based on the input and returns a Tax <c>Calculation</c> object.</p>.
        /// </summary>
        public virtual Task<Calculation> CreateAsync(CalculationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Calculation>(HttpMethod.Post, $"/v1/tax/calculations", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a Tax <c>Calculation</c> object, if the calculation hasn’t expired.</p>.
        /// </summary>
        public virtual Calculation Get(string id, CalculationGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Calculation>(HttpMethod.Get, $"/v1/tax/calculations/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a Tax <c>Calculation</c> object, if the calculation hasn’t expired.</p>.
        /// </summary>
        public virtual Task<Calculation> GetAsync(string id, CalculationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Calculation>(HttpMethod.Get, $"/v1/tax/calculations/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the line items of a tax calculation as a collection, if the calculation
        /// hasn’t expired.</p>.
        /// </summary>
        public virtual StripeList<CalculationLineItem> ListLineItems(string id, CalculationListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CalculationLineItem>>(HttpMethod.Get, $"/v1/tax/calculations/{WebUtility.UrlEncode(id)}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the line items of a tax calculation as a collection, if the calculation
        /// hasn’t expired.</p>.
        /// </summary>
        public virtual Task<StripeList<CalculationLineItem>> ListLineItemsAsync(string id, CalculationListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CalculationLineItem>>(HttpMethod.Get, $"/v1/tax/calculations/{WebUtility.UrlEncode(id)}/line_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the line items of a tax calculation as a collection, if the calculation
        /// hasn’t expired.</p>.
        /// </summary>
        public virtual IEnumerable<CalculationLineItem> ListLineItemsAutoPaging(string id, CalculationListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CalculationLineItem>($"/v1/tax/calculations/{WebUtility.UrlEncode(id)}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the line items of a tax calculation as a collection, if the calculation
        /// hasn’t expired.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<CalculationLineItem> ListLineItemsAutoPagingAsync(string id, CalculationListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CalculationLineItem>($"/v1/tax/calculations/{WebUtility.UrlEncode(id)}/line_items", options, requestOptions, cancellationToken);
        }
    }
}
