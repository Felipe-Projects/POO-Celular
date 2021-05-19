namespace Poo_celular
{
    public class Celular
    {
        public string cor;
        public string modelo = "S20K";
        public string tamanho = "13cm";
        public bool ligado = true;
        

        public bool Ligar()
        {
            return ligado = true;
        }

        public bool Desligar()
        {
            return ligado = false;
        }


            
    
    }
}