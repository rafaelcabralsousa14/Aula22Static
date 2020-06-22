namespace Aula22S
{
    public static class Conversor
    {
        public static float CotacaoDolar = 5.30f;
        public static float CotacaoEuro = 5.30f;

        public static float RealParaDolar(float valor){
            return valor / CotacaoDolar; 
        }
        public static float RealParaEuro(float valor){
            return valor / CotacaoEuro; 
        }
        public static float DolarParaReal(float valor){
            return valor * CotacaoDolar; 
        }
        public static float EuroParaReal(float valor){
            return valor * CotacaoEuro; 
        }
        
    }
}