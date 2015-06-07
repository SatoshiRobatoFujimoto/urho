
Binding
-------
Urho3D::String(string) would currently call a constructor that assumes
that the value woudl not be released, we probably need to change this
constructor to call instead String(string,length) so that it makes
its own copy

Generator
---------

String&
=======

Return values can be the new StringPtr data type, which is a wrapper
around the pointer and is implicitly convertible to string.

For calling, we need to figure out what to do here.   We could create
an on-stack String on demand based on a C# string for an overload method
and always surface the one that takes a "ref String" method.

Enumerations
============

They currently just dump the name, we need to dump the value

We should also likely dump the values as constants, and use the
constants inside real enumeration definitions (because trying to
prettify this automatically is a lot of work for little gain,
85 or so enumerations)

PInvoke generator
=================

Needs to generate unique names for the C method names, currently, we
have clashing names like these for the C functions:

String_String ()
String_String (const char *)

So for P/Invoek we need unique signatures

Rename/Remap some types
=======================
String is a bad name, because it is easy to clash, this type should 
likely be renamed to UrhoString