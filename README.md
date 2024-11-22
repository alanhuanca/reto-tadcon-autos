# Clean Architecture Lambda API

## Descripción

Esta solución implementa una API CRUD para el modelo `Auto` utilizando Clean Architecture y desplegada en AWS Lambda. La API permite realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) sobre el modelo `Auto` y está diseñada siguiendo el patrón CQRS (Command Query Responsibility Segregation). La base de datos utilizada es MS SQL Server.

## Autor

Alan Huanca Villaverde

## Estructura del Proyecto

La solución está organizada en los siguientes proyectos:

- **Domain**: Contiene las entidades y las interfaces.
- **Application**: Contiene la lógica de negocio, los casos de uso y los validadores.
- **Infrastructure**: Contiene la implementación de las interfaces y la configuración de la base de datos.
- **API**: Contiene los controladores, los middlewares y la configuración de la API.

## Modelo `Auto`

El modelo `Auto` tiene la siguiente estructura:

```csharp
public class Auto
{
    public int Id { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Tipo { get; set; }
    public int CantidadAsientos { get; set; }
    public int AñoFabricacion { get; set; }
}
```

Configuración de la Base de Datos
La conexión a la base de datos se configura en el archivo appsettings.json del proyecto API:

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=your_server_name;Database=your_database_name;User Id=your_user_id;Password=your_password;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

## Instrucciones para Levantar el Proyecto
Prerrequisitos
.NET 8 SDK
SQL Server
AWS CLI (para desplegar en AWS Lambda)
AWS SAM CLI (para pruebas locales de Lambda)


Paso 1: Clonar el repositorio

```
git clone <URL_DEL_REPOSITORIO>
cd CleanArchitectureLambda
```

Paso 2: Configurar la cadena de conexión
Edita el archivo API/appsettings.json y actualiza la cadena de conexión con los detalles de tu base de datos SQL Server.

 

Paso 3: Crear la base de datos y aplicar migraciones

Crear una migración
```
dotnet ef migrations add InitialCreate -p Infrastructure/Infrastructure.csproj -s API/API.csproj
```

Aplicar la migración
```
dotnet ef database update -p Infrastructure/Infrastructure.csproj -s API/API.csproj
```

Paso 4: Acceder a Swagger
Una vez que la aplicación esté en ejecución, accede a Swagger en la siguiente URL:

https://localhost:5001/swagger

Paso 6: Probar los endpoints
Puedes usar herramientas como Postman o cURL para probar los endpoints de la API.

Ejemplo de prueba con cURL
GET all autos
```
curl -X GET "https://localhost:5001/api/auto" -H "accept: text/plain"
```

GET auto by ID
```
curl -X GET "https://localhost:5001/api/auto/1" -H "accept: text/plain"
```

POST create auto
```
curl -X POST "https://localhost:5001/api/auto" -H "accept: text/plain" -H "Content-Type: application/json" -d "{\"Marca\":\"Toyota\",\"Modelo\":\"Corolla\",\"Tipo\":\"Sedan\",\"CantidadAsientos\":5,\"AñoFabricacion\":2020}"
```

PUT update auto
```
curl -X PUT "https://localhost:5001/api/auto/1" -H "accept: text/plain" -H "Content-Type: application/json" -d "{\"Id\":1,\"Marca\":\"Toyota\",\"Modelo\":\"Corolla\",\"Tipo\":\"Sedan\",\"CantidadAsientos\":5,\"AñoFabricacion\":2021}"
```

DELETE auto
```
curl -X DELETE "https://localhost:5001/api/auto/1" -H "accept: text/plain"
```
