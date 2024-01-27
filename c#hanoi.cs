using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace c_sample1
{
    internal class Program
    {
        public const int Max_Value = 64;//64层
        public static int steps = 0;
        
        static void Main(string[] args)
        {
            int levels = 0;
            Console.WriteLine($"输入汉诺塔层数（1~{Max_Value}）;");
            levels=int.Parse( Console.ReadLine() );
            if (levels>0&&levels<=Max_Value)
            {
                move(levels, 'A','B','C');
                Console.WriteLine($"一共移动了{Program.steps}次");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("输入正确范围");
            Console.ReadKey();
            return;
        }
        static void move(int pile, char src, char temp,char dst)
        {
            if (pile==1)
            {
                Console.WriteLine(  $"{src}-->{dst}");
                steps++;
                return;
            }
            move(pile - 1, src, dst, temp);//移动n-1层以上的汉诺塔到空位
            move(1, src, temp, dst);//最下层汉诺塔移动到最终目标
            move(pile - 1, temp, src, dst);//n-1层移动到最终目标
        }
    }
}
