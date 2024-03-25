
using System.Timers;

internal class Program
{
    static Robot [] robots=new Robot[10];
    static int totalRobots=0, option;
    private static void Main(string[] args)
    {   

        bool exit=true;
        
        while(exit){

            showMenu();

            switch(option){
                case 0:
                    Console.WriteLine("Gracias por usas nuestro programa.\n¡Adiós!");
                    exit=false;
                    break;
                
                case 1:
                    generationRobot();
                    break;

                case 2:
                    ChangeRobotValues(); //
                    break;

                case 3:
                    showEspecificRobot();
                    break;

                case 4:
                    deleteRobot();
                    totalRobots=totalRobots-1;
                    break;

                case 5:
                    showAllRobots();   
                    break;
            }

        }

        



        
    }

    struct Robot{
        public string name;
        public string model;
    }

    static int showMenu(){
        Console.WriteLine("BIENVENIDO A LA FABRICA DE ROBOT");
        Console.WriteLine("Pulse:");
        Console.WriteLine("1. Para generar un nuevo robot.");
        Console.WriteLine("2. Para cambiar los valores de un robot.");
        Console.WriteLine("3. Para ver un robot en concreto.");
        Console.WriteLine("4. Eliminar  un robot.");
        Console.WriteLine("5. mostrar todos los robots.");
        Console.WriteLine("0. Para cerrar el programa.");
        option=Convert.ToInt32(Console.ReadLine());
        return option;
    }
    static string generationName(){
        Random indexName = new Random();
        string name;
        string [] arrayAbecedario={"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
        string [] arrayNumbers={"0","1","2","3","4","5","6","7","8","9"};
        string [] arrayName=new string [5];

        for(int i=0; i<5; i++){
            if(i<2){
                arrayName[i]=arrayAbecedario[indexName.Next(26)]; //selecionar un numero index alatorio
            }else{
            arrayName[i]=arrayNumbers[indexName.Next(10)];
            
            }
        }
           name=string.Concat(arrayName); //transfomrar la array Name en un solo valor string
            return name;
    }

    static string generationModel(){
        Random indexmodel = new Random();
        string model;
        string [] arrayModels={"R2D2", "C3PO", "BBB"};
        model=arrayModels[indexmodel.Next(3)]; 
               
        return model;
    }

    static Robot generationRobot(){
        if(totalRobots==0){
            robots[totalRobots].name=generationName();
            robots[totalRobots].model=generationModel();    
            Console.WriteLine("Su robot se llama {0} y su modelo es {1}.\n",robots[totalRobots].name,robots[totalRobots].model);
            totalRobots++;

        }else if(totalRobots!=0 && totalRobots<10){
            bool duplicateName=true;
            while(duplicateName){
                string robotName=generationName();
                for (int i=0; i<totalRobots; i++){
                    if(robots[i].name!=robotName){
                        robots[totalRobots].name=robotName;
                        duplicateName=false;
                        break;
                    }        
                }
            }    
        robots[totalRobots].model=generationModel();    
        Console.WriteLine("Su robot se llama {0} y su modelo es {1}.\n",robots[totalRobots].name,robots[totalRobots].model);
        totalRobots++;
        }else{
            Console.WriteLine("Lo siento, el registro de robots está completo.\n");
        }
        return robots[totalRobots];
    }

    static void ChangeRobotValues(){
        if (totalRobots!=0){
            Console.WriteLine("Escriba la posición en la que se encuentra el robot: ");
            int position=Convert.ToInt32(Console.ReadLine())-1;
            string newName=generationName();
            string newModel=generationModel();
            robots[position].name=newName;
            robots[position].model=newModel;
            Console.WriteLine("Cambio realizado, su robot ahora será {0}, modelo es {1}.\n",robots[position].name,robots[position].model); 
        }else{
            Console.WriteLine("Todavía no hay ningún robot generado.\n");
        }             
    }

    static void showAllRobots(){    
        if(totalRobots!=0){
            Console.WriteLine("LISTADO DE ROBOTS ACTUAL:");
            for (int i=0; i<totalRobots; i++){
                Console.WriteLine("ROBOT Nº{0}", i+1);
                Console.WriteLine("Nombre: {0}", robots[i].name);
                Console.WriteLine("Modelo: {0}", robots[i].model);
                Console.WriteLine("________________________________\n");
            }   
        }else{
            Console.WriteLine("Todavía no hay ningún robot generado.\n");
        }
    }

    static void deleteRobot(){
        if(totalRobots!=0){
            Console.WriteLine("Escriba la posición en la que se encuentra el robot: ");
            int position=Convert.ToInt32(Console.ReadLine());
            int diferenciaRobots=totalRobots-position;
            for (int i=0; i<diferenciaRobots;i++){
                robots[position-1].name=robots[position].name;
                robots[position-1].model=robots[position].model;
                position++;
            }
            robots[position-1].name="";
            robots[position-1].model="";
            Console.WriteLine("Robot borrado correctamente.\n");
        }else{
            Console.WriteLine("Todavía no hay ningún robot generado.\n");
        }

    }

    static void showEspecificRobot(){
        if(totalRobots!=0){
            Console.WriteLine("Escriba la posición en la que se encuentra el robot: ");
            int position=Convert.ToInt32(Console.ReadLine())-1;
            if (position<totalRobots){
                Console.WriteLine("Esa posición pertenece al robot {0}, modelo {1}.\n",robots[position].name,robots[position].model); 
            }else{
                Console.WriteLine("no hay ningún robot en esa posición.\n");
            }
        }else{
            Console.WriteLine("Todavía no hay ningún robot generado.\n");
        }
    }

}