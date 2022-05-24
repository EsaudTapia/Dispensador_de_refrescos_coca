import 'dart:html';


void main() {
  
  var rosco = Rosco();
  
  var primeraDefinicion = rosco.obtenerPregunta();
  var pregunta=primeraDefinicion.definicion;
  querySelector("#letra").text = pregunta;
  
}

class Rosco { 
  List<Pregunta> roscoPreguntas=[];

  //estatic es que no se destruira la informacion,
  //ya que se queda en la memoria todo el tiempo de la
  //ejecucion del sistema, mientras que una variable normal
  //se destrulle despues de su uso

  static List letras = const ["A", "B", "C", "D", "E", "F"];
  static List definiciones = const [
    "Persona que tripula una Astronave o que está entrenada para este Trabajo",
    "Especie de Talega o Saco de Tela y otro material que sirve para llevar o guardar algo",
    "Aparato destinado a registrar imágenes animadas para el cine o la telivision",
    "Obra literaria escrita para ser representada",
    "Que se prolonga muchisimo o excesivamente",
    "Laboratorio y despacho del farmaceutico"
  ];
  static List respuestas = [
    "Astronauta",
    "Bolsa",
    "Camara",
    "Drama",
    "Eterno",
    "Farmacia"
  ];
 
   Rosco(){
    
     for(var letra in letras){
        var index = letras.indexOf(letra);
        var roscoPregunta= Pregunta(letra, definiciones[index], respuestas[index]);
        roscoPreguntas.add(roscoPregunta);
     } 
     
  }
  
  
  
  Pregunta obtenerPregunta() {
    return roscoPreguntas[0];
  }

  Pregunta pasapalabra() {
    return Pregunta("", "", "");
  }

  String valuarRespuesta() {
    return '';
  }
  
 
}

class Pregunta {
  String letra = '';
  String definicion = '';
  String respuesta = '';

  Pregunta(this.letra, this.definicion, this.respuesta);
}
