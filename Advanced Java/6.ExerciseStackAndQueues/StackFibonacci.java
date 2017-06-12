import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayDeque;

public class StackFibonacci {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        ArrayDeque<Long> stack = new ArrayDeque<>();

        int number = Integer.parseInt(reader.readLine());
        stack.push(1L);
        stack.push(0L);
        long result;

        while (number-- >= 0) {
            long prev = stack.pop();
            long next = stack.pop();
            result = prev + next;
            prev = next;
            next = result;
            stack.push(next);
            stack.push(prev);
        }

        System.out.println(stack.pop());
    }
}
