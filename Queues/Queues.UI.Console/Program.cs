using QueueArray;

var queue = new QueueUsingArray<int>(5);
var opc = "0";
do
{
    opc = Menu();
    switch (opc)
    {
        case "1":
            try
            {
                Console.Write("Enter a number: ");
                var number = int.Parse(Console.ReadLine()!);
                queue.Enqueue(number);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;

        case "2":
            try
            {
                var item = queue.Dequeue();
                Console.WriteLine($"Item dequeued: {item}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;

        case "3":
            try
            {
                Console.WriteLine($"Item in peek: {queue.Peek()}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
    }
} while (opc != "0");

string Menu()
{
    Console.WriteLine("1. Enqueue");
    Console.WriteLine("2. Dequeue");
    Console.WriteLine("3. Peek");
    Console.WriteLine("0. Exit");
    Console.Write("Choose an option: ");
    return Console.ReadLine()!;
}