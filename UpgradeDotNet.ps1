$configFiles = Get-ChildItem . *.csproj -rec
$dotnetCoreProjectFile = '<Project Sdk="Microsoft.NET.Sdk">

<PropertyGroup>
  <TargetFramework>netcoreapp3.1</TargetFramework>
</PropertyGroup>

</Project>
'
foreach ($file in $configFiles)
{
    Set-Content $file.PSPath -Value $dotnetCoreProjectFile
}