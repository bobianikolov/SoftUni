import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class SquaresInMatrix {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] input = reader.readLine().split("\\s+");
        int rows = Integer.parseInt(input[0]);
        int cols = Integer.parseInt(input[1]);

        String[][] matrix = new String[rows][cols];

        for (int row = 0; row < matrix.length; row++) {
            String[] character = reader.readLine().split(" ");
            for (int col = 0; col < matrix[row].length; col++) {
                matrix[row][col] = character[col];
            }
        }

        int counter = 0;
        for (int row = 0; row < matrix.length - 1; row++) {
            for (int col = 0; col < matrix[row].length - 1; col++) {
                if(matrix[row][col].equals(matrix[row][col + 1]) &&
                   matrix[row + 1][col].equals(matrix[row + 1][col + 1]) &&
                        matrix[row][col].equals(matrix[row + 1][col])){
                    counter++;
                }
            }
        }
        System.out.println(counter);
    }
}
