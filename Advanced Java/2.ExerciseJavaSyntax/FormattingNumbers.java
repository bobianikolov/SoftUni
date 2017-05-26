import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class FormattingNumbers {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] input = reader.readLine().split("\\s+");
        int firstNumber = Integer.parseInt(input[0]);
        double secondNumber = Double.parseDouble(input[1]);
        double thirdNumber = Double.parseDouble(input[2]);

        String hexadecimal = Integer.toHexString(firstNumber).toUpperCase();
        String binary = Integer.toBinaryString(firstNumber);

        while (binary.length() < 10) {
           binary = "0" + binary;
        }

        if(binary.length() > 10){
            binary = binary.substring(0,10);
        }

        System.out.println(String.format("|%-10s|%s|%10.2f|%-10.3f|",
                hexadecimal,binary,secondNumber,thirdNumber));
    }
}
