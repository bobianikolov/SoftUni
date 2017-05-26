import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

public class GetFirstOddOrEvenElement {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] inputNumbers = reader.readLine().split("\\s+");
        String[] inputCommand = reader.readLine().split("\\s+");
        int n = Integer.parseInt(inputCommand[1]);
        String oddOrEven = inputCommand[2];

        List<Integer> numbers = new ArrayList<>();

        for (String inputNumber : inputNumbers) {
            numbers.add(Integer.valueOf(inputNumber));
        }

        if(oddOrEven.equals("odd")){
            findOddElements(numbers,n);
        }else if(oddOrEven.equals("even")){
            findEvenElements(numbers,n);
        }
    }

    private static void findOddElements(List<Integer> integers, int n){
        List<String> stringOddList = new ArrayList<>();

        for (Integer integer : integers) {
            if(integer % 2 == 1){
                stringOddList.add(String.valueOf(integer));
            }
        }

        if(stringOddList.size() < n){
            System.out.print(String.join(" ", stringOddList));
        }else {
            System.out.print(String.join(" ",stringOddList.subList(0,n)));
        }
    }

    private static void findEvenElements(List<Integer> integers, int n){
        List<String> stringEvenList = new ArrayList<>();

        for (Integer integer : integers) {
            if(integer % 2 == 0){
                stringEvenList.add(String.valueOf(integer));
            }
        }

        if(stringEvenList.size() < n){
            System.out.print(String.join(" ",stringEvenList));
        }else {
            System.out.print(String.join(" ",stringEvenList.subList(0,n)));
        }
    }
}
