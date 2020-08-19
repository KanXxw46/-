using System;

namespace Экзамен
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Button1_Click(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
