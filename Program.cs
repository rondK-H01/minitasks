Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("[1,2] Name Input and Age Verification");
Console.WriteLine("[3] Variable Names and Types");
Console.WriteLine("[4] Calculator");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Choose a task [1 (default), 3, 4]: ");
Console.ResetColor();
string input = Console.ReadLine();

if(input == "") {
    Name_and_Age_Verification();
} else {
    int input_num;
    try {
        input_num = Convert.ToInt32(input);
    } catch {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Could not convert input to a number.");
        Console.ResetColor();
        return;
    }
    switch(input_num) {
        case 1:

        case 2:
            Name_and_Age_Verification();
            break;

        case 3:
            Variable_Names_and_Types();
            break;

        case 4:
            Calculator();
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid number.");
            Console.ResetColor();
            break;
    }
}

void Name_and_Age_Verification() {
    Console.Write("Please enter your name: ");
    string name = Console.ReadLine();

    Console.WriteLine($"Hello {name}!");

    Console.Write("Please enter your age: ");
    string age_input = Console.ReadLine();

    int age;
    try {
        age = Convert.ToInt32(age_input);
    } catch {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Could not convert input to a number.");
        Console.ResetColor();
        return;
    }

    if (age < 18) {
        Console.WriteLine("You must be 18 years old to use this service.");
        return;
    }

    Console.Write("Do you agree with the terms of service? yes/no: ");
    string terms_input = Console.ReadLine().ToLower();
    bool accepted_terms = (terms_input == "yes" || terms_input == "y");
    if(!accepted_terms) {
        Console.WriteLine("You must agree to the terms of service to continue.");
        return;
    }
    string accepted_terms_string = accepted_terms ? "yes" : "no";
    Console.WriteLine("Thank you.");
    Console.Write($"Summary: \n\tName:\t\t {name}\n\tAge:\t\t {age}\n\tAccepted TOS:\t {accepted_terms_string}");
}

void Variable_Names_and_Types() {

    // NOTE: The comments below are redundant as the code is self-explanatory.

    // Prompts for the name of the grocery item
    Console.WriteLine("Enter the name of the grocery item:");
    // Stores user input in the grocery_name variable
    string grocery_name = Console.ReadLine();

    // Prompts for the quantity of the grocery item
    Console.WriteLine("Enter the quantity:");
    // Stores user input in the grocery_quantity variable
    string grocery_quantity = Console.ReadLine();

    // Prompts for the weight of the grocery item
    Console.WriteLine("Enter the weight in kilograms:");
    // Stores user input in the grocery_weight variable
    string grocery_weight = Console.ReadLine();

    // Prompts for the price of the grocery item
    Console.WriteLine("Enter the price per unit:");
    // Stores user input in the grocery_price variable
    string grocery_price = Console.ReadLine();

    // Outputs a summary of the information captured above
    Console.WriteLine($"Item: {grocery_name}, Quantity: {grocery_quantity}, Weight: {grocery_weight} kg, Price: {grocery_price}");
}

void Calculator() {
    firstnum:
    Console.Write("Enter the first number: ");
    string first_num_input = Console.ReadLine();
    int first_num;
    try {
        first_num = Convert.ToInt32(first_num_input);
    } catch {
        Console.WriteLine("Invalid number, try again.");
        goto firstnum;
    }

    // NOTE: This goto section should be named "operator", but that is a reserved keyword
    op:
    Console.Write("Enter an operator (+,-,*,/): ");
    string operator_input = Console.ReadLine();
    if(operator_input != "+" && operator_input != "-" && operator_input != "*" && operator_input != "/") {
        Console.WriteLine("Invalid operator, try again.");
        goto op;
    }

    secondnum:
    Console.Write("Enter the second number: ");
    string second_num_input = Console.ReadLine();
    int second_num;
    try {
        second_num = Convert.ToInt32(second_num_input);
    } catch {
        Console.WriteLine("Invalid number, try again.");
        goto secondnum;
    }

    int result;
    switch(operator_input) {
        case "+":
            result = first_num + second_num;
            break;
        case "-":
            result = first_num - second_num;
            break;
        case "*":
            result = first_num * second_num;
            break;
        case "/":
            result = first_num / second_num;
            break;
        default:
            result = 0;
            break;
    }
    Console.WriteLine($"The result of {first_num} {operator_input} {second_num} is {result}");
}
