import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class RecursiveFibonacci {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        Byte number = Byte.parseByte(reader.readLine());

        long previous = 0;
        long next = 1;
        long result = 0;

        while (number-- > 0){
            result = previous + next;
            previous = next;
            next = result;
        }

        System.out.println(result);
    }
}
