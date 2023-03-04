utilizando  el sistema ;

espacio de nombres  IngresosDeMeses
{
     programa de clase
    {
         vacío  estático principal ( cadena [] args )
        {
            PedirDatos ();
        }
        static  void  PedirDatos ()
        {
            consola _ WriteLine ( " Hola, ingresa tu nombre " );
            cadena  nombre  =  Consola . Línea de lectura ();
            consola _ WriteLine ( " Ingresa el salario de tus ultimos 3 meses " );
            int  sueldo1  =  int . Analizar ( Consola . ReadLine ());
            int  sueldo2  =  int . Analizar ( Consola . ReadLine ());
            int  sueldo3  =  int . Analizar ( Consola . ReadLine ());

            int  total  =  sueldo1  +  sueldo2  +  sueldo3 ;
            doble  promedio  =  total  /  3 . 0 ;

            consola _ WriteLine ( " Hola {0} en total ganaste {1}, y promediaste {2} " , nombre , total , promedio );
        }
    }
}