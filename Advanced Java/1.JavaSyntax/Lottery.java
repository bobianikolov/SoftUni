import java.io.IOException;

public class Lottery {

    public static void main(String[] args) throws IOException {

        for (int first = 1; first <= 8 ; first++) {
            for (int second = first + 1; second <= 9 ; second++) {
                for (int third = second + 1; third <= 10 ; third++) {
                    System.out.printf("%d %d %s%n",first,second,third);
                }
            }
        }
    }
}

