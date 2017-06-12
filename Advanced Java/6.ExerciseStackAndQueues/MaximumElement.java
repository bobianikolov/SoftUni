import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayDeque;

public class MaximumElement {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int n = Integer.parseInt(reader.readLine());
        ArrayDeque<Integer> numbers = new ArrayDeque<>();
        ArrayDeque<Integer> max = new ArrayDeque<>();

        int maxNumber = Integer.MIN_VALUE;

        while (n-- > 0) {
            String[] input = reader.readLine().split("\\s+");
            String command = (input[0]);

            switch (command) {
                case "1":
                    int addNumbers = Integer.parseInt(input[1]);
                    if(addNumbers >= maxNumber){
                        maxNumber = addNumbers;
                        max.push(maxNumber);
                    }
                    numbers.push(addNumbers);
                    break;
                case "2":
                    int deleteNumber = numbers.pop();
                    if(deleteNumber == maxNumber){
                        max.pop();
                        if(!max.isEmpty()){
                            maxNumber = max.peek();
                        }else {
                            maxNumber = Integer.MIN_VALUE;
                        }
                    }
                    break;
                case "3":
                    System.out.println(max.peek());
                    break;
            }
        }
    }
}
