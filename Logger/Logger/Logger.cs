using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace MyUtility
{
    public class Logger
    {
        /// <summary>
        /// ファイルパス
        /// </summary>
        string _filePath;

        /// <summary>
        /// エンコーディング
        /// </summary>
        Encoding _enc;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="logFilePath">ログファイルパス（ログファイル名込み）</param>
        /// <param name="enc">ログファイルのエンコーディング</param>
        public Logger(string logFilePath, Encoding enc)
        {
            _filePath = logFilePath;
            _enc = enc;
        }
        
        /// <summary>
        /// ログファイル書き込み
        /// </summary>
        /// <param name="writeContents">書き込み内容</param>
        public void Write(string writeContents)
        {
            StackTrace st = new StackTrace(1, true);
            string dateTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");
            string fileName = Path.GetFileName(st.GetFrame(0).GetFileName()).PadRight(20).Substring(0, 20);
            string lineNumber = st.GetFrame(0).GetFileLineNumber().ToString();
            //string methodName = st.GetFrame(0).GetMethod().ToString();

            writeContents = (dateTime + " " + fileName + " Line:" + lineNumber + " " + writeContents);

            try
            {
                using (StreamWriter sw = new StreamWriter(_filePath, true, _enc))
                {
                    sw.WriteLine(writeContents);
                }
            }
            catch
            {
                // 握りつぶす
            }
        }
    }
}
