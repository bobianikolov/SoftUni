import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayDeque;

public class BasicStackOperations {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] input = reader.readLine().split("\\s+");
        int n = Integer.parseInt(input[0]);
        int s = Integer.parseInt(input[1]);
        int x = Integer.parseInt(input[2]);

        ArrayDeque<Integer> numbers = new ArrayDeque<>();

        String[] inputNumbers = reader.readLine().split("\\s+");

        int minNumber = Integer.MAX_VALUE;
        for (String inputNumber : inputNumbers) {
            numbers.push(Integer.valueOf(inputNumber));
        }

        for (int i = 0; i < s; i++) {
            numbers.pop();
        }

        if(numbers.contains(x)){
            System.out.println(true);
        }else if(numbers.isEmpty()){
            System.out.println(0);
        }else {
            for (Integer number : numbers) {
                if(number < minNumber){
                    minNumber = number;
                }
            }
            System.out.println(minNumber);
        }
    }
}
