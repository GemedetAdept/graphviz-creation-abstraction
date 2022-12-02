// Quick generation of graphs via GraphViz using command line inputs

string[] commandList = new string[] {

	"--help                  List available commands",
	"connect [A] to [B]      Create a connection between nodes [A] and [B]",

};


Console.WriteLine("Abstracted GraphViz Creator initalized.");
Snippet.Break();
Console.WriteLine("Type 'agc --help' for a list of commands.");

Snippet.Break();

bool commandLineLoop = true;
while(commandLineLoop) {
	string consoleInput = "";
	Console.Write("> ");
	consoleInput = Console.ReadLine();

	commandParse(consoleInput);

}

void commandParse (string command) {

	if (command == "agc --help") {
		agcHelp();
	}

	else if (command.Contains("connect")) {
		connectNodes(command);
	}

	else {
		Console.WriteLine("Invalid input...");
	}
}

void agcHelp () {
	Snippet.Break();

	foreach (string command in commandList) {
		Console.WriteLine(command);
	}
}

void connectNodes (string command) {

	string[] parts = command.Split(" ");
	string nodeOne = parts[2];
	string nodeTwo = parts[4];

	string graphvizOutput = $"{nodeOne} -> {nodeTwo}";
	Console.WriteLine(graphvizOutput);
}