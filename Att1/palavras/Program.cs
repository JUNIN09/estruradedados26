string firstname = "Edilio"; // Corrigido de firtname para firstname
string lastname = "Junior";

string note = lastname.ToUpper() + " " + firstname;


string initials = lastname[0].ToString() + firstname[0].ToString(); 

Console.WriteLine("" + initials); 

// Formatação de string

string texto = string.Format(
    "{0} {1} nascido em {2}", 
    firstname, 
    lastname,
    "2005"
);

Console.WriteLine(texto); 

// C# é um linguagem filha do C++
// Totalmente Orientada a Objetos
// Portanto , tudo dentro do C é descendente
// do tipo Object

int age = 20;
object ageBoxing = age;
int ageUnboxing = (int) ageBoxing;