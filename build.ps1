﻿Remove-Item –path ./client –recurse
& java -jar swagger-codegen-cli-2.4.12.jar generate -i https://api.cloudmersive.com/swagger/api/security -l csharp -o client -c packageconfig.json
#(Get-Content ./client/src/api/ConvertDocumentApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertDocumentApi.js
#(Get-Content ./client/src/api/ConvertWebApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertWebApi.js
#& npm build ./client






(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.Security/Cloudmersive.APIClient.NETCore.Security.csproj).replace('<Authors>Swagger</Authors>', "<Authors>Cloudmersive</Authors>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.Security/Cloudmersive.APIClient.NETCore.Security.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.Security/Cloudmersive.APIClient.NETCore.Security.csproj).replace('<Company>Swagger</Company>', "<Company>Cloudmersive</Company>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.Security/Cloudmersive.APIClient.NETCore.Security.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.Security/Cloudmersive.APIClient.NETCore.Security.csproj).replace('<AssemblyTitle>Swagger Library</AssemblyTitle>', "<AssemblyTitle>Cloudmersive Virus Scan API Client</AssemblyTitle>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.Security/Cloudmersive.APIClient.NETCore.Security.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.Security/Cloudmersive.APIClient.NETCore.Security.csproj).replace('<Description>A library generated from a Swagger doc</Description>', "<Description>Virus Scan API lets you scan files and content for viruses and identify security issues with content.</Description>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.Security/Cloudmersive.APIClient.NETCore.Security.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.Security/Cloudmersive.APIClient.NETCore.Security.csproj).replace('<TargetFramework>net45</TargetFramework>', "<TargetFramework>netcoreapp2.1</TargetFramework>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.Security/Cloudmersive.APIClient.NETCore.Security.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.Security/Cloudmersive.APIClient.NETCore.Security.csproj).replace('</PropertyGroup>', "<PackageIconUrl>https://cloudmersive.com/images/cmsdk_core.png</PackageIconUrl><PackageLicenseExpression>Apache-2.0</PackageLicenseExpression><PackageProjectUrl>https://cloudmersive.com/virus-api</PackageProjectUrl></PropertyGroup>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.Security/Cloudmersive.APIClient.NETCore.Security.csproj
(Get-Content '.\client\src\Cloudmersive.APIClient.NETCore.Security\Cloudmersive.APIClient.NETCore.Security.csproj').replace('<PackageReference Include="RestSharp" Version="105.1.0" />', '<PackageReference Include="RestSharp" Version="106.6.10" />') | Set-Content '.\client\src\Cloudmersive.APIClient.NETCore.Security\Cloudmersive.APIClient.NETCore.Security.csproj'
(Get-Content '.\client\src\Cloudmersive.APIClient.NETCore.Security\Client\ApiClient.cs').replace('request.AddFile(param.Value.Name, param.Value.Writer, param.Value.FileName, param.Value.ContentType);', 'request.AddFile(param.Value.Name, param.Value.Writer, param.Value.FileName, param.Value.ContentLength, param.Value.ContentType);') | Set-Content '.\client\src\Cloudmersive.APIClient.NETCore.Security\Client\ApiClient.cs'


(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.Security/Cloudmersive.APIClient.NETCore.Security.csproj).replace('</ItemGroup>', '</ItemGroup><Target Name="PostBuild" AfterTargets="PostBuildEvent">    <Exec Command="call powershell C:\CodeSigning\sign.ps1  $(TargetPath)" />  </Target>') | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.Security/Cloudmersive.APIClient.NETCore.Security.csproj


& dotnet build ./client/src/Cloudmersive.APIClient.NETCore.Security/Cloudmersive.APIClient.NETCore.Security.csproj -c Release
& dotnet pack ./client/src/Cloudmersive.APIClient.NETCore.Security/Cloudmersive.APIClient.NETCore.Security.csproj -c Release

(Get-Content ./client/README.md).replace(' automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project', " for the [Cloudmersive Virus Scan API](https://www.cloudmersive.com/virus-api)") | Set-Content ./client/README.md

Copy-Item ./client/README.md ./README.md