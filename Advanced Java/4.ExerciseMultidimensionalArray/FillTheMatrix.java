import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class FillTheMatrix {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] input = reader.readLine().split(", ");
        int n = Integer.parseInt(input[0]);
        String pattern = input[1];

        switch (pattern){
            case "A":
                calculatePatternA(n);
                break;
            case "B":
                calculatePatternB(n);
                break;
        }
    }

    private static void calculatePatternA(int size){
        int[][] matrix = new int[size][size];

        int counter = 1;

        for (int row = 0; row < matrix.length; row++) {
            for (int col = 0; col < matrix[row].length; col++) {
                matrix[col][row] = counter;
                counter++;
            }
        }

        for (int row = 0; row < matrix.length; row++) {
            for (int col = 0; col < matrix[row].length; col++) {
                System.out.print(matrix[row][col] + " ");
            }
            System.out.println();
        }
    }

    private static void calculatePatternB(int size){
        int[][] matrix = new int[size][size];

        int counter = 1;

        for (int col = 0; col < matrix.length; col++) {
            if(col % 2 == 0){
                for (int row = 0; row < matrix.length; row++) {
                    matrix[row][col] = counter;
                    counter++;
                }
            }else {
                for (int row = matrix.length - 1; row >= 0; row--) {
                    matrix[row][col] = counter;
                    counter++;
                }
            }
        }

        for (int row = 0; row < matrix.length; row++) {
            for (int col = 0; col < matrix.length; col++) {
                System.out.print(matrix[row][col] + " ");
            }
            System.out.println();
        }
    }
}
