Convertir AEntero ();
consola _ Clave de lectura ();

static  void  ConvertirAEntero ()
{
    consola _ WriteLine ( " Ingrese 2 numeros " );
    intentar
    {
        int  n1  =  int . Analizar ( Consola . ReadLine ());
        int  n2  =  int . Analizar ( Consola . ReadLine ());
        int  total  =  n1  +  n2 ;
        consola _ WriteLine ( " El resultado es: {0} " , total );
    }
    captura ( Excepción  c )
    {
        consola _ WriteLine ( " Ocurrio un error " );
    }
    finalmente
    {
        consola _ WriteLine ( " Programa terminado " );
    }
}