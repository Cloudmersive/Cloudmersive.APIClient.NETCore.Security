# Cloudmersive.APIClient.NETCore.Security.Api.ContentThreatDetectionApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ContentThreatDetectionAutomaticThreatDetectionString**](ContentThreatDetectionApi.md#contentthreatdetectionautomaticthreatdetectionstring) | **POST** /security/threat-detection/content/automatic/detect/string | Automatically detect threats in an input string
[**ContentThreatDetectionCheckSqlInjectionString**](ContentThreatDetectionApi.md#contentthreatdetectionchecksqlinjectionstring) | **POST** /security/threat-detection/content/sql-injection/detect/string | Check text input for SQL Injection (SQLI) attacks
[**ContentThreatDetectionCheckXxe**](ContentThreatDetectionApi.md#contentthreatdetectioncheckxxe) | **POST** /security/threat-detection/content/xxe/detect/xml/string | Protect text input from XML External Entity (XXE) attacks
[**ContentThreatDetectionDetectInsecureDeserializationJsonString**](ContentThreatDetectionApi.md#contentthreatdetectiondetectinsecuredeserializationjsonstring) | **POST** /security/threat-detection/content/insecure-deserialization/json/detect/string | Detect Insecure Deserialization JSON (JID) attacks in a string
[**ContentThreatDetectionProtectXss**](ContentThreatDetectionApi.md#contentthreatdetectionprotectxss) | **POST** /security/threat-detection/content/xss/detect/string | Protect text input from Cross-Site-Scripting (XSS) attacks through normalization


<a name="contentthreatdetectionautomaticthreatdetectionstring"></a>
# **ContentThreatDetectionAutomaticThreatDetectionString**
> StringAutomaticThreatDetection ContentThreatDetectionAutomaticThreatDetectionString (string value)

Automatically detect threats in an input string

Auto-detects a wide range of threat types in input string, including Cross-Site Scripting (XSS), SQL Injection (SQLI), XML External Entitites (XXE), Server-side Request Forgeries (SSRF), and JSON Insecure Deserialization (JID).

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Security.Api;
using Cloudmersive.APIClient.NETCore.Security.Client;
using Cloudmersive.APIClient.NETCore.Security.Model;

namespace Example
{
    public class ContentThreatDetectionAutomaticThreatDetectionStringExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | **string**| User-facing text input. | 

### Return type

[**StringAutomaticThreatDetection**](StringAutomaticThreatDetection.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contentthreatdetectionchecksqlinjectionstring"></a>
# **ContentThreatDetectionCheckSqlInjectionString**
> StringSqlInjectionDetectionResult ContentThreatDetectionCheckSqlInjectionString (string value)

Check text input for SQL Injection (SQLI) attacks

Detects SQL Injection (SQLI) attacks from text input.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Security.Api;
using Cloudmersive.APIClient.NETCore.Security.Client;
using Cloudmersive.APIClient.NETCore.Security.Model;

namespace Example
{
    public class ContentThreatDetectionCheckSqlInjectionStringExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContentThreatDetectionApi();
            var value = value_example;  // string | User-facing text input.

            try
            {
                // Check text input for SQL Injection (SQLI) attacks
                StringSqlInjectionDetectionResult result = apiInstance.ContentThreatDetectionCheckSqlInjectionString(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentThreatDetectionApi.ContentThreatDetectionCheckSqlInjectionString: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | **string**| User-facing text input. | 

### Return type

[**StringSqlInjectionDetectionResult**](StringSqlInjectionDetectionResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contentthreatdetectioncheckxxe"></a>
# **ContentThreatDetectionCheckXxe**
> StringXxeDetectionResult ContentThreatDetectionCheckXxe (string value)

Protect text input from XML External Entity (XXE) attacks

Detects XXE (XML External Entity) attacks from XML text input.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Security.Api;
using Cloudmersive.APIClient.NETCore.Security.Client;
using Cloudmersive.APIClient.NETCore.Security.Model;

namespace Example
{
    public class ContentThreatDetectionCheckXxeExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContentThreatDetectionApi();
            var value = value_example;  // string | User-facing text input.

            try
            {
                // Protect text input from XML External Entity (XXE) attacks
                StringXxeDetectionResult result = apiInstance.ContentThreatDetectionCheckXxe(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentThreatDetectionApi.ContentThreatDetectionCheckXxe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | **string**| User-facing text input. | 

### Return type

[**StringXxeDetectionResult**](StringXxeDetectionResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contentthreatdetectiondetectinsecuredeserializationjsonstring"></a>
# **ContentThreatDetectionDetectInsecureDeserializationJsonString**
> StringInsecureDeserializationJsonDetection ContentThreatDetectionDetectInsecureDeserializationJsonString (string value)

Detect Insecure Deserialization JSON (JID) attacks in a string

Detects Insecure Deserialization JSON (JID) attacks from text input.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Security.Api;
using Cloudmersive.APIClient.NETCore.Security.Client;
using Cloudmersive.APIClient.NETCore.Security.Model;

namespace Example
{
    public class ContentThreatDetectionDetectInsecureDeserializationJsonStringExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContentThreatDetectionApi();
            var value = value_example;  // string | User-facing text input.

            try
            {
                // Detect Insecure Deserialization JSON (JID) attacks in a string
                StringInsecureDeserializationJsonDetection result = apiInstance.ContentThreatDetectionDetectInsecureDeserializationJsonString(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentThreatDetectionApi.ContentThreatDetectionDetectInsecureDeserializationJsonString: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | **string**| User-facing text input. | 

### Return type

[**StringInsecureDeserializationJsonDetection**](StringInsecureDeserializationJsonDetection.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contentthreatdetectionprotectxss"></a>
# **ContentThreatDetectionProtectXss**
> StringXssProtectionResult ContentThreatDetectionProtectXss (string value)

Protect text input from Cross-Site-Scripting (XSS) attacks through normalization

Detects and removes XSS (Cross-Site-Scripting) attacks from text input through normalization.  Returns the normalized result, as well as information on whether the original input contained an XSS risk.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Security.Api;
using Cloudmersive.APIClient.NETCore.Security.Client;
using Cloudmersive.APIClient.NETCore.Security.Model;

namespace Example
{
    public class ContentThreatDetectionProtectXssExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContentThreatDetectionApi();
            var value = value_example;  // string | User-facing text input.

            try
            {
                // Protect text input from Cross-Site-Scripting (XSS) attacks through normalization
                StringXssProtectionResult result = apiInstance.ContentThreatDetectionProtectXss(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentThreatDetectionApi.ContentThreatDetectionProtectXss: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | **string**| User-facing text input. | 

### Return type

[**StringXssProtectionResult**](StringXssProtectionResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

