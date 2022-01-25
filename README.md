# aos_library
C# project for calculating probabilites in Age of Sigmar using .NET 6.0 and xUnit testing

## Process of creating the project

1. Create first solution, which is the furthest layer.

	dotnet new sln

2. Create class library template and add it to your solution.
	dotnet new classlib --output AosLibrary
	dotnet sln add AosApp

3. Create console application to use your class library.
	dotnet new console --output AosApp
	dotnet sln add AosApp

## Running application

	dotnet run
