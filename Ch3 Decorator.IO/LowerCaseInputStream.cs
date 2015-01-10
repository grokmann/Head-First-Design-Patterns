using System;
using System.IO;

namespace Ch3_Decorator.IO
{
    class LowerCaseInputStream : TextReader
    {
        private TextReader source;
        public LowerCaseInputStream(TextReader source)
        {
            this.source = source;
        }

        public override int Read()
        {
            int c = source.Read();
            return (c == -1 ? c : Char.ToLower((char)c));
        }

        public override int Read(char[] buffer, int index, int count)
        {
            //var str = base.Read(buffer, index, count).ToString().ToLower();
            //var result = Convert.ToInt32(str);
            int result = source.Read(buffer, index, count);
            for (int i = index; i < index + result; i++)
            {
                buffer[i] = buffer[i];
                //Convert.ToByte(System.Text.Encoding.UTF8.GetString(buffer[i]).ToCharArray());
            }
            return result;
        }
    }
}
