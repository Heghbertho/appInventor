using System;

class Login
{
    private string usuario = "beto";
    private int senha = 123;
    
    public string getUsuario(){
        return usuario;
    }
    
    public bool logar(){
        string u;
        int s;
        
        //tela
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Sistema de Matrícula - FAMETRO 1917");
        Console.WriteLine("----------------------------------------------------");
        
        //entrada de usuario e senha
        Console.WriteLine("Digite seu nome de Usuário");
        u = Console.ReadLine();
        Console.WriteLine("Digite sua senha");
        s = Convert.ToInt32(Console.ReadLine());
        
        if(u == usuario && s == senha){
            Console.WriteLine("ok");
            return true;
        }else{
             Console.WriteLine("erro");
             return false;
        }
       
    }
    
    
}