import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class CharacterMultiplier {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] input = reader.readLine().split("\\s+");
        String first = input[0];
        String second = input[1];

        if(first.length() == second.length()){
            calculateEqualsCountCharacter(first,second);
        }else if(first.length() < second.length()){
            calculateCountDifferentCharacterAndSecondStringIsLonger(first,second);
        }else {
            calculateCountDifferentCharacterAndFirstStringIsLonger(first,second);
        }
    }

    private static void calculateEqualsCountCharacter(String first, String second) {

        int sum = 0;
        for (int i = 0; i < first.toCharArray().length; i++) {
            for (int j = 0; j < second.toCharArray().length; j++) {
                sum += first.charAt(i) * second.charAt(j);
                i++;
            }
        }
        System.out.println(sum);
    }

    private static void calculateCountDifferentCharacterAndSecondStringIsLonger(String first, String second){

        int sum = 0;
        int collectionSum = 0;
        int multiplySum = 0;
        int min = Math.min(first.length(),second.length());
        int max = Math.max(first.length(),second.length());

        for (int i = 0; i < min; i++) {
            for (int j = 0; j < min; j++) {
                collectionSum += first.charAt(i) * second.charAt(j);
                i++;
            }
        }

        for (int i = 0; i < max-min; i++) {
            for (int j = 0; j < max-min; j++) {
                multiplySum += second.charAt(j);
                i++;
            }
        }

        sum = collectionSum + multiplySum;
        System.out.println(sum);
    }

    private static void calculateCountDifferentCharacterAndFirstStringIsLonger(String first,String second){
        int sum = 0;
        int min = Math.min(first.length(),second.length());
        int max = Math.max(first.length(),second.length());

        for (int i = 0; i < max; i++) {
            for (int j = 0; j < min; j++) {
                sum += first.charAt(i) + second.charAt(j);
                i++;
            }
        }
        System.out.println(sum);
    }
}
