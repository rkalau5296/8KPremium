using _8KPremium;

Binary binary = new();

Console.WriteLine(binary.BinaryGap(1000001111));
Console.WriteLine(binary.BinaryGap(1001011110));
Console.WriteLine(binary.BinaryGap(1011000001));
Console.WriteLine(binary.BinaryGap(1011000001));
Console.WriteLine(binary.BinaryGap(1001010000));
Console.WriteLine(binary.BinaryGap(1000010001));

JewelsAndStones stones = new();

Console.WriteLine(stones.CountJewelsInStones("As", "AdDsAsAAAssDDDDzxczsdsf"));
Console.WriteLine(stones.CountJewelsInStones("As", "ERlkdfdbiuidfvp"));

Console.WriteLine(stones.CountJewelsInStonesVer2("As", "AdDsAsAAAssDDDDzxczsdsf"));
Console.WriteLine(stones.CountJewelsInStonesVer2("As", "ERlkdfdbiuidfvp"));

