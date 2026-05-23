¿String es un tipo por valor o un tipo por referencia?

String es un tipo por referencia, aunque se comporta de forma especial porque es inmutable. Eso significa que cuando modificamos un string, en realidad se crea un nuevo string.

¿Qué secuencias de escape tiene el tipo string?

Algunas secuencias de escape son:
\n para salto de línea
\t para tabulación
\" para escribir comillas dobles
\\ para escribir una barra invertida

¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

El carácter @ permite escribir cadenas literales, donde no hace falta escapar algunas barras. Por ejemplo: @"C:\Carpeta\Archivo"

El carácter $ permite interpolar variables dentro de una cadena. Por ejemplo:
$"Hola {nombre}"

También se pueden combinar:
$@"La ruta es {ruta}"