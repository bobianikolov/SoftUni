import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class MaximalSum {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] input = reader.readLine().split("\\s+");
        int rows = Integer.parseInt(input[0]);
        int cols = Integer.parseInt(input[1]);

        int[][] matrix = new int[rows][cols];

        for (int row = 0; row < matrix.length; row++) {
            String[] reminder = reader.readLine().split("\\s+");
            for (int col = 0; col < matrix[row].length; col++) {
                matrix[row][col] = Integer.parseInt(reminder[col]);
            }
        }

        int maxSum = Integer.MIN_VALUE;
        int first = 0;
        int second = 0;
        int third = 0;
        int fourth = 0;
        int fifth = 0;
        int sixth = 0;
        int seventh = 0;
        int eighth = 0;
        int ninth = 0;

        for (int row = 0; row < matrix.length - 2; row++) {
            for (int col = 0; col < matrix[row].length - 2; col++) {
                int firstNumber = matrix[row][col];
                int secondNumber = matrix[row][col + 1];
                int thirdNumber = matrix[row][col + 2];
                int fourthNumber = matrix[row + 1][col];
                int fifthNumber = matrix[row + 1][col + 1];
                int sixthNumber = matrix[row + 1][col + 2];
                int seventhNumber = matrix[row + 2][col];
                int eighthNumber = matrix[row + 2][col + 1];
                int ninthNumber = matrix[row + 2][col + 2];

                int sum = firstNumber + secondNumber + thirdNumber + fourthNumber +
                          fifthNumber + sixthNumber + seventhNumber + eighthNumber +
                        ninthNumber;

                if(sum > maxSum){
                    maxSum = sum;
                    first = firstNumber;
                    second = secondNumber;
                    third = thirdNumber;
                    fourth = fourthNumber;
                    fifth = fifthNumber;
                    sixth = sixthNumber;
                    seventh = seventhNumber;
                    eighth = eighthNumber;
                    ninth = ninthNumber;
                }
            }
        }
        System.out.printf("Sum = %d%n", maxSum);
        System.out.printf("%d %d %d%n", first,second,third);
        System.out.printf("%d %d %d%n", fourth,fifth,sixth);
        System.out.printf("%d %d %d%n", seventh,eighth,ninth);
    }
}
