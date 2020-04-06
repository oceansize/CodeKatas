$configFiles = Get-ChildItem . *.cs -rec
foreach ($file in $configFiles)
{
    echo $file
    (Get-Content $file.PSPath) |
    Foreach-Object { $_ -replace "\[TestClass\]", "[TestFixture]" } |
    Foreach-Object { $_ -replace "\[TestInitialize\]", "[SetUp]" } |
    Foreach-Object { $_ -replace "\[TestCleanup\]", "[TearDown]" } |
    Foreach-Object { $_ -replace "\[TestMethod\]", "[Test]" } |
    Foreach-Object { $_ -replace "using Microsoft\.VisualStudio\.TestTools\.UnitTesting\;", "" } |
    Set-Content $file.PSPath
}