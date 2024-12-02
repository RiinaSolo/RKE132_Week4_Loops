using System;

Random rnd = new Random();


//int myRandomNum = rnd.Next(0, 11); //0-10
//Console.WriteLine($"My random nr is {myRandomNum}");
// paneme seda kolm korda tegema
//for(int i = 0; i < 3; i ++)
//{
//int myRandomNum = rnd.Next(0, 11); //0-10
//Console.WriteLine($"My random nr is {myRandomNum}");
//}
//aga võimalik ka

int myRandomNum;

int randomSum = 0; 

for(int i = 0; i < 3; i ++)
{
    myRandomNum = rnd.Next(0, 11); //0-10
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"My random nr is: {myRandomNum}");
}

Console.WriteLine($"Random sum is:{randomSum}");