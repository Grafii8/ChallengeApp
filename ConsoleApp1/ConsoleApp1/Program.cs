var firstname = "Ewa";
var gender = "kobieta";
int age = 30;
if (gender == "kobieta" && age < 30)
{
    Console.WriteLine("kobieta ponizej lat 30");
}
else if (firstname == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa lat 30");
}
else if (age < 18 && gender == "mezczyzna")
{
    Console.WriteLine("niepelnoletni mezczyzna");
}

