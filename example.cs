int answer; // 計算結果

// 加算
answer = 7 + 4;
Console.WriteLine(answer);

// 減算
answer = 12 - 18;
Console.WriteLine(answer);

// 乗算
answer = 2 * 7;
Console.WriteLine(answer);

// 除算
answer = 18 / 3;
Console.WriteLine(answer);

// 剰余
answer = 21 % 5;
Console.WriteLine(answer);

// 変数の初期化
int money = 15000;  // 現在の所持金
int salary = 1000;  // 時給
int hour = 5;       // 働いた時間

// 時給が150円アップした場合の合計金額を表示
int sum = money + (salary + 150) * hour;
Console.WriteLine(sum);