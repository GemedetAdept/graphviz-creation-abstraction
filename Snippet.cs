public class Snippet {

	public static void Break () {

		string lineBreak = "";
		Console.WriteLine(lineBreak);

	}

	public static void Note (object tempMessage) {

		tempMessage = tempMessage.ToString();
		Console.WriteLine($"* {tempMessage} *");
	}
}