using System.Runtime.InteropServices;

internal class Program
{

    
    // static Product [,] stock=new Product[2,10];
    // static string [] category=["food","others"];
    // static int totalFood=0, totalOthers=0;
	// static void Main(string[] arg){

    //     bool exit=true;
        
    //     while(exit){
    
    //         switch(showMenu()){
    //             case 0:
    //                 Console.WriteLine("Gracias por usas nuestro programa.\n¡Adiós!");
    //                 exit=false;
    //                 break;         
                
    //             case 1:
    //                 addProduct();
    //                 break;

    //             case 2:
    //                 deleteProduct(); 
    //                 break;

    //             case 3:
    //                 ChangeproductsValues();
    //                 break;

    //             case 4:
    //                 showAllProduct();
    //                 break;

    //             case 5:
    //                 showCategoryProducts();   
    //                 break;
    //         }
    //     }
		
     
                       

	//     }	
    //     struct Product{
    //     public string name;
    //     public string category;
    //     public decimal price;
    //     public int quantity;
    // }

    //     static int showMenu(){
    //     Console.WriteLine("BIENVENIDO A CONTROL ESTOC CATÁLOGO:");
    //     Console.WriteLine("Pulse:");
    //     Console.WriteLine("1. Para agregar un producto.");
    //     Console.WriteLine("2. Para eliminar  un producto.");
    //     Console.WriteLine("3. Para modificar valores de un producto.");
    //     Console.WriteLine("4. Para mostrar todos los productos introducidos en el catálogo.");
    //     Console.WriteLine("5. Para ver los productos de una categoria en concreto");
    //     Console.WriteLine("0. Para cerrar el programa.");
    //     int option=Convert.ToInt32(Console.ReadLine());
    //     return option;
    // }


    // static void addProduct(){
    //    bool newProduct=true;
    //     while(newProduct){
    //         Console.WriteLine("¿En qué categoria quiere añadir el producto?\nPulse 1 para alimentación y 2 para otros.");
    //         int answerd=Convert.ToInt32(Console.ReadLine())-1;
    //         if(answerd==0){
    //             if(totalFood<10){
    //                 Console.Write("Escriba el nombre del producto: ");
    //                 stock[answerd,totalFood].name=Console.ReadLine()!;
    //                 Console.Write("Escriba el precio del producto: ");
    //                 stock[answerd,totalFood].price=Convert.ToDecimal(Console.ReadLine());
    //                 Console.Write("Escriba el estoc del producto: ");
    //                 stock[answerd,totalFood].quantity=Convert.ToInt32(Console.ReadLine());
    //                 stock[answerd,totalFood].category=category[answerd];
    //                 totalFood++;
    //                 newProduct= false;
    //             }else{
    //                 Console.WriteLine("El estoc de alimentación está completo.");
    //                 newProduct= false;
    //             }

    //         }else if (answerd==1){
    //             if(totalOthers<10){
    //                 Console.Write("Escriba el nombre del producto: ");
    //                 stock[answerd,totalOthers].name=Console.ReadLine()!;
    //                 Console.Write("Escriba el precio del producto: ");
    //                 stock[answerd,totalOthers].price=Convert.ToDecimal(Console.ReadLine());
    //                 Console.Write("Escriba el estoc del producto: ");
    //                 stock[answerd,totalOthers].quantity=Convert.ToInt32(Console.ReadLine());
    //                 stock[answerd,totalOthers].category=category[answerd];
    //                 totalOthers++;
    //                 newProduct= false;
    //             }else{
    //                 Console.WriteLine("El estoc de otros productos está completo.");
    //                 newProduct= false;
    //             }          

    //         }else{
    //             Console.WriteLine("Valor incorrecto. Pruebe de nuevo.");            
    //         }
    //     }
    // }

