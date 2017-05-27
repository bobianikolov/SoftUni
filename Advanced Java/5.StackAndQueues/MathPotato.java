import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayDeque;
import java.util.Collections;

public class MathPotato {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] children = reader.readLine().split("\\s+");
        int index = Integer.parseInt(reader.readLine());

        ArrayDeque<String> deque = new ArrayDeque<>();
        Collections.addAll(deque, children);

        int count = 1;
        while (deque.size() > 1){
            for (int i = 1; i < index; i++) {
                String firstChild = deque.poll();
                deque.offer(firstChild);
            }
            if(isPrime(count)){
                System.out.printf("Prime %s%n",deque.peek());
            }else {

                System.out.printf("Removed %s%n",deque.poll());
            }
            count++;
        }
        System.out.printf("Last is %s%n",deque.poll());
    }
    private static boolean isPrime(int number){
        if(number <= 1){
            return false;
        }

        for (int i = 2; i <= Math.sqrt(number); i++) {
            if(number % i == 0){
                return false;
            }
        }
          return true;
    }
}
