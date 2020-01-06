# MemorableExtensions
A collection of memorable C# extensions:

* _Do_ for _System.Windows.Forms.Control_ objects. It's helpfull when working with multithreading WinForm applications
* _InsituMap_ for _List<T>_ to perform a map (aka _Select_) directly on the elements of the given list
* _MyWhere_ my implementation of _Where_

**Language: C#**

**Start: 2015**

## Example

```csharp
List<string> xs = new List<string> { "a", "b", "C" };
xs.InsituMap(s => s.ToUpper());
```

xs: "A", "B", "C"

