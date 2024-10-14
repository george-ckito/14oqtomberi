using _14oqtomberi;

while (true)
{
    Console.WriteLine("Choose which program to run: (328, 329, 296, 755, 754, 752, 7 - palindrome )");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch(choice)
    {
        case 328:
            _328 program = new _328();
            program.Execute();
            break;
        case 329:
            _329 program2 = new _329();
            program2.Execute();
            break;
        case 296:
            _296 program3 = new _296();
            program3.Execute();
            break;
        case 755:
            _755 program4 = new _755();
            program4.Execute();
            break;
        case 754:
            _754 program5 = new _754();
            program5.Execute();
            break;
        case 752:
            _752 program6 = new _752();
            program6.Execute();
            break;
        case 7:
            palindrome program7 = new palindrome();
            program7.Execute();
            break;
        default:
            Console.WriteLine("invalid option");
            break;
    }
}