    // static void deleteProduct(){
    //     bool deleteProduct=true;
    //     while(deleteProduct){
    //         Console.WriteLine("¿A qué categoría pertenece el producto que quiere borrar?\nPulse 1 para alimentación y 2 para otros.");
    //         int answerdCategory=Convert.ToInt32(Console.ReadLine())-1;
    //         if(answerdCategory==0){
    //             if(totalFood!=0){
    //                 Console.WriteLine("¿En que posición se encuentra el producto que quiere eliminar?");
    //                 int position=Convert.ToInt32(Console.ReadLine());
    //                 int diferenciaEstoc=totalFood-position;
    //                 for (int i=0; i<diferenciaEstoc;i++){
    //                     stock[answerdCategory,position-1].name=stock[answerdCategory,position].name;
    //                     stock[answerdCategory,position-1].price=stock[answerdCategory,position].price;
    //                     stock[answerdCategory,position-1].quantity=stock[answerdCategory,position].quantity; 
    //                     position++;     
    //                 }
    //                 stock[answerdCategory,position-1].name="";
    //                 stock[answerdCategory,position-1].price=0;
    //                 stock[answerdCategory,position-1].quantity=0;
    //                 stock[answerdCategory,position-1].category="";
    //                 Console.WriteLine("Producto borrado correctamente.\n");
    //                 totalFood=totalFood-1;
    //                 deleteProduct= false;
    //             }else{
    //                 Console.WriteLine("Aún no hay productos introducidos en esta categoría");
    //                 deleteProduct= false;
    //             }

    //         }else if (answerdCategory==1){
    //             if(totalOthers!=0){
    //                 Console.WriteLine("¿En que posición se encuentra el producto que quiere eliminar?");
    //                 int position=Convert.ToInt32(Console.ReadLine());
    //                 int diferenciaEstoc=totalOthers-position;
    //                 for (int i=0; i<diferenciaEstoc;i++){
    //                     stock[answerdCategory,position-1].name=stock[answerdCategory,position].name;
    //                     stock[answerdCategory,position-1].price=stock[answerdCategory,position].price;
    //                     stock[answerdCategory,position-1].quantity=stock[answerdCategory,position].quantity; 
    //                     position++;     
    //                 }
    //                 stock[answerdCategory,position-1].name="";
    //                 stock[answerdCategory,position-1].price=0;
    //                 stock[answerdCategory,position-1].quantity=0;
    //                 stock[answerdCategory,position-1].category="";
    //                 Console.WriteLine("Producto borrado correctamente.\n");
    //                 totalOthers=totalOthers-1;
    //                 deleteProduct= false;
    //             }else{
    //                 Console.WriteLine("Aún no hay productos introducidos en esta categoría");
    //                 deleteProduct= false;
    //             }         

    //         }else{
    //             Console.WriteLine("Valor incorrecto. Pruebe de nuevo.");            
    //         }
    //     }
    // }

    // static void ChangeproductsValues(){
    //     bool modifyProduct=true;
    //     while(modifyProduct){
    //         Console.WriteLine("¿A qué categoría pertenece el producto que quiere borrar?\nPulse 1 para alimentación y 2 para otros.");
    //         int answerdCategory=Convert.ToInt32(Console.ReadLine())-1;
    //         Console.WriteLine("¿En que posición se encuentra el producto que quiere eliminar?");
    //         int position=Convert.ToInt32(Console.ReadLine());
    //         if(answerdCategory==0){
    //             if(totalFood!=0){
    //                 Console.Write("Escriba el nuevo nombre del producto");
    //                 stock[answerdCategory,position-1].name=Console.ReadLine()!;
    //                 Console.Write("Escriba el nuevo precio del producto:");
    //                 stock[answerdCategory,position-1].price=Convert.ToDecimal(Console.ReadLine()!);
    //                 Console.Write("Escriba el nuevo estoc del producto:");
    //                 stock[answerdCategory,position-1].quantity=Convert.ToInt32(Console.ReadLine()!);
    //                 modifyProduct=false;
    //             }else{
    //                 Console.WriteLine("Aún no hay productos introducidos en esta categoría");
    //                 modifyProduct= false;
    //             }
    //         }else if (answerdCategory==1){
    //             if(totalOthers!=0){
    //                 Console.Write("Escriba el nuevo nombre del producto: ");
    //                 stock[answerdCategory,position-1].name=Console.ReadLine()!;
    //                 Console.Write("Escriba el nuevo precio del producto: ");
    //                 stock[answerdCategory,position-1].price=Convert.ToDecimal(Console.ReadLine()!);
    //                 Console.Write("Escriba el nuevo estoc del producto: ");
    //                 stock[answerdCategory,position-1].quantity=Convert.ToInt32(Console.ReadLine()!);
    //                 modifyProduct=false;
    //             }else{
    //                 Console.WriteLine("Aún no hay productos introducidos en esta categoría");
    //                 modifyProduct= false;
    //             }
    //         }else{
    //             Console.WriteLine("Valor incorrecto. Pruebe de nuevo.");  
    //         }
    //     }
    // }

