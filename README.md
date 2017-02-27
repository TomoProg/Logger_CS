# Logger_CS

C#で作った自作ロガーです。

プロジェクトに組み込んで、簡単にログを出力できます。

### 使い方
1. まずは`git clone https://github.com/TomoProg/Logger_CS`

2. ビルドしてlogger.dllを作成

3. Loggerを使用するプロジェクトの参照にlogger.dllを追加

#### サンプルプログラム
```c#
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static MyUtility.Logger l = new MyUtility.Logger("test.txt", Encoding.UTF8);
        static void Main(string[] args)
        {
            l.Write("test文字列");
            method1("method1を呼び出したよ。");
        }
        static void method1(string str)
        {
            l.Write(str);
        }
    }
}
```

#### 実行結果
```
[test.txt]
2017/02/27 22:41:11.248 Program.cs Line:11 test文字列
2017/02/27 22:41:11.251 Program.cs Line:12 method1を呼び出したよ。
```




