import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayDeque;

public class BasicQueueOperations {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] input = reader.readLine().split("\\s+");
        ArrayDeque<Integer> queue = new ArrayDeque<>();

        int n = Integer.parseInt(input[0]);
        int s = Integer.parseInt(input[1]);
        int x = Integer.parseInt(input[2]);

        String[] inputNumbers = reader.readLine().split("\\s+");
        int minNumber = Integer.MAX_VALUE;

        for (String inputNumber : inputNumbers) {
            queue.offer(Integer.parseInt(inputNumber));
        }

        for (int i = 0; i < s; i++) {
            queue.poll();
        }

        if(queue.contains(x)){
            System.out.println("true");
        }
        else if(queue.isEmpty()){
            System.out.println("0");
        }else {
            for (Integer integer : queue) {
                if(integer < minNumber){
                    minNumber = integer;
                }
            }
            System.out.println(minNumber);
        }

    }
}
