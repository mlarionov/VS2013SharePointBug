VS2013SharePointBug
===================

This code reproduces Visual Studio 2013 bug.
The code compiles correctly, but try "Publish" on VisualWebPartProject1 you will get a compilation error.
This is because this project has two "additional assemblies" that also refer one to the other.
