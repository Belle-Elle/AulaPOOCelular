namespace Poo
{
    public class telefone
    {
        public string cor = "Branco";
        public string modelo = "Moto G Play 7";
        public float tamanho = 2.26f;
        public bool ligado;
        public string msg;

        public bool Ligar()
        {
            return ligado = true;
        }
        public bool Desligar()
        {
            return ligado = false;
        }

        public string Fazerligação()
        {

            return "Fazendo ligação";
        }

        public string Enviarmsg()
        {
            
            return "Send...";
        }
    }
}