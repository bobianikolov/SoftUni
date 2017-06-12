import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.*;

public class InfixToPostfix {

    public static void main(String args[]) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] input = reader.readLine().split("\\s+");
        System.out.println(infixToPostfix(input));
    }

    private static String infixToPostfix(String[] infix) {

        String postfix = "";
        String postfixResult = "";
        Stack<String> stack = new Stack<>();
        String popped;

        for (int i = 0; i < infix.length; i++) {

            String getCharacter = infix[i];

            if (!isOperator(getCharacter)){
                postfix += getCharacter;
            }else if (getCharacter.equals(")")){
                while (!(popped = stack.pop()).equals("(")){
                    postfix += popped;
                }
            }else {
                while (!stack.isEmpty() && !getCharacter.equals("(") && precedence(stack.peek()) >= precedence(getCharacter)){
                    postfix += stack.pop();
                }
                stack.push(getCharacter);
            }
        }

        while (!stack.isEmpty()){
            postfix += stack.pop();
        }
        for (char ch : postfix.toCharArray()) {
            postfixResult += ch + " ";
        }
        return postfixResult;
    }

    private static int precedence(String ch) {

        if (ch.equals("(") || ch.equals(")")) {
            return 1;
        } else if (ch.equals("-") || ch.equals("+")) {
            return 2;
        } else if (ch.equals("*") || ch.equals("/")) {
            return 3;
        } else {
            return 0;
        }
    }

    private static boolean isOperator(String ch) {
        return precedence(ch) > 0;
    }
}
