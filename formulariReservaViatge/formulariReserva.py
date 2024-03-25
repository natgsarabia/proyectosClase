from flask import Flask, render_template, request
import os

app = Flask(__name__)

@app.route('/formulariReserva', methods=['GET', 'POST'])





def template():
    if request.method == 'POST':  
        respuesta=request.form
        name=respuesta.get('name','')
        direction=respuesta.get('direction','')
        telephone=respuesta.get('telephone','') 
        email=respuesta.get('email','') 
        destination=respuesta.get('destination','') 
        startDate=respuesta.get('startDate','') 
        endDate=respuesta.get('endDate','') 
        extraInformation=respuesta.get('extraInformation','') 
        saveInformation(name,direction,telephone,email,destination,startDate,endDate,extraInformation)
        return render_template("formularioRespuesta.html", name=name,  destination=destination, startDate=startDate,extraInformation=extraInformation )
        
    return render_template("formularioReserva.html")

def saveInformation(name,direction,telephone,email,destination,startDate,endDate,extraInformation):
    with open ('C:/Users/Natalia/Desktop/DAW/BIGDATA/exercici_formulariReservaViatge_nataliaGarcia/BaseDatosReserva.txt',  mode='a') as file:
        file.write('Reserva:\nNombre:'+name+'\nDirección: '+direction+'\nTeléfono: '+telephone+'\nEmail: '+email+'\nDestino: '+destination+'\nFecha entrada: '+startDate+'\nFecha salida: '+endDate+'\nNecesidades especiales: '+extraInformation+'\n--------------------------------------------------------\n\n')
    file.close()

    
if __name__ == '__main__':
    app.run(host='localhost', port=5000, debug=True)
