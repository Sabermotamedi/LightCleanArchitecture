# Clean Architecture Solution Template

[![Build](https://github.com/yourusername/your-project/workflows/Build/badge.svg)](https://github.com/yourusername/your-project/actions?query=workflow%3ABuild)
[![CodeQL](https://github.com/yourusername/your-project/workflows/CodeQL/badge.svg)](https://github.com/yourusername/your-project/actions?query=workflow%3ACodeQL)
[![Nuget](https://img.shields.io/nuget/v/Clean.Architecture.Solution.Template.svg)](https://www.nuget.org/packages/Clean.Architecture.Solution.Template/)
[![Nuget](https://img.shields.io/nuget/dt/Clean.Architecture.Solution.Template.svg)](https://www.nuget.org/packages/Clean.Architecture.Solution.Template/)
[![Discord](https://img.shields.io/discord/your-discord-id.svg)](https://discord.gg/your-discord-invite-link)
[![Twitter Follow](https://img.shields.io/twitter/follow/your-twitter-handle.svg?style=social)](https://twitter.com/your-twitter-handle)

This project serves as a template for scenarios where user authorization is implemented with Identity Server 4 and does not utilize Identity and MediatR. It provides a structured starting point for building applications that require user authentication without the complexity of a full-fledged Identity Server and the MediatR library.

If you find this project useful, please give it a star. Thanks! ⭐



## Getting Started

The easiest way to get started is to install the .NET template:

```bash
dotnet new install Clean.Architecture.Simple.Template::8.0.0
```


Once installed, create a new solution using the template. You can choose to use Angular, React, or create a Web API-only solution. Specify the client framework using the -cf or --client-framework option, and provide the output directory where your project will be created. Here are some examples:

# To create a Single-Page Application (SPA) with Angular and ASP.NET Core:
dotnet new ca-sln --client-framework Angular --output YourProjectName

# To create a SPA with React and ASP.NET Core:
dotnet new ca-sln -cf React -o YourProjectName

# To create an ASP.NET Core Web API-only solution:
dotnet new ca-sln -cf None -o YourProjectName



This project serves as a template for scenarios where user authorization is implemented with Identity Server 4 and does not utilize Identity and MediatR. It provides a structured starting point for building applications that require user authentication without the complexity of a full-fledged Identity Server and the MediatR library.

## Table of Contents

1. [Setup](#setup)
2. [Authorization with Identity Server 4](#authorization-with-identity-server-4)
3. [Not Using Identity and MediatR](#not-using-identity-and-mediatr)

## Setup

Follow these steps to set up and run the project:

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/yourusername/your-project.git
   cd your-project
