// See https://aka.ms/new-console-template for more information
Console.Write("Mata in ett bilmärke: ");
string carBrand =  Console.ReadLine().ToLower();
if (carBrand == "volvo")
{
    
}
else if (carBrand == "volkswagen" || carBrand == "bmw" || carBrand == "audi")
{
    Console.WriteLine("Bilen är tysk.");
}
else if (carBrand == "renault" || carBrand == "peugeot" || carBrand == "citroen")
{
    Console.WriteLine("Bilen är fransk.");
}
else 
{
}

