// use csi to interactively run this file
// use #load "adhoc.csx" to dynamically load defintions in this file


using System;

// Example 1: Value Types
static void ValueTypesExample()
{
    int a = 10;
    int b = a;
    b = 20;
    Console.WriteLine($"Value Types Example: a = {a}, b = {b}"); // a = 10, b = 20
}

// Example 2: Reference Types
static void ReferenceTypesExample()
{
    var arr1 = new int[] { 1, 2, 3 };
    var arr2 = arr1;
    arr2[0] = 10;
    Console.WriteLine($"Reference Types Example: arr1[0] = {arr1[0]}, arr2[0] = {arr2[0]}"); // arr1[0] = 10, arr2[0] = 10
}

// Example 3: Garbage Collection
static void GarbageCollectionExample()
{
    var obj = new object();
    var weakRef = new WeakReference(obj);
    obj = null;
    GC.Collect();
    Console.WriteLine($"Garbage Collection Example: Is object alive? {weakRef.IsAlive}"); // False
}

// Example 4: Passing by Reference
static void PassingByReferenceExample()
{
    int x = 5;
    ModifyValue(ref x);
    Console.WriteLine($"Passing by Reference Example: x = {x}"); // x = 10
}

static void ModifyValue(ref int i)
{
    i = 10;
}

// Run all examples
ValueTypesExample();
ReferenceTypesExample();
GarbageCollectionExample();
PassingByReferenceExample();