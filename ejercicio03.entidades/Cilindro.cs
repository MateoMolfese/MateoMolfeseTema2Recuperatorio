using System.Text;

namespace ejercicio03.entidades
{
    public struct Cilindro
    {
        public int rad {  get; set; }
        public int alt { get; set; }
        public Cilindro(int radio,int altura)
        {
            rad = radio;
            alt = altura;
        }
        public double getVolumen=> Math.PI * Math.Pow(rad, 2) * alt;
        public double getSuperficie => 2 * Math.PI * Math.Pow(rad, 2) + 2 * Math.PI * rad * alt;
        public string getInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"radio del cilindro: {rad}");
            sb.AppendLine($"altura del cilindro: {alt}");
            sb.AppendLine($"volumen del cilindro: {getVolumen}");
            sb.AppendLine($"superficie del cilindro: {getSuperficie}");
            return sb.ToString();

        }
    }
}
