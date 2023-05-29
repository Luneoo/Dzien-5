using Dzien_6;

Employee E1 = new Employee("Marcin", "Pierwszy", 33);
Employee E2 = new Employee("Ania", "Druga", 28);
Employee E3 = new Employee("Wojciech", "Trzeci", 41);

E1.AddScore(3);
E1.AddScore(6);
E1.AddScore(2);

E2.AddScore(2);
E2.AddScore(7);
E2.AddScore(5);

E3.AddScore(1);
E3.AddScore(2);
E3.AddScore(4);

var ScoreE1 = E1.ScoreCheck;
var ScoreE2 = E2.ScoreCheck;
var ScoreE3 = E3.ScoreCheck;

if (ScoreE1 > ScoreE2 && ScoreE1 > ScoreE3) Console.WriteLine(E1.Name + " " + E1.Surname + " lat " + E1.Age + " wynik: " + ScoreE1);
else if (ScoreE2 > ScoreE3) Console.WriteLine(E2.Name + " " + E2.Surname + " lat " + E2.Age + " wynik: " + ScoreE2);
else Console.WriteLine(E3.Name + " " + E3.Surname + " lat " + E3.Age + " wynik: " + ScoreE3);
