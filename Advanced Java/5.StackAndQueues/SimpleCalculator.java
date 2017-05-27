import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayDeque;
import java.util.Collections;

public class SimpleCalculator {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] input = reader.readLine().split("\\s+");
        ArrayDeque<String> deque = new ArrayDeque<>();

        Collections.addAll(deque,input);

        while (deque.size() > 1){
            int first = Integer.parseInt(deque.pop());
            String calculate = deque.pop();
            int second = Integer.parseInt(deque.pop());

           switch (calculate){
               case "+":
                   deque.push(String.valueOf(first+second));
                   break;
               case "-":
                   deque.push(String.valueOf(first-second));
                   break;
           }
        }
        System.out.println(deque.pop());
    }
}
