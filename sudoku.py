sudoku=[[8,4,9,"-",1,2,"-","-",3],[7,2,"-",4,3,8,6,"-",9],[3,6,1,9,"-",5,4,"-",8],
        [2,9,"-","-","-","-",8,"-",6],["-","-",4,"-","-","-",2,"-","-"],[1,"-",6,"-","-","-","-",3,5],
        [9,"-",2,8,"-",3,1,6,7],[6,"-",7,"-","-",9,"-","-","-"],[4,"-","-",1,6,"-","-",9,2]]

def tablero(lista):
    print("SUDOKU")
    print("columna 1 2 3   4 5 6   7 8 9")
    
    for n in range(0,3):
        print(f"fila {n+1}", end=" ")
        print(f"|{lista[n][0]}|{lista[n][1]}|{lista[n][2]}| |{lista[n][3]}|{lista[n][4]}|{lista[n][5]}| |{lista[n][6]}|{lista[n][7]}|{lista[n][8]}|")
    
    print("       _______________________")
    
    for n in range(3,6):
        print(f"fila {n+1}", end=" ")
        print(f"|{lista[n][0]}|{lista[n][1]}|{lista[n][2]}| |{lista[n][3]}|{lista[n][4]}|{lista[n][5]}| |{lista[n][6]}|{lista[n][7]}|{lista[n][8]}|")
    
    print("       _______________________")

    for n in range(6,9):
        print(f"fila {n+1}", end=" ")
        print(f"|{lista[n][0]}|{lista[n][1]}|{lista[n][2]}| |{lista[n][3]}|{lista[n][4]}|{lista[n][5]}| |{lista[n][6]}|{lista[n][7]}|{lista[n][8]}|")
    
    print("       _______________________")



def jugada(lista):
    columna=int(input("¿Escriba la columna: "))-1
    fila=int(input("¿Escriba la fila: "))-1
    numero=int(input("¿Qué número quiere colocar en esa posición?"))

    if lista[fila][columna] != "-":
        return print("Esta casilla ya esta ocupada. Pruebe de nuevo.")
    
    if numero in lista[fila]:
        return print("Esa fila ya tiene ese número. Pruebe de nuevo.")         

    if all( numero in lista[j][columna] for j in range(9)):    
        return print("Esa columna ya tiene ese número. Pruebe de nuevo.")
    
    if all(numero in lista[fila][columna+x]for x in range(3)) or all(numero in lista[fila+1][columna+x] for x in range(3)) or all(numero in lista[fila+2][columna+x] for x in range(3)):
        return print ("Ese recuadro ya contiene ese número. Pruebe de nuevo")      
                            
    return lista[fila-1][columna-1]==numero and tablero(lista)
    
    


tablero(sudoku)
while "-" not in sudoku:
    jugada(sudoku)
