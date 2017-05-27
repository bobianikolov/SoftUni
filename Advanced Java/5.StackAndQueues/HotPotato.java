import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayDeque;

public class HotPotato {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] names = reader.readLine().split("\\s+");
        int index = Integer.parseInt(reader.readLine());

        ArrayDeque<String> queue = new ArrayDeque<>();

        for (String name : names) {
            queue.offer(name);
        }

        while (queue.size() > 1){
            for (int i = 1; i < index; i++) {
               String firstChild = queue.poll();
               queue.offer(firstChild);
            }
            System.out.printf("Removed %s%n",queue.poll());
        }
        System.out.printf("Last is %s%n",queue.poll());
    }
}
