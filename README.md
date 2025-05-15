# GeTechnologiesTest
Configuracion
Copiar la carpeta "GeTechnologies" que se encuentra dentro de la carpeta "Archivos" a "C:\"

Diagramas
Dentro de la carpeta Archivos dentro del proyecto Test, se encuentra los diagramas de flujo, secuencia y Clases

Descripción general de lo que realiza el codigo:

Lo primero al mandar llamar al metodo UpdateMonitor, de la clase MonitorUpdaterManagerSample lo que realiza es:
Obtiene una lista de procesos en ejecucion, yo estableci que obtuviera las ejecuciones de excel y si hay alguna en proceso las va a cerrar.
Posteriormente establece y crea una ruta de backup, que para mi caso la estableci en C:\GeTechnologies\MonitorUpdatesPath\tmp\Backup\{Guid.NewGuid().ToString().Replace("-", "").Substring(0, 6)}
Despues manda a llamar el metodo UpdateFiles, de la clase FileManagerSample, sobre el cual le manda valores sobre los parametros (monitorFilesLocation,installationFolder,backupPath) que son las rutas de los archivos de origen, ruta de los archivos de destino y ruta de un backup
Posteriormente este a su vez llama al metodo UpdateFiles, pero de la clase FileUpdater, que contiene toda la logica para copiar/actualizar archivos
Dentro de este metodo, primeramente vuelve a validar si existe la ruta del backup, si no existe, la crea
Despues entra a un foreach(ciclo) en la carpeta origen en donde se encuentran todos los archivos que para mi caso es en "C:\GeTechnologies\MonitorFiles" y por cada archivo que contenga la extension ".eini" mandara llamar la ejecuion del metodo ExecuteBats, la cual por el nombre, creo que refiere a ejecutar archivos .bat
Posteriormente entra a otro foreach en la misma carpeta de origen "C:\GeTechnologies\MonitorFiles" para leer todos los archivos que no contengan la extension  ".eini" y ".eend"
Por cada archivo entrara a una serie de opciones dependiendo su extension y de la cual mandara a llamar a otro metodo en donde realizara backups(cambiando extensiones de los archivos)/copiar archivos de una ruta a otra/realizar merge entre dos archivos/eliminar archivos y ejecutar archivos que deberian de ser .bat.
Cabe mencionar que existen varios procesos repetitivos, declaracion de variables sin usar, de los cuales se pudieran optimizar.
Posteriormente al termino de este procesamientos de los archivos, realizara una validacion para saber si no existio un error, en caso contrario realizara un rollback
Si todo funciono correctamente, eliminar los archivos del backup y eliminara la carpeta de los archivos de origen

