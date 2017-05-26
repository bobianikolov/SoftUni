import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class BlurFilter {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        int blurAmount = Integer.parseInt(reader.readLine());
        String[] input = reader.readLine().split("\\s+");
        int rows = Integer.parseInt(input[0]);
        int cols = Integer.parseInt(input[1]);

        long[][] matrix = new long[rows][cols];

        for (int row = 0; row < matrix.length; row++) {
            String[] reminder = reader.readLine().split("\\s+");
            for (int col = 0; col < matrix[row].length; col++) {
                matrix[row][col] = Long.parseLong(reminder[col]);
            }
        }

        String[] inputCoordinates = reader.readLine().split("\\s+");
        int rowCoordinates = Integer.parseInt(inputCoordinates[0]);
        int colCoordinates = Integer.parseInt(inputCoordinates[1]);

        int left = Math.max(0,colCoordinates - 1);
        int right = Math.min(colCoordinates + 1,cols);
        int top = Math.max(rowCoordinates - 1,0);
        int bottom = Math.min(rowCoordinates + 1,rows);

        for (int row = 0; row < matrix.length; row++) {
            for (int col = 0; col < matrix[row].length; col++) {
                if((left <= col && col <= right) && (top <= row && row <= bottom)){
                    System.out.printf("%d ", matrix[row][col] + blurAmount);
                }else {
                    System.out.printf("%d ", matrix[row][col]);
                }
            }
            System.out.println();
        }
    }
}
