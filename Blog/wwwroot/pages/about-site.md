---
title: About this site 
---
This entire site has been written in HTML and C#, using [Blazor](https://blazor.net/), an experimental web component framework that runs in your browser using WebAssembly. 
There is no JavaScript involved and it's fully open-source.

## How it works

The C# source code for this app has been compiled into regular .NET assemblies (.dll files). These files are downloaded by your browser when the site is being loaded. The site then loads them into an instance of the [Mono](https://www.mono-project.com/) .NET runtime that has been compiled for [WebAssembly](https://webassembly.org/) (or WASM), a web standard that is supported by modern web browsers. 

WebAssembly is a compilation target that allows for programming languages (other than JavaScript) like C/C++, Rust and C# to run in the browser.

There are some caveats to .NET on WASM due to it still being an experimental technology. I will not get into them here. However, I can mention that the download size of this app is one of them.

## Source code

The source code for this app can be found [here](https://github.com/robertsundstrom/blog).