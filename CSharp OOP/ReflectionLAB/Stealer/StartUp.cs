using System;

namespace Stealer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();

            //string r = spy.StealFieldInfo("Stealer.Hacker", new string[] { "username", "password" }); 
            //Console.WriteLine(r);

            //string re = spy.AnalyzeAcessModifiers("Stealer.Hacker");
            //Console.WriteLine(re);

            string res = spy.RevealPrivateMethods("Stealer.Hacker");
            Console.WriteLine(res);

            string resu = spy.CollectGettersAndSetters("Stealer.Hacker");
            Console.WriteLine(resu);

        }
    }
}
