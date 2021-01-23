public class SumAllDivisors {

    public int divisorSum(int num) {
        // Para cada divisor i < que a raíz quadrada existe um recíproco num/i;
        int sum = 0;
        int max = ((int) Math.floor(Math.sqrt(num)))+1;
        for(int i=1; i<max; i++) {
            if(num % i == 0) {
                sum += i;

                if (!(num/i == i)) { // própria raiz
                    sum += num/i; // recíproco.
                }
            }
        }
        return sum;
    }

    public static void main(String[] args) {
        SumAllDivisors sumAllDivisors = new SumAllDivisors();
        int result = sumAllDivisors.divisorSum(19000);
        System.out.println("Resultado: " + result);

    }
}
