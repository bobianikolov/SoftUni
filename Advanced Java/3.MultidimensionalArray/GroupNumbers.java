import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

public class GroupNumbers {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] input = reader.readLine().split(", ");

        List<ArrayList<Integer>> nestedList = new ArrayList<>();

        nestedList.add(0, new ArrayList<>());
        nestedList.add(1, new ArrayList<>());
        nestedList.add(2, new ArrayList<>());

        for (String s : input) {
            int currentNumber = Integer.parseInt(s);
            nestedList.get(Math.abs(currentNumber % 3)).add(currentNumber);
        }

        for (ArrayList<Integer> integers : nestedList) {

            for (Integer integer : integers) {
                System.out.print(integer + " ");
            }
            System.out.println();
        }
    }
}
