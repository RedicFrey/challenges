/* Made by RedicFrey  */

string Letters = "Q q W w E e R r T t Y y U u I i O o P p A a S s D d F f G g H h J j K l Z z X x C c V v B b N n M m 1 2 3 4 5 6 7 8 9 0 ! @ # $ % & * ? - _";
string[] LettersV = Letters.Split(" ");
string Password = "";
int V = 999;
Random r = new Random();


for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 8; j++)
    {
        int R = r.Next(0, 68);

        if (R != V)
        {
            Password += "" + LettersV[R];
        }
        else
        {
            j -= 1;
        }

        V = R;
    }

    Password += "\n\n";
}



Console.WriteLine(Password);
Console.ReadKey();
