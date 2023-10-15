// See https://aka.ms/new-console-template for more information


Console.WriteLine("Please enter first operand: ");
string a_string = Console.ReadLine();

int a = 0;

try {
    a = int.Parse(a_string);
} catch (FormatException) {
    Console.WriteLine("I'm sorry, I don't understand that number.");
    return;
}

bool firstOperand_ok = false;
int b = 0;

do {
    Console.WriteLine("Please enter second operand: ");
    string b_string = Console.ReadLine();
    firstOperand_ok = int.TryParse(b_string, out b);
    if (!firstOperand_ok) {
        Console.WriteLine("I'm sorry, I don't understand that number.");
    }
} while (!firstOperand_ok);



if (b == 0) {
    Console.WriteLine("I'm sorry, I can't divide by zero.");
    return;
}

Console.WriteLine("Result, " + (a / b));
Console.ReadLine();
