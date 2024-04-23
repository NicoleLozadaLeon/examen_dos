// See https://aka.ms/new-console-template for more information
Console.WriteLine("*****CALCULADORA DE MRU Y MRUA*****");
Console.WriteLine("*Calculadora de MRU = 1");
Console.WriteLine("*Calculadora de MRUA = 2");
Console.WriteLine("Seleccione una opción (1 -2)");
int option = Convert.ToInt32(Console.ReadLine());
if( option == 1){
    Console.WriteLine("¿Que desea calcular?");
    Console.WriteLine("* Distancia = 3    * Velocidad = 4     * Tiempo = 5");
    int calculo1 = Convert.ToInt32(Console.ReadLine());

}
if( option == 2){
    Console.WriteLine("¿Que desea calcular?");
    Console.WriteLine("* Posición final = 3    *  Velocidad final = 4     * Tiempo = 5");
    int calculo2 = Convert.ToInt32(Console.ReadLine());
    
}
    //int continuar = Convert.ToInt32(Console.ReadLine()){
    //    if(continuar == 2){
    //        user = 2;
    //    } 
    //}
//while( user = 1){

//    Console.WriteLine("¿Desea realizar otra operacion?    - MRU = 1       - MRUA = 2       -NO = 3");
//    int continuar = Convert.ToInt32(Console.ReadLine()){
//        if(continuar == 2){
//            user = 2;
//        }
//    }
//}
//while (user = 2){

//    Console.WriteLine("¿Desea realizar otra operacion?     - MRU = 1       - MRUA = 2       -NO = 3");
//    int continuar = Convert.ToInt32(Console.ReadLine()){
//        if(continuar == 1){
//            user = 1;
//        }
//    }
//}