# Cloudmersive.APIClient.NETCore.Security.Model.StringAutomaticThreatDetection
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Successful** | **bool?** | True if the operation was successful, false otherwise | [optional] 
**CleanResult** | **bool?** |  | [optional] 
**ContainedJsonInsecureDeserializationAttack** | **bool?** | True if the input contained Insecure Deserialization JSON, false otherwise | [optional] 
**ContainedXssThreat** | **bool?** | True if the input contained XSS attack, false otherwise | [optional] 
**ContainedXxeThreat** | **bool?** | True if the input contained XXE attack, false otherwise | [optional] 
**ContainedSqlInjectionThreat** | **bool?** | True if the input contained SQL Injection attack, false otherwise | [optional] 
**ContainedSsrfThreat** | **bool?** | True if the input contained an Server-Side Request Forgery (SSRF) URL attack, false otherwise | [optional] 
**IsXML** | **bool?** | True if the input string is XML, false otherwise | [optional] 
**IsJSON** | **bool?** | True if the input string is JSON, false otherwise | [optional] 
**IsURL** | **bool?** | True if the input string is a URL, false otherwise | [optional] 
**OriginalInput** | **string** | Original input string | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

