import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayDeque;

public class ReverseString {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String text = reader.readLine();
        ArrayDeque<Character> deque = new ArrayDeque<>();

        for (char c : text.toCharArray()) {
            deque.push(c);
        }

        while (!deque.isEmpty()){
            System.out.print(deque.pop());
        }
    }
}
