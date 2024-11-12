GuessNumber();




 // 03 Metoder
float RightTriangleArea(float a, float b)
{
    return (a * b) / 2;
}

float CircleArea(float r)
{
    return MathF.Pow(r, 2) * MathF.PI;
}

(float, float) PQformel(float p, float q) // Räkna ut andra gradsfunktioner
{
    float discriminant = MathF.Pow(p / 2, 2) - q;
    if (discriminant < 0)
    {
        throw new ArgumentException("Har ej rella rötter.");
    }
    float sqrtDiscriminant = MathF.Sqrt(discriminant);
    float root1 = -(p / 2) + sqrtDiscriminant;
    float root2 = -(p / 2) - sqrtDiscriminant;
    return (root1, root2);
}

int GetNumberInput()
{
    int num;
    while (!int.TryParse(Console.ReadLine(), out num)) ;
    return num;
}

void Hello32()
{
    for (int i = 0; i < 32; i++)
    {
        System.Console.WriteLine("Hello World");
    }
}

string GetChoice(string[] choices)
{
    for (int i = 0; i < choices.Length; i++)
        System.Console.WriteLine($"{i + 1}. {choices[i]}");
    int num;

    while (!int.TryParse(Console.ReadLine(), out num) || num < 1 || num > choices.Length)
    {
        System.Console.WriteLine("Skriv ett giltigt alternativ");
    }
    return choices[num - 1];
}

// 02 Listor och array

void Cities(){
    List<string> cities = new List<string>();

    string city;
    while((city = Console.ReadLine().ToLower()) != "d"){
        cities.Add(city);
    }

    foreach (string name in cities)
        System.Console.WriteLine(name);
}

void Leksaker() {
    string[] toys = [ "Ronaldo Action Figure", "Fortnite Figure", "Roblox Figure", "Mogcraft figure", "Jojo" ];
    Dictionary<string, int> toysRating = new Dictionary<string, int>();

    foreach (string toy in toys)
    {
        int rating;
        do{
            System.Console.Write($"Skriv en rating på {toy}: ");
        }
        while(!int.TryParse(Console.ReadLine(), out rating));
        toysRating.Add(toy, rating);
    }
    Console.Clear();
    System.Console.WriteLine("Ratings:");

    foreach (var toy in toysRating)
    {
        System.Console.WriteLine($"{toy.Key}: {toy.Value}");
    }
}

// 01 If-satser, loopar, datatyper

void BiggerOrEqualHello(){
    if(6>=3) {
        System.Console.WriteLine("Hello World");
    }
}

void Loop5Times(){
    for (int i = 0; i < 5; i++)
    {
        int num;
        while(!int.TryParse(Console.ReadLine(), out num)){
            System.Console.WriteLine("Skriv ett nummer!");
        }
        if(num>5){
            System.Console.WriteLine("Högre än 5!");
        }
    }
}

void GuessNumber(){
    int correctAnswer = Random.Shared.Next(10);
    int answer;
    while (!int.TryParse(Console.ReadLine(), out answer) || answer != correctAnswer)
    {
        System.Console.WriteLine("Prova Igen!");
    }
    System.Console.WriteLine($"Du gissade rätt och det var {correctAnswer}");
}
