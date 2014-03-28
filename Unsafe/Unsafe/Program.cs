using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Unsafe
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            char a = 'a';
            Console.Write("the char ");
            print('a');
            Console.Write(" is locate ");
            print(&a);
            Console.Read();

        }
        static unsafe void print(char a)
        {
            a = 'a';
            Console.Write(a);
        }
        static unsafe void print(char* a)
        {
            *a = 'a';
            Console.Write((int)a);
        }
        static unsafe void test_char()
        {
            char a = 'a';       //l'adresse n'est pas la meme car dans les fonctions precedentes les char sont en copie
            print(&a);
            print(a);
        }
        public static unsafe void swap(int* p, int* q)
        {
            int* tmp;
            tmp = q;
            q = p;
            p = tmp;
        }

    }
}
