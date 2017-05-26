import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class ReadSorttAndPrintArray {

    public static void main(String[] args) throws IOException {

        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int n = Integer.parseInt(reader.readLine());
        String[] names = new String[n];

        for (int i = 0; i < n; i++) {
            names[i] = reader.readLine();
        }

        Arrays.stream(names)
                .sorted((a,b) -> a.compareTo(b))
                .forEach(c -> System.out.println(c));
    }
}