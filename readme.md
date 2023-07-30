# Tutorial para Web Scraping en Google Scholar utilizando UiPath

## Pasos:

1. **Crear un Flowchart**
   Inicia tu proyecto en UiPath creando un Flowchart. Este servirá como tu guía para determinar las tareas a seguir en tu aplicación.

2. **Tarea Input Dialog**
   Este será el primer paso en tu Flowchart. Aquí, el usuario introduce lo que quiere buscar en Google Scholar.

3. **Flow Decision**
   Después del Input Dialog, agrega un Flow Decision al Flowchart. Si el string ingresado por el usuario es vacío, vuelve al Input Dialog. De lo contrario, el proceso continua hacia la próxima tarea.

4. **Abrir Navegador**
   Ahora, añade una tarea que abra el navegador Chrome con la URL de Google Scholar.

5. **Tipear Búsqueda**
   Dentro de la página de Google Scholar, añade una tarea que tipee la cadena de búsqueda proporcionada por el usuario, asegúrate de añadir un delay entre caracteres para evitar que la página detecte que estás utilizando un bot.

6. **Guardar Navegador en Variable**
   Una vez que la búsqueda se ha realizado, añade una tarea que almacene el navegador en una variable y luego continúa a la siguiente tarea.

7. **Crear Variable currentPage**
   Ahora, debes crear una variable llamada "currentPage" para guardar la página actual de resultados de Google Scholar.

8. **Obtención de Resultados y Guardar**
   Para esta tarea, necesitarás añadir un delay en la página de resultados de Google para darle tiempo a la página de cargar todo el contenido. Luego, utiliza la actividad Find Children en el elemento con clase 'gs_bdy_ccl' para cargar cada uno de los artículos por página.

9. **Ciclo ForEach**
   Añade un ciclo ForEach para el recorrido de cada uno de estos elementos hijos.

10. **Try Catch**
    Dentro del body del ForEach, agrega un Try Catch para evitar el cierre inesperado de la aplicación.

11. **Find Children**
    Ahora, dentro del Try, añade tres tareas de Find Children para obtener el botón de guardar de cada uno de los resultados. Utiliza los filtros `<webctrl tag='DIV' class='gs_ri' />`, `<webctrl class='gs_fl gs_flb' />`, y `<webctrl class='gs_or_sav gs_or_btn' />` respectivamente para cada uno de los Find Children. Esto es con el fin de llegar a la raíz del control objetivo.

12. **Click y Selección de Biblioteca**
    Luego de obtener el botón de guardar, añade una actividad Click para que se abra la pantalla de lista de bibliotecas. Dentro de esta pantalla, selecciona la biblioteca en la cual quieres almacenar el artículo.

13. **Incrementar currentPage**
    Una vez terminado el ciclo, incrementa la variable currentPage y procede a clickear en el link de "Siguiente" para pasar a la siguiente página de resultados.

14. **Repetir el Proceso**
    Repite el proceso hasta que currentPage sea menor o igual a 5, o hasta que el usuario decida finalizarlo.

Este tutorial te ayudará a desarrollar una automatización robusta para buscar, almacenar y exportar bibtex de artículos de Google Scholar. Recuerda siempre probar y depurar tu proyecto para asegurarte de que funcione correctamente.
