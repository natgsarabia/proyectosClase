using System.Diagnostics;

internal class Program
{
    static bool continueGame=true;
    private static void Main(string[] args)
    {
        List<int> player1=new List<int>();
        List<int> player2=new List<int>();
        bool continueRound=true;
        int rounds=0;

        startGame(player1,player2,ref continueGame,continueRound,rounds);


        while(continueGame){
            switch(ShowGameMenu()){
            case 0:
                Console.WriteLine("Cerrando el juego.");
                continueGame=false;
                break;
            case 1:
                Console.WriteLine("TOTAL PUNTUACIONES CONSEGUIDAS");
                showScores(player1,player2);
                Console.WriteLine();
                break;

            case 2:
                Console.WriteLine("ORDENANDO LOS PUNTOS DE LOS JUGADORES:");
                player1.Sort();
                player2.Sort();
        
                showScores(player1,player2);
                Console.WriteLine();
                break;

            case 3:
                player1.Reverse();
                player2.Reverse();
                Console.WriteLine("Máxima puntuacion jugador 1: {0}",player1[0]);
                Console.WriteLine("Máxima puntuacion jugador 2: {0}\n",player2[0]);

                break;

            case 4:
                if (averageScore(player1,"Jugador 1")>averageScore(player2,"Jugador 2")){
                    Console.WriteLine("EL JUGADOR 1 HA GANADO LA PARTIDA\n");

                }else if(averageScore(player1,"Jugador 1")==averageScore(player2,"Jugador 2")){
                    Console.WriteLine("LOS JUGADORES HAN EMPATADO\n");

                }else{
                    Console.WriteLine("EL JUGADOR 2 HA GANADO LA PARTIDA\n");
                }
                
                break;
            }
        }


    }

    static bool startGame(List<int> player1,List<int> player2, ref bool continueGame,bool continueRound, int rounds){
        Console.WriteLine("En este juego durante 10 rondas cada jugador tirará un dado.");
        Console.WriteLine("El jugador que saque el dado con el número más alto ganará la ronda.");
        Console.WriteLine("Los números de las rondas ganadas de cada jugador se irán almacenando, al final del juego ganará el jugador con la media más alta.");
        Console.WriteLine("¡COMENZAMOS!");

        
        while(continueRound){
            if(rounds<10){
                Console.WriteLine("Pulse Y para empezar la ronda. Si quieren abandonar el juego pulsen N");
                string answerd=Console.ReadLine()!;
                if(answerd=="y"){
                    
                    Console.WriteLine("RONDA Nº{0}",rounds+1); 
                    bestDiceRoll(player1,player2); 
                    rounds++;
                }else if (answerd=="n"){
                    Console.WriteLine("Cerrando el juego.");
                    continueRound=false;
                    continueGame=false;
                    
        
                }else{
                    Console.WriteLine("Por favor, marque la tecla correcta.");
                }
                      
            } else if(rounds==10){
        
            Console.WriteLine("Partida finalizada.");
            continueRound=false;
                        
            }
            
        }  
        return continueGame;        
    }



//Juego de azar, cada jugador lanza un dado en su turno, el que saque el número
//más alto gana esa ronda y se anota ese punto en su lista.
    static void bestDiceRoll(List<int> player1,List<int> player2){ 
        Random randomNumber = new Random();
        int dice1 = randomNumber.Next(1,7);
        int gamePlayer1=dice1;
        Console.WriteLine("TIRADA JUGADOR 1\nDADO: {0}",dice1);
        int dice2 = randomNumber.Next(1,7);
        int gamePlayer2=dice2;
        Console.WriteLine("TIRADA JUGADOR 2\nDADO: {0}",dice2);
        if (gamePlayer1>gamePlayer2){
            player1.Add(dice1);
            Console.WriteLine("             ***             ");
            Console.WriteLine("JUGADOR 1 HA GANADO ESTA RONDA");
        }else if(gamePlayer1==gamePlayer2){
            player1.Add(dice1);
            player2.Add(dice2);
            Console.WriteLine("             ***             ");
            Console.WriteLine("LOS JUGADORES HAN EMPATADO.\nSe guardan ambas puntuaciones.");
        
        }else{
            player2.Add(dice2);
            Console.WriteLine("             ***             ");
            Console.WriteLine("JUGADOR 2 HA GANADO ESTA RONDA");
        }
        Console.WriteLine("             ***             ");

    }

    static void showScores(List<int> player1,List<int> player2){
        Console.WriteLine("PUNTUACIÓN JUGADOR 1:");
        foreach(int points in player1) Console.WriteLine(points);
        Console.WriteLine("____________________________________");
        Console.WriteLine("PUNTUACIÓN JUGADOR 2:");
        foreach(int points in player2) Console.WriteLine(points);
    }

    //Calcular media de todas las puntuaciones conseguidas
    static int averageScore(List<int> playerPoints, string player){
        int resultPlayer=0;
        foreach(int points in playerPoints){
             resultPlayer+=points;  
        }
        int totalScoresDone=playerPoints.Count();
        int averagePlayer=resultPlayer/totalScoresDone;
        Console.WriteLine("La media de puntos del jugador {0} es: {1}",player,averagePlayer);
        return averagePlayer;

    }


    static int ShowGameMenu(){
        Console.WriteLine("MENU FINAL DEL JUEGO:");
        Console.WriteLine("Pulse 1 para ver las puntuaciones conseguidas durante el juego.");
        Console.WriteLine("Pulse 2 para ordenar las puntuciones de menor a mayor de cada jugador.");
        Console.WriteLine("Pulse 3 para ver la mejor puntuación de cada jugador.");
        Console.WriteLine("Pulse 4 para ver las medias de las puntaciones de cada jugador.");
        Console.WriteLine("Pulse 0 para salir del juego");
        int option=Convert.ToInt32(Console.ReadLine()!);
        return option;
    }
}