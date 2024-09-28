bool wtf = false;
int a = Convert.ToInt32(Console.ReadLine());
if (a%2 == 0)
{
    wtf = true;
}
string res = wtf ? "Yes" : "No";
Console.WriteLine(res);