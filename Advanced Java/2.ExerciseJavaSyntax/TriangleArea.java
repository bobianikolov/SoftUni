import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class TriangleArea {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] firstLine = reader.readLine().split("\\s+");
        int firstX = Integer.parseInt(firstLine[0]);
        int firstY = Integer.parseInt(firstLine[1]);

        String[] secondLine = reader.readLine().split("\\s+");
        int secondX = Integer.parseInt(secondLine[0]);
        int secondY = Integer.parseInt(secondLine[1]);

        String[] thirdLine = reader.readLine().split("\\s+");
        int thirdX = Integer.parseInt(thirdLine[0]);
        int thirdY = Integer.parseInt(thirdLine[1]);

        int area = Math.abs(firstX * (secondY-thirdY) + secondX * (thirdY-firstY) + thirdX * (firstY-secondY)) / 2;
        System.out.println(area);
    }
}
