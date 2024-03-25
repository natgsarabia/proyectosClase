import random
game={}
vidas=5

letrasAdivinadas=[] #listado de las letras dichas para no repetir
paraules=["mesa","raiz","murcielago","curso","lapiz"] #listado palabras que pueden salir


def seleccionPalabra(word,diccionario):
    for letra in word:  
        diccionario[letra]="_"   #esto sirve para crear un diccionario de la palabra elegida. Dejando los valores vacios y los index con la letra.

    for x in diccionario:
        print(diccionario[x], end=" ")  #esto sirve para imprimir los valores( solo "_") de las letras de nuestra palabra de forma continuada, sin salto de línea
        
    print("  ")



def comprobarPalabraLLena(diccionario): #esto sirve para comprobar si la palabra ya está llena.
    for x in diccionario:
        if "_" not in diccionario.values():
            return True
        else:
            return False


def comprobarPalabra(diccionario, i):   #comprobar si la palabra es correcta
    answerd=input("¿Sabe ya cúal es la palabra?")
    if answerd=="si":  
        palabraSecreta={}
        palabra=list(input("Escriba la palabra: "))
        for i,letra in enumerate(palabra):
            palabraSecreta[letra]=i


        lista1=list(diccionario.keys())
        lista2=list(palabraSecreta.keys())

        if lista1== lista2:
            return True
                 
        else:
            print("Palabra incorrecta. Siga intentandolo :)")
            return False
            

def pedirLetra(diccionario, letras ,i):  #esto sirve para pedir letras y comprobar si están en la palabra secreta.
    while i>=1: 
        letra=input("Escriba una letra: ")
        if letra in letras:
            print("Ya adiviniste esta letra, escribe otra")
            
        
        elif letra in diccionario:
            letras.append(letra)
            diccionario[letra]=letra
            if comprobarPalabraLLena(diccionario)==True:
                break
            
            for x in diccionario:
                print(diccionario[x], end=" ") 
        
            print("  ")
            
            if comprobarPalabra(diccionario,i)==True:
                break
 
        else:
            letras.append(letra)
            i=i-1
            print(f"Esa letra no se encuentra en la palabra. Le quedan {i} vidas.")
        
            for x in diccionario:
                print(diccionario[x], end=" ") 
        
            print("  ")
    if i!=0:
        print("¡Felicidades ha adivinado la palabra!")
        print("FIN DEL JUEGO")
    
    else:
        print("Lo sentimos, ha perdido.")
        print("FIN DEL JUEGO")
                  



print("Dispones de 5 vidas para adivinar la palabra, si fallas la letra se te restará una vida.")
print("¡Que comience el juego!")
word=paraules[random.randint(0,4)]
seleccionPalabra(word,game)
pedirLetra(game,letrasAdivinadas, vidas)





