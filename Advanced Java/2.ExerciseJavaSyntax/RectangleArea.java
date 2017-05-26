import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class RectangleArea {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] input = reader.readLine().split("\\s+");
        double firstSide = Double.parseDouble(input[0]);
        double secondSide = Double.parseDouble(input[1]);
        double area = rectangleArea(firstSide,secondSide);
        System.out.printf("%.2f%n",area);
    }

    private static double rectangleArea(double a, double b){
        return a * b;
    }
}
