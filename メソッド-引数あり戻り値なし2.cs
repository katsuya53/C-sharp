// 引数の値が偶数か奇数かを表示するメソッド
void ShowEvenOrOdd(int num)
{
    if ((num % 2) == 0)
    {
        Console.WriteLine("偶数です");
    }
    else
    {
        Console.WriteLine("奇数です");
    }
}

// ShowEvenOrOddメソッドを呼び出す
ShowEvenOrOdd(3);
