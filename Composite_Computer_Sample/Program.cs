using Composite_Computer_Sample;

IComponent hardDisk = new Leaf("Hard Disk", 100000);
IComponent ram = new Leaf("RAM", 100000);
IComponent cpu = new Leaf("CPU", 200000);
IComponent mouse = new Leaf("Mouse", 50000);
IComponent keyboard = new Leaf("Keyboard", 50000);
IComponent Monitor = new Leaf("Monitor", 400000);

Composite motherBoard = new Composite("MotherBoard", 100000);
Composite Case = new Composite("Case", 70000);
Composite peripherals = new Composite("Peripherals", 0);
Composite computer = new Composite("Computer", 0);


motherBoard.AddComponent(cpu);
motherBoard.AddComponent(ram);


Case.AddComponent(motherBoard);
Case.AddComponent(hardDisk);


peripherals.AddComponent(mouse);
peripherals.AddComponent(keyboard);

computer.AddComponent(Case);
computer.AddComponent(peripherals);
computer.AddComponent(Monitor);

computer.DisplayPrice();
