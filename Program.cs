using DesafioPOO.Models;

Nokia nokia = new Nokia("151320", "G10", "123", 8);
nokia.MudarNumero("12345682");
nokia.InstalarAplicativo("Facebook");
nokia.Ligar();

Iphone iphone = new Iphone("152145", "11", "1232", 8);
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();

Console.ReadKey(true);