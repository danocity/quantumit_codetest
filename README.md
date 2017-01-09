# Code Test by Alan Dano

This is a C# exercise for Quantum IT.

See the "Design Document.docx" for list of tools you need to be able to compile and run it.

Configuration Notes:

1) Copy the database files from \CodeTest\App_Data folder to an external folder of your choice.

2) Edit connectionStrings section of the Web.config of both CodeTest and RestAPI projects and point the path of the DefaultConnection entry to where you copied the database files.

Example:
C:\junk\db\aspnet-WebApplication1-20170107103542.mdf

2) Under the CodeTest project, edit the file: \Views\Shared\_Layout.cshtml and change the location of the REST API path where it is running:

Example:
var CONFIG =
    {
        apiPath: "http://localhost:60988/api"
    };
