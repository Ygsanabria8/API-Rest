API REST .Net Core - SQL Server
Para poder correr el API con otra base de datos local (SQL Server) seguir los siguientes pasos:

1. Abrir el archivo appsettings.json y en la línea número 11 cambiar el server por el server local que tenga en SQLServer
`"TicketContextConnectionString": "server=LAPTOP-66V4VMGN;database=TicketDB;Trusted_Connection=true"`
En el siguiente fragmento debes colocar tu server local
`server=LAPTOP-66V4VMGN`
2. Si te conectas a SQL Server por medio de Windows no cambies nada más, de lo contrario eliminar
`Trusted_Connection=true"`
   y agrega lo siguiente
   `User ID= [Tu usuario];Password=[Tu password];`

3. Una vez aplicado los cambios ir a:
   - Herramientas
   - Administrador de paquetes NuGet
   - Consola del administrador de paquetes
   
   Se ejecutará una terminal dentro de Visual Studio y digita lo siguiente:
   
   - Add-Migration
   
   Saldra que asignes un nombre a la migración, coloca initialMigration o el que desees, después digita lo siguiente
   
   - Update-Database
   
   Esto hará que se cree automáticamente la base de datos con los campos requeridos
   
   Para testear el API ejecuta Postman usando el URL que carga en el navegador al compilar el proyecto, y agrega lo siguiente
   
   `https://localhost:[puerto asignado]/api/tickets`
   
   Ten en cuenta que para buscar un ticket específico, eliminar un ticket o editar un ticket debe agregar `/[id Ticket]`
