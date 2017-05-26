import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class ConvertFromDecimalToBase7 {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int number = Integer.parseInt(reader.readLine());

        String result = Integer.toString(number,7);
        System.out.println(result);
    }
}
