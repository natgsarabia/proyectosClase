internal class Program
{
    static List<Product> catalogue  = new List<Product>();
    static Product product=new Product();

    private static void Main(string[] args)
    {
        bool menu=true;
        
        while(menu){
            switch(ShowMenu()){
                case 0:
                    Console.WriteLine("Cerrando programa");
                    menu=false;
                    break;
                
                case 1:
                    AddProduct();
                    break;
                
                case 2:
                    ShowAllProduct();
                    break;
                
                case 3:
                    DeleteProduct();
                    break;

                case 4:
                    FindProductByName();
                    break;

                
                default:
                    Console.WriteLine("Ha marcado un número incorrecto. Pruebe de nuevo");
                    break;
            }
        }



     }

    public struct Product{
        public string name;
        public double price;
        public int stock;
    }

    static int ShowMenu(){
        Console.WriteLine("MENÚ ACTUALIZACIÓN ESTOC");
        Console.WriteLine("Pulse 1 para añadir un producto al catalogo.");
        Console.WriteLine("Pulse 2 para ver todos los productos. ");
        Console.WriteLine("Pulse 3 para eliminar un producto. ");
        Console.WriteLine("Pulse 4 para buscar producto por nombre.");
        Console.WriteLine("Pulse 0 para cerrar programa.");
        int answerd=Convert.ToInt32(Console.ReadLine()!);
        return answerd;
    }

    static void AddProduct(){
        Console.Write("¿Qué producto desea añadir? ");
        product.name=Console.ReadLine()!;
        Console.Write("¿Qué precio tiene el producto? ");
        product.price=Convert.ToDouble(Console.ReadLine()!);
        Console.Write("Escriba el estoc actual del producto: ");
        product.stock=Convert.ToInt32(Console.ReadLine()!);
        catalogue.Add(product);
        Console.WriteLine("Producto añadido correctamente.");
    }

    static void ShowAllProduct(){
        Console.WriteLine("Productos actuales:");
        int position=1;
        foreach(var product in catalogue){
            Console.WriteLine("Producto {0}",position);
            Console.WriteLine("Nombre: {0}", product.name);
            Console.WriteLine("Precio: {0}", product.price);
            Console.WriteLine("Estoc: {0}", product.stock);
            position++;
        } 
    }

    static void DeleteProduct(){
        Console.Write("¿Que producto quiere eliminar? Escriba el número del producto ");
        int index=Convert.ToInt32(Console.ReadLine()!);
        catalogue.RemoveAt(index-1);
        Console.WriteLine("Producto eliminado correctamente.");
    }

    static void FindProductByName(){
        Console.Write("Escriba el nombre del producto que quiere ver: ");
        string product=Console.ReadLine()!;
       foreach(var item in catalogue){
            if(item.name==product){
                Console.WriteLine("Nombre: {0}", item.name);
                Console.WriteLine("Precio: {0}", item.price);
                Console.WriteLine("Estoc: {0}", item.stock);
            }
       }
    }


}