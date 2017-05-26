import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class GameOfNames {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int n = Integer.parseInt(reader.readLine());
        int maxPoint = Integer.MIN_VALUE;
        String winner = "";

        while (n-- > 0){
            String name = reader.readLine();
            int initialScores  = Integer.parseInt(reader.readLine());
            int point = 0;
            int totalPoint = 0;

            for (int i = 0; i < name.toCharArray().length; i++) {
                if(name.charAt(i) % 2 == 0){
                    point += name.charAt(i);
                }else {
                    point -= name.charAt(i);
                }
            }
            totalPoint = initialScores + point;
            if(totalPoint > maxPoint){
                maxPoint = totalPoint;
                winner = name;
            }
        }
        System.out.println(String.format("The winner is %s - %d points",winner,maxPoint));
    }
}
