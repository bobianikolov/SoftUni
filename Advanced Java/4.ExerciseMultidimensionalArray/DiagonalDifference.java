import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class DiagonalDifference {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int size = Integer.parseInt(reader.readLine());

        int[][] matrix = new int[size][size];
        int primarySum = 0;
        int secondarySum = 0;

        for (int row = 0; row < matrix.length; row++) {
            String[] reminder = reader.readLine().split("\\s+");
            for (int col = 0; col < matrix[row].length; col++) {
                matrix[row][col] = Integer.parseInt(reminder[col]);
            }
        }

        for (int row = 0; row < 1; row++) {
            for (int col = 0; col < 1; col++) {
                for (int i = 0; i < size; i++) {
                    primarySum += matrix[row = i][col = i];
                }
            }
        }

        for (int row = 0; row < 1; row++) {
            for (int col = 0; col < 1; col++) {
                for (int i = 0; i < size; i++) {
                    secondarySum += matrix[row = i][col = size-1-i];
                }
            }
        }

        System.out.println(Math.abs(primarySum - secondarySum));
    }
}
