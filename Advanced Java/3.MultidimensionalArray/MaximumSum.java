import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class MaximumSum {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] input = reader.readLine().split(", ");
        int rows = Integer.parseInt(input[0]);
        int cols = Integer.parseInt(input[1]);

        int[][] matrix = new int[rows][cols];

        for (int row = 0; row < matrix.length; row++) {
            String[] reminder = reader.readLine().split(", ");
            for (int col = 0; col < matrix[row].length; col++) {
                matrix[row][col] = Integer.parseInt(reminder[col]);
            }
        }

        int maxSum = Integer.MIN_VALUE;
        int first = 0;
        int second = 0;
        int third = 0;
        int fourth = 0;

        for (int row = 0; row < matrix.length - 1; row++) {
            for (int col = 0; col < matrix[row].length - 1; col++) {
                int sum = matrix[row][col] + matrix[row][col+1] +
                        matrix[row+1][col] + matrix[row+1][col+1];

                if(sum > maxSum){
                    maxSum = sum;
                    first = matrix[row][col];
                    second = matrix[row][col+1];
                    third = matrix[row+1][col];
                    fourth = matrix[row+1][col+1];
                }
            }
        }
        System.out.printf("%d %d%n",first,second);
        System.out.printf("%d %d%n",third,fourth);
        System.out.println(maxSum);
    }
}
