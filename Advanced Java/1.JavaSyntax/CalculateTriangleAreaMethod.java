import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class CalculateTriangleAreaMethod {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] input = reader.readLine().split("\\s+");
        double first = Double.parseDouble(input[0]);
        double second = Double.parseDouble(input[1]);

        double area = getArea(first,second);
        System.out.println(String.format("Area = %.2f",area));
    }

    private static double getArea(double base, double height){
             return  (base * height) / 2;
    }
}
