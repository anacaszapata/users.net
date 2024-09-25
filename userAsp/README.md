# Proyecto ASP.NET Core con Moq y Pruebas Unitarias

Este proyecto es una API desarrollada en __ASP.NET Core__ que permite gestionar usuarios a través de una conexión a una base de datos __MySQL__. Se ha implementado una petición `GET` para obtener la lista de usuarios, y se realizaron pruebas unitarias usando xUnit.

#### Notion
Aquí encontrarás documentación sobre el modelo y los resultados de la API.
https://bloom-addition-983.notion.site/API-xUnit-net-10c7e7bcf866809e8c2af54f9be9885c?pvs=4


---
## Tecnologías utilizadas

- ASP.NET Core
- Entity Framework Core
- MySQL
- Swagger
- xUnit
- Moq

---

## Configuración y uso

### 1. Clonar el repositorio
```bash
git clone https://github.com/anacaszapata/users.net.git
```
### 2. Crear la base de datos

Para configurar __MySQL__ localmente:

1. Inicia __XAMPP__ y asegúrate de que los servicios __Apache__ y __MySQL__ estén ejecutándose (presiona `Start`).
2. Abre el panel de administración de __MySQL__.
3. Crea una base de datos llamada `users`.
4. Crea una tabla llamada `users` con las siguientes columnas:
   - `ID`, tipo: `int`, longitud: `11`, y selecciona la casilla de __A_I__ (auto-incrementable).
   - `name`, tipo: `varchar`, longitud: `45`.
   - `email`, tipo: `varchar`, longitud: `100`.

### La configuración por defecto para MySQL es:

server=localhost;
port=3306;
user=root;
password=;
database=users;

### 3. Ejecutar el proyecto

Con el repositorio clonado, puedes ejecutar el proyecto de dos maneras:

#### Opción 1: Desde la consola
```bash
dotnet run
```
#### Opción 2: Desde Visual Studio Community
Abre el proyecto .sln en Visual Studio.
Haz clic en el botón de Play en el perfil de https.

### 4. Ejecutar las pruebas unitarias
Puedes ejecutar las pruebas unitarias de dos maneras:

#### Opción 1: Desde la consola
```bash
dotnet test
```
#### Opción 2: Desde Visual Studio Community
- Ve a Ver > Explorador de pruebas.
Ejecuta las pruebas desde el explorador de pruebas.

### Documentación de la API
#### Puedes acceder a la documentación de la API generada por Swagger en el siguiente enlace cuando la aplicación esté ejecutándose:

https://localhost:7103/swagger/index.html

#### Colección de Postman la encontrarás en el archivo
API RESTful.net.postman_collection.json






