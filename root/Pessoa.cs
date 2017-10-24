class Pessoa
{
     private string nome;
     private string cidade;
     private int idade;
     
     public void setNome(string nome){
         if (nome.Length < 2){
            this.nome = "error"; 
         } else {
            this.nome = nome;
        //     return true;
         }
     }
     public string getNome(){
         return nome;
     }
     
     public void setCidade(string cidade)
    {
        this.cidade = cidade;
    }
    public string getCidade(){
        return cidade;
    }
    
    public void setIdade(int idade){
        this.idade = idade;
    }
    public int getIdade(){
         return idade;
    }
}