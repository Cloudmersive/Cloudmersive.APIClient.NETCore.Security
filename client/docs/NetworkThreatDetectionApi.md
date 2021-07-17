# Cloudmersive.APIClient.NETCore.Security.Api.NetworkThreatDetectionApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NetworkThreatDetectionDetectSsrfUrl**](NetworkThreatDetectionApi.md#networkthreatdetectiondetectssrfurl) | **POST** /security/threat-detection/network/url/ssrf/detect | Check a URL for Server-side Request Forgery (SSRF) threats
[**NetworkThreatDetectionIsBot**](NetworkThreatDetectionApi.md#networkthreatdetectionisbot) | **POST** /security/threat-detection/network/ip/is-bot | Check if IP address is a Bot client threat
[**NetworkThreatDetectionIsThreat**](NetworkThreatDetectionApi.md#networkthreatdetectionisthreat) | **POST** /security/threat-detection/network/ip/is-threat | Check if IP address is a known threat
[**NetworkThreatDetectionIsTorNode**](NetworkThreatDetectionApi.md#networkthreatdetectionistornode) | **POST** /security/threat-detection/network/ip/is-tor-node | Check if IP address is a Tor node server


<a name="networkthreatdetectiondetectssrfurl"></a>
# **NetworkThreatDetectionDetectSsrfUrl**
> UrlSsrfThreatDetectionResponseFull NetworkThreatDetectionDetectSsrfUrl (UrlSsrfThreatDetectionRequestFull request)

Check a URL for Server-side Request Forgery (SSRF) threats

Checks if an input URL is at risk of being an SSRF (Server-side request forgery) threat or attack.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Security.Api;
using Cloudmersive.APIClient.NETCore.Security.Client;
using Cloudmersive.APIClient.NETCore.Security.Model;

namespace Example
{
    public class NetworkThreatDetectionDetectSsrfUrlExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new NetworkThreatDetectionApi();
            var request = new UrlSsrfThreatDetectionRequestFull(); // UrlSsrfThreatDetectionRequestFull | Input URL request

            try
            {
                // Check a URL for Server-side Request Forgery (SSRF) threats
                UrlSsrfThreatDetectionResponseFull result = apiInstance.NetworkThreatDetectionDetectSsrfUrl(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NetworkThreatDetectionApi.NetworkThreatDetectionDetectSsrfUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**UrlSsrfThreatDetectionRequestFull**](UrlSsrfThreatDetectionRequestFull.md)| Input URL request | 

### Return type

[**UrlSsrfThreatDetectionResponseFull**](UrlSsrfThreatDetectionResponseFull.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="networkthreatdetectionisbot"></a>
# **NetworkThreatDetectionIsBot**
> ThreatDetectionBotCheckResponse NetworkThreatDetectionIsBot (string value)

Check if IP address is a Bot client threat

Check if the input IP address is a Bot, robot, or otherwise a non-user entity.  Leverages real-time signals to check against known high-probability bots..

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Security.Api;
using Cloudmersive.APIClient.NETCore.Security.Client;
using Cloudmersive.APIClient.NETCore.Security.Model;

namespace Example
{
    public class NetworkThreatDetectionIsBotExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new NetworkThreatDetectionApi();
            var value = value_example;  // string | IP address to check, e.g. \"55.55.55.55\".  The input is a string so be sure to enclose it in double-quotes.

            try
            {
                // Check if IP address is a Bot client threat
                ThreatDetectionBotCheckResponse result = apiInstance.NetworkThreatDetectionIsBot(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NetworkThreatDetectionApi.NetworkThreatDetectionIsBot: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | **string**| IP address to check, e.g. \&quot;55.55.55.55\&quot;.  The input is a string so be sure to enclose it in double-quotes. | 

### Return type

[**ThreatDetectionBotCheckResponse**](ThreatDetectionBotCheckResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="networkthreatdetectionisthreat"></a>
# **NetworkThreatDetectionIsThreat**
> IPThreatDetectionResponse NetworkThreatDetectionIsThreat (string value)

Check if IP address is a known threat

Check if the input IP address is a known threat IP address.  Checks against known bad IPs, botnets, compromised servers, and other lists of threats.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Security.Api;
using Cloudmersive.APIClient.NETCore.Security.Client;
using Cloudmersive.APIClient.NETCore.Security.Model;

namespace Example
{
    public class NetworkThreatDetectionIsThreatExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new NetworkThreatDetectionApi();
            var value = value_example;  // string | IP address to check, e.g. \"55.55.55.55\".  The input is a string so be sure to enclose it in double-quotes.

            try
            {
                // Check if IP address is a known threat
                IPThreatDetectionResponse result = apiInstance.NetworkThreatDetectionIsThreat(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NetworkThreatDetectionApi.NetworkThreatDetectionIsThreat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | **string**| IP address to check, e.g. \&quot;55.55.55.55\&quot;.  The input is a string so be sure to enclose it in double-quotes. | 

### Return type

[**IPThreatDetectionResponse**](IPThreatDetectionResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="networkthreatdetectionistornode"></a>
# **NetworkThreatDetectionIsTorNode**
> ThreatDetectionTorNodeResponse NetworkThreatDetectionIsTorNode (string value)

Check if IP address is a Tor node server

Check if the input IP address is a Tor exit node server.  Tor servers are a type of privacy-preserving technology that can hide the original IP address who makes a request.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Security.Api;
using Cloudmersive.APIClient.NETCore.Security.Client;
using Cloudmersive.APIClient.NETCore.Security.Model;

namespace Example
{
    public class NetworkThreatDetectionIsTorNodeExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new NetworkThreatDetectionApi();
            var value = value_example;  // string | IP address to check, e.g. \"55.55.55.55\".  The input is a string so be sure to enclose it in double-quotes.

            try
            {
                // Check if IP address is a Tor node server
                ThreatDetectionTorNodeResponse result = apiInstance.NetworkThreatDetectionIsTorNode(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NetworkThreatDetectionApi.NetworkThreatDetectionIsTorNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | **string**| IP address to check, e.g. \&quot;55.55.55.55\&quot;.  The input is a string so be sure to enclose it in double-quotes. | 

### Return type

[**ThreatDetectionTorNodeResponse**](ThreatDetectionTorNodeResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

