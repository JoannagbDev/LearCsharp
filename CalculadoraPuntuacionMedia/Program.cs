
// Declaramos las variables que nos serviran como base da datos
string athleteName = "Maria Espinoza";
string sport1Name = "Taekwondo";
string sport2Name = "Box";
string sport3Name = "Judo";
string sport4Name = "Football";
string sport5Name = "Basketball";

int team1Hours = 2;
int team2Hours = 3;
int team3Hours = 4;
int team4Hours = 5;
int team5Hours = 4;

//  valores númericos equivalentes a las calificaciones A=4, B=3...
int gradeA = 4;
int gradeB = 3;

// declaramos las variables que alamacenaran los valores de las calificaciones
int sport1Grade = gradeA;
int sport2Grade = gradeB;
int sport3Grade = gradeA;
int sport4Grade = gradeB;
int sport5Grade = gradeA;


/// Creamos las variables que almacenarán los valores de las horas totales de entrenamiento y los puntos de calificación
/// para cada deporte.
int totalHours = team1Hours + team2Hours + team3Hours + team4Hours + team5Hours;
int totalGradePoints = (team1Hours * sport1Grade) + (team2Hours * sport2Grade) + (team3Hours * sport3Grade) + (team4Hours * sport4Grade) + (team5Hours * sport5Grade); 
// Calculamos el GPA
decimal gpa = (decimal) totalGradePoints / totalHours; 
// Almacenamos el gpa
int leadingGPA = (int) gpa;
// Almacenamos el digito inicial del GPA
int gpaFirstDigit = (int) (gpa * 10) % 10;
// Recuperamos el segundo digito 
int gpaSecondDigit = (int) (gpa * 100) % 10;


// Mostremos los datos en consola formatedos con el formato requerido
 Console.WriteLine($"Athlete: {athleteName}\n");
 Console.WriteLine("sport\t\t\tHours\tGrade");

 Console.WriteLine($"{sport1Name}\t\t{team1Hours}\t{sport1Grade}");
 Console.WriteLine($"{sport2Name}\t\t\t{team2Hours}\t{sport2Grade}");
 Console.WriteLine($"{sport3Name}\t\t\t{team3Hours}\t{sport3Grade}");
 Console.WriteLine($"{sport4Name}\t\t{team4Hours}\t{sport4Grade}");
 Console.WriteLine($"{sport5Name}\t\t{team5Hours}\t{sport5Grade}");

 Console.WriteLine($"\nFinal GPA:\t\t\t {leadingGPA}.{gpaFirstDigit}{gpaSecondDigit}");


// La salida en consola es la siguiente:
// Athlete: Maria Espinoza

// sport           Hours   Grade
// Taekwondo       2       4
// Box             3       3
// Judo            4       4
// Football        5       3
// Basketball      4       4

// Final GPA:             3.55