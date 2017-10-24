using System.IO;
using System;


class Program
{
    static void Main()
    {
        Login novoLogin = new Login();
        
        if (!novoLogin.logar()) {
            Console.WriteLine("Erro de acesso, verifique e tente novamente.");
            Main();
        } else {
            
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Sistema de Matrícula - FAMETRO 1917");
            Console.WriteLine("---------------------------------------------------- Usuário :" + novoLogin.getUsuario());
            
            string tecla;
            Aluno novoAluno = new Aluno();
            
            Console.WriteLine("Digite o nome do Aluno :");
            tecla =  Console.ReadLine();
            novoAluno.setNome(tecla);
            Console.WriteLine("Digite a Idade do Aluno :");
            tecla =  Console.ReadLine();
            novoAluno.setIdade(Convert.ToInt32(tecla));
            Console.WriteLine("Digite o Curso do Aluno :");
            tecla =  Console.ReadLine();
            novoAluno.setCurso(tecla);
            
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Matricula realizada");
            Console.WriteLine("Aluno :" + novoAluno.getNome());
            Console.WriteLine("Idade :" + novoAluno.getIdade());
            Console.WriteLine("Curso :" + novoAluno.getCurso());
            // Console.WriteLine("qtd letras" + novoAluno.getCurso().Length);
        }    
    }
}
