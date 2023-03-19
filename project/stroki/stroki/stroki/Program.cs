/*
// task 8
string slovo = "sydysadyayaya";
int sumy=0;
for (int i=1; i<slovo.Length; i+=2)
{
    if (slovo[i]=='y')
    {
        sumy++;
    }
}
Console.WriteLine("Количество букв y на чётных местах : " + sumy);

// task 9 
string slovo = "kak dela,iy tyt";
string new1=slovo.Replace('a', 'A');
Console.WriteLine(new1) ;


// task 10
string slovo = "OOOLLOAOSLDLLASLLSLDSOSL";
int Firstbukva = 0; 
int lastbukva = 0;

for (int i = 0;i < slovo.Length; i++)
{
    if (slovo[0] == slovo[i]) 
    {
        Firstbukva++; 
    }
    if (slovo[slovo.Length-1] == slovo[i]) 
    {
        lastbukva++;
    }

}
if (Firstbukva > lastbukva)
{
    Console.WriteLine("Chase:" + slovo[0] + " " + Firstbukva);
}
else if (lastbukva > Firstbukva) {
    Console.WriteLine("Chase:" + slovo[slovo.Length - 1] + " " + lastbukva);
}
else
{
    Console.WriteLine("kol-vo odinakovo");
        } 

// task  11

string slovo = "my name is Saniy, my old 18. 2329123.";
string[] array = slovo.Split('.');
string slovo1 = array[0];
string slovo2 = array[1];
string new1 = slovo1.Replace(',', ' ');
string new2 = slovo2.Replace('3', '+');
Console.WriteLine(new1 + "." + new2 + ".");*/