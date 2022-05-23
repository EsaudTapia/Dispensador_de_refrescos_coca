void main(){
 var vehiculo=Vehiculo('Chevy');    
  
  vehiculo.arrancar();
}

class Vehiculo{
  
 String nombre='';  
 String marca='';
 
 //Vehiculo(this.marca );
 Vehiculo(String marcas ){
   marca = marcas;
   
   
 }
  
  
  void arrancar(){
    print ('Hola soy un auto $marca y estoy arrancando');
    
  }
  
  
  void frenar(){
    print ('Hola soy un auto $marca y estoy frenando');
  }
  

}

