internal class Program
{
class dominoes{
    private int num;
    private int den;
    public dominoes(int num, int den){
        this.num=num; this.den = den;  }
    public void imprime() {Console.WriteLine($"{den}");}

    public static dominoes operator + (dominoes a, dominoes b)
    {
        int den = a.den + b.den + a.num + b.num;
        int num = a.den + b.den + a.num + b.num;
        return new dominoes (num,den);

    }

}

    private static void Main(string[] args)
    {
        dominoes a = new dominoes(5,1);
        dominoes b = new dominoes (2,3);
        dominoes c = a+b;
        c.imprime();
    }
}