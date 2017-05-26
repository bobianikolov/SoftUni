import java.io.IOException;
import java.util.Scanner;

public class ReadInput {

    public static void main(String[] args) throws IOException {

        Scanner scanner = new Scanner(System.in);


        String firstWord = scanner.next();
        String secondWord = scanner.next();

        int first = Integer.parseInt(scanner.next());
        double second = Double.parseDouble(scanner.next());
        double third = Double.parseDouble(scanner.next());
        int sum = first + (int)second + (int)third;

        String thirdWord = scanner.next();

        System.out.println(String.format("%s %s %s %d",
                firstWord,secondWord,thirdWord,sum));
    }
}
