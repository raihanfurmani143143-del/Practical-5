Practical 5 — Academic Calendar & Leave Management System
=========================================================

An ASP.NET Core Razor Pages demo for student details, academic date selection,
and leave applications. The project targets .NET 8.

Features
--------
- Captures student name, student ID, department, date, leave type, and reason.
- Retains the student name in a cookie and student ID in session storage.
- Displays a confirmation after the form is submitted.

Run locally
-----------
1. Install the .NET 8 SDK.
2. From this directory, run `dotnet run`.
3. Open the local URL printed by the .NET CLI and submit the form.

Project structure
-----------------
- `Pages/Index.cshtml`: Razor form and confirmation UI.
- `Pages/Index.cshtml.cs`: form handler, cookie, and session logic.
- `Program.cs`: Razor Pages and session configuration.
- `AcademicLeaveManagement.csproj`: .NET 8 project configuration.
