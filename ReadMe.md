# Renting construction equipment (shorthand : Rce)   
** Sample application demonstrating asp.net 5 features

## Short overview
========================================================================================================================
* MVC core 
* EF core (code first)

## What is required to run this project
========================================================================================================================
* Visual Studio 2015 with update 1 / 2 and dnx-clr-win-x86.1.0.0-rc1-update2 *(nuget package manager will install it!).
* No ReSharper or ReShaper 2016.1.1. Older versions are buggy *(ex: Ambiguous references with the exact same namespace).

## How to run tests
========================================================================================================================
0. Press F6 *(to build project), tests are set to run after build. 
1. Use "Test - Windows - Test Expolorer" select feature "Run Tests after build" and F6 (to build).
2. Right click "RunTests.ps1" select "Open with PowerShell ISE" and run.
3. Right click on test project and "Open folder in file explorer", enter "cmd" in address bar and "dnx test" to cmd.
4. ReSharper support for xunit tests is expected in ~v2016.2.

## Progress
========================================================================================================================
### v. 0.0.1 
- [x] Create web api project
- [x] Create data project
- [x] Create web api integration test project 
- [x] Add ReadMe.md
- [x] Create create failing integration test
- [x] Recover from hd failure
- [x] Push commits to GitHub
