# Com.Vorboss.ProductAvailability - the C# library for the Vorboss Product Availability API

This API is provided by Vorboss to allow customers to check which products are available at a given postcode.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 0.2.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.v3.generators.dotnet.CsharpDotNet2ClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 2.0

<a name="dependencies"></a>
## Dependencies
- Mono compiler
- Newtonsoft.Json.7.0.1
- RestSharp.Net2.1.1.11

Note: NuGet is downloaded by the mono compilation script and packages are installed with it. No dependency DLLs are bundled with this generator

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh compile-mono.sh`
- [Windows] `./Install.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Com.Vorboss.ProductAvailability.Api;
using Com.Vorboss.ProductAvailability;
using Com.Vorboss.ProductAvailability.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Com.Vorboss.ProductAvailability.Api;
using Com.Vorboss.ProductAvailability;
using Com.Vorboss.ProductAvailability.Model;

namespace Example
{
    public class Example
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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to */*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ProductAvailabilityApi* | [**ConfirmPostcode**](docs/ProductAvailabilityApi.md#confirmpostcode) | **GET** /product-availability/postcode/{postcode} | Check a postcode

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Com.Vorboss.ProductAvailability.Model.Postcode](docs/Postcode.md)
 - [Com.Vorboss.ProductAvailability.Model.PostcodeAvailableProducts](docs/PostcodeAvailableProducts.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="bearerAuth"></a>
### bearerAuth


