---
title: Hello, World!
date: 2018-11-28
author: Robert Sundström
tags: foo, bar
---

This is a sample post

```csharp
// A Hello World! program in C#.
using System;
namespace HelloWorld
{
    class Hello 
    {
        static void Main() 
        {
            Console.WriteLine("Hello World!");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
```