import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayDeque;

public class PalindromeChecker {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String input = reader.readLine();
        ArrayDeque<Character> deque = new ArrayDeque<>();

        for (char ch : input.toCharArray()) {
            deque.offer(ch);
        }

        boolean isPalindrome = true;

        while (deque.size() > 1){
            Character first = deque.poll();
            Character last = deque.pollLast();

            if(first != last){
                isPalindrome = false;
                break;
            }
        }
        System.out.println(isPalindrome);
    }
}
