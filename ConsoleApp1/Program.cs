using ConsoleApp1;
using ConsoleApp1.Classes;

var macaco = new MacacoHandler();
var vaca = new VacaHandler();
var lhama = new LhamaHandler();

macaco.SetNext(vaca).SetNext(lhama);

Console.WriteLine("Chain: Macaco > Vaca > Lhama\n");
Client.ClientCode(macaco);
Console.WriteLine();

Console.WriteLine("Subchain: Vaca > Lhama\n");
Client.ClientCode(vaca);