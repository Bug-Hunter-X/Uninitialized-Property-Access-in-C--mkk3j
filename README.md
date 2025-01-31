# Uninitialized Property Access in C#

This repository demonstrates a common coding error in C#: accessing a property of a class before it has been initialized.  This can lead to unexpected `NullReferenceException` errors, especially when dealing with reference types.

## The Bug

The `bug.cs` file contains a simple class with a property and a method. The method attempts to use the property before it's given a value. If the property is a reference type and hasn't been set, a `NullReferenceException` will occur.

## The Solution

The `bugSolution.cs` file shows the corrected code.  The property is initialized either in the constructor or before it's used within the method, preventing the exception.