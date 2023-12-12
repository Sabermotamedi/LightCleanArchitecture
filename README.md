# Light Clean Architecture Solution Template

[![Nuget](https://img.shields.io/nuget/v/Clean.Architecture.Solution.Template.svg)](https://www.nuget.org/packages/Clean.Architecture.Solution.Template/)
[![Nuget](https://img.shields.io/nuget/dt/Clean.Architecture.Solution.Template.svg)](https://www.nuget.org/packages/Clean.Architecture.Solution.Template/)
[![Discord](https://img.shields.io/discord/your-discord-id.svg)](https://discord.gg/your-discord-invite-link)
[![Twitter Follow](https://img.shields.io/twitter/follow/your-twitter-handle.svg?style=social)](https://twitter.com/Saber_motamedi)

This project serves as a template for scenarios where user authorization is implemented with Identity Server 4 and does not utilize Identity and MediatR. It provides a structured starting point for building applications that require user authentication without the complexity of a full-fledged Identity Server and the MediatR library.

If you find this project useful, please give it a star. Thanks! ⭐

## Getting Started

The easiest way to get started is to install the .NET template:

```bash
dotnet new install Clean.Architecture.Light.Template::8.0.0
```


Once installed, create a new solution using the template. You can choose to use Angular, React, or create a Web API-only solution. Specify the client framework using the -cf or --client-framework option, and provide the output directory where your project will be created. Here are some examples:

# To create a Single-Page Application (SPA) with Angular and ASP.NET Core:
dotnet new cal-sln --client-framework Angular --output YourProjectName

# To create a SPA with React and ASP.NET Core:
dotnet new cal-sln -cf React -o YourProjectName

# To create an ASP.NET Core Web API-only solution:
dotnet new cal-sln -cf None -o YourProjectName


## Table of Contents

1. [Setup](#setup)
2. [Authorization with Identity Server 4](#authorization-with-identity-server-4)

# Where I you use this Template?

![Project structure](https://private-user-images.githubusercontent.com/12557356/289789327-7f98fe95-2263-4b1f-82fa-c43e08ed2bb1.jpeg?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTEiLCJleHAiOjE3MDIzNjkyMTUsIm5iZiI6MTcwMjM2ODkxNSwicGF0aCI6Ii8xMjU1NzM1Ni8yODk3ODkzMjctN2Y5OGZlOTUtMjI2My00YjFmLTgyZmEtYzQzZTA4ZWQyYmIxLmpwZWc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMxMjEyJTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMTIxMlQwODE1MTVaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT1mY2FkMzczNjExMjFmZGQ5MDM5MzNjMDMwY2IwZmYxZWJiZjQzNmQ3YmMxYzg5MmE1NmY2OWQ4ZWMwZTU4ZTI3JlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCZhY3Rvcl9pZD0wJmtleV9pZD0wJnJlcG9faWQ9MCJ9.AqcPMw955bPgLzf4IhSp9ZIly5csZleoQ1dlzZG3mXs)