    // static void showAllProduct(){
    //     Console.WriteLine("ESTOC ACTUAL\n");
    //     for(int i=0; i<2;i++){
    //         if(i==0){
    //             Console.WriteLine("PRODUCTOS ALIMENTICIOS");
    //             if(totalFood==0){
    //                 Console.WriteLine("Sin productos regristrados.");
    //                 Console.WriteLine("__________________________________________");
    //             }else{
    //                 for (int j=0; j<totalFood; j++){
    //                     Console.WriteLine("        -------     ");
    //                     Console.WriteLine("Nº{0}",j+1);
    //                     Console.WriteLine("Producto: {0}",stock[i,j].name);
    //                     Console.WriteLine("Precio: {0}€", stock[i,j].price);
    //                     Console.WriteLine("Estoc: {0} und.",stock[i,j].quantity);
    //                     Console.WriteLine("Categoria: {0}",stock[i,j].category);
    //                     Console.WriteLine("__________________________________________");
    //                 }
    //             }
    //             Console.WriteLine("\n");
    //         }else{
    //             Console.WriteLine("PRODUCTOS VARIOS");
    //             if(totalOthers==0){
    //                 Console.WriteLine("Sin productos regristrados.");
    //                 Console.WriteLine("__________________________________________");
    //             }else{
    //                 for (int j=0; j<totalOthers; j++){
    //                     Console.WriteLine("        -------     ");
    //                     Console.WriteLine("Nº{0}",j+1);
    //                     Console.WriteLine("Producto: {0}",stock[i,j].name);
    //                     Console.WriteLine("Precio: {0}€", stock[i,j].price);
    //                     Console.WriteLine("Estoc: {0} und.",stock[i,j].quantity);
    //                     Console.WriteLine("Categoria: {0}",stock[i,j].category);
    //                     Console.WriteLine("__________________________________________");
    //                 }
    //             }
    //             Console.WriteLine("\n");
    //         }
    //     }
    // }

    // static void showCategoryProducts(){
    //     bool showCategory=true;
    //     while(showCategory){
    //         Console.WriteLine("¿Qué categoría de productos quiere ver?\nPulse 1 para alimentación y 2 para otros.");
    //         int answerdCategory=Convert.ToInt32(Console.ReadLine())-1;
    //         if(answerdCategory==0){
    //             if(totalFood!=0){
    //                 Console.WriteLine("PRODUCTOS ALIMENTICIOS");
    //                 for (int i=0; i<totalFood;i++){
    //                     Console.WriteLine("        -------     ");
    //                     Console.WriteLine("Nº{0}",i+1);
    //                     Console.WriteLine("Producto: {0}",stock[answerdCategory,i].name);
    //                     Console.WriteLine("Precio: {0}€", stock[answerdCategory,i].price);
    //                     Console.WriteLine("Estoc: {0} und.",stock[answerdCategory,i].quantity);
    //                     Console.WriteLine("Categoria: {0}",stock[answerdCategory,i].category);
    //                     Console.WriteLine("__________________________________________");
    //                 }
    //                 showCategory=false;
    //             }else{
    //                 Console.WriteLine("Sin productos regristrados.");
    //                 Console.WriteLine("__________________________________________\n");;
    //                 showCategory= false;
    //             }
    //         }else if (answerdCategory==1){
    //             if(totalOthers!=0){
    //                 Console.WriteLine("PRODUCTOS VARIOS");
    //                 for (int i=0; i<totalOthers;i++){      
    //                     Console.WriteLine("        -------     ");
    //                     Console.WriteLine("Nº{0}",i+1);
    //                     Console.WriteLine("Producto: {0}",stock[answerdCategory,i].name);
    //                     Console.WriteLine("Precio: {0}€", stock[answerdCategory,i].price);
    //                     Console.WriteLine("Estoc: {0} und.",stock[answerdCategory,i].quantity);
    //                     Console.WriteLine("Categoria: {0}",stock[answerdCategory,i].category);
    //                     Console.WriteLine("__________________________________________");
    //                 }
    //                 showCategory=false;
    //             }else{
    //                 Console.WriteLine("Sin productos regristrados.");
    //                 Console.WriteLine("__________________________________________\n");;
    //                 showCategory= false;
    //             }
    //         }else{
    //             Console.WriteLine("Valor incorrecto. Pruebe de nuevo.");  
    //         }
    //     }
    // }



}

