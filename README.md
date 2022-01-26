# aos_library
C# project for calculating probabilites in Age of Sigmar using .NET 6.0 and xUnit testing

## Process of creating the project

1. Create first solution, which is the furthest layer. When the name is not specified, folder's name is used.

	dotnet new sln

2. Create class library template and add it to your solution.

	dotnet new classlib --output AosLibrary
	dotnet sln add AosApp

3. Create console application to use your class library.

	dotnet new console --output AosApp
	dotnet sln add AosApp

4. Create xUnit tests template.

	dotnet new xunit --output AosApp
	dotnet sln add AosApp

5. Add reference from application to your class library

	dotnet add AosApp/AosApp.csproj reference AosLibrary/AosLibrary.csproj

## Running application

	dotnet run

### Building application

	dotnet build

## Coding practices

After consideration, I decided to name fields in classes without underscore, and decided to use "this." to seperate between the function term and variable. [Link](https://stackoverflow.com/questions/450238/to-underscore-or-to-not-to-underscore-that-is-the-question)

But then again.. [Link](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)

## Design thoughts

Deserialization JSON object to private fields is not straight-forward, so I had to create class properties & fields as public.
But then..
private setters.

I was getting nullable properties error, so I decided to make `string` fields nullable `string?` [Link](https://www.c-sharpcorner.com/blogs/nonnullable-property-must-contain-a-nonnull-value)

## Material

Readonly modifier ensures the field can only be given a value during its initialization or in its class constructor. [Link](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/readonly)

Cloning a collection [Link](https://stackoverflow.com/questions/26126660/how-do-i-clone-a-collectiont)
How to create a deep copy of a object of Dictionary class [Link](https://stackoverflow.com/questions/139592/what-is-the-best-way-to-clone-deep-copy-a-net-generic-dictionarystring-t)

MemberwiseCloning [Link](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-6.0)

Decided to use struct for Range. It has few members, and values aren't changed that much. [Link](https://www.c-sharpcorner.com/article/what-is-structure-and-when-to-use-in-c-sharp/)

Using automatic properties by defining get as public and setter as private [Link](https://softwareengineering.stackexchange.com/questions/72495/net-properties-use-private-set-or-readonly-property)

Readonly are considered more safer for the threads.[Link](https://stackoverflow.com/questions/7975661/which-is-better-between-a-readonly-modifier-and-a-private-setter)
