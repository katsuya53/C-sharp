int player1PosX = 2;    // プレイヤ1の位置
int player2PosX = 6;    // プレイヤ2の位置

// プレイヤ1の位置が「2」かつプレイヤ2の位置が「6」の場合に仕掛けを解除
if (player1PosX == 2)
{
    if (player2PosX == 6)
    {
        Console.WriteLine("仕掛け解除");
    }
}