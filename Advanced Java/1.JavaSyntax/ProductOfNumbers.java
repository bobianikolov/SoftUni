import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.math.BigInteger;

public class ProductOfNumbers {

    public static void main(String[] args) throws IOException {

        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] input = reader.readLine().split("\\s+");
        int first = Integer.parseInt(input[0]);
        int second = Integer.parseInt(input[1]);

        BigInteger bigInteger = BigInteger.valueOf(first);
        int count = first;
        do {
            bigInteger = bigInteger.multiply(BigInteger.valueOf(count + 1));
            count++;
        } while (count < second);

        System.out.println(String.format("product[%d..%d] = %d",
                first, second, bigInteger));
    }
}
