import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class AverageOfThreeNumbers {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] input = reader.readLine().split("\\s+");

        double first = Double.parseDouble(input[0]);
        double second = Double.parseDouble(input[1]);
        double third = Double.parseDouble(input[2]);

        double average = (first + second + third) / 3;

        System.out.printf("%.2f",average);
    }
}
