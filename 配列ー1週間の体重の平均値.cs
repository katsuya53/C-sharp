float[] weights = { 41.2f, 42.5f, 44.9f, 43.2f, 
                    45.1f, 43.2f, 42.7f };

float sum = 0.0f;   // 1週間の体重の合計を入れる変数

// 1週間の体重の合計値を求める
for (int i = 0; i < weights.Length; i++)
{
    sum += weights[i];
}

// 1週間の体重の平均値を求める
float average = sum / weights.Length;
Console.WriteLine("平均値は" + average + "です");