import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayDeque;

public class SequenceWithQueue {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        Long n = Long.parseLong(reader.readLine());
        ArrayDeque<Long> queue = new ArrayDeque<>();
        queue.offer(n);

        for (int i = 0; i < 50; i++) {
            long element = queue.poll();
            System.out.printf("%d ",element);

            queue.offer(element + 1);
            queue.offer((element * 2) + 1);
            queue.offer(element + 2);
        }
    }
}
