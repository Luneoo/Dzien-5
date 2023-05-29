using Dzien_6;

Employee employee1 = new Employee("Marcin", "Pierwszy", 33);
Employee employee2 = new Employee("Ania", "Druga", 28);
Employee employee3 = new Employee("Wojciech", "Trzeci", 41);

employee1.AddScore(3);
employee1.AddScore(6);
employee1.AddScore(2);

employee2.AddScore(2);
employee2.AddScore(7);
employee2.AddScore(5);
employee2.AddScore(-1);

employee3.AddScore(1);
employee3.AddScore(2);
employee3.AddScore(4);

var scoreEmployee1 = employee1.ScoreCheck;
var scoreEmployee2 = employee2.ScoreCheck;
var scoreEmployee3 = employee3.ScoreCheck;

if (scoreEmployee1 > scoreEmployee2 && scoreEmployee1 > scoreEmployee3) Console.WriteLine(employee1.Name + " " + employee1.Surname + " lat " + employee1.Age + " wynik: " + scoreEmployee1);
else if (scoreEmployee2 > scoreEmployee3) Console.WriteLine(employee2.Name + " " + employee2.Surname + " lat " + employee2.Age + " wynik: " + scoreEmployee2);
else Console.WriteLine(employee3.Name + " " + employee3.Surname + " lat " + employee3.Age + " wynik: " + scoreEmployee3);
