# Com.Vorboss.ProductAvailability.Api.ProductAvailabilityApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfirmPostcode**](ProductAvailabilityApi.md#confirmpostcode) | **GET** /product-availability/postcode/{postcode} | Check a postcode

<a name="confirmpostcode"></a>
# **ConfirmPostcode**
> Postcode ConfirmPostcode (string postcode)

Check a postcode

Check which products are available at the given postcode.

### Example
```csharp
using System;
using System.Diagnostics;
using Com.Vorboss.ProductAvailability.Api;
using Com.Vorboss.ProductAvailability;
using Com.Vorboss.ProductAvailability.Model;

namespace Example
{
    public class ConfirmPostcodeExample
    {
        public void main()
        {


            var apiInstance = new ProductAvailabilityApi();
            var postcode = postcode_example;  // string | UK Postcode to check availability for.

            try
            {
                // Check a postcode
                Postcode result = apiInstance.ConfirmPostcode(postcode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductAvailabilityApi.ConfirmPostcode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postcode** | **string**| UK Postcode to check availability for. | 

### Return type

[**Postcode**](Postcode.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

