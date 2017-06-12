import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayDeque;

public class BalancedParentheses {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String input = reader.readLine();
        input = input.trim();
        input = input.replaceAll("\\s+","");
        ArrayDeque<Character> allParentheses = new ArrayDeque<>();
        boolean isBalancedParentheses = true;

        for (int i = 0; i < input.toCharArray().length; i++) {
            char parentheses = input.charAt(i);
            allParentheses.offer(parentheses);
        }

        while (!allParentheses.isEmpty()) {
            char openParentheses = allParentheses.pollFirst();
            char closeParentheses = allParentheses.pollLast();

            if (allParentheses.size() % 2 == 1 || (!(openParentheses == '(' || openParentheses == '{' || openParentheses == '['))) {
                isBalancedParentheses = false;
                System.out.println("NO");
                break;
            }else {
                if(openParentheses == '('){
                    openParentheses = ')';
                }

                if(openParentheses == '{'){
                    openParentheses = '}';
                }

                if(openParentheses == '['){
                    openParentheses = ']';
                }

                if(openParentheses != closeParentheses){
                    System.out.println("NO");
                    isBalancedParentheses = false;
                    break;
                }
            }
        }

        if(isBalancedParentheses){
            System.out.println("YES");
        }
    }
}
