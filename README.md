# C# Bug: Accessing Disposed Object

This repository demonstrates a common error in C#: attempting to access an object after it has been disposed of using a `using` statement. This often occurs when working with unmanaged resources like database contexts or file streams.

## Bug Description

The `bug.cs` file contains code that uses a database context within a `using` block.  After the `using` block, the code attempts to use the context again, leading to an `ObjectDisposedException`. This is because the `using` statement ensures that the `Dispose()` method of the context is called, releasing the underlying resources.

## Solution

The `bugSolution.cs` file shows how to fix the issue. The solution involves making sure any access to the context is completed before exiting the `using` block or storing the data you need to use after the context is disposed.  Avoid using the `context` variable after it goes out of scope in the `using` block.