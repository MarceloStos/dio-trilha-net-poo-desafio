using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new Iphone("123456789", "iPhone 12", "123456789012345", "128GB");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

Nokia nokia = new Nokia("987654321", "Nokia 3310", "987654321098765", "16MB");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");


