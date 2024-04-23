// See https://aka.ms/new-console-template for more information
Console.WriteLine("*****CALCULADORA DE MRU Y MRUA*****");
Console.WriteLine("*Calculadora de MRU = 1");
Console.WriteLine("*Calculadora de MRUA = 2");
Console.WriteLine("Seleccione una opción (1 -2)");
int option = Convert.ToInt32(Console.ReadLine());
while( option == 1){
    Console.WriteLine("¿Que desea calcular?");
    Console.WriteLine("* Distancia = 3    * Velocidad = 4     * Tiempo = 5");
    int calculo1 = Convert.ToInt32(Console.ReadLine());
    switch (calculo1){
        case 3:
            Console.WriteLine("Ingrese el valor de la velocidad");
            int v3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del tiempo");
            int t3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", v3 * t3);
            break;
        case 4:
            Console.WriteLine("Ingrese el valor de la distancia");
            int d4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del tiempo");
            int t4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", d4 / t4);
            break;
        case 5:
            Console.WriteLine("Ingrese el valor de la distancia");
            int d5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la velocidad");
            int v5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", d5 / v5);
            break;
    }


}
while( option == 2){
    Console.WriteLine("¿Que desea calcular?");
    Console.WriteLine("* Posición final = 6    *  Velocidad final = 7     * Tiempo = 8");
    int calculo2 = Convert.ToInt32(Console.ReadLine());
    switch (calculo2){
        case 6:
            break;
    }
    
}
    