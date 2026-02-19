# Startup C# Console Application - Learning Guide
````````

# C# Learning Guide - Frequently Asked Questions

This guide answers common questions about C# project structure, namespaces, and method modifiers.

---

## 1. Why do we need to import `Examples.cs` into `Program.cs`?

**You DON'T need to import it!** C# automatically finds all classes in the same **namespace**. Since both files use `namespace HelloWorld`, they can see each other automatically. No import needed!

---

## 2. How was the import made exactly?

There's **NO import statement**. The connection happens through:
- **Same namespace** (`HelloWorld`)
- **Same project** (ConsoleApp1)

C# compiles all `.cs` files in your project together. If you wanted to use classes from a **different namespace**, you'd add `using`:

---

## 3. Why are the first letters capital?

This is **C# naming convention** (the standard way C# developers write code):

// PascalCase (capital first letter for each word):
class Program           // ✅ Classes
void DataTypesExample() // ✅ Methods
string FirstName        // ✅ Properties

// camelCase (lowercase first letter):
string name            // ✅ Variables
int age                // ✅ Local variables
**Why?** It makes code easier to read and helps developers instantly know what something is.

---

## 4. Why are `using System;` and `namespace HelloWorld` in both files?

**`using System;`** - Gives access to basic C# features:
namespace HelloWorld  // Your code's "family name"
{
    // All classes here belong to HelloWorld
}

**`namespace HelloWorld`** - Groups your code together:

Each file needs these because they work independently. Without them, the code wouldn't know what `Console` is or where it belongs.

---

## 5. Why `static void Main(string[] args)`?

This is the **entry point** - where your program starts:

````````markdown
**Every C# console app needs exactly ONE Main method** - it's the starting point!
static void Main(string[] args)
  │    │    │         │
  │    │    │         └─ Command line arguments (optional inputs)
  │    │    └─ Name of the method (must be "Main")
  │    └─ Returns nothing (void)
  └─ Can be called without creating an object (static)

---

## 6. Explain each concept in `public static void DataTypesExample()`

Breaking it down:
- **`public`** = Any code can call this method
- **`static`** = Call it directly: `Examples.DataTypesExample()` (no need to create an object)
- **`void`** = Doesn't return a value
- **`DataTypesExample`** = The name of the method
public static void DataTypesExample()
  │      │     │         │
  │      │     │         └─ Method name
  │      │     └─ Returns nothing
  │      └─ Can be called without creating an object
  └─ Accessible from anywhere

---

## 7. Why does `static void Main` start first and the rest is `public static void`?

Good question! Actually, `Main` **can** be public or private - C# doesn't care:

**Why make other methods `public`?**
- So they can be called from other classes
- `Main` doesn't need `public` because it's only called by the system, not your code

---

## 8. Is there a `private static void`?

**YES!** Here's an example:
    // PRIVATE - can ONLY be called inside Examples class
    private static void PrivateHelper()
    {
        Console.WriteLine("This is private - only Examples class can use me!");
    }
}


If you tried this in `Program.cs`:

### Program.cs
- Contains the `Main` method (program entry point)
- Calls methods from `Examples.cs`
- Handles user input

### Examples.cs
- Contains organized example methods
- `DataTypesExample()` - Shows different data types
- `ConstantsExample()` - Demonstrates constants
- `StringOperationsExample()` - String manipulation examples

---

## Running the Project

1. **Build**: Press `Ctrl + Shift + B`
2. **Run**: Press `F5` (with debugging) or `Ctrl + F5` (without debugging)
3. **Stop**: Press `Shift + F5` or close the console window

---

## Common Errors and Solutions

### Error: "File is locked by another process"
**Solution**: Close all console windows or press `Shift + F5` to stop the running program before rebuilding.

### Error: "The name 'Examples' does not exist"
**Solution**: Make sure both files are in the same namespace (`namespace HelloWorld`)

### Error: "More than one entry point"
**Solution**: Only one `Main` method is allowed per project

---

## Learning Resources

- [Microsoft C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [C# Naming Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- [Access Modifiers](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers)

---

## Repository

GitHub: [C-STARTING-OUT](https://github.com/samueleffiongjacob/C-STARTING-OUT)

---

**Happy Coding! 🚀**


---

## Quick Reference Tables

### Access Modifiers

| Access Modifier | Who Can Call It? |
|----------------|------------------|
| **`public`** | Anyone |
| **`private`** | Only the same class |
| **`protected`** | Same class and derived classes |
| **`internal`** | Same assembly/project |
| *(no modifier)* | Private for classes, private for methods |

### Common Keywords

| Keyword | Meaning |
|---------|---------|
| **`static`** | Call without creating object: `Examples.Method()` |
| **`void`** | Returns nothing |
| **`Main`** | Program starting point |
| **`const`** | Value cannot be changed |
| **`class`** | Blueprint for creating objects |
| **`namespace`** | Groups related classes together |

---

## Project Structure

````````
