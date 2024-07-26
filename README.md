# LENGUAJE: C#

## Tabla de contenido
1. [Concectos previos](#concectos-previos)  
2. [Crear proyecto de C#](#crear-proyecto-en-c)
3. [Contenidos de los proyectos](#contenidos-de-los-proyectos)
4. [CARPETA: PROJECT](#carpeta-project)
----
# Concectos previos

## ¿Que es un programa?
Un programa es un conjunto de instruciones o pasos a seguir que se le dan a un ordenador de forma secuencial para que realice una tarea especifica.

<table align="center">
  <tr border="none">
  <td width="50%" align="center">
  <h3>Flujo de un programa</h3>
  <p>1 - Recibe los datos (normalmente introducidos por el user)</p>
  <p>2 - Ejecuta las instruciones </p>
  <p>2 - Obtine resultados </p>
  
  <br></br>
  <!-- Imagen Natsu -->
  <td width="50%" align="center">
  <img  align="center"  src="https://www.areatecnologia.com/informatica/imagenes/flujo-cocinar-huevo.jpg"/>
  <br></br>
  <p>Seria un flujo de un programa</p>
  </td>
  </tr>

  </table>


# Crear varios proyectos en la misma carpeta
- Crea la carpeta raiz donde se almacenaran los proyectos.
- Abrimos la terminal:
    - Usando comando win + r > cmd.
    - Desde la propia carpeta, en la ruta remplazarla por ``cmd``.
    - O desde el editor Visual Studio Code.
- Se escribe el siguiente comando: ``dotnet new sln -n [nombre de la carpeta raiz]`` 
    - Lo que hace este comando es que se genera un archivo de solucion ``.sln`` que gestiona los multiples proyectos.
- Para la creacion de las consolas se escribe: ``dotnet new console -o [nombre del proyecto]``
- Añadimos los proyectos al archivo ``.sln``: ``dotnet sln [Nombre del archivo].sln add [proyecto]/[proyecto].csproj``
- Dentro de los proyectos escribirmos: ``dotnet build`` 
    - Esto generara las capetas de ``bin`` y ``obj``
- Ejecutar un programa: ``dotnet run`` o ``darle al ejecutador de visual stuido``

- Crear los proyectos por separado

# Contenidos de los proyectos
Los proyectos realizados en este PROYECTOSC# estan sacados de: _Aprende C# en un fin de semana._
<h3>Primera parte</h3>
- El proyecto con el nombre: _``proyecto1``_ trata de los siguientes puntos: 
    - OBJETIVO 1: Variables y constantes
    - OBJETIVO 2: Manejo de mensjaes por pantalla

- El proyecto con el nombre: _``BoolOperadores``_ trata de los siguientes puntos: 
    - OBJETIVO 3: TIPOS DE DATOS BASICOS Y OPERADORES

- El proyecto con el nombre: _``CadenaTexto``_ trata de los siguientes puntos: 
    - OBJETIVO 4: CADENAS DE TEXTO

- El proyecto con el nombre: _``Colecciones``_ trata de los siguientes puntos: 
    - OBJETIVO 5: COLECCIONES

- El proyecto con el nombre: _``FLUJO``_ trata de los siguientes puntos: 
    - OBJETIVO 6: CONTROL FLUJO DE UN PROGRAMA

- El proyecto con el nombre: _``BUCLES``_ trata de los siguientes puntos: 
    - OBJETIVO 7: BUCLES

- El proyecto con el nombre: _``FUNCIONES``_ trata de los siguientes puntos: 
    - OBJETIVO 8: FUNCIONES (_METODOS_)

<h3>Segunda parte</h3>

- El proyecto con el nombre: _``OBJETOSB``_ trata de los siguientes puntos: 
    - OBJETIVO 9: PROGRAMACION ORIENTADA A OBJETOS (BASICA)

- El proyecto con el nombre: _``OBJETOSA``_ trata de los siguientes puntos: 
    - OBJETIVO 10: PROGRAMACION ORIENTADA A OBJETOS (AVANZADA)

- El proyecto con el nombre: _``EXCEPCIONES``_ trata de los siguientes puntos: 
    - OBJETIVO 11: CONTROL DE EXCEPCIONES

- El proyecto con el nombre: _``FICHEROS``_ trata de los siguientes puntos: 
    - OBJETIVO 12: TRABAJANDO CON FICHEROS




# CARPETA: PROJECT
<h3>PRIMERA PARTE</h3>

# PROYECTO 1 - CALCULADORA

<br></br>
---
<br></br>

# PROYECTO 2 - CALCULADORA EVOLUTIVA

<h3>SEGUNDA PARTE</h3>

# PROYECTO 4 - CALCULADORA EVOLUTIVA (V2)

<br></br>
---
<br></br>

# PROYECTO FINAL - AGENDA
