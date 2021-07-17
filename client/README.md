# Cloudmersive.APIClient.NETCore.Security - the C# library for the securityapi

The security APIs help you detect and block security threats.

This C# SDK is for the [Cloudmersive Virus Scan API](https://www.cloudmersive.com/virus-api):

- API version: v1
- SDK version: 2.0.1
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext
- UWP >=10.0

<a name="dependencies"></a>
## Dependencies
- FubarCoder.RestSharp.Portable.Core >=4.0.7
- FubarCoder.RestSharp.Portable.HttpClient >=4.0.7
- Newtonsoft.Json >=10.0.3

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Cloudmersive.APIClient.NETCore.Security.Api;
using Cloudmersive.APIClient.NETCore.Security.Client;
using Cloudmersive.APIClient.NETCore.Security.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Security.Api;
using Cloudmersive.APIClient.NETCore.Security.Client;
using Cloudmersive.APIClient.NETCore.Security.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: Apikey
            Configuration.Default.ApiKey.Add("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Apikey", "Bearer");

            var apiInstance = new ContentThreatDetectionApi();
            var value = value_example;  // string | User-facing text input.

            try
            {
                // Automatically detect threats in an input string
                StringAutomaticThreatDetection result = apiInstance.ContentThreatDetectionAutomaticThreatDetectionString(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentThreatDetectionApi.ContentThreatDetectionAutomaticThreatDetectionString: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.cloudmersive.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ContentThreatDetectionApi* | [**ContentThreatDetectionAutomaticThreatDetectionString**](docs/ContentThreatDetectionApi.md#contentthreatdetectionautomaticthreatdetectionstring) | **POST** /security/threat-detection/content/automatic/detect/string | Automatically detect threats in an input string
*ContentThreatDetectionApi* | [**ContentThreatDetectionCheckSqlInjectionString**](docs/ContentThreatDetectionApi.md#contentthreatdetectionchecksqlinjectionstring) | **POST** /security/threat-detection/content/sql-injection/detect/string | Check text input for SQL Injection (SQLI) attacks
*ContentThreatDetectionApi* | [**ContentThreatDetectionCheckXxe**](docs/ContentThreatDetectionApi.md#contentthreatdetectioncheckxxe) | **POST** /security/threat-detection/content/xxe/detect/xml/string | Protect text input from XML External Entity (XXE) attacks
*ContentThreatDetectionApi* | [**ContentThreatDetectionDetectInsecureDeserializationJsonString**](docs/ContentThreatDetectionApi.md#contentthreatdetectiondetectinsecuredeserializationjsonstring) | **POST** /security/threat-detection/content/insecure-deserialization/json/detect/string | Detect Insecure Deserialization JSON (JID) attacks in a string
*ContentThreatDetectionApi* | [**ContentThreatDetectionProtectXss**](docs/ContentThreatDetectionApi.md#contentthreatdetectionprotectxss) | **POST** /security/threat-detection/content/xss/detect/string | Protect text input from Cross-Site-Scripting (XSS) attacks through normalization
*NetworkThreatDetectionApi* | [**NetworkThreatDetectionDetectSsrfUrl**](docs/NetworkThreatDetectionApi.md#networkthreatdetectiondetectssrfurl) | **POST** /security/threat-detection/network/url/ssrf/detect | Check a URL for Server-side Request Forgery (SSRF) threats
*NetworkThreatDetectionApi* | [**NetworkThreatDetectionIsBot**](docs/NetworkThreatDetectionApi.md#networkthreatdetectionisbot) | **POST** /security/threat-detection/network/ip/is-bot | Check if IP address is a Bot client threat
*NetworkThreatDetectionApi* | [**NetworkThreatDetectionIsThreat**](docs/NetworkThreatDetectionApi.md#networkthreatdetectionisthreat) | **POST** /security/threat-detection/network/ip/is-threat | Check if IP address is a known threat
*NetworkThreatDetectionApi* | [**NetworkThreatDetectionIsTorNode**](docs/NetworkThreatDetectionApi.md#networkthreatdetectionistornode) | **POST** /security/threat-detection/network/ip/is-tor-node | Check if IP address is a Tor node server


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.IPThreatDetectionResponse](docs/IPThreatDetectionResponse.md)
 - [Model.StringAutomaticThreatDetection](docs/StringAutomaticThreatDetection.md)
 - [Model.StringInsecureDeserializationJsonDetection](docs/StringInsecureDeserializationJsonDetection.md)
 - [Model.StringSqlInjectionDetectionResult](docs/StringSqlInjectionDetectionResult.md)
 - [Model.StringXssProtectionResult](docs/StringXssProtectionResult.md)
 - [Model.StringXxeDetectionResult](docs/StringXxeDetectionResult.md)
 - [Model.ThreatDetectionBotCheckResponse](docs/ThreatDetectionBotCheckResponse.md)
 - [Model.ThreatDetectionTorNodeResponse](docs/ThreatDetectionTorNodeResponse.md)
 - [Model.UrlSsrfThreatDetectionRequestFull](docs/UrlSsrfThreatDetectionRequestFull.md)
 - [Model.UrlSsrfThreatDetectionResponseFull](docs/UrlSsrfThreatDetectionResponseFull.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Apikey"></a>
### Apikey

- **Type**: API key
- **API key parameter name**: Apikey
- **Location**: HTTP header

