
```bash
dotnet new sln;
dotnet new classlib -o Solution.Service;
dotnet sln add Solution.Service/Solution.Service.csproj;
dotnet new xunit -o Solution.UnitTests.Service;
dotnet add Solution.UnitTests.Service/Solution.UnitTests.Service.csproj reference Solution.Service/Solution.Service.csproj;
dotnet sln add Solution.UnitTests.Service/Solution.UnitTests.Service.csproj;

mv Solution.Service/Class1.cs Solution.Service/SolutionService.cs;
sed -i 's/Class1/SolutionService : ISolutionService/g' Solution.Service/SolutionService.cs;
mv Solution.UnitTests.Service/UnitTest1.cs Solution.UnitTests.Service/SolutionServiceTests.cs;
sed -i 's/Test1/SolutionServiceTests/g' Solution.UnitTests.Service/SolutionServiceTests.cs;
```