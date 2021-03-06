# functions-assembly-loading-catalog
The purpose of this repo is to help demonstrate some different assembly loading scenarios when using Azure Functions. Its pretty bare-bones right now - the scenarios covered are for Azure Functions v1 and include:

1. ReferenceNewerJsonNet - Referencing a newer version of JSON.NET than what is used by Azure Functions
2. ReferenceNuGetRequiringBindingRedirect - Referencing a NuGet that requires binding redirects to successfully load its own dependencies
3. ReferenceProjectThatDependsOnNewerJsonNet - Using a project reference on a .NET Standard class library that in turn depends on a newer version of JSON.NET

See [here](https://github.com/Azure/azure-functions-host/issues/992#issuecomment-366396738) for some additional context.

### Contributions Welcome

If you are having trouble using Azure Functions due to assembly loading issues, please take a look at the examples in this repo to see if your scenario is represented. If not, please consider sending a pull request!

The format is to use a separate directory + solution for each scenario as often a given scenario requires multiple projects.

