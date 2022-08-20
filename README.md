# AccrontolWeb

Proyecto ciclo 3  **MisionTic2022**. 
Se necesita controlar el acceso  y login  de usuarios para una empresa con dos sedes presenciales y un grupo de trabajadores bajo la modalidad de virtualidad, se debe registrar la hora de entrada y la salida de los empleados al hacer login desde los computadores, el sistema debe contar  con una herramienta de consulta por parte de los jefes de área de la jornada laboral del día anterior por grupo o por empleado, el pantalla de consulta también debe estar disponible para los empelados pero solo pueden consultar su información, el portal también debe contar con la opción de registrar/eliminar un empleado, así como habilitar la opción de trabajo presencial/remoto para un empelado.

# Requisitos

- Los empelados están divididos en los siguientes cargos: supervisor, administrativos, desarrollo, soporteIT, servicios**.
- Los jefes de área el sistema los identifica como: (supervisor, administrativo), (supervisor, desarrollo), (supervisor, soporteIT).
- La hora de entrada  y de salida, en el sistema  solo pude ser editada por el (supervisor, administrativo).
- El sistema debe permitir el ingreso de los usuarios a la sede que tiene habilitada.
- El área de desarrollo por defecto tiene habilitado el trabajo en casa.  
- Ningún empelado puede hacer login en dos sedes al mismo tiempo, o en dos computadores.
- Al finalizar la jornada a todos los empleados en sus computadores, les aparece un mensaje en pantalla indicando que su jornada ha terminado.
- Si los empleados desean seguir laborando después de la salida deben hacer login nuevamente por el portal, en sus computadores.
- Los jefes de área  pueden consultar las horas laborados por grupo o por empleado.
- Un jefe de de otra área no puede consultar un área que no sea la suya. 
- Los empelados no pueden consultar información de sus compañeros de área o de otra área. 
- El ingreso al portal es con usuario y contraseña.
- El portal debe contar con la pantalla de consulta, solo los supervisores tienen habilitada la opción consulta por grupo. 

>  Restricciones 

- La persistencia de los datos debe ser  en una BD sql server.
- El sistema debe tener separado el front-end y el back-end, para tener las responsabilidades separadas y facilitar los cambios en el futuro. En el back-end se usarán servicios con API REST para facilitar las pruebas.

# Historias de usuario 

- **HU-01** Como supervisor-administrativo, deseo modificar la  hora de ingreso y salida.
- **HU-02** Como jefe de área,  no puedo modificar la  hora de ingreso y salida, del grupo de trabajo.
- **HU-03** Como jefe de área, deseo consultar las horas trabajadas por empleado.
- **HU-04** Como jefe de área, no puedo consultar las horas trabajadas, por empleado o por grupo de otra área.
- **HU-05** Como empleado, solo puedo consultar mi registro de horas.
- **HU-06** Como empleado, no puedo consultar  registro de horas, de otras aéreas y otros trabajadores. 
- **HU-07** Como empleado al hacer login el portal me notifica la hora de ingreso. 
- **HU-08** Como empleado a la salida el portal me notifica la hora de salida. 
- **HU-09** Como empleado solo puedo hacer login en la sede que tengo habilitada. 
- **HU-10** Como empleado si hago login en una sede que no tengo habilitada, el portal me notifica la sede que tengo habilitada.
- **HU-11** Como empleado si hago login con credenciales incorrectas, el portal me notifica que ingrese los datos nuevamente.
- **HU-12** Como empleado a la hora de salida solo presiono salir desde el portal.
- **HU-13** Como empleado puedo iniciar sesión nuevamente en el portal, si el equipo de computo se reinicia o pierdo conexión.
- **HU-14** Como empleado administrativo puedo registra un nuevo usuario en el sistema. 
- **HU-15** Como empleado administrativo puedo eliminar un  un usuario del sistema. 
- **HU-16** Como jefe de área puedo modificar la sede habilitada de un empleado  (presencial o virtual). 
