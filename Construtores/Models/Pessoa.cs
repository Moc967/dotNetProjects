namespace Construtores.Models
{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;

        // public Pessoa()
        // {
        //     nome = string.Empty;
        //     sobrenome = string.Empty;            
        // }
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Construtor Pessoa");
        }
        public void Apresentar()
        {
            Console.WriteLine("Ola, meu nome é {0} {1}", nome, sobrenome);
        }   
    }
}