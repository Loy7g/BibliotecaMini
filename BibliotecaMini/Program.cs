using BibliotecaMini.Controllers;

Console.WriteLine("Iniciando Mini Biblioteca...");
Console.WriteLine("Pressione qualquer tecla para continuar...");
Console.ReadKey();

var controller = new LivroController();
controller.IniciarSistema();


