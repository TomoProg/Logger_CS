# Logger_CS

C#�ō�������샍�K�[�ł��B

�v���W�F�N�g�ɑg�ݍ���ŁA�ȒP�Ƀ��O���o�͂ł��܂��B

### �g����
1. �܂���`git clone https://github.com/TomoProg/Logger_CS`

2. �r���h����logger.dll���쐬

3. Logger���g�p����v���W�F�N�g�̎Q�Ƃ�logger.dll��ǉ�

#### �T���v���v���O����
```c#
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static MyUtility.Logger l = new MyUtility.Logger("test.txt", Encoding.UTF8);
        static void Main(string[] args)
        {
            l.Write("test������");
            method1("method1���Ăяo������B");
        }
        static void method1(string str)
        {
            l.Write(str);
        }
    }
}
```

#### ���s����
```
[test.txt]
2017/02/27 22:41:11.248 Program.cs Line:11 test������
2017/02/27 22:41:11.251 Program.cs Line:12 method1���Ăяo������B
```




