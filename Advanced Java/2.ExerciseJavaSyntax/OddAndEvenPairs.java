import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

public class OddAndEvenPairs {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] input = reader.readLine().split("\\s+");
        List<Integer> numbers = new ArrayList<>();

        for (String number : input) {
            numbers.add(Integer.valueOf(number));
        }

        for (int i = 0; i < numbers.size(); i+=2) {
            if(numbers.size() % 2 == 1){
                System.out.println("invalid length");
                break;
            }
            if((numbers.get(i) % 2 == 0) && (numbers.get(i+1) % 2 == 0)){
                System.out.println(String.format("%d, %d -> both are even",numbers.get(i),numbers.get(i+1)));
            }else if((numbers.get(i) % 2 == 1) && (numbers.get(i+1) % 2 == 1)) {
                System.out.println(String.format("%d, %d -> both are odd", numbers.get(i),numbers.get(i+1)));
            }else {
                System.out.println(String.format("%d, %d -> different", numbers.get(i),numbers.get(i+1)));
            }
        }
    }
}
