import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class ConvertFromBase7ToDecimal {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String input = reader.readLine();

        Integer result = Integer.valueOf(input,7);

        System.out.println(result);
    }
}
