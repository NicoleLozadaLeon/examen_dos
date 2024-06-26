// See https://aka.ms/new-console-template for more information

Console.WriteLine("*****CALCULADORA DE MRU Y MRUA*****"); //diseño del programa
Console.WriteLine("*Calculadora de MRU = 1");
Console.WriteLine("*Calculadora de MRUA = 2");
Console.WriteLine("Seleccione una opción (1 - 2)");
int option = Convert.ToInt32(Console.ReadLine());           //Ingresar un número = elegir una opción
while(option == 1){   //MRU: opcion ==1
    Console.WriteLine("***** BIENVENIDO A LA CALCULADORA DE MRU *****"); 
    Console.WriteLine("¿Que desea calcular?");           //diseño del programa
    Console.WriteLine("* Distancia = 1    * Velocidad = 2     * Tiempo = 3");
    int calculo1 = Convert.ToInt32(Console.ReadLine());      //Ingresar un número = elegir una opción
        switch (calculo1){
            case 1:
                Console.WriteLine("***** BIENVENIDO A LA CALCULADORA DE MRU *****");      
                Console.WriteLine("Ingrese el valor de la velocidad km/h");      
                double v3 = Convert.ToDouble(Console.ReadLine());             //Ingresar un número para cada variable
                Console.WriteLine("Ingrese el valor del tiempo en h");
                double t3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("La distancia es {0} en km ", v3 * t3);        //lógica usando la formula de la distancia
                break;
            case 2:
                Console.WriteLine("***** BIENVENIDO A LA CALCULADORA DE MRU *****");
                Console.WriteLine("Ingrese el valor de la distancia en km");
                double d4 = Convert.ToDouble(Console.ReadLine());             //Ingresar un número para cada variable
                Console.WriteLine("Ingrese el valor del tiempo en horas");
                double t4 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("La velocidad es {0} km/h", d4 / t4);          //lógica usando la formula de la velocidad
                break;
            case 3:
                Console.WriteLine("***** BIENVENIDO A LA CALCULADORA DE MRU *****");
                Console.WriteLine("Ingrese el valor de la distancia en km ");          //Ingresar un número para cada variable
                double d5 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de la velocidad km/h");
                double v5 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El tiempo es {0} horas", d5 / v5);             //lógica usando la formula del tiempo
                break;
        }
        Console.WriteLine("Desea hacer otro cálculo?:");
        Console.WriteLine("Si, de MRU = 1");
        Console.WriteLine("Si, pero de MRUA = 2");
        Console.WriteLine("No = 3");
        int continuar = Convert.ToInt32(Console.ReadLine());           //Ingresar un número = elegir una opción
        if(continuar == 2){
            option = 2;             //MRUA: opcion == 2
        }
        if(continuar == 3){
            option = 3;              //Terminar el programa: option == 3
            Console.WriteLine("Gracias por usar este programa :)");
            break;
        }
        
}

while(option == 2){     //MRUA: opcion == 2
    Console.WriteLine("***** BIENVENIDO A LA CALCULADORA DE MRUA *****");
    Console.WriteLine("¿Que desea calcular?");           //diseño del programa
    Console.WriteLine("* Posición final = 1    *  Velocidad final = 2     * Tiempo = 3");
    int calculo2 = Convert.ToInt32(Console.ReadLine());              //Ingresar un número = elegir una opción
    switch (calculo2){
        case 1:
            Console.WriteLine("***** BIENVENIDO A LA CALCULADORA DE MRUA *****");
            Console.WriteLine("Ingrese el valor de la posción inicial en metros");
            double x01 = Convert.ToDouble(Console.ReadLine());                       //Ingresar un número para cada variable
            Console.WriteLine("Ingrese el valor de la velocidad inicial en km/h");
            double v01 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del tiempo en horas");
            double t1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la aceleración en m/s2");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double ans = x01 + v01 * t1 + 0.5 * a1 * Math.Pow(t1, t1);
            Console.WriteLine($"La posición final es {ans} km");     //lógica usando la formula de la posición final
            break;
        case 2:
            Console.WriteLine("***** BIENVENIDO A LA CALCULADORA DE MRUA *****");
            Console.WriteLine("Ingrese el valor de la velocidad inicial en km/ h");
            double v02 = Convert.ToDouble(Console.ReadLine());                              //Ingresar un número para cada variable
            Console.WriteLine("Ingrese el valor de la aceleración en m/s2");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del tiempo en horas");
            double t2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("La velocidad final es {0} km/h", v02 + a2 * t2 );             //lógica usando la formula de la velocidad
            break;
        case 3:
            Console.WriteLine("***** BIENVENIDO A LA CALCULADORA DE MRUA *****");
            Console.WriteLine("Ingrese el valor de la velocidad final km/h");
            double v3 = Convert.ToDouble(Console.ReadLine());                            //Ingresar un número para cada variable
            Console.WriteLine("Ingrese el valor de la velocidad inicial en km/h");
            double v03 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la aceleración en m/s2");
            double a3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El tiempo es {0} horas", (v3 - v03) / a3 );                 //lógica usando la formula del tiempo
            break; 
    }
    Console.WriteLine("Desea hacer otro cálculo?:");
        Console.WriteLine("Si, de MRU = 1");
        Console.WriteLine("Si, pero de MRUA = 2");
        Console.WriteLine("No = 3");
        int continuar = Convert.ToInt32(Console.ReadLine());           //Ingresar un número = elegir una opción
        if(continuar == 1){           
            option = 1;             //MRU: opcion ==1
        }
        if(continuar == 3){
            option = 3;             //Terminar el programa: option == 3
            Console.WriteLine("Gracias por usar este programa :)");
            break;
        }
        
}
    