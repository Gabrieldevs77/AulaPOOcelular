using System;

namespace AulaPOOcelular
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Aluno Breno = new Aluno();
            Breno.nome = "Breno";
            Breno.idade = 16;
            Breno.bolsista = false;
            Breno.valorMensalidade = 2000f;
            Breno.mediaFinal = 9.7f;

            Console.WriteLine("Breno: "+Breno.VerMediaFinal());
            Console.WriteLine("Breno: "+Breno.VerMensalidade());
            

    }
    }
}
