import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayDeque;

public class MatchingBrackets {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String expression = reader.readLine();
        ArrayDeque<Integer> deque = new ArrayDeque<>();

        for (int i = 0; i < expression.toCharArray().length; i++) {
            if(expression.charAt(i) == '('){
                deque.push(i);
            }else if(expression.charAt(i) == ')'){
                int startBracket = deque.pop();
                String result = expression.substring(startBracket, i + 1);
                System.out.println(result);
            }
        }
    }
}
