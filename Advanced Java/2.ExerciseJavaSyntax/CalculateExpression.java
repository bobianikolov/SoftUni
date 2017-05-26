import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class CalculateExpression {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] input = reader.readLine().split("\\s+");
        double a = Double.parseDouble(input[0]);
        double b = Double.parseDouble(input[1]);
        double c = Double.parseDouble(input[2]);

        double firstExpression = (Math.pow(a,2) + Math.pow(b,2)) / (Math.pow(a,2) - Math.pow(b,2));
        double sqrt = (a + b + c) / Math.sqrt(c);
        double f1 = Math.pow(firstExpression,sqrt);

        double secondExpression = Math.pow(a,2) + Math.pow(b,2) - Math.pow(c,3);
        double pow = (a-b);
        double f2 = Math.pow(secondExpression,pow);

        double firstAverage = ((a + b + c) / 3);
        double secondAverage  = ((f1 + f2) / 2);

        double f3 = Math.abs(firstAverage - secondAverage);

        System.out.println(String.format("F1 result: %.2f; F2 result: %.2f; Diff: %.2f", f1,f2,f3));
    }
}
