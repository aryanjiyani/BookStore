# BookStore
I have used React &amp; Typescript for the frontend development as well as Dotnet for backend development. And for the Database I've used PostgreSQL.


# Getting Started with Create React App

This project was bootstrapped with [Create React App](https://github.com/facebook/create-react-app).

## Available Scripts

In the project directory, you can run:

### `yarn start`

Runs the app in the development mode.\
Open [http://localhost:3000](http://localhost:3000) to view it in the browser.

The page will reload if you make edits.\
You will also see any lint errors in the console.

### `yarn test`

Launches the test runner in the interactive watch mode.\
See the section about [running tests](https://facebook.github.io/create-react-app/docs/running-tests) for more information.

### `yarn build`

Builds the app for production to the `build` folder.\
It correctly bundles React in production mode and optimizes the build for the best performance.

The build is minified and the filenames include the hashes.\
Your app is ready to be deployed!

See the section about [deployment](https://facebook.github.io/create-react-app/docs/deployment) for more information.

### `yarn eject`

**Note: this is a one-way operation. Once you `eject`, you can’t go back!**

If you aren’t satisfied with the build tool and configuration choices, you can `eject` at any time. This command will remove the single build dependency from your project.

Instead, it will copy all the configuration files and the transitive dependencies (webpack, Babel, ESLint, etc) right into your project so you have full control over them. All of the commands except `eject` will still work, but they will point to the copied scripts so you can tweak them. At this point you’re on your own.

You don’t have to ever use `eject`. The curated feature set is suitable for small and middle deployments, and you shouldn’t feel obligated to use this feature. However we understand that this tool wouldn’t be useful if you couldn’t customize it when you are ready for it.

## Learn More

You can learn more in the [Create React App documentation](https://facebook.github.io/create-react-app/docs/getting-started).

To learn React, check out the [React documentation](https://reactjs.org/).

# .NET Samples

![Markdownlint](https://github.com/dotnet/samples/workflows/Markdownlint/badge.svg) [![Snippets 5000](https://github.com/dotnet/samples/actions/workflows/build-validation.yml/badge.svg)](https://github.com/dotnet/samples/actions/workflows/build-validation.yml) [![target supported version](https://github.com/dotnet/samples/actions/workflows/version-sweep.yml/badge.svg)](https://github.com/dotnet/samples/actions/workflows/version-sweep.yml)

This repo contains all the sample code that is part of any topic under
the .NET documentation. There are several different projects that
are organized in sub-folders. These sub-folders are organized similarly
to the organization of the docs for .NET. Some of the articles will have more than one sample associated with them.

The content team tracks issues for .NET documentation in the [dotnet/docs](https://github.com/dotnet/docs) and [dotnet/dotnet-api-docs](https://github.com/dotnet/dotnet-api-docs) repositories. Issues are turned off on this repository. File issues against existing samples and suggestions for new samples in those repositories. If you're not sure where, choose [dotnet/docs](https://github.com/dotnet/docs/issues). This process keeps the issues associated with the articles that explain the concepts for each sample. The best process is to file an issue from the feedback control at the bottom of each docs page:

- For existing samples, file the issue on the page with the sample.
- To suggest new samples, file the issue on the index page where you want to see the new sample.

The code in this repository represents programs that demonstrate application or library scenarios. These samples often use more than one technology, feature, or toolkit. Each sample has a readme.md file that explains the sample and links to resources for more information.

Samples should be buildable projects. Those projects should build and
run on the widest set of platforms possible for the given sample. In practice, that means building .NET Core-based console applications where possible. Samples that are specific to the web or a UI framework should add those tools as needed. Examples include web applications, mobile apps, WPF or WinForms apps, and so on.

We are working toward having a CI system in place for all code. When you make any updates to samples, make sure each update is part of a buildable
project. Ideally, add tests for correctness on samples as well.

## Building a sample

Build any .NET Core sample using the .NET Core CLI, which is installed with [the .NET Core SDK](https://www.microsoft.com/net/download). Then run
these commands from the CLI in the directory of any sample:

```console
dotnet build
dotnet run
```

These will install any needed dependencies, build the project, and run
the project respectively.

Multi-project samples have instructions in their root directory in
a `README.md` file.  

Except where noted, all samples build from the command line on
any platform supported by .NET Core. There are a few samples that are
specific to Visual Studio and require Visual Studio 2017 or later. In
addition, some samples show platform-specific features and will require
a specific platform. Other samples and snippets require the .NET Framework
and will run on Windows platforms, and will need the Developer Pack for
the target Framework version.

## Creating new samples

If you wish to add a code sample:

1. Your sample **must be part of a buildable project**. Where possible, the projects should build on all platforms supported by .NET Core. Exceptions to this are samples that demonstrate a platform-specific feature or platform-specific tool.

2. Your sample should conform to the [runtime coding style](https://github.com/dotnet/runtime/blob/main/docs/coding-guidelines/coding-style.md) to maintain consistency.

    - Additionally, we prefer the use of `static` methods rather than instance methods when demonstrating something that doesn't require instantiating a new object.

3. Your sample should include **appropriate exception handling**. It should handle all exceptions that are likely to be thrown in the context of the sample. For example, a sample that calls the [Console.ReadLine](https://docs.microsoft.com/dotnet/api/system.console.readline) method to retrieve user input should use appropriate exception handling when the input string is passed as an argument to a method. Similarly, if your sample expects a method call to fail, the resulting exception must be handled. Always handle the specific exceptions thrown by the method, rather than base class exceptions such as [Exception](https://docs.microsoft.com/dotnet/api/system.exception) or [SystemException](https://docs.microsoft.com/dotnet/api/system.systemexception).

4. If your sample builds a standalone package, you must include the runtimes used by our CI build system, in addition to any runtimes used by your sample:

    - `win7-x64`
    - `win8-x64`
    - `win81-x64`
    - `ubuntu.16.04-x64`

We will have a CI system in place to build these projects shortly.

To create a sample:

1. File an [issue](https://github.com/dotnet/docs/issues) or add a comment to an existing one that you are working on it.
2. Write the topic that explains the concepts demonstrated in your sample (example: `docs/standard/linq/where-clause.md`).
3. Write your sample (example: *WhereClause-Sample1.cs*).
4. Create a *Program.cs* with a Main entry point that calls your samples. If there is already one there, add the call to your sample:

    ```csharp
    public class Program
    {
        public void Main(string[] args)
        {
            WhereClause1.QuerySyntaxExample();

            // Add the method syntax as an example.
            WhereClause1.MethodSyntaxExample();
        }
    }
    ```

5. Don't check in the solution file if it contains only one project.

To build and run your sample:

1. Go to the sample folder and build to check for errors:

    ```console
    dotnet build
    ```

2. Run your sample:

    ```console
    dotnet run
    ```

3. Add a *README.md* to the root directory of your sample.

   This should include a brief description of the code, and refer people to the article that references the sample.
