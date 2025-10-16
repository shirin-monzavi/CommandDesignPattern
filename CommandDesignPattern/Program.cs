using CommandDesignPattern.ConcretCommands;
using CommandDesignPattern.Receivers;

var doc = new Document();

var command = new PasteCommand(doc);

command.Execute();
