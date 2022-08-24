# AccrontolWeb

Proyecto ciclo 3  **MisionTic2022**. 
Se necesita registrar el  login  de usuarios para una empresa con dos sedes presenciales y un grupo de trabajadores bajo la modalidad virtual,  el empleado registra la hora de entrada haciendo login en un portal desde su computador, la salida el empelado la registra presionando la opción de salir en el portal, el login para todos los trabajadores es con usuario y contraseña, el sistema debe contar  con una pantalla de consulta por parte de los jefes de área el cual permite filtrar por empelado o grupo, la misma pantalla de consulta también debe estar disponible para los empleados pero solo pueden filtrar su información, el portal también debe contar con la opción de registrar/eliminar un empleado, así como habilitar la opción de trabajo presencial/remoto para un empelado.

# Requisitos

- Los empleados están divididos en los siguientes cargos: supervisor, administrativos, desarrollo y soporteIT.
- Los jefes de área el sistema los identifica como: (supervisor, administrativo), (supervisor, desarrollo), (supervisor, soporteIT).
- La jornada laboral (ingreso y salida) en el sistema solo pude ser editada por el (supervisor, administrativo).
- La jornada laboral cuando se modifica aplica para todos los empelados
- El sistema debe permitir el ingreso de los usuarios a la sede que tiene habilitada.
- El área de desarrollo por defecto tiene habilitado el trabajo en casa.  
- Ningún empelado puede hacer login en dos sedes al mismo tiempo, o en dos computadores.
- Al finalizar la jornada a todos los empleados en sus computadores, les aparece un mensaje en pantalla indicando que su jornada ha terminado.
- Si los empleados desean seguir laborando después de la hora de salida deben hacer login nuevamente por el portal, en sus computadores.
- Los jefes de área pueden consultar las horas laboradas por grupo o por empleado.
- Un jefe de otra área no puede consultar un área que no sea la suya. 
- Los empleados no pueden consultar información de sus compañeros de área o de otra área. 
- El ingreso al portal es con usuario y contraseña.
- El portal debe contar con la pantalla de consulta, solo los supervisores tienen habilitada la opción consulta por grupo y consulta por empleado.


>  Restricciones 

- La persistencia de los datos debe ser  en una BD sql server.
- El sistema debe tener separado el front-end y el back-end, para tener las responsabilidades separadas y facilitar los cambios en el futuro. En el back-end se usarán servicios con API REST para facilitar las pruebas.

# Historias de usuario 

- **HU-01** Como supervisor-administrativo, puedo modificar la jornada laboral, ingreso y salida.
- **HU-02** Como jefe de área, no puedo modificar la jornada laboral.
- **HU-03** Como jefe de área, deseo consultar las horas trabajadas por empleado.
- **HU-04** Como jefe de área, no puedo consultar las horas trabajadas, por un empleado que pertenezca a otra área.
- **HU-05** Como empleado, solo puedo consultar mi registro de horas.
- **HU-06** Como empleado, no puedo consultar registro de horas de un área diferente.
- **HU-07** Como empleado al hacer login el portal me notifica la hora de ingreso. 
- **HU-08** Como empleado a la salida el portal me notifica la hora de salida. 
- **HU-09** Como empleado solo puedo hacer login en la sede que tengo habilitada. 
- **HU-10** Como empleado si hago login en una sede que no tengo habilitada, el portal me notifica la sede que tengo habilitada.
- **HU-11** Como empleado si hago login con credenciales incorrectas, el portal me notifica que ingrese los datos nuevamente.
- **HU-12** Como empleado a la hora de salida solo presiono salir del portal.
- **HU-13** Como empleado puedo iniciar sesión nuevamente en el portal, si el equipo de cómputo se reinicia o pierdo conexión.
- **HU-14** Como empleado administrativo puedo registra un nuevo trabajador en el sistema. 
- **HU-15** Como empleado administrativo puedo eliminar un trabajador del sistema. 
- **HU-16** Como jefe de área puedo modificar la sede habilitada de un empleado entre presencial o virtual.

