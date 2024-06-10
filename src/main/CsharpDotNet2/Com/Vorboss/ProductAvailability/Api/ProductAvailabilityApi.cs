using System;
using System.Collections.Generic;
using RestSharp;
using Com.Vorboss.ProductAvailability;
using Com.Vorboss.ProductAvailability.Model;

namespace Com.Vorboss.ProductAvailability.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProductAvailabilityApi
    {
        /// <summary>
        /// Check a postcode Check which products are available at the given postcode.
        /// </summary>
        /// <param name="postcode">UK Postcode to check availability for.</param>
        /// <returns>Postcode</returns>
        Postcode ConfirmPostcode (string postcode);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ProductAvailabilityApi : IProductAvailabilityApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductAvailabilityApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ProductAvailabilityApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductAvailabilityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductAvailabilityApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Check a postcode Check which products are available at the given postcode.
        /// </summary>
        /// <param name="postcode">UK Postcode to check availability for.</param>
        /// <returns>Postcode</returns>
        public Postcode ConfirmPostcode (string postcode)
        {
            // verify the required parameter 'postcode' is set
            if (postcode == null) throw new ApiException(400, "Missing required parameter 'postcode' when calling ConfirmPostcode");
    
            var path = "/product-availability/postcode/{postcode}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "postcode" + "}", ApiClient.ParameterToString(postcode));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConfirmPostcode: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ConfirmPostcode: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Postcode) ApiClient.Deserialize(response.Content, typeof(Postcode), response.Headers);
        }
    
    }
}
