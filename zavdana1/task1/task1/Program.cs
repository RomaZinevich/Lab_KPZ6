using task1;


Handler h1 = new LevelHandler1();
Handler h2 = new LevelHandler2();
Handler h3 = new LevelHandler3();
Handler h4 = new LevelHandler4();

h1.SetSuccessor(h2);
h2.SetSuccessor(h3);
h3.SetSuccessor(h4);

int level = 0;

while (level < 1 || level > 4)
{
    Console.WriteLine("Виберiть потрiбний рiвень пiдтримкi оператора: ");
    //Замість рівнів підтримкі тут можуть бути якісь питання які будуть направлятти на певний рівень підтрикі
    Console.WriteLine("1. Рiвень 1");
    Console.WriteLine("2. Рiвень 2");
    Console.WriteLine("3. Рiвень 3");
    Console.WriteLine("4. Рiвень 4");

    level = Convert.ToInt32(Console.ReadLine());

    h1.HandleRequest(level);

    if (level < 1 || level > 4)
    {
        Console.WriteLine("Невiрний вибiр. Будь ласка спробуйте ще раз.");
    }

    Console.WriteLine();

}

