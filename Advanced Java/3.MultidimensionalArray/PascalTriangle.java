import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class PascalTriangle {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int rows = Integer.parseInt(reader.readLine());

        long[][] matrix = new long[rows][];

        for (int i = 0; i < rows; i++) {
            matrix[i] = new long[i+1];
        }
        matrix[0][0] = 1;

        for (int row = 1; row < rows; row++) {
            matrix[row][0] = 1;
            matrix[row][matrix[row].length - 1] = 1;
            for (int col = 1; col < matrix[row].length - 1; col++) {
                matrix[row][col] = matrix[row-1][col-1] + matrix[row-1][col];
            }
        }

        for (int row = 0; row < rows; row++) {
            for (int col = 0; col < matrix[row].length ; col++) {
                System.out.print(matrix[row][col] + " ");
            }
            System.out.println();
        }
    }
}
