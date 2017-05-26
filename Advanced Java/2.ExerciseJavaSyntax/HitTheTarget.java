import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

public class HitTheTarget {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int target = Integer.parseInt(reader.readLine());
        List<Integer> numbers = new ArrayList<>();

        for (int i = 1; i <=20; i++) {
            numbers.add(i);
        }

        for (int i = 1; i <= numbers.size(); i++) {
            for (int j = 1; j <= numbers.size(); j++) {
                if(i + j == target){
                    System.out.println(String.format("%d + %d = %d",i,j,target));
                }else if(i - j == target) {
                    System.out.println(String.format("%d - %d = %d", i, j, target));
                }
            }
        }
    }
}
