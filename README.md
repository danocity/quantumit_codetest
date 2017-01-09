# Code Test by Alan Dano

This is a C# exercise for Quantum IT.

See the "Design Document.docx" for list of tools you need to be able to compile and run it.

Configuration Notes:

1) Edit connectionStrings section of the Web.config of RestAPI project and point the path of the SQL Server LocalDB file to the same localdb file being used by the main project: CodeTest.
Example:
<connectionStrings>
    <add name="DefaultConnection" connectionString="Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=C:\Work\QuamtumIT\CodeTest\CodeTest\App_Data\aspnet-WebApplication1-20170107103542.mdf;Initial Catalog=aspnet-WebApplication1-20170107103542;Integrated Security=True" providerName="System.Data.SqlClient" />
</connectionStrings>
  
2) Under the CodeTest project, edit the file: \Views\Shared\_Layout.cshtml and change the location of the REST API path where it is running:
Example:
  <script type="text/javascript">
        var CONFIG =
            {
                apiPath: "http://localhost:60988/api"
            };
    </script>
