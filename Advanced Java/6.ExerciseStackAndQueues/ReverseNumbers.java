import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayDeque;

public class ReverseNumbers {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] input = reader.readLine().split("\\s+");
        ArrayDeque<Integer> numbers = new ArrayDeque<>();

        for (String number : input) {
            numbers.push(Integer.valueOf(number));
        }

        while (!numbers.isEmpty()){
            System.out.printf("%d ",numbers.pop());
        }
    }
}
