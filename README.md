# Challenge Nubimetrics
## Guillermo Andrés Tolaba

### Instrucciones Web API.

Configurar el string de conexión a la base de datos del archivo `appsettings.json` y agregar la base de datos que está adjunta en la raíz del repositorio. 

Para hacer uso del endpoint de Búsqueda tendrá que acceder realizando la siguiente consulta por GET.
`http://localhost:57117/busqueda/CRITERIOBUSQUEDA`

Para hacer uso del endpoint de los Paises tendrá que acceder realizando la siguiente consulta por GET.
`http://localhost:57117/paises/AR`

## ABM Usuarios.

### Listar usuarios.
Realizar una petición GET a la siguiente dirección `http://localhost:57117/api/User/`

### Listar un usuario por ID
Realizar una petición GET a la siguiente dirección `http://localhost:57117/api/User/id`

### Creación de usuario.
Realizar una petición POST a la siguiente dirección `http://localhost:57117/api/User/` agregando además como parámetros un JSON con la siguiente estructura.
```
	{
		"nombre": "Bartholomew",
		"apellido" : "Dijkstra",
		"email": "example@gmail.com",
		"password": "Password"
	}

```
### Edición de un usuario
Realizar una petición PUT a la siguiente dirección `http://localhost:57117/api/User/id` agregando además como parámetros un JSON con la siguiente estructura.
```
	{
    "id" : IDINTEGER
		"nombre": "NombreACambiar",
		"apellido" : "ApellidoACambiar",
		"email": "emailACambiar",
		"password": "ContraseñaACambiar"
	}

```
### Eliminar un usuario
Realizar una petición DELETE a la siguiente dirección `http://localhost:57117/api/User/id`


### Instrucciones Aplicación Conversión.
Al ejecutarse realizará las consultas necesarias para guardar todo en un List, luego pasará directamente a la conversión y almacenamiento en una carpeta guardado dentro del directorio en el cual está siendo ejecutada la aplicación.
