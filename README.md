# HW-Promises-of-Merge-Sort
1 Task Point

## Git Setup

To download the skeleton code for the homework assignment, use the following commands:

```bash
git clone https://github.com/CSC-3380-Class-Code/HW-Promises-of-Merge-Sort.git
```

Make sure .NET 9.0 SDK is installed: https://dotnet.microsoft.com/en-us/download/dotnet/9.0

## Background Info / Helpful Links:
-	https://www.geeksforgeeks.org/merge-sort/
-	https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1?view=net-9.0
-	https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.run?view=net-9.0
-	https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-9.0
-	https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1?view=net-9.0#methods
-	https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.skip?view=net-9.0#system-linq-enumerable-skip-1(system-collections-generic-ienumerable((-0))-system-int32)
-	https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.take?view=net-9.0#system-linq-enumerable-take-1(system-collections-generic-ienumerable((-0))-system-int32)
-	https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.tolist?view=net-9.0#system-linq-enumerable-tolist-1(system-collections-generic-ienumerable((-0)))

## NOTE:

The first build should have errors pertaining to CS0021 and CS0019. These errors mean that the functions haven’t been made yet. Aside from these errors, the function to implement throws a Not Implemented error.

Also, for this assignment, the only file you are adding code to is “./MergeSort/Program.cs”. Furthermore, whenever I refer to the “codespace”, I am referring to the “./MergeSort/” folder.

## Assignment

Provided to you are functions to run MergeSort synchronously. Your task is to implement the “List<int> SortPromise(List<int> arr)” method in addition to any other methods to help you achieve full implementation.
To fully implement SortPromise, you must program the MargeSort algorithm and make use of Promises which C# calls Tasks. The method has 1 parameter, a List<int> to sort and returns a sorted List<int>.

Given that promises allows for better utilization of hardware, there is also the expectation that the asynchronous version will compute faster on average. This is reflected in the unit tests.

HINT: Due to Tasks being a class, creating them causes a bit of overhead and will slow execution time if called too often. At some array size, it is faster to just compute MergeSort synchronously. Finding this barrier takes some experimentation, but it will be necessary to find this boundary to get your asynchronous version to take at least 70% the time of the synchronous version.

Any questions about the assignment feel free to contact me via Discord, email, or in-person.

## Testing

Whilst in the codespace, use command ‘dotnet test’ to run the unit test file.

## Submission

Upload only the Program.cs from the MergeSort folder to Moodle

## Grading

This assignment is worth 1 task point.

Part of the skeleton code you download is an NUnit test file. For this to count for the task point, all tests must be passed.